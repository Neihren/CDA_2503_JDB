# Base de données 

## Base de données :
- Serveur : `MariaDB 11.8.3`
- Port : `4015`
- Nom de la base de données : `db_architecte` 
- Nom de l'image Docker : `ecf-architecte-database`
- Nom du conteneur Docker : `ecf-architecte-database` 
- Nom du volume Docker :  `ecf-architecte-data`

## Créer l'image Docker
```docker
docker build . -t neihren/ecf-architecte-database:3.0
```
## Créer le container
```docker
docker run -d -p 4015:3306 -v ecf-architecte-data:/var/lib/mysql --name ecf-architecte-database neihren/ecf-architecte-database:3.0
```