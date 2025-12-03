<?php
    class DepartmentRepository {
        
        private ?PDO $dbConnect;
        private int $nbcol;
        private array $tabColName=[];

        public function __construct() {
            $this->dbConnect = Dbconnection::getInstance();
            $query =   "SELECT
                            *
                        FROM
                            departements";
            $statement = $this->dbConnect->query($query);
            $this->nbcol = $statement->rowCount();
        }

        public function searchAll(): array | bool {
            $query =   "SELECT
                            id_dep AS Id,
                            `Name` AS Nom
                        FROM
                            departements";
            $statement = $this->dbConnect->query($query);
            $statement->execute();
            return $statement->fetchAll();
        }
    }