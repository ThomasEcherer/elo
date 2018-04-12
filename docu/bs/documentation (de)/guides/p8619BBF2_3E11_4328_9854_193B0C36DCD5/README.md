# Web Client-Scripting

Web Client-Skripte sollten eine sich selbstausführende anonyme Funktion beinhalten, welche den gesamten Inhalt der Datei enthält. Dies sorgt u.a. dafür, dass Variablen zwangsläufig lokal definiert werden.

    (function () {
    
      var myVar = 'test';
    
    }());

Wird innerhalb eines Skripts auf globale Variablen zugegriffen, können diese als Parameter in die anonyme Funktion gegeben werden. Das bringt bei häufiger Anwendung Performance-Vorteile, da lokale Variablen im Zugriff performanter als globale sind.

    (function (window, document) {
    
      var myVar = document.getElementById('123');
    
    }(window, document));

Ein weiterer Vorteil ist, dass lokale Variablennamen minifiziert werden können. Ein Beispiel:

    (function(a,b){var c=b.getElementById('123');}(window,document));

