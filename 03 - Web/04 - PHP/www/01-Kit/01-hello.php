<?php
    // Affiche test
    echo "test";
    echo "\n";

    // Affiche Hello World !
    function helloWorld() : void
    {
        echo "Hello World !";
    }
    helloWorld();
    echo "\n";

    // Affiche Hello avec la variable en paramètre
    function hello(string $name) : string
    {
        if (empty($name)) {
            $name = "Nobody";
        }
        return "Hello $name";
    }
    echo hello("Jessy");
    echo "\n";
    echo hello("");
    echo "\n";

?>