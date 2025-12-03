<?php

    class Pret
    {
        private float $capitalEmprunte;
        private float $tauxInteret;
        private int $dureeAnnee;
        private int $dureeMois;
        private float $tauxMensuel;

        public function __construct(float $capitalEmprunte, float $tauxInteret, int $dureeAnnee)
        {
            $this->capitalEmprunte = $capitalEmprunte;
            $this->tauxInteret = $tauxInteret;
            $this->dureeAnnee = $dureeAnnee;
            $this->dureeMois = $dureeAnnee * 12;
            $this->tauxMensuel = $tauxInteret / 12 / 100;
        }


        // capital emprunte                : $capitalEmprunte
        // taux interet annuel             : $tauxInteret
        // nombre annee remboursement      : $dureeAnnee
        // taux mensuel interet mensuel    : Tm = $tauxInteret / 12
        // nombre mois remboursement       : n = $dureeAnnee * 12

        // Q = (1-(1+Tm)^-n)
        // mensualite constante recherche  : a = ($capitalEmprunte*Tm)/Q


        public function calculMensualite() : float {
            $q = (1 - (1 + $this->tauxMensuel)**(-$this->dureeMois));
            $mensualite = ($this->capitalEmprunte * $this->tauxMensuel) / $q;
            return $mensualite;
        }



        public function tableauAmortissement() : string {
            $tabHTML = "";
            $capitalRestant = array_fill(0, $this->dureeMois,0.0);
            $partCapital = array_fill(0, $this->dureeMois,0.0);
            $partInteret = array_fill(0, $this->dureeMois,0.0);
            $mensualite = $this->calculMensualite();
            $coutTotal = 0.0;
            
            $capitalRestant[0] = $this->capitalEmprunte;
            for ($i = 1; $i < $this->dureeMois; $i++) { 
                $partInteret[$i] = $capitalRestant[$i - 1] * $this->tauxMensuel;
                $partCapital[$i] = $mensualite - $partInteret[$i];
                $capitalRestant[$i] = $capitalRestant[$i - 1] - $partCapital[$i];
            }

            foreach ($partInteret as $i) {
                $coutTotal += $i;
            }

            $tabHTML =  "<div class='class='table-wrapper'><p>Mensualite Constantes : " . round($mensualite, 2) . "</p><hr>";
            $tabHTML .= "<table class='amort-table'>
                            <thead>
                                <tr>
                                    <td>Numéro Mois</td>
                                    <td>Part Intérêt</td>
                                    <td>Part Capital</td>
                                    <td>Capital Restant dû</td>
                                    <td>Mensualité</td>
                                </tr>
                            </thead>
                            <tbody>";
            for ($i = 0; $i < $this->dureeMois; $i++) { 
                $tabHTML .= "<tr>
                                <td>" . $i . "</td>
                                <td>" . round($partInteret[$i], 2) . "</td>
                                <td>" . round($partCapital[$i], 2) . "</td>
                                <td>" . round($capitalRestant[$i], 2) . "</td>
                                <td>" . round($mensualite, 2) . "</td>
                            </tr>";
            }
            $tabHTML .= "</tbody>
                        </table><hr>
                        <p>Coût total du crédit : " . round($coutTotal, 2) . "</p></div>";

            return $tabHTML;
        }
    }
?>