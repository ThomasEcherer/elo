# Problem Solving

The developer of an ELO App is responsible for its correctness.
The more complex an ELO App will get the more can go wrong. This guide should give
you an idea where to look and what to do when a problem occurs.

## Introduction

To see if there is something wrong in your ELO app, the browser console is used for 
logging. Also the communication with the IndexServer is directly done in the 
browser via the IndexServer JSON API. Therefore it is most likely that problems
will occur on the client side in the browser. Especially if there is a lot of
JavaScript involved. It is important to start looking for problems in the browser
not in server side logs.

## Browser Development Tools

Every common browser (by that I mean always at least Internet Explorer, Chrome,
Firefox and Safari) has a Java Script console or better **Development Tools**.
These are essential when writing own scripts but also very useful to see what is
going on in the ELO Webclient.

Here are some links on the development tools in different browsers.

- [Microsoft Internet Explorer](http://msdn.microsoft.com/en-us/library/ie/gg589500\(v=vs.85\).aspx)
- [Google Chrome](https://developer.chrome.com/devtools)
- [Mozilla Firefox - Firebug Add on](http://getfirebug.com/)
- [Apple Safari](https://developer.apple.com/safari/tools/)

All the Development Tools consist of:

- *HTML/CSS inspector* to analyse HTML code.
- **Network inspector** to see what data the browser sends and receives. 
- *Java Script debugger* to inspect the Java Script code.
- **Java Script console** to see if there are any problems in the Java Script code.

{@img devTools_Chrome.png Alt Development Tools Google Chrome}

### Java Script Console

The ELO Apps are writing log messages to the JavaScript console. There are 3
kinds of messages:

- Informations are displayed as black text messages.
- Warning are displayed with yellow warning signs.
- Error are displayed in red.

If there are any error messages in the JavaScript console while the ELO App
is running it can be a hint how to proceed. At least such error should be sent
along with the usual information if you contact the support.

You can see the JavaScript console as the log file of the ELO App.

**Please note:** Error messages can be expanded. 
Sometimes a whole stack trace hides additional information.

### Network inspector

In the network inspector all requests are shown with there answers that are send
from the browser. If there is a problem with communication it can help to know what
request informations were sent. Therefore the header informations of the requests
and answers always hold good information. 

## Problem Solving

When there is a Problem with the ELO App:

- Look in the Console for error messages.
- Look in the Network tab for bad requests.
- Clear browser cache and try again.
- Looking for help by post a search the support forum, or post a thread there.
