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

    public function createCandidate(string $_name, string $_firstname, string $_email, string $_password, int $_dep, int $_age): bool
    {
        $name = trim($_name);
        $firstname = trim($_firstname);
        $email = trim($_email);
        $password = trim($_password);
        $dep = intval($_dep);
        $age = intval($_age);   
        $query = "INSERT INTO 
                candidats ( lastname_user,
                            firstname_user,
                            mail_user,
                            pass_user,
                            departement_user,
                            age_user,
                            archive_user) 
                VALUES 
                (   :name,
                    :firstname,
                    :email,
                    :password,
                    :dep,
                    :age,
                    0)";
        $PDOstatement = $this->dbConnect->prepare($query);
        $PDOstatement->bindValue(":name", $name, PDO::PARAM_STR);
        $PDOstatement->bindValue(":firstname", $firstname, PDO::PARAM_STR);
        $PDOstatement->bindValue(":email", $email, PDO::PARAM_STR);
        $PDOstatement->bindValue(":password", password_hash($password, PASSWORD_BCRYPT), PDO::PARAM_STR);
        $PDOstatement->bindValue(":dep", $dep, PDO::PARAM_INT);
        $PDOstatement->bindValue(":age", $age, PDO::PARAM_INT);
        return $PDOstatement->execute();        
    }
}
