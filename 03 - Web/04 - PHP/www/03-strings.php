<?php
    function getMC2() : string
    {
        return "Albert Einstein";
    }

    function getUserName(string $firstName, string $lastName) : string
    {
        return $firstName.$lastName;
    }

    function getFullName(string $lastName, string $firstName) : string
    {
        return ucfirst($firstName)." ".(mb_strtoupper($lastName));
    }

    function askUser(string $lastName, string $firstName) : string
    {
        return "Bonjour ".getFullName($lastName, $firstName).", connaissez-vous ".getMC2();
    }

    echo getMC2();
    echo "\n";
    echo getUserName("mickaël", "devoldère");
    echo "\n";
    echo getFullName("devoldère", "mickaël");
    echo "\n";
    echo askUser("de brito", "jessy");
?>