<?php

class Contribuable
{
    private string $name;
    private float $yearlyIncome;
    private const RATE1 = 0.11;
    private const RATE2 = 0.30;
    private const RATE3 = 0.41;
    private const RATE4 = 0.45;
    private const BRACKET1 = 11497;
    private const BRACKET2 = 29315;
    private const BRACKET3 = 83823;
    private const BRACKET4 = 180294;

    public function __construct(string $name, float $yearlyIncome)
    {
        $this->name = $name;
        $this->yearlyIncome = $yearlyIncome;
    }

    public function calculImpot() : float
    {
        $incomeTax = 0;
        $incomeAmount = $this->yearlyIncome;

        if ($incomeAmount <= self::BRACKET1) {
            $incomeTax = 0;
        } elseif ($incomeAmount <= self::BRACKET2) {
            $incomeTax = ($incomeAmount - self::BRACKET1) * self::RATE1;
        } elseif ($incomeAmount <= self::BRACKET3) {
            $incomeTax = ($incomeAmount - self::BRACKET2) * self::RATE2 + 1959.98;
        } elseif ($incomeAmount <= self::BRACKET4) {
            $incomeTax = ($incomeAmount - self::BRACKET3) * self::RATE3 + 18312.38;
        } else {
            $incomeTax = ($incomeAmount - self::BRACKET4) * self::RATE4 + 57865.49;
        }
        return round($incomeTax, 2);
    }
}

?>