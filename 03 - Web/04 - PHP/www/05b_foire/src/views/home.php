<?php

    function displayData(array $data) : string {
        $html = "<div style='overflow-x:auto;'><table>
                    <thead>
                        <tr>";
        foreach ($data[0] as $key => $value) {
            $html .=        "<th>" . htmlspecialchars($key) . "</th>";
        }
        $html .=        "</tr>
                    </thead>
                    <tbody>";
        foreach ($data as $ligne) {
            $html .="<tr>";
            foreach ($ligne as $value) {
                $html .=    "<td>" . htmlspecialchars((string)$value) . "</td>";
            }
            $html .="</tr>";
        }
        $html .=    "</tbody>
                </table></div>";
        return $html;
    }

    echo displayData($dataCanditat);
?>