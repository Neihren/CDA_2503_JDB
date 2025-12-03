<?php

/**
 * @author JDebrito
 * @version 1.0
 * @created 19-nov.-2025 10:19:49
 */
class Moteur
{
	private string $marque;
	private int $vitesseMax;

	function __construct(string $marque, int $vitesseMax)
	{
		$this->marque = $marque;
		$this->vitesseMax = $vitesseMax;
	}

	function getvitesseMax() : int
	{
		return $this->vitesseMax;
	}

	function __toString() : string
	{
		return "Moteur[marque : " . $this->marque . ", vitesseMax : " . $this->vitesseMax . "]";
	}
}
?>