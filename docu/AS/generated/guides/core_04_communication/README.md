# Communication between web page and client

Since ELO 9.02 it is possible for the ELO web pages (like workflow forms, feed, 
my elo etc.) to communicate messages and events to the client and vice versa.
This guide will show how this feature can be used inside custom scripting.

## Prerequisites

To communicate between client and web page, both must have an implementation of
the communication api available.
These are the client currectly supporting the communication library:

- ELO Java Client (since 9.02.008)
- ELO Web Client (since 9.02.000 build 234)

These are the web pages loading the communication library:

- ELO forms
- Document feeds
- My ELO/ Feed Aggregation
- ELO Apps

To use communication there must be a scripting possibility on both sides.
For the web pages this is only available in the ELO forms and ELO apps.

To send message between both parties, the web page must be rendered and loaded.

## Web Page side

The web page is embedded inside the client. To communicate to the client (parent)
the singleton api.communication.Parent ist used.

To check if a client is wrapping the page you can use:

    api.communication.Parent.hasParent();

To send a custom script message to the client:

    api.communication.Parent.sendCustomMessage('FOO', {my: 'data'}, function(data, event){
        // Handle responses from the client to this 'FOO' message.
        // There is no response of a response
    });

Here the first parameter ('FOO') can be any String. On the client side you can register
a handler to listen to messages with the same string name. The second parameter 
is any JavaScript Object that should be communicated to the client. This is done via JSON serialization.
The third parameter is a callback function to handle any response a client sends to this message.
Inside the reponse function you cannot re-response again, but sent a new message via sendCustomMessage.
It lies in the responsibility of the client to sent back a response. If it doesn't the function will never get called.

To listen to a custom event from the client:

    api.communication.Parent.onCustomMessage('BAR', function(data, event){
        // handle 'BAR' messages from the client.

        // maybe send a response back
        api.communication.Parent.sendResponse(event, { /* some response data */ });
    });

Here a listener is registered to handle all 'BAR' messages from a client. If 
this client wants to send a response e can use the sendResponse function. The first 
parameter of the response function is always the original incoming event from the client.
The second parameter is a object holding the reponse data. The library needs the
original event object to respond back to the correct message.

## Client side (Web Client)

To handle incoming messages from the web page:

    api.EventManager.addComponentListener('CMP_IFRAME', 'FOO', function(scope, state){
        // Handle the FOO message sent from the web page
        // Maybe send a response back to the page.
        scope.sendResponse(state.get('event'), {/* response data */});
    });

Here the String 'CMP_IFRAME' is a constant of the Web Client to register the 
listener function to any custom 'FOO' events that are received in any iframe.
The listener function gets called with two parameters. The scope is the wrapper 
object needed to send responses. The state is the normal Web Client state object.
It contains a members 'message' (the msgdata sent), 'event' (the complete event
object needed to answer to it) and 'scope' (the wrapper again).

To sent a message from the Web Client to a ELO form page:

    var child = api.Webclient.getActiveIFrameInterface('ELOWF_FORMULAR');
    if (child){
        child.sendCustomMessage('BAR', { 
            msg: 'Hello World from the Web Client.' 
        });
    }

Here the String 'ELOWF_FORMULAR' is a constant of the Web Client to retrieve
 a wrapper object of the currently rendered formular iframe. To this iframe 
the 'BAR' is sent.

Also see the script custom-communication.js in the /dev folder of any 9.02 
Web Client installation.

## Client side (Java Client)

To handle incoming messages from the a web page the following function must be implemented in a script:

    function eloReceiveBrowserMessage(msg, compName){
        // Handle the message sent from the web page given by compName
        

        // Maybe send a response back to the page.
        var browserComp = components.getClientBrowserComponent(compName);
        browserComp.sendCustomResponse(msg, {/* response data */});
    }

Here the message is the complete message object. And compName is the name of the
 browser component the message was sent from. In order to listen to a specific 
message name, the implementation must check if e.g. msg.name is 'FOO'.

To sent a message from the Java Client to a ELO form page:

    var browserComp = components.getClientBrowserComponent(CONSTANTS.BROWSER_COMPONENT_NAME.FORMULAR_PANEL);
    var fctParamsObject = { 
            msg: 'Hello World from the Java Client.' 
        };
    browserComp.callCustomFunction( "BAR", fctParamsObject, "responseFunction" );

Here the browser component is identified by the CONSTANTS.BROWSER_COMPONENT_NAME 
object. To this component the 'BAR' message is sent. The last parameter is the
 name of a function that should be called in case of a response.

    function responseFunction(data, event){
        // hanlde the response to the prior message
    }

