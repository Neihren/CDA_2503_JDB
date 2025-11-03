<?php
function getToday(): string
{
    return date("d/m/o");
}

echo getToday();

// YYYY-MM-DD
function getTimeLeft(string $date): string
{
    $year = (int)substr($date, 0, 4);
    $month = (int)substr($date, 5, 2);
    $day = (int)substr($date, 8, 2);
    if (!checkdate($month, $day, $year)) {
        return "La date est invalide";
    }
    $today = new DateTime();
    $date = new DateTime($date);
    $today->setTime(0, 0, 0);
    $date->setTime(0, 0, 0);
    if ($date < $today) {
        return "Evenement passé";
    } elseif ($date == $today) {
        return "Aujourd'hui";
    }
    $duration = $date->diff($today);
    $duration =$duration->format('%a');
    if ($duration < 31) {
        return "Dans ".$duration." jours.";
    } elseif ($duration < 365) {
        $nbMonth = (int)($duration / 30);
        $duration = $duration - 30 * $nbMonth;
        return "Dans ".$nbMonth." mois et ".$duration." jours.";
    } else {
        $nbYear = (int)($duration / 365);
        $duration = $duration - 365 * $nbYear;
        $nbMonth = (int)($duration / 30);
        if ($nbYear > 1) {
            return "Dans ".$nbYear." ans et ".$nbMonth." mois.";  
        } else {
            return "Dans ".$nbYear." ans et ".$nbMonth." mois.";
        }
    }

    //echo $duration->format('%a');
    // } elseif (($date->diff($today))->format('%a') < 31) {
    //     return "Dans ".$date->diff($today)." jours.";
    // }

    //echo $today->format('d/m/Y');
    //echo $date->format('d/m/Y');
    //echo date_diff($today, $date);
    return "a";
}
echo "\n";
echo getTimeleft("2027-12-05");
?>