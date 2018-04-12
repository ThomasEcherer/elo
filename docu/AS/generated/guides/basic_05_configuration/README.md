# Configuration

This guide explains how to set the global configuration of the ELO Apps.

## Archive Configuration folder

The ELO Apps will create several folders inside the Administration folder. One 
is called Configuration. In the description of this folder are the configuration
values for global ELO Apps settings stored. The values are stored in simple Java
properties notation (key=value).

{@img config_folder.PNG Alt Folder holding global configuration values inside its description.}

## Global configuration settings

### secureCookies (Default false)

This setting will set the secure flag to the cookie that holds the ELO session ticket.
The cookie will only be transmitted if a https connection is established.

**Please note**: Setting this to true will break all ELO Apps that need an
ELO session, without configuring https in the network.

### timezone (Default none)

Without this setting ELO Apps will get their timezone (the timezone when 
establishing a connection to the archive) from an parameter in the url 
(e.g. if the app gets started inside an ELO client) or by computing it during
the Login app (if the app is started standalone). If this setting is set it will
overwrite these two scenarios and the timezone given in the setting will be used.
If no setting is found and the two scenarios fail the timezone of the server is used.
The value must be a Java compatible TimeZone Id (see Java Documentation
[java.util.TimeZone#getAvailableIDs()](http://docs.oracle.com/javase/7/docs/api/java/util/TimeZone.html#getAvailableIDs%28%29),
or a list of values [here](https://garygregory.wordpress.com/2013/06/18/what-are-the-java-timezone-ids/)).