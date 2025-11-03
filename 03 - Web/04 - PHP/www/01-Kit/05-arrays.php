<?php
    $names = ['Joe', 'Jack', 'Léa', 'Zoé', 'Néo'];
    $emptyNames = [];
    function firstItem(array $namesList): string
    {
        return $namesList[0];
    }

    echo firstItem($names)."\n";

    function lastItem(array $namesList): string
    {
        return $namesList[count($namesList) - 1];
    }

    echo lastItem($names)."\n";

    function sortItem(array $nameList): array
    {
        rsort($nameList);
        return $nameList;
    }

    print_r(sortItem($names));
    print_r(sortItem($emptyNames));

    function stringItems(array $nameList): string
    {
        if (empty($nameList)) {
            return 'Nothing to display';
        }
        sort($nameList);
        return implode(', ', $nameList);
    }

    echo stringItems($names)."\n";
    echo stringItems($emptyNames)."\n";
?>