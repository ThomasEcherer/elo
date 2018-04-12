-- mssql_00_sol.common.sql created at 2017-11-21 13:27:16

IF OBJECT_ID('sol_accounting_costcenter') IS NOT NULL DROP TABLE sol_accounting_costcenter
CREATE TABLE sol_accounting_costcenter (company_code NVARCHAR(20) NOT NULL, no NVARCHAR(20) NOT NULL, name NVARCHAR(100) NOT NULL, PRIMARY KEY (company_code, no))

IF OBJECT_ID('sol_accounting_costobject') IS NOT NULL DROP TABLE sol_accounting_costobject
CREATE TABLE sol_accounting_costobject (company_code NVARCHAR(20) NOT NULL, no NVARCHAR(20) NOT NULL, name NVARCHAR(100) NOT NULL, PRIMARY KEY (company_code, no))

IF OBJECT_ID('sol_accounting_gl_account') IS NOT NULL DROP TABLE sol_accounting_gl_account
CREATE TABLE sol_accounting_gl_account (company_code NVARCHAR(20) NOT NULL, no NVARCHAR(20) NOT NULL, name NVARCHAR(100) NOT NULL, PRIMARY KEY (company_code, no))

IF OBJECT_ID('sol_business_area') IS NOT NULL DROP TABLE sol_business_area
CREATE TABLE sol_business_area (company_code NVARCHAR(20) NOT NULL, code NVARCHAR(20) NOT NULL, name NVARCHAR(100) NOT NULL, PRIMARY KEY (company_code, code))

IF OBJECT_ID('sol_common_fx') IS NOT NULL DROP TABLE sol_common_fx
CREATE TABLE sol_common_fx (currency_code NVARCHAR(20) NOT NULL, currency_exchange_rate NVARCHAR(10) NOT NULL, currency_symbol NVARCHAR(10) NULL, currency_description NVARCHAR(50) NULL, time NVARCHAR(14) NOT NULL, PRIMARY KEY (currency_code))

IF OBJECT_ID('sol_company') IS NOT NULL DROP TABLE sol_company
CREATE TABLE sol_company (code NVARCHAR(20) NOT NULL, name NVARCHAR(150) NULL, street NVARCHAR(150) NULL, zipcode NVARCHAR(20) NULL, city NVARCHAR(50) NULL, country_code NVARCHAR(50) NULL, gln NVARCHAR(15) NULL, standard_currency_code NVARCHAR(10) NULL, PRIMARY KEY (code))

IF OBJECT_ID('sol_inbox_register') IS NOT NULL DROP TABLE sol_inbox_register
CREATE TABLE sol_inbox_register (pos NVARCHAR(50) NOT NULL, main_register NVARCHAR(50) NULL, register NVARCHAR(50) NULL, doctype_name NVARCHAR(100) NULL, doctype_id NVARCHAR(10) NULL, workflow NVARCHAR(50) NULL, PRIMARY KEY (pos))

IF OBJECT_ID('sol_internal_order') IS NOT NULL DROP TABLE sol_internal_order
CREATE TABLE sol_internal_order (company_code NVARCHAR(20) NOT NULL, no NVARCHAR(20) NOT NULL, name NVARCHAR(100) NOT NULL, PRIMARY KEY (company_code, no))

IF OBJECT_ID('sol_invoice_item') IS NOT NULL DROP TABLE sol_invoice_item
CREATE TABLE sol_invoice_item (company_code NVARCHAR(20) NOT NULL, no NVARCHAR(20) NOT NULL, description NVARCHAR(150) NOT NULL, unit_name NVARCHAR(50) NULL, unit_price NUMERIC(18,4) NULL, cost_center_no NVARCHAR(50) NULL, cost_object_no NVARCHAR(50) NULL, gl_account_no NVARCHAR(50) NULL, vendor_no NVARCHAR(50) NULL, PRIMARY KEY (company_code, no))

