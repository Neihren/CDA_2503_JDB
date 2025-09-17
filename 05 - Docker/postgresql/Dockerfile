## port par défaut 5432
# Utilise l'image postgres
FROM postgres:17


ENV POSTGRES_ROOT_PASSWORD=1234
# Créer une base de donnée nommée mydatabase
ENV POSTGRES_DB=mydatabase

# Créer un utilisateur ayant les droits sur la basse crée précédemment
ENV POSTGRES_USER=jessy

# Variable environnement pour le mdp du compte jessy
ENV POSTGRES_PASSWORD=azer

VOLUME [ "/data" ]

# Demande au systeme de mettre à jour le fichier d'index des packages disponibles
RUN apt-get update

# Exécute la commande unix pour installer openssh client & serveur
# # paramètre -y pour skip la confirmation
# # paramètre --fix-missing pour aller chercher les dépendances manquantes
RUN apt-get install -y --fix-missing openssh-client openssh-server