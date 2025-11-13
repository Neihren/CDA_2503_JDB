<?php

    class Pret
    {
        private float $loan;
        private float $rate;
        private int $durationYears;

        public function __construct(float $loan, float $rate, int $durationYears)
        {
            $this->$loan = $loan;
            $this->$rate = $rate;
            $this->$durationYears = $durationYears;
        }


    }

?>