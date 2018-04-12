# Skriptversionsbericht

<span class="tag_important">Die folgenden Konzepte benötigen das Modul <span
style='font-weight:bold;font-style:italic'>development</span>.</span>

Mithilfe von Skriptversionsberichten kann der Zustand aller Skripte unterhalb eines Ordners in einer Report-Datei gespeichert werden. 

{@img img1.png ELO 
- BS Invoice (Nils Mosbach) 
DOKUMENT 
AUFGABEN 
WERKZEUGE 
DEVELOPMENT 
RECHNU 
Goto I d 
Tools 
Generate Validate 
report 
report 
Versions report 
auild Setup auild debug 
Package Setup Package 
Setup}

## Report erzeugen

Zuerst muss ein Ordner im Administrationsbereich selektiert werden, der die gewünschten Skripte für den Bericht enthält.

{@img img3.png Administration 
t:» _temp 
Business Solutions 
Eloinst 
build 
Install 
t:' keywordng forms 
All 
t:' All Rhino 
t:" Configuraticn}

Anschließend wird mithilfe der Funktion <span
style='font-weight:bold;font-style:italic'>Generate report</span> ein Bericht in Form einer <span
style='font-style:italic'>.json</span>-Datei erzeugt.

    {
      "date": "20151020183324",
      "files": [
        {
          "refPath": "¶Administration¶Business Solutions¶common¶.eloinst",
          "name": "build",
          "filehash": "A9D8F20B2851A4951AFAF49C533AD35E",
          "guid": "(5CA093FB-21E1-F65D-FEAD-E9527CE77D52)",
          "version": "",
          "editor": "Michael Weiler",
          "date": "20151013163422",
          "deleted": false
        },
        {
          "refPath": "¶Administration¶Business Solutions¶common¶.eloinst",
          "name": "install",
          "filehash": "4562909FE6EF6631AA68742FF289C9B2",
          "guid": "(1E508032-1228-3A91-3E37-338355A72FFA)",
          "version": "",
          "editor": "Michael Weiler",
          "date": "20151016101939",
          "deleted": false
        },
        // …
    }

## Report abgleichen

Zu einem späteren Zeitpunkt kann mithilfe des Reports der aktuelle Stand mit der Report-Datei abgeglichen werden. Hierbei hilft die Funktion <span
style='font-weight:bold;font-style:italic'>Validate report</span> in der Multifunktionsleiste des Java Clients. 

Es öffnet sich ein Dialog, in dem die zuvor erzeugte JSON-Report-Datei ausgewählt werden muss. Abschließend wird einer Auflistung aller Skripte gegeben inkl. einer Trennung, welche Dateien modifiziert wurden und welche sich im Originalzustand befinden. Der Abgleich geschieht hier über die Hashwerte der Dateien.

Über einen Klick auf den Skriptnamen kann direkt zum Skript gesprungen werden.

{@img img5.png ScriptVersionReport common 
Modified Files 
Ih 
lih 
Editor 
GUID 
(5CAOEFB-21E1-F65D-FEAD-E9S27CE77D52) 
(1 E508032-1228-3A91-3E37-338355A72FFA) 
(50488444-668E-9E09-F02C-6E75214336DE) 
(73EB37F3-25B1-989C-D32B-72FD279E543E) 
(6930545-43Ag-DE47-7F22-0655F829066C) 
(56C13DE5-EF37-C4D8-381g-C7D83FDA13A5) 
(A3D86E30-13SF-FD36-77SF-03722522E943) 
(C7725058-C612-019F-78B3-OB90E78403A2) 
(3A0396E5-OF18-8748-7DE4-SA38S4DD4F8F) 
(801CD48F-3A98-8D57-5573-0733AEIA2BE1) 
(7AEC9ADg-A437-F472-1C60-2492594303C3) 
(9789A2DF-CC44-C202-7D87-5336CS8D620E) 
(E78D3320-DB31-7323-W5A-C3EFISB8EA6) 
(80CD3E78-DOA5-95EB-6536-2EEA85B7DF89) 
(2271536C-DCDA-CA5E-FW5-6CBAAB251695) 
Scriptname 
Original Files 
Scriptname 
Version 
Version 
3.04 
2.10.8 
GUID 
Editor 
Michael Weiler 
Michael Weiler 
Nils Mosbach 
Pascal Zipfel 
Nils Mosbach 
Nils Mosbach 
Pascal Zipfel 
Michael Weiler 
Michael Weiler 
Pascal Zipfel 
Adm i n istrator 
Pascal Zipfel 
Michael Weiler 
Michael Weiler 
Pascal Zipfel 
Michael Weiler 
Pascal Zipfel 
October 13, 2015 4:3422 PM CEST 
Friday, October 16, 2015 AM CEST 
Wednesday, September 16, 2015 PM CEST 
Wednesday, October 7, 2015 1049:18 AM CEST 
Wednesday, September 16, 2015 PM CEST 
Wednesday, September 1 6, 2015 5:31:00 PM CEST 
6, 2015 AM CEST 
Tuesday, October 13, 2015 AM CEST 
Tuesday, October6, 2015 PM CEST 
Thursday, October8, 2015 PM CEST 
Wednesday, September 16, 2015 1 0:01 AM CEST 
Friday, October 2, 2015 PM CEST 
Wednesday, October 14, 2015 945:51 AM CEST 
Tuesday, October 13, 2015 1:5419 PM CEST 
Wednesday, October 7, 2015 AM CEST 
Wednesday, October 7, 2015 5:3443 PM CEST 
Tuesday, October 6, 2015 PM CEST}

