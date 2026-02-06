# Symfony8-2503

Création d'une API REST

Procédure d'installation de Symfony avec Docker.

## Stack technique

Identifier les composants nécessaires pour exécuter le projet.

- Une base de données
    - Mariadb 11.8.5
- Un serveur web avec l'interpréteur PHP
    - Apache 2.4
    - PHP 8.4
    - Composer gestionnaire de dépendances pour PHP
- Symfony 8.x avec API PLatform
    - à installer dans le conteneur à l'aide de Composer

A partir de cette liste, nous pouvons créer un conteneur Docker qui exécutera notre future application Symfony.

Les services Base de données et Serveur Web seront séparés dans des conteneurs distincts. 

### La configuration du serveur Web 

Pour que Symfony fonctionne bien, nous devons configurer quelques éléments dans la cvonfiguration d'Apache.

Nous alons éditer l'hôte virtuel par défaut dans un fichier qu'il sera nécessaire de copier dans le conteneur à sa création :

- Le répertoire de travail de Apache pointe sur le dossier "public" de symfony. 
    - Le dossier "public" est le point d'entrée des applications Symfony.
- Définir les règles de réécriture d'url pour le routage de Symfony.

A la racine dans un dossier **conf** créer un fichier **000-default.conf** et y inserer
``` APACHE
<VirtualHost *:80>
        ServerName localhost
        ServerAdmin webmaster@localhost
        # DocumentRoot pointe vers le dossier public de Symfony
        DocumentRoot /var/www/html/public

        # Configuration pour le répertoire public
        <Directory /var/www/html/public>
            # Permet de suivre les liens symboliques +(mets à la suite des options)
            Options +FollowSymLinks
            # Permet l'utilisation des fichiers .htaccess
            AllowOverride All
            # Autorise l'accès à tous
            Require all granted
            # Redirige toutes les requêtes vers index.php en cas de ressource non trouvée
            FallbackResource /index.php
            # Active le moteur de réécriture d'URL
            RewriteEngine On
            # Si le fichier demandé n'existe pas
            RewriteCond %{REQUEST_FILENAME} !-f
            # Si le répertoire demandé n'existe pas
            RewriteCond %{REQUEST_FILENAME} !-d
            # Exclut les requêtes pour favicon.ico
            RewriteCond %{REQUEST_FILENAME} !favicon.ico$
            # Réécrit l'URL vers index.php avec les paramètres
            RewriteRule ^(.*)$ /index.php/$1 [L,QSA]

            # http://localhost:9000/articles/8/comments
            # Internally rewrites to:
            # /index.php/articles/8/comments
        </Directory>

        # Journal des erreurs
        ErrorLog ${APACHE_LOG_DIR}/error.log
        # Journal des accès
        CustomLog ${APACHE_LOG_DIR}/access.log combined 
</VirtualHost>
```

### Le Docker-compose 

[Voir le docker-compose.yml](./docker-compose.yml)

Pour le service Web, un Dockerfile est nécessaire afin de pouvoir installer les outils et modules nécessaires au bon fonctionnement de notre application.

[Voir le Dockerfile](./Dockerfile)

Une fois le docker-compose.yml et le Dockerfile renseignés, il est temps de créer et lancer le conteneur

```bash
docker compose up --build -d
```

## Installation de Symfony

- Se connecter au serveur web

```bash
docker exec -it symfony8-API-web bash
```
- Le repertoir de travail est ``/var/www/html/``
- Il doit être vide pour pouvoir installer Symfony ``ls -a``
- Verifier que composer est bien disponible ``composer -v``
- Installer Symfony avec composer
    - On part du squelette de Symfony, l'installation la plus basique
    - On fixe la version
```bash
composer create-project symfony/skeleton:"8.0.*" .
```

- Verifier l'installation de Symfony ``localhost:9000``

## Configuration de Symfony

- Ajouter le module ``maker-bundle`` pour générer en quelques lignes de commandes des vues, des classes, des formulaires, des controleurs, des classes modèles ect...
```bash
composer require symfony/maker-bundle --dev
```
- Ajouter le Module API pour installer API platform  (editeur de configuration pour API , interface pour tester l'API)
```bash
composer require api
```
- Acceder à SwaggerUi via ``localhost:9001\api``
- En Local dans VSC dans le dossier ``\src\config\routes\api_platform.yalm``
    - Pour que l'api soit accessible directement depuis la racine du site, commenter ``prefix: /api``
    ```yaml
    api_platform:
        resource: .
        type: api_platform
        # prefix: /api
    ```
- Dans ``\src\config\packages\api_platform.yaml``
    ```yaml
    api_platform:
    title: Hello API Platform
    version: 1.0.0
    formats:
        json: ['application/json']
        xml: ['application/xml', 'text/xml']
        jsonld: ['application/ld+json']
        csv: ['text/csv']
    defaults:
        stateless: true
        cache_headers:
            vary: ['Content-Type', 'Authorization', 'Origin']

    ```
    - on peut définir le titre de l'api,
    - la version de l'api,
    - ajouter ``show_webby: false`` pour retirer l'araignée.
    - définir les formats renvoyés par l'api (le premier est le format par défaut):
    ```yaml
    formats:
        json: ['application/json']
        xml: ['application/xml', 'text/xml']
        jsonld: ['application/ld+json']
        csv: ['text/csv']
    ```

## Pour créer une entité

Pour creer une entité avec le maker-bundle, dans la console de symfony entrer ces commandes PHP

```php
php bin/console make:entity # permet de creer ou de modifier une entité existante
```
et suivre l'outil interactif en ligne de commande
- indiquer le nom de l'entité
- indiquer si on veut exposer l'entité en tant qu'entité de l'API (pour qu'elle s'affiche)
- ajouter un attribut :
    - son nom,
    - son type ou sa relation,
    - sa longueur,
    - nullable ou non.

### Modifications du code des entités

- Pour qu'une entité ne soit plus exposée :  
    Dans ``\src\src\Entity\Entite.php`` retirer la ligne ``#[ApiResource]``

## Configuration de la base de donnée

Dans le fichier ``\src\.env``

Commenter la chaine de connection non utilisée et copier et decommenter celle qui correspond a la base de donnée installée

Pour MariaDB faire les modification en fonction du docker compose

```php
DATABASE_URL="mysql://app:!ChangeMe!@127.0.0.1:3306/app?serverVersion=10.11.2-MariaDB&charset=utf8mb4"
```
Modifier 
- la version, ici ``10.8.5``
- ``app`` correspond au nom de la base de donnée, ici ``db_symfony``
- le nom du service, ici ``db``
- l'identifiant et le mdp, ici ``user_symfony:azer``

```php
DATABASE_URL="mysql://user_symfony:azer@db:3306/db_symfony?serverVersion=10.8.5-MariaDB&charset=utf8mb4"
```

## Migration des données vers la BDD

Scanner le répertoire des entités et générer les requêtes SQL :
```php
php bin/console make:migration
```
Crée un fichier versionné dans le répertoire migrations avec les requetes pour appliquer la migration ou revenir en arrière

Appliquer les requêtes SQL sur la BDD :
```php
php bin/console doctrine:migrations:migrate
```

Pour verifier les dépendances et les mettres à jours :
```bash
composer update
```