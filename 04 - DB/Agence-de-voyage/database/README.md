# Base de données Agence de Voyage 

## Base de données :
- Serveur : `MariaDB 11.8.3`
- Port : `4013`
- Nom de la base de données : `db_agence_voyage` 
- Nom de l'image Docker : `agence-voyage-database`
- Nom du conteneur Docker : `agence-voyage-database` 
- Nom du volume Docker :  `agence-voyage-data`

## Créer l'image Docker
```docker
docker build . -t neihren/agence-voyage-database:1.0
```
## Créer le container
```docker
docker run -d -p 4013:3306 -v agence-voyage-data:/var/lib/mysql --name agence-voyage-database neihren/agence-voyage-database:1.0
```