﻿using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.myelo
{
	
	/// <summary>
	/// This interface provides functions to MyELO page.
	/// </summary>
	// checkpoint byps.gen.cs.GenRemoteClass:93
	public interface MyELOServiceAuth : BRemote {
	
		EloixClient.IndexServer.myelo.MyELOState checkState(String userGuidOrID, String sinceDateIso);
		void checkState(String userGuidOrID, String sinceDateIso, BAsyncResult<EloixClient.IndexServer.myelo.MyELOState> asyncResult) ;
		
		EloixClient.IndexServer.myelo.MyELOContent readContent(EloixClient.IndexServer.myelo.MyELOState state, EloixClient.IndexServer.myelo.MyELOInfo info);
		void readContent(EloixClient.IndexServer.myelo.MyELOState state, EloixClient.IndexServer.myelo.MyELOInfo info, BAsyncResult<EloixClient.IndexServer.myelo.MyELOContent> asyncResult) ;
		
		
	}
}  // end namespace
