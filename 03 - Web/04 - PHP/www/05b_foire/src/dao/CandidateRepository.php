<?php


class CandidateRepository{
private ?PDO $dbconnect=null;
private int $nbcol; 

public function __construct()
{
    $this->dbconnect=Dbconnection::getInstance();
    $query="SELECT * FROM candidats";
    $stmt= $this->dbconnect->query($query);
    $this->nbcol=$stmt->rowCount();     
}   
public function insert(array $data):bool
{
    $query="INSERT INTO candidats (username,email,password,department,age) VALUES (:username,:email,:password,:department,:age)";
    $stmt= $this->dbconnect->prepare($query);
    return $stmt->execute([
        ':username'=>$data['username'],
        ':email'=>$data['email'],
        ':password'=>$data['password'],
        ':department'=>$data['department'],
        ':age'=>$data['age']
    ]);
}

public function searchByEmail(string $email):array|false
{
    $query="SELECT * FROM candidats WHERE email=:email";
    $stmt= $this->dbconnect->prepare($query);
    $stmt->execute([':email'=>$email]);
    return $stmt->fetch();              



}
public function searchAll():array
{
        $query="SELECT lastname_user, firstname_user, mail_user, departement_user, age_user FROM candidats";
        $stmt= $this->dbconnect->prepare($query);
        $stmt->execute();
        return $stmt->fetchAll();
}
public function update(array $data):bool
{
    $query="UPDATE candidats SET username=:username, password=:password, department=:department, age=:age WHERE email=:email";
    $stmt= $this->dbconnect->prepare($query);
    return $stmt->execute([
        ':username'=>$data['username'],
        ':email'=>$data['email'],
        ':password'=>$data['password'],
        ':department'=>$data['department'],
        ':age'=>$data['age']
    ]);
}

}