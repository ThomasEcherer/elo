importPackage(Packages.de.elo.ix.client);
importPackage(Packages.java.util);

/**
 * Indexserver calls this event after a file has been uploaded via the JSON-API.
 * https://github.com/blueimp/jQuery-File-Upload/wiki
 * https://github.com/blueimp/jQuery-File-Upload/wiki/Setup
 * @param ec Execution context
 * @param dv DocVersion object with the following valid members: ext, size, guid, uploadResult, physPath. 
 * DocVersion.uploadResult has to be returned to the client application. It must be set into its DocVersion.uploadResult before checkinDocEnd can be called. 
 * DocVersion.physPath is set to the location of the uploaded file in the servers temporary directory.
 * @param fileName Name of the uploaded file.
 * @param requestInfo Information of the underlying HttpServletRequest object.    
 * @param responseInfo  Information for the underlying HttpServletResponse object. 
 */
function onFileUploadBuildResponse(ec, dv, fileName, requestInfo, responseInfo) {
	log.info("onFileUploadBuildResponse(");
	log.info("dv=" + dv);
	log.info("dv.ext=" + dv.ext);
	log.info("dv.size=" + dv.size);
	log.info("dv.physPath=" + dv.physPath);
	
	log.info("fileName=" + fileName);

	log.info("requestInfo=" + requestInfo);
	log.info("requestInfo.headers=" + Arrays.toString(requestInfo.headers));
	log.info("requestInfo.cookies=" + Arrays.toString(requestInfo.cookies));
	log.info("requestInfo.requestParams=" + Arrays.toString(requestInfo.requestParams));
	
	log.info("responseInfo=" + responseInfo);
	
	var solution = getValueFromKey(requestInfo.requestParams, "solution", "valums");
	
	if (solution == "blueimp") {
		makeResponseBlueimp(ec, dv, fileName, requestInfo, responseInfo);
	}
	else {
		makeResponseValums(ec, dv, fileName, requestInfo, responseInfo);
	}

	log.info("responseInfo=" + responseInfo);
	log.info(")onFileUploadBuildResponse");
}

function makeResponseValums(ec, dv, fileName, requestInfo, responseInfo) {
	responseInfo.contentType = "text/html";

	var response = { uploadResult : ""+dv.uploadResult, success : true };
	responseInfo.responseString = JSON.stringify( response );
}

function makeResponseBlueimp(ec, dv, fileName, requestInfo, responseInfo) {
	
	var acceptHeader = getValueFromKey(requestInfo.headers, "ACCEPT", "");
	responseInfo.contentType = acceptHeader.indexOf("application/json") >= 0 ? "application/json" : "text/plain";
	
	var response = {
			name : ""+fileName,
			uploadResult : ""+dv.uploadResult,
			size : ""+dv.size

// 			Unsupported:
//		    "url":"\/\/example.org\/files\/picture1.jpg",
//		    "thumbnail_url":"\/\/example.org\/thumbnails\/picture1.jpg",
//		    "delete_url":"\/\/example.org\/upload-handler?file=picture1.jpg",
//		    "delete_type":"DELETE"
			
		};

	// Put response object into an array and convert to JSON
	responseInfo.responseString = JSON.stringify( [ response ] );
}

function getValueFromKey(keyValues, key, defaultValue) {
	var value = defaultValue;
	for (var i = 0; i < keyValues.length; i++) {
		if (keyValues[i].key == key) {
			value = keyValues[i].value;
			break;
		}
	}
	return value;
}