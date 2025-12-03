<?php
//require "./src/dao/RestaurantRepository.php";

function afficherTableau(array $data): string
{


    $chainesHtml = "<table class='styled-table' ><thead><tr>";
    foreach (array_keys($data[0]) as $colonne) {
        $chainesHtml .= "<th>" . htmlspecialchars($colonne) . "</th>";
    }
    $chainesHtml.= "<th>Modifier</th><th>Supprimer</th></tr></thead><tbody>";
    foreach ($data as $ligne) {
        $chainesHtml .= "<tr>";
        foreach ($ligne as $cellule) {
            $chainesHtml .= "<td>" . htmlspecialchars((string)$cellule) . "</td>";
        }
        $chainesHtml .= "<td><a href='detail.php?id=".$ligne['id']."' target='_self'> Modifier </a></td><td><form action='".$_SERVER["PHP_SELF"]."' method='POST'><input type='hidden' name='suppr' value='".$ligne['id']."'><input type='submit' value='Supprimer' name='suppression' /></form></td></tr>";
    }
    $chainesHtml .= "</tbody></table>";
    return $chainesHtml;
}
