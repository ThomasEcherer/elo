<h1>Exchange rates</h1>
<p>The <span
style='font-weight:bold;font-style:italic'>common_fx</span> package contains mechanisms for getting the daily exchange rates from the ECB's currency service.</p>
<h2>Scope</h2>
<p>The exchange rates of the following foreign currencies are determined using up-to-date information provided by the ECB. The exchange rates are currently calculated at around 15:00 (CET) based on data from all European and world central banks.</p>
<table><thead><tr><td><span
style='font-weight:bold'>Abbreviation</span></td><td><span
style='font-weight:bold'>Name</span></td><td></td><td><span
style='font-weight:bold'>Abbreviation</span></td><td><span
style='font-weight:bold'>Name</span></td></tr></thead><tbody><tr><td>USD</td><td>US dollar</td><td></td><td>BRL</td><td>Brazilian real</td></tr><tr><td>JPY</td><td>Japanese yen</td><td></td><td>CAD</td><td>Canadian dollar</td></tr><tr><td>BGN</td><td>Bulgarian lev</td><td></td><td>CNY</td><td>Chinese yuan renminbi</td></tr><tr><td>CZK</td><td>Czech koruna</td><td></td><td>HKD</td><td>Hong Kong dollar</td></tr><tr><td>DKK</td><td>Danish krone</td><td></td><td>IDR</td><td>Indonesian rupiah</td></tr><tr><td>GBP</td><td>Pound sterling</td><td></td><td>ILS</td><td>Israeli shekel</td></tr><tr><td>HUF</td><td>Hungarian forint</td><td></td><td>INR</td><td>Indian rupee</td></tr><tr><td>PLN</td><td>Polish zloty</td><td></td><td>KRW</td><td>South Korean won</td></tr><tr><td>RON</td><td>Romanian leu</td><td></td><td>MXN</td><td>Mexican peso</td></tr><tr><td>SEK</td><td>Swedish krona</td><td></td><td>MYR</td><td>Malaysian ringgit</td></tr><tr><td>CHF</td><td>Swiss franc</td><td></td><td>NZD</td><td>New Zealand dollar</td></tr><tr><td>NOK</td><td>Norwegian krone</td><td></td><td>PHP</td><td>Philippine peso</td></tr><tr><td>HRK</td><td>Croatian kuna</td><td></td><td>SGD</td><td>Singapore dollar</td></tr><tr><td>RUB</td><td>Russian rouble</td><td></td><td>THB</td><td>Thai baht</td></tr><tr><td>TRY</td><td>Turkish lira</td><td></td><td>ZAR</td><td>South African rand</td></tr><tr><td>AUD</td><td>Australian dollar</td><td></td><td>EUR</td><td>Euro (base currency)</td></tr></tbody></table>

<h2>Provision of exchange rates</h2>
<p>The exchange rates are available in the database in the <span
style='font-weight:bold;font-style:italic'>dbo.sol_common_fx </span>table.</p>
<p>The IX provides access to this table:</p>
<table><thead><tr><td><span
style='font-weight:bold'>Type</span></td><td><span
style='font-weight:bold'>Name</span></td></tr></thead><tbody><tr><td>Service</td><td>sol.common.fx.ix.services.ForeignExchangeRates</td></tr></tbody></table>

<h2>Automatic update</h2>
<p>The data is refreshed every three hours using an ELOas rule <code>sol.common.fx.as.UpdateExchangeRates.</code>
This rule uses the IX function <code>RF_sol_common_fx_service_LoadExchangeRates</code> with the parameter <code>persist = true</code>.</p>
<h2>Database structure</h2>
<table><thead><tr><td><span
style='font-weight:bold'>Column name</span></td><td><span
style='font-weight:bold'>Data type</span></td><td><span
style='font-weight:bold'>NULL allowed</span></td><td><span
style='font-weight:bold'>Description</span></td><td><span
style='font-weight:bold'>Update by ELOas</span></td></tr></thead><tbody><tr><td><span
style='font-weight:bold'>currency_code</span></td><td>nvarchar(10)</td><td>No</td><td>3-digit currency code</td><td>No</td></tr><tr><td><span
style='font-weight:bold'>currency_exchange_rate</span></td><td>nvarchar(10)</td><td>No</td><td>Exchange rate to euros</td><td>Yes</td></tr><tr><td><span
style='font-weight:bold'>currency_symbol</span></td><td>nvarchar(10)</td><td>Yes</td><td>Currency symbol</td><td>Yes</td></tr><tr><td><span
style='font-weight:bold'>currency_description</span></td><td>nvarchar(50)</td><td>Yes</td><td>Name of the currency</td><td>No</td></tr><tr><td><span
style='font-weight:bold'>time</span></td><td>nvarchar(14)</td><td>Yes</td><td>Last update ISO date string</td><td>Yes</td></tr></tbody></table>