IF OBJECT_ID('sol_invoice_po_line') IS NOT NULL DROP TABLE sol_invoice_po_line
CREATE TABLE sol_invoice_po_line (company_code NVARCHAR(20) NOT NULL, vendor_no NVARCHAR(20) NOT NULL, purchase_order_no NVARCHAR(20) NOT NULL, line_no NVARCHAR(20) NOT NULL, item_no NVARCHAR(20) NULL, item_description NVARCHAR(150) NULL, cost_center_no NVARCHAR(20) NULL, cost_object_no NVARCHAR(20) NULL, gl_account_no NVARCHAR(20) NULL, quantity INT NULL, quantity_unit NVARCHAR(5) NULL, unit_price NUMERIC(18,4) NULL, discount NUMERIC(18,4) NULL, line_amount NUMERIC(18,4) NULL, currency_code NVARCHAR(5) NULL, delivery_note_no NVARCHAR(10) NULL, delivery_note_date DATE NULL, received INT NOT NULL, PRIMARY KEY (company_code, vendor_no, purchase_order_no, line_no))

IF OBJECT_ID('sol_profit_center') IS NOT NULL DROP TABLE sol_profit_center
CREATE TABLE sol_profit_center (company_code NVARCHAR(20) NOT NULL, code NVARCHAR(20) NOT NULL, name NVARCHAR(100) NOT NULL, PRIMARY KEY (company_code, code))

IF OBJECT_ID('sol_project') IS NOT NULL DROP TABLE sol_project
CREATE TABLE sol_project (company_code NVARCHAR(20) NOT NULL, no NVARCHAR(20) NOT NULL, name NVARCHAR(100) NULL, PRIMARY KEY (company_code, no))

IF OBJECT_ID('sol_special_gl_indicator') IS NOT NULL DROP TABLE sol_special_gl_indicator
CREATE TABLE sol_special_gl_indicator (company_code NVARCHAR(20) NOT NULL, code NVARCHAR(10) NOT NULL, language NVARCHAR(10) NOT NULL, description NVARCHAR(100) NULL, PRIMARY KEY (company_code, code, language))

IF OBJECT_ID('sol_tax_code') IS NOT NULL DROP TABLE sol_tax_code
CREATE TABLE sol_tax_code (company_code NVARCHAR(20) NOT NULL, code NVARCHAR(10) NOT NULL, language NVARCHAR(10) NOT NULL, description NVARCHAR(100) NULL, vat_rate NUMERIC(18,4) NOT NULL, PRIMARY KEY (company_code, code, language))

IF OBJECT_ID('sol_trade_charge') IS NOT NULL DROP TABLE sol_trade_charge
CREATE TABLE sol_trade_charge (code NVARCHAR(10) NOT NULL, language NVARCHAR(10) NOT NULL, description NVARCHAR(100) NULL, docxfield NVARCHAR(50) NULL, PRIMARY KEY (code, language))

IF OBJECT_ID('sol_units') IS NOT NULL DROP TABLE sol_units
CREATE TABLE sol_units (code NVARCHAR(10) NOT NULL, language NVARCHAR(10) NOT NULL, description NVARCHAR(100) NULL, symbol NVARCHAR(20) NULL, PRIMARY KEY (code, language))

IF OBJECT_ID('sol_vat_rates') IS NOT NULL DROP TABLE sol_vat_rates
CREATE TABLE sol_vat_rates (country NVARCHAR(20) NOT NULL, start_date DATE NOT NULL, vat_rates NVARCHAR(100) NOT NULL, PRIMARY KEY (country, start_date, vat_rates))

