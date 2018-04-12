# Wechselkurse

Im Paket <span
style='font-weight:bold;font-style:italic'>common_fx</span> finden sich Mechanismen, um tagesaktuelle Wechselkurse über den Währungsdienst der Europäischen Zentralbank zu beziehen.

## Umfang

Wechselkurse für folgende Fremdwährungen werden mithilfe tagesaktueller Daten der ECB ermittelt. Nach gegenwärtigem Stand werden die Kurse mittels Daten aller europäischen und weltweiten Zentralbanken gegen 15:00 Uhr (CET) berechnet.

<table><thead><tr><td><span
style='font-weight:bold'>Kürzel</span></td><td><span
style='font-weight:bold'>Name</span></td><td></td><td><span
style='font-weight:bold'>Kürzel</span></td><td><span
style='font-weight:bold'>Name</span></td></tr></thead><tbody><tr><td>USD</td><td>US dollar</td><td></td><td>BRL</td><td>Brasilian real</td></tr><tr><td>JPY</td><td>Japanese yen</td><td></td><td>CAD</td><td>Canadian dollar</td></tr><tr><td>BGN</td><td>Bulgarian lev</td><td></td><td>CNY</td><td>Chinese yuan renminbi</td></tr><tr><td>CZK</td><td>Czech koruna</td><td></td><td>HKD</td><td>Hong Kong dollar</td></tr><tr><td>DKK</td><td>Danish krone</td><td></td><td>IDR</td><td>Indonesian rupiah</td></tr><tr><td>GBP</td><td>Pound sterling</td><td></td><td>ILS</td><td>Israeli shekel</td></tr><tr><td>HUF</td><td>Hungarian forint</td><td></td><td>INR</td><td>Indian rupee</td></tr><tr><td>PLN</td><td>Polish zloty</td><td></td><td>KRW</td><td>South Korean won</td></tr><tr><td>RON</td><td>Romanian leu</td><td></td><td>MXN</td><td>Mexican peso</td></tr><tr><td>SEK</td><td>Swedish krona</td><td></td><td>MYR</td><td>Malaysian ringgit</td></tr><tr><td>CHF</td><td>Swiss franc</td><td></td><td>NZD</td><td>New Zealand dollar</td></tr><tr><td>NOK</td><td>Norwegian krone</td><td></td><td>PHP</td><td>Philippine peso</td></tr><tr><td>HRK</td><td>Croatian kuna</td><td></td><td>SGD</td><td>Singapore dollar</td></tr><tr><td>RUB</td><td>Russian rouble</td><td></td><td>THB</td><td>Thai baht</td></tr><tr><td>TRY</td><td>Turkish lira</td><td></td><td>ZAR</td><td>South African rand</td></tr><tr><td>AUD</td><td>Australian dollar</td><td></td><td>EUR</td><td>Euro (Base Currency)</td></tr></tbody></table>

## Bereitstellung der Wechselkurse

Die Wechselkurse stehen in der Datenbank in der Tabelle <span
style='font-weight:bold;font-style:italic'>dbo.sol_common_fx </span>zur Verfügung.

Über den IX gibt es Möglichkeiten, auf diese Tabelle zuzugreifen:

<table><thead><tr><td><span
style='font-weight:bold'>Typ</span></td><td><span
style='font-weight:bold'>Name</span></td></tr></thead><tbody><tr><td>Service</td><td>sol.common.fx.ix.services.ForeignExchangeRates</td></tr></tbody></table>

## Automatische Aktualisierung

Der Abruf erfolgt alle 3 Stunden über die ELOas-Regel `sol.common.fx.as.UpdateExchangeRates`
Diese Regel nutzt die IX-Funktion `RF_sol_common_fx_service_LoadExchangeRates` mit dem Parameter `persist = true`.

## Datenbankstruktur

<table><thead><tr><td><span
style='font-weight:bold'>Spaltenname</span></td><td><span
style='font-weight:bold'>Datentyp</span></td><td><span
style='font-weight:bold'>NULL erlaubt</span></td><td><span
style='font-weight:bold'>Beschreibung</span></td><td><span
style='font-weight:bold'>Update durch ELOas</span></td></tr></thead><tbody><tr><td><span
style='font-weight:bold'>currency_code</span></td><td>nvarchar(10)</td><td>nein</td><td>3-stelliger Währungscode</td><td>nein</td></tr><tr><td><span
style='font-weight:bold'>currency_exchange_rate</span></td><td>nvarchar(10)</td><td>nein</td><td>Umrechnungskurs nach Euro</td><td>ja</td></tr><tr><td><span
style='font-weight:bold'>currency_symbol</span></td><td>nvarchar(10)</td><td>ja</td><td>Währungssymbol</td><td>ja</td></tr><tr><td><span
style='font-weight:bold'>currency_description</span></td><td>nvarchar(50)</td><td>ja</td><td>Name der Währung</td><td>nein</td></tr><tr><td><span
style='font-weight:bold'>time</span></td><td>nvarchar(14)</td><td>ja</td><td>ISO-Datumsstring letzter Stand</td><td>ja</td></tr></tbody></table>

