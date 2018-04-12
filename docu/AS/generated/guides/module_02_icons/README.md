# elo.module.icons

This module handles ELO specific icons. It has no version number since the web 
application creates the icons of this module on startup.

## Dpi level

All icon sets will have according css files where CSS classes are used to load
the icons as background image. All icons are available in 4 different sizes in 
order to support high resolution displays. The dpi level is detected on startup 
and the according css files are loaded.

## Level Icons

The level icons are the type icons used for sord entries. They appear in the 
archive tree, help to separate folder from document objects or distinguish between
document types. The icon set is defined in the AdminConsole.

To use an level icon the css class name is *elo-levelicons-* and the level that 
is computed by the *api.module.LevelIcons.getLevel* method. This method gets a
sord type as input together with a flag for reference and encryption.

    api.module.LevelIcons.getLevel(sord.type, false, false);

In AngularJS the eloLevelIcon filter can be used.

    class="elo-levelicons-{{ sord.type | eloLevelIcon }}

## Using Custom Icons

In order to include custom icons, there are two possibilities:

- Store the icon in the resource/images folder of the app and define your own css class if needed.
In this case the app developer has to deal with different resolution etc. on its own.
- Strore icons into the archive. See below.

## Archived Icons

In the archive Administration/ELOapps/Icons several .ico files can be placed.
The ICO file type is a container holding several icons. In each file the icons 
should only differ in size (same icon in different sizes). There should be 4 sizes
in the ico container:

- Original size: (e.g. 60x60 pixels)
- Size x1,5: (e.g. 90x90 pixels)
- Size x2: (e.g. 120x120 pixels)
- Size x4: (e.g. 240x240 pixels)

The ELO web application will read those ico files, transform them accordingly and
provide css files to use them in the app. The name of the css class is 
*elo-archiveicons-* and the sanitized (no special characters or spaces) short description
of each icon in the archive.

All icons will be transformed to have an inverted icon, this icon can be used for dark background.
For colored the inverted version is the same, but monochome icons the are inverted.
The inverted version can be used with the following css class *elo-archiveicons-inv-* 
and the sanitized (no special characters or spaces) short description of each icon
 in the archive.

### Archived Icons (Tiles)

Archived icons are also used as tile icons. Tile icon can be selected by the 
user in the tile configuration. 

To mark a icon as tile icon it must start with lower-case 'tile' 
(e.g. 'tile-myIconName') in the short description.
Each tile icon needs special resolutions in order to extract all images for the 
small and large tiles. The ico file should contain one icon in the following sizes:

- Original size: (24x24 pixels) (Original size of a small tile)
- Size x1,5: (36x36 pixels) (Size x1,5 of a small tile)
- Size x2: (48x48 pixels) (Original size of a large tile; Size x2 of a small tile)
- Size x3: (72x72 pixels) (Size x1,5 of a large tile)
- Size x4: (96x96 pixels) (Size x2 of a large tile; Size x4 of a small tile)
- Size x8: (192x192 pixels) (Size x4 of a large tile)

To provide a better look tile icons should be monochrome.

### Archived Icons (ClientInfos)

If an icons short description name in the archive is the same as the id of a 
client info object. The icon will be displayed if the client info object places
a web page with type REGION into the client.





