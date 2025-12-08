<?php


class departmentRepository
{
private ?PDO $dbconnect=null;
private int $nbcol;
private array $tabColName=[];
public function __construct()
{
    $this->dbconnect=Dbconnection::getInstance();
    $query="SELECT * FROM departements";
    $stmt= $this->dbconnect->query($query);
    $this->nbcol=$stmt->rowCount();

}

public function searchAll():array
{
        $query="SELECT `id_dep`,`Name` FROM departements";
        $stmt= $this->dbconnect->prepare($query);
        $stmt->execute();
        return $stmt->fetchAll();
}





}