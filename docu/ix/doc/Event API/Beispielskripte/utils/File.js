/**
 * Helper functions to read and write text files.
 */

/**
 * Import Java packages
 */
var importNamesFile = JavaImporter();
importNamesFile.importPackage(Packages.java.io);
importNamesFile.importPackage(Packages.java.nio);

/**
 * Reads the entire text from a file.
 * @param filePath File name and directory
 * @return Text content as JavaScript String
 */
function readTextFile(filePath) {
	
	with (importNamesFile) {
		var fis = null;
		var rd = null;
		var text = "";
		
		try {
			var file = new File(filePath);
			var buf = CharBuffer.allocate( file.length() );
			fis = new FileInputStream( filePath );
			rd = new InputStreamReader(fis);
			rd.read(buf);
			buf.flip();
			text = buf.toString();
		}
		catch (e) {
			log.error( "exception:" + e );
		}
		finally {
			if (rd != null) rd.close();
			if (fis != null) fis.close();
		}
	
		return text;
	}
}

/**
 * Write text into a file.
 * @param filePath File name and directory
 * @param text Content to be written.
 */
function writeTextFile(filePath, text) {
	var importNamesFile = JavaImporter();
	importNamesFile.importPackage(Packages.java.io);
	
	with (importNamesFile) {
	    var fos = null;
	    var wr = null;  
	    var pr = null;
	    try {
	      fos =  new FileOutputStream(filePath);
	      wr = new OutputStreamWriter(fos);
	      pr = new PrintWriter(wr);
	      pr.print( text );
	    }
		catch (e) {
			log.error( "exception:" + e );
		}
	    finally {
	      if (pr != null) pr.close();
	      if (wr != null) wr.close();
	      if (fos != null) fos.close();
	    }
	}
}

