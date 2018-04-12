# Namespaces

Skripte einer Lösung müssen Namespaces {{NAMSPC}}} zugeordnet werden. Ein Namespace sollte sich dabei mindestens aus der Herkunft, dem zugehörigen Modul sowie einer Gruppierung zusammensetzen.

    {Herkunft}.{Modul Name}.{Gruppierung}
    Bspw.: sol.invoice.ix

ELO-intern sind Herkunftsbezeichner mit maximal drei Zeichen reserviert. Partner werden daher angewiesen, Bezeichner, die mehr als vier Zeichen enthalten, zu verwenden.

<span
style='font-weight:bold'>Beispiele für ELO-interne Namespaces:</span>

    sol.common
    sol.invoice
    elo.apps
    api.ix

<span
style='font-weight:bold'>Beispiele für benutzerdefinierte Namespaces:</span>

    custom.invoice
    elopartnername.invoice
    elobp.common

## Erstellen von Namespaces

Namespaces {{NAMSPC}}} werden automatisch bei der Definition einer Klasse erzeugt, falls notwendig. Sollen Namespaces automatisch angelegt werden, kann die Klasse `sol.NamespaceManager` hierzu verwendet werden.

    sol.ns('elopartnername.invoice');
    
    // in diesem Fall wird eine Objektstruktur in JS wie folgt angelegt
    var elopartnername = elopartnername || {};
    elopartnername.invoice= elopartnername.invoice|| {};
