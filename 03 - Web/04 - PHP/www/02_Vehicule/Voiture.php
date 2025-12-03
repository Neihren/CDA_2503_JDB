<?php
require_once ('Moteur.php');

/**
 * @author JDebrito
 * @version 1.0
 * @created 19-nov.-2025 10:19:48
 */
class Voiture
{
	protected string $marque;
	protected string $modele;
	protected int $poids;
	protected Moteur $sonMoteur;

	/**
	 * 
	 * @param _marque
	 * @param _modele
	 * @param _poids
	 * @param _marqueMoteur
	 * @param _vitesseMaxMoteur
	 */
	function __construct(string $_marque, string $_modele, string $_marqueMoteur, int $_vitesseMaxMoteur, int $_poids = 1000)
	{
		$this->marque = $_marque;
		$this->modele = $_modele;
		$this->poids = $_poids;
		$this->sonMoteur = new Moteur($_marqueMoteur, $_vitesseMaxMoteur);

	}

	function getmarque() : string
	{
		return $this->marque;
	}

	function getmodele() : string
	{
		return $this->modele;
	}

	function getpoids() : int
	{
		return $this->poids;
	}

	function getsonMoteur() : Moteur
	{
		return $this->sonMoteur;
	}
	
	function setmarque(string $_marque) : void
	{
		$this->marque = $_marque;
	}
	
	function setmodele(string $_modele) : void
	{
		$this->modele = $_modele;
	}
	
	function setpoids(int $_poids) : void
	{
		$this->poids = $_poids;
	}
	
	function setsonMoteur(string $_marqueMoteur, int $_vitesseMaxMoteur) : void
	{
		$this->sonMoteur = new Moteur($_marqueMoteur, $_vitesseMaxMoteur);
	}

	function __toString() : string
	{
		return "Voiture [marque : " . $this->marque . ", modele : " . $this->modele . ", poids : " . $this->poids . ", moteur :" . $this->sonMoteur . ", vitesse max : " . $this->vitesseMax() . "]";
	}

	/**
	 * Voiture.vitesseMax = Moteur.vitesseMax - (Voiture.poids x 30%)
	 */
	function vitesseMax() : float
	{
		return $this->sonMoteur->getvitesseMax() - ($this->poids * 0.03);
	}

}
?>