/**
 * Helper functions to read from a database.
 */

/**
 * Import packages
 */
var importNamesDB = JavaImporter();
importNamesDB.importPackage(Packages.java.sql);
importNamesDB.importPackage(Packages.java.util);
importNamesDB.importPackage(Packages.java.lang);
importNamesDB.importPackage(Packages.de.elo.utils.sec);

/**
 * JDBC driver class names
 */
var DB_DRIVER_MSSQL = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
var DB_DRIVER_ORACLE = "oracle.jdbc.OracleDriver";
var DB_DRIVER_DB2 = "com.ibm.db2.jcc.DB2Driver";

/**
 * Opens a JDBC connection.
 * @param driver One of the DB_DRIVER_* constants.
 * @param url JDBC connection URL
 * @param props java.util.Properties object with connection properties.
 * @return java.sql.Connection object or null, if the connection failes.
 * @see #openMssql
 * @see #openOracle
 * @see #openDB2
 */
function openDB(driver, url, props) {
	log.info("openDB");
	with (importNamesDB) {
		var db = null;
		try {
			var pwd = props.get("password");
			pwd = new DesEncryption().decryptIfEncrypted(pwd);
			props.put( "password", pwd );

			Class.forName(driver);
			db = DriverManager.getConnection(url, props);
		}
		catch (e) {
			log.error("exception: " + e);
		}
		return db;
	}
}

/**
 * Open a database connection to Microsoft SQL Server.
 * @param url JDBC url
 * @param dbuser Database account
 * @param dbpwd Database account password
 * @param archive Archive name
 * @return java.sql.Connection object or null, if the connection failes.
 */
function openMssql(url, dbuser, dbpwd, archive) {
	with (importNamesDB) {
	
		// url="jdbc:sqlserver://servername:1433"
		
	    var props = new Properties();
	    props.put("user", dbuser);
	    props.put("password", dbpwd);
	    props.put("applicationName", "IX-JScript");
	    props.put("databaseName", archive);
	
	    return openDB(DB_DRIVER_MSSQL, url, props);
	}
}

/**
 * Open a database connection to ORACLE SQL Server.
 * @param url JDBC url
 * @param dbpwd Database account password
 * @param archive Archive name
 * @return java.sql.Connection object or null, if the connection failes.
 */
function openOracle(url, dbpwd, archive) {
	with (importNamesDB) {
	
		// url = "jdbc:oracle:thin:@servername:1521:databasename"
		
	    var props = new Properties();
	    props.put("user", archive);
	    props.put("password", dbpwd);
	    props.put("program", "IX-JScript");
		
	    return openDB(DB_DRIVER_ORACLE, url, props);
	}	
}

/**
 * Open a database connection to IBM DB2 SQL Server.
 * @param url JDBC url
 * @param dbuser Database account
 * @param dbpwd Database account password
 * @param shema Archive name
 * @return java.sql.Connection object or null, if the connection failes.
 */
function openDB2(url, dbuser, dbpwd, shema) {
	with (importNamesDB) {
	
		// url = "jdbc:db2://servername:50000/databasename"
		
	    var props = new Properties();
	    props.put("user", archive);
	    props.put("password", dbpwd);
	    props.put("currentSchema", shema.toUpperCase());
		
	    return openDB(DB_DRIVER_DB2, url, props);
	}	
}

/**
 * Close database connection.
 * @param db Database connection 
 */
function closeDB(db) {
	if (db) db.close();
}

/**
 * Executes a select command.
 * It returns the data in an JScript array of rows.
 * Each row is an array of Java Strings.
 * @param db Database connection 
 * @param sqlcmd SQL-Select command
 * @return Array of arrays of Java Strings 
 */
function readDB(db, sqlcmd) {
	var ret = new Array();
	with (importNamesDB) {
		var stmt = null;
		var rs = null;
		try {
			stmt = db.createStatement();
			rs = stmt.executeQuery(sqlcmd);
			var cols = rs.getMetaData().getColumnCount();
			while (rs.next()) {
				var row = [];
				for (var i = 1; i <= cols; i++) {
					row.push( rs.getString(i) );
				}
				ret.push(row);
			}
		}
		catch (e) {
			log.error("exception:" + e);
		}
		finally {
			if (rs != null) rs.close();
			if (stmt != null) stmt.close();
		}
		
		return ret;
	}
}

