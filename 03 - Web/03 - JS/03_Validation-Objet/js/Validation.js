/**
 * Contrôle de données
 */
export class Validation {
  validerFormatNombre(_nombre) {
    let regex = /^[\-]?[0-9]+[\.|,]?[0-9]{0,15}$/; // REGEX nombre entier ou décimal strictement positif
    if (!regex.test(_nombre)) {
      throw new Error("Ce n'est pas un nombre");
    }
  }

  /**
   * Valide un nombre positif
   * - doit être un numérique strictement positif
   * @param {Number} _prix le prix à valider
   */
  validerNombrePositif(_nombre) {
    try {
      this.validerFormatNombre(_nombre);
      _nombre = parseFloat(_nombre);
      if (_nombre < 0) {
        throw new Error("Ce n'est pas un nombre positif");
      }
    } catch (error) {
        throw error;
    }
  }

  /**
   *
   */
  static validerNomArcticle() {}
}