IF OBJECT_ID('sol_vendor') IS NOT NULL DROP TABLE sol_vendor
CREATE TABLE sol_vendor (company_code NVARCHAR(20) NOT NULL, no NVARCHAR(20) NOT NULL, name NVARCHAR(100) NULL, street NVARCHAR(150) NULL, zipcode NVARCHAR(10) NULL, city NVARCHAR(50) NULL, iban NVARCHAR(100) NULL, bic NVARCHAR(20) NULL, country_code NVARCHAR(10) NULL, vat_id NVARCHAR(30) NULL, due_days INT NULL, tax_no NVARCHAR(30) NULL, gln NVARCHAR(15) NULL, PRIMARY KEY (company_code, no))

IF OBJECT_ID('sol_vendor_terms_of_payment') IS NOT NULL DROP TABLE sol_vendor_terms_of_payment
CREATE TABLE sol_vendor_terms_of_payment (company_code NVARCHAR(20) NOT NULL, vendor_no NVARCHAR(10) NOT NULL, cash_discount_days INT NOT NULL, cash_discount_rate NUMERIC(18,4) NOT NULL, PRIMARY KEY (company_code, vendor_no, cash_discount_days))

IF OBJECT_ID('sol_wbs_element') IS NOT NULL DROP TABLE sol_wbs_element
CREATE TABLE sol_wbs_element (company_code NVARCHAR(20) NOT NULL, code NVARCHAR(20) NOT NULL, name NVARCHAR(100) NOT NULL, PRIMARY KEY (company_code, code))

INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('EUR', '1', '€', 'Euro', '20170101000000')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('USD', '1.1761', '$', 'US dollar', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('JPY', '133.95', '¥', 'Japanese ye', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('BGN', '1.9558', 'лв', 'Bulgarian lev', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('CZK', '25.583', 'Kč', 'Czech koruna', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('DKK', '7.4433', 'kr', 'Danish krone', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('GBP', '0.89303', '£', 'Pound sterling', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('HUF', '308.53', 'Ft', 'Hungarian forint', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('PLN', '4.2403', 'zł', 'Polish zloty', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('RON', '4.6013', 'kr', 'Romanian leu', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('SEK', '9.6475', 'kr', 'Swedish krona', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('CHF', '1.1613', 'CHF', 'Swiss franc', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('NOK', '9.3883', 'kr', 'Norwegian krone', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('HRK', '7.5130', 'k', 'Croatian kuna', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('RUB', '67.6090', 'руб', 'Russian rouble', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('TRY', '4.3751', 'TRY', 'Turkish lira', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('AUD', '1.5117', '$', 'Australian dollar', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('BRL', '3.8022', 'R$', 'Brasilian real', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('CAD', '1.4875', '$', 'Canadian dollar', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('CNY', '7.8022', '¥', 'Chinese yuan renminbi', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('HKD', '9.1803', '$', 'Hong Kong dollar', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('IDR', '15937.33', 'Rp', 'Indonesian rupiah', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('ILS', '4.1184', '₪', 'Israeli shekel', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('INR', '76.5790', 'INR', 'Indian rupee', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('KRW', '1327.81', '₩', 'South Korean wo', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('MXN', '22.4841', '$', 'Mexican peso', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('MYR', '4.9849', 'RM', 'Malaysian ringgit', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('NZD', '1.7008', '$', 'New Zealand dollar', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('PHP', '60.801', '₱', 'Philippine peso', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('SGD', '1.6023', '$', 'Singapore dollar', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('THB', '39.035', '฿', 'Thai baht', '20171025101010')
INSERT INTO sol_common_fx (currency_code, currency_exchange_rate, currency_symbol, currency_description, time) VALUES ('ZAR', '16.1396', 'R', 'South African rand', '20171025101010')
GO

INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AA', 'DE', 'Werbekostenzuschuß', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AA', 'EN', 'Advertising allowance', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AAA', 'DE', 'Telekommunikationsgebühren', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AAA', 'EN', 'Telecommunication charges', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AAB', 'DE', 'Warenrücksendung', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AAB', 'EN', 'Returned goods charges', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AAC', 'DE', 'Anpassungskosten', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AAC', 'EN', 'Modification costs', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AAH', 'DE', 'Abwicklungskosten', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AAH', 'EN', 'Processing surcharge', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AAT', 'DE', 'Schnelle Lieferung', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AAT', 'EN', 'Rush delivery', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('ABK', 'DE', 'Sonstige Kosten', 'INV_SPECIAL_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('ABK', 'EN', 'Miscellaneous Charge', 'INV_SPECIAL_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('ABW', 'DE', 'Zoll', 'INV_CUSTOMS_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('ABW', 'EN', 'Customs duty charge', 'INV_CUSTOMS_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('ADR', 'DE', 'Andere Dienste', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('ADR', 'EN', 'Other services', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AEO', 'DE', 'Sammel- und Recylingservice', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AEO', 'EN', 'Collection and recycling service', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AJ', 'DE', 'Anpassungsgebühr', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('AJ', 'EN', 'Adjustments', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('FC', 'DE', 'Frachtkosten', 'INV_FREIGHT_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('FC', 'EN', 'Freight charge', 'INV_FREIGHT_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('IAA', 'DE', 'Installation', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('IAA', 'EN', 'Installation', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('I', 'DE', 'Versicherung', 'INV_INSURANCE_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('I', 'EN', 'Insurance', 'INV_INSURANCE_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('MAC', 'DE', 'Mindermengenzuschlag', 'INV_SMALL_VOL_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('MAC', 'EN', 'Minimum order/minimum billing charge', 'INV_SMALL_VOL_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('NAA', 'DE', 'Einwegbehälter', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('NAA', 'EN', 'Non-returnable containers', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('PAB', 'DE', 'Portokosten', 'INV_POSTAL_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('PAB', 'EN', 'Postage charge', 'INV_POSTAL_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('PC', 'DE', 'Verpacken', 'INV_PACKING_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('PC', 'EN', 'Packing', 'INV_PACKING_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('RAA', 'DE', 'Rückvergütung', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('RAA', 'EN', 'Rebate', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('SC', 'DE', 'Sonstiger Aufschlag', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('SC', 'EN', 'Surcharge', '')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('ZT', 'DE', 'Maut', 'INV_TOLL_CHARGE')
INSERT INTO sol_trade_charge (code, language, description, docxfield) VALUES ('ZT', 'EN', 'Toll', 'INV_TOLL_CHARGE')
GO

INSERT INTO sol_units (code, language, description, symbol) VALUES ('C62', 'DE', 'Eins (Stück)', 'Stk.')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('C62', 'EN', 'One (Unit)', 'Unit')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('DAY', 'DE', 'Tag', 'Tag(e)')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('DAY', 'EN', 'Day', 'Day(s)')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('HAR', 'DE', 'Hektar', 'ha')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('HAR', 'EN', 'hectare', 'ha')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('HUR', 'DE', 'Stunde', 'Std.')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('HUR', 'EN', 'Hour', 'h')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('KGM', 'DE', 'Kilogramm', 'kg')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('KGM', 'EN', 'kilogram', 'kg')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('KTM', 'DE', 'Kilometer', 'km')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('KTM', 'EN', 'kilometre', 'km')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('KWH', 'DE', 'Kilowattstunde', 'kWh')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('KWH', 'EN', 'kilowatt hour', 'kWh')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('LS', 'DE', 'Pauschale', 'pausch.')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('LS', 'EN', 'lump sum', 'lump s.')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('LTR', 'DE', 'Liter', 'l')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('LTR', 'EN', 'litre', 'l')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('MI', 'DE', 'Minute', 'mi')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('MI', 'EN', 'minute', 'mi')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('MMK', 'DE', 'Quadratmillimeter', 'mm²')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('MMK', 'EN', 'square millimetre', 'mm²')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('MMT', 'DE', 'Millimeter', 'mm')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('MMT', 'EN', 'millimetre', 'mm')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('MTK', 'DE', 'Quadratmeter', 'm²')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('MTK', 'EN', 'square meter', 'm²')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('MTQ', 'DE', 'Kubikmeter', 'm³')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('MTQ', 'EN', 'cubic metre', 'm³')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('MTR', 'DE', 'Meter', 'm')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('MTR', 'EN', 'metre', 'm')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('NAR', 'DE', 'Anzahl Artikel', 'Anz.')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('NAR', 'EN', 'number of articles', 'art.')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('NPR', 'DE', 'Anzahl Paare', 'Pr.')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('NPR', 'EN', 'number of pairs', 'prs.')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('P1', 'DE', 'Prozent', '%')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('P1', 'EN', 'percent', '%')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('SET', 'DE', 'Set', 'Set(s)')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('SET', 'EN', 'Set', 'set(s)')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('TNE', 'DE', 'Tonne', 't')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('TNE', 'EN', 'tonne', 't')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('WEE', 'DE', 'Woche', 'Woche(n)')
INSERT INTO sol_units (code, language, description, symbol) VALUES ('WEE', 'EN', 'week', 'wk')
GO

INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('AT', '2008-01-01', '20;12;10')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('BE', '2008-01-01', '21;12;6')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('BG', '2008-01-01', '20;7')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('BG', '2011-04-01', '20;9')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('CH', '2008-01-01', '7.6;3.6;2.4')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('CH', '2011-01-01', '8;3.8;2.5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('CY', '2008-01-01', '15;8;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('CZ', '2008-01-01', '19;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('CZ', '2012-01-01', '20;14')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('DE', '2008-01-01', '19;7;10.7')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('DK', '2008-01-01', '25')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('EE', '2008-01-01', '18;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('EE', '2009-07-01', '20;9')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('EL', '2008-01-01', '19;9;4.5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('EL', '2011-01-01', '23;13;6.5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('ES', '2008-01-01', '16;7;4')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('ES', '2010-07-01', '18;8;4')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('ES', '2012-09-01', '21;10;4')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('FI', '2008-01-01', '22;17;8')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('FI', '2010-07-01', '23;13;9')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('FR', '2008-01-01', '19.6;5.5;2.1')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('FR', '2012-04-01', '19.6;7;5.5;2.1')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('HU', '2008-01-01', '20;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('HU', '2012-01-01', '27;18;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('IE', '2008-01-01', '21;13.5;4.8')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('IE', '2012-01-01', '23;13.5;9;4.8')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('IT', '2008-01-01', '20;10;4')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('IT', '2011-09-17', '21;10;4')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('LT', '2008-01-01', '18;9;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('LT', '2012-01-01', '21;9;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('LU', '2008-01-01', '15;12;6;3')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('LV', '2008-01-01', '18;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('LV', '2012-01-01', '21;12')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('ME', '2008-01-01', '17;7')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('ME', '2012-01-01', '17;8')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('MT', '2008-01-01', '18;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('MT', '2011-01-01', '18;7;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('NL', '2008-01-01', '19;6')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('NL', '2012-10-01', '21;6')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('NO', '2008-01-01', '23;11.11')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('NO', '2011-01-01', '25;11;7')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('PL', '2008-01-01', '22;7;3')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('PL', '2011-01-01', '23;8;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('PT', '2008-01-01', '21;12;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('PT', '2011-01-01', '23;13;6')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('RU', '2008-01-01', '18;10')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('RO', '2008-01-01', '19;9')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('RO', '2010-07-01', '24;9;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('RS', '2008-01-01', '18;8')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('RS', '2011-01-01', '20;8')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('SE', '2008-01-01', '25;12;6')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('SI', '2008-01-01', '20;8.5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('SK', '2008-01-01', '19;10')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('SK', '2011-01-01', '20;10')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('UK', '2008-01-01', '17.5;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('UK', '2008-12-01', '15;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('UK', '2010-01-01', '17.5;5')
INSERT INTO sol_vat_rates (country, start_date, vat_rates) VALUES ('UK', '2011-01-04', '20;5')
GO
