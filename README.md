# Utazóügynök probléme - mesterséges intelligencia
## Heurisztikus kereső
A kereső operátorok közül azt választja ki, amely a legközelebb vinné a célhoz. Egyszerűbb algoritmus, ha egy mélységen alkalmazzuk ezt.

## Legrövidebb út kereső
A kereső nyílt és zárt csúcsok halmaza segítségével keresi a megoldást. Mielőtt választana egy csúcsot, sorba rendezi a nyílt csúcsok halmazát az
útvonal alapján. Szokásos módon alkalmazza a kiterjesztést.

## A és A\* algoritmus
Az előző két keresőt kombinálva "nézi a múltat *(legrovidebb út)* és jövőt *(heurisztikus)*" egyszerre. A kettő között az a külömbség, hogy a A* algoritmus heurisztikája
az optimális megoldás csúcsába vezető operátort válassza ki (alulról becslő heurisztika).
