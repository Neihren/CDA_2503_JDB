<?php

class RestaurantRepository
{

    private ?PDO $dbConnect;
    private int $nbcol;
    private array $tabNameCol = [];

    public function __construct()
    {
        $this->dbConnect = Dbconnexion::getInstance();
        $this->nbcol = 0;
    }

    public function searchAll(): array
    {
        $data = [];
        $rqSQL =   "SELECT
                            nom,
                            adresse,
                            prix,
                            commentaire,
                            note,
                            visite
                        FROM
                            restaurants";
        $stmt = $this->dbConnect->query($rqSQL);
        $data = $stmt->fetchAll();
        return $data;
    }

    public function searchById(int $_id): array | bool
    {
        $data = [];
        $rqSQL =   "SELECT
                            nom,
                            adresse,
                            prix,
                            commentaire,
                            note,
                            visite
                        FROM
                            restaurants
                        WHERE
                            id = :ID";
        $PDOstmt = $this->dbConnect->prepare($rqSQL);
        $PDOstmt->bindValue(":ID", $_id, PDO::PARAM_INT);
        $PDOstmt->execute();
        $data = $PDOstmt->fetch();
        return $data;
    }

    public function searchByName(string $_name): array | bool
    {
        $data = [];
        $rqSQL =   "SELECT
                            nom,
                            adresse,
                            prix,
                            commentaire,
                            note,
                            visite
                        FROM
                            restaurants
                        WHERE
                            SOUNDEX(nom) = SOUNDEX(:NOM)";
        $PDOstmt = $this->dbConnect->prepare($rqSQL);
        //$PDOstmt->bindValue(":NOM", $_name, PDO::PARAM_STR);
        $PDOstmt->execute([":NOM" => $_name]);
        $data = $PDOstmt->fetchAll();
        return $data;
    }

    public function searchByNote(float $_limit): array | bool
    {
        $PDOstmt = $this->dbConnect->prepare("CALL afficherListeNote(:NOTE);");
        $PDOstmt->bindValue(":NOTE", $_limit);
        $PDOstmt->execute();
        $data = $PDOstmt->fetchAll();
        return $data;
    }

    public function searchByPrice(float $_limitInf, float $_limitSup): array | bool
    {
        $PDOstmt = $this->dbConnect->prepare("CALL afficherListePrix(:LIMINF, :LIMSUP);");
        $PDOstmt->execute([":LIMINF" => $_limitInf, ":LIMSUP" => $_limitSup]);
        $data = $PDOstmt->fetchAll();
        return $data;
    }

    public function afficherTableau(array $_data): string
    {
        $tab = "<table class='styled-table'> <thead> <tr>";
        foreach ($_data[0] as $key => $value) {
            $tab .= "<th>" . $key . "</th>";
        }
        $tab .= "</tr> </thead> <tbody>";
        foreach ($_data as $ligne) {
            $tab .= "<tr>";
            foreach ($ligne as $key => $cellule) {
                $tab .= "<td>" . $cellule . "</td>";
            }
            $tab .= "</tr>";
        }
        $tab .= "</tbody> </table>";
        return $tab;
    }
}
