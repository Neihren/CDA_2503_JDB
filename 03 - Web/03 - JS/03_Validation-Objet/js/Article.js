import { Validation } from "./Validation.js";

/**
 * Classe modèle
 * Représente un article
 * @author Jessy DE BRITO<jdebrito@arfp.asso.fr>
 * @version 1.0
 */
export class Article {
  /**
   * Constructeur
   * @param {String} _nom Le nom de l'article
   * @param {Number} _prixHT Le prix Hors Taxe de l'article
   * @param {Number} _tva La TVA appliquée à l'article
   */
  constructor(_nom, _prixHT, _tva) {
    this.nom = _nom;
    this.prixHT = parseInt(_prixHT);
    this.tva = parseInt(_tva);
  }

  estValide() {
    try {
      let validation = new Validation();
      validation.validerNombrePositif(this.prixHT);
    } catch (error) {
        
    }
  }
  /**
   * Fonction qui calcule le prix TTC en fonction du prix hors taxe et de la tva
   * @returns {Number} le prix TTC
   */
  prixTTC() {
    return this.prixHT * (1 + this.tva / 100);
  }
}
