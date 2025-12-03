<?php
require_once ('Voiture.php');

/**
 * @author JDebrito
 * @version 1.0
 * @created 19-nov.-2025 10:19:50
 */
class VoitureDeCourse extends Voiture
{

	/**
	 * 
	 * @param _marque
	 * @param _modele
	 * @param _poids
	 * @param _marqueMoteur
	 * @param _vitesseMaxMoteur
	 */
	function __construct(string $_marque, string $_modele,  string $_marqueMoteur, int $_vitesseMaxMoteur, int $_poids = 1000)
	{
		if ($_marque !== $_marqueMoteur)
		{
			throw new InvalidArgumentException("La moteur doit être de même marque que la voiture");
		} else {
			parent::__construct($_marque, $_modele, $_marqueMoteur, $_vitesseMaxMoteur, $_poids);
		}
	}

	function __toString() : string
	{
		//return "VoitureDeCourse [marque : " . $this->marque . ", modele : " . $this->modele . ", poids : " . $this->poids . ", moteur :" . $this->sonMoteur . ", vitesse max : " . $this->vitesseMax() . "]";
		return "VoitureDeCourse [ Parent : " . parent::__toString() . "]";
	}

	/**
	 * Voiture.vitesseMax = Moteur.vitesseMax - (Voiture.poids x 5%)
	 */
	function vitesseMax() : float
	{
		return $this->sonMoteur->getvitesseMax() - ($this->poids * 0.005);
	}

}
?>