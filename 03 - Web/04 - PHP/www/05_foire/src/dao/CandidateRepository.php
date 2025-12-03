<?php
    
    class CandidateRepository
    {
        private ?PDO $dbConnect;

        public function __construct()
        {
            $this->dbConnect = Dbconnection::getInstance();
        }
    

        public function searchAll(): array | bool
        {
            $query =   "SELECT
                            id_user AS Id,
                            lastname_user AS Nom,
                            firstname_user AS Prenom,
                            mail_user AS Email,
                            pass_user AS `Mot de passe`,
                            departement_user AS Departement,
                            age_user AS Age,
                            archive_user As Archivé
                        FROM
                            candidats;";
            $statement = $this->dbConnect->query($query);
            $data = $statement->fetchAll();
            return $data;
        }
    }