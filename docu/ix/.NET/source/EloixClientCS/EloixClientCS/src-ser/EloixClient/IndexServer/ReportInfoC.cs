//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	/// <summary>
	/// Report information.
	/// </summary>
	/// <remarks>
	/// <p>IndexServer writes the following report entries</p>
	/// <table border="2">
	/// <tr>
	/// <td>ReportInfo.action</td>
	/// <td>ReportInfo.objId</td>
	/// <td>ReportInfo.extra1</td>
	/// <td>ReportInfo.extra2</td>
	/// <td>ReportInfo.comment</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_LOGIN</td>
	/// <td>0</td>
	/// <td>SSO User ID</td>
	/// <td>[EXTRA2_SSO_LOGIN]</td>
	/// <td>Computer name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_LOGOUT</td>
	/// <td>0</td>
	/// <td>0</td>
	/// <td>0</td>
	/// <td>&nbsp;</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_LOCK_ARCHIVE</td>
	/// <td>0</td>
	/// <td>Key ID</td>
	/// <td>0</td>
	/// <td>Key name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CREATE_USER</td>
	/// <td>0</td>
	/// <td>User ID</td>
	/// <td>User Flags</td>
	/// <td>User name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKIN_USER</td>
	/// <td>0</td>
	/// <td>User ID</td>
	/// <td>User Flags</td>
	/// <td>User name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_DELETE_USER</td>
	/// <td>0</td>
	/// <td>User ID</td>
	/// <td>User Flags</td>
	/// <td>User name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CREATE_KEY</td>
	/// <td>0</td>
	/// <td>Key ID</td>
	/// <td>0</td>
	/// <td>Key name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKIN_KEY</td>
	/// <td>0</td>
	/// <td>Key ID</td>
	/// <td>0</td>
	/// <td>Key name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_DELETE_KEY</td>
	/// <td>0</td>
	/// <td>Key ID</td>
	/// <td>0</td>
	/// <td>Key name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CREATE_SORD</td>
	/// <td>Object ID</td>
	/// <td>Object type</td>
	/// <td>Storage mask ID</td>
	/// <td>Sord name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKOUT_SORD</td>
	/// <td>Object ID</td>
	/// <td>0</td>
	/// <td>combination of EXTRA2_*</td>
	/// <td>Sord name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKIN_SORD</td>
	/// <td>Object ID</td>
	/// <td>0</td>
	/// <td>combination of EXTRA2_*</td>
	/// <td>Sord name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_DELETE_SORD</td>
	/// <td>Object ID</td>
	/// <td>Object type</td>
	/// <td>combination of EXTRA2_*</td>
	/// <td>Sord name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_DELETE_REFERENCE</td>
	/// <td>Object ID</td>
	/// <td>Parent ID</td>
	/// <td>combination of EXTRA2_*</td>
	/// <td>Sord name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_COPY_SORD</td>
	/// <td>unsupported</td>
	/// <td></td>
	/// <td></td>
	/// <td>&nbsp;</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_REFERENCE_SORD</td>
	/// <td>Parent ID</td>
	/// <td>Object ID</td>
	/// <td></td>
	/// <td>Parent name, Object name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_MOVE_SORD</td>
	/// <td>New parent ID</td>
	/// <td>Object ID</td>
	/// <td>Old parent ID</td>
	/// <td>New parent name, old parent name, Sord name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_LINK_SORD</td>
	/// <td>From object ID</td>
	/// <td>To object ID</td>
	/// <td>
	/// </td>
	/// <td>From Sord name, To Sord name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_UNLINK_SORD</td>
	/// <td>From object ID</td>
	/// <td>To object ID</td>
	/// <td>
	/// </td>
	/// <td>From Sord name, To Sord name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKOUT_DOCVERSION</td>
	/// <td>Object ID</td>
	/// <td>Document version ID</td>
	/// <td>combination of EXTRA2_*</td>
	/// <td>Objektname, Versionsnummer</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKIN_DOCVERSION</td>
	/// <td>Objekt-ID</td>
	/// <td>Doc-ID</td>
	/// <td>combination of EXTRA2_*</td>
	/// <td>Objektname, Versionsnummer</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CREATE_DOC_MASK</td>
	/// <td>0</td>
	/// <td>Mask-ID</td>
	/// <td>0</td>
	/// <td>Maskname</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKIN_DOC_MASK</td>
	/// <td>0</td>
	/// <td>Mask-ID</td>
	/// <td>0</td>
	/// <td>Maskname</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_DELETE_DOC_MASK</td>
	/// <td>0</td>
	/// <td>Mask-ID</td>
	/// <td>replace with Mask-ID</td>
	/// <td>Maskname</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKIN_REPL_NAME</td>
	/// <td>0</td>
	/// <td>Repl-ID</td>
	/// <td>0</td>
	/// <td>ReplSet-Name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKIN_REPORT_OPTIONS</td>
	/// <td>0</td>
	/// <td>0</td>
	/// <td>0</td>
	/// <td>&nbsp;</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_DELETE_REPORT</td>
	/// <td>0</td>
	/// <td>endDate</td>
	/// <td>0</td>
	/// <td>TS-End-Date</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKIN_COLOR</td>
	/// <td>0</td>
	/// <td>Color-ID</td>
	/// <td>rgb</td>
	/// <td>Color-Name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKIN_USER_PROFILE</td>
	/// <td>0</td>
	/// <td>For User-ID</td>
	/// <td>0</td>
	/// <td>User-Name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_DELETE_USER_PROFILE</td>
	/// <td>0</td>
	/// <td>For User-ID</td>
	/// <td>0</td>
	/// <td>User-Name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CREATE_WORKFLOW</td>
	/// <td>0</td>
	/// <td>Workflow-ID</td>
	/// <td>combination of EXTRA2_*</td>
	/// <td>Workflow-Name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKIN_WORKFLOW</td>
	/// <td>0</td>
	/// <td>Workflow-ID</td>
	/// <td>combination of EXTRA2_*</td>
	/// <td>Workflow-Name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_DELETE_WORKFLOW</td>
	/// <td>0</td>
	/// <td>Workflow-ID</td>
	/// <td>combination of EXTRA2_*</td>
	/// <td>Workflow name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_EDIT_WORKFLOW_NODE</td>
	/// <td>Object-ID</td>
	/// <td>Workflow-ID</td>
	/// <td>Node-ID</td>
	/// <td>Node name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_START_WORKFLOW</td>
	/// <td>Object-ID</td>
	/// <td>Workflow-ID</td>
	/// <td>Template-WF-ID</td>
	/// <td>Workflow name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_START_ADHOC_WORKFLOW</td>
	/// <td>Object-ID</td>
	/// <td>Workflow-ID</td>
	/// <td>0</td>
	/// <td>Workflow name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_TERMINATE_WORKFLOW</td>
	/// <td>Object-ID</td>
	/// <td>Workflow-ID</td>
	/// <td>0</td>
	/// <td>Workflow-Name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKIN_CONFIG_FILE</td>
	/// <td>0</td>
	/// <td>0</td>
	/// <td>0</td>
	/// <td>Config file name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_DELETE_CONFIG_FILE</td>
	/// <td>0</td>
	/// <td>0</td>
	/// <td>0</td>
	/// <td>Config file name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKIN_COUNTER</td>
	/// <td>0</td>
	/// <td>Value</td>
	/// <td>0</td>
	/// <td>Counter-Name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_DELETE_COUNTER</td>
	/// <td>0</td>
	/// <td>0</td>
	/// <td>0</td>
	/// <td>Counter-Name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_INCREMENT_COUNTER</td>
	/// <td>0</td>
	/// <td>Value</td>
	/// <td>0</td>
	/// <td>Counter name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKIN_SORD_TYPE</td>
	/// <td>0</td>
	/// <td>ID (Sord.type)</td>
	/// <td>0</td>
	/// <td>Type name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_DELETE_SORD_TYPE</td>
	/// <td>0</td>
	/// <td>ID (Sord.type)</td>
	/// <td>0</td>
	/// <td>Type name</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CREATE_NOTE</td>
	/// <td>Objekt-ID</td>
	/// <td>Note-ID (internal)</td>
	/// <td>combination of EXTRA2_*</td>
	/// <td>Note-Guid</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_CHECKIN_NOTE</td>
	/// <td>Objekt-ID</td>
	/// <td>Note-ID (internal)</td>
	/// <td>combination of EXTRA2_*</td>
	/// <td>Note-Guid</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_IX_DELETE_NOTE</td>
	/// <td>Objekt-ID</td>
	/// <td>Note-ID (internal)</td>
	/// <td>combination of EXTRA2_*</td>
	/// <td>Note-Guid</td>
	/// </tr>
	/// <tr>
	/// <td>ACT_DM_READDOC</td>
	/// <td>Objekt-ID</td>
	/// <td>Doc-ID</td>
	/// <td>0</td>
	/// <td>&nbsp;</td>
	/// </tr>
	/// </table>
	/// 
	/// <p>
	/// To enable or disable reporting of actions, action codes have to be transformed into
	/// ERP codes first. One ERP code can subsume serverel action codes. The ERP codes
	/// can be used in checkinReportOptions to manipulate reporting. Furthermore they
	/// can be used in findFirstReportInfos, FindReportInfo, to search for reported actions.
	/// The following table shows how actions codes are mapped to report options.
	/// </p>
	/// 
	/// <table border="2">
	/// <tr><td>Action code, ReportInfoC</td><td>ERP code, ReportOptionsC </td></tr>
	/// <tr><td>ACT_CLIENT_ELOSTART           </td><td>ERP_LOGOPENARC     </td></tr>
	/// <tr><td>ACT_CLIENT_ELOEND             </td><td>ERP_LOGCLOSEARC    </td></tr>
	/// <tr><td>ACT_CLIENT_COMPLAIN           </td><td>ERP_LOGCOMPLAIN    </td></tr>
	/// <tr><td>ACT_CLIENT_DELETEDOCS         </td><td>ERP_LOGERADOC      </td></tr>
	/// <tr><td>ACT_CLIENT_KEYCHANGED         </td><td>ERP_LOGCHANGEKEY   </td></tr>
	/// <tr><td>ACT_CLIENT_USERCHANGED        </td><td>ERP_LOGUSERDATA    </td></tr>
	/// <tr><td>ACT_CLIENT_COLORCHANGED       </td><td>ERP_LOGCHANGEKIND  </td></tr>
	/// <tr><td>ACT_CLIENT_PATHCHANGED        </td><td>ERP_LOGPATHDATA    </td></tr>
	/// <tr><td>ACT_CLIENT_MASKCHANGED        </td><td>ERP_LOGMASKDATA    </td></tr>
	/// <tr><td>ACT_CLIENT_PWDCHANGED         </td><td>ERP_LOGCHANGEPWD   </td></tr>
	/// <tr><td>ACT_CLIENT_CREATEDOC          </td><td>ERP_LOGCREATEDOC   </td></tr>
	/// <tr><td>ACT_CLIENT_EDITDOC            </td><td>ERP_LOGEDITDOC     </td></tr>
	/// <tr><td>ACT_CLIENT_CHANGEDOC          </td><td>ERP_LOGEDITDOC     </td></tr>
	/// <tr><td>ACT_CLIENT_CHANGEATTACH       </td><td>ERP_LOGEDITDOC     </td></tr>
	/// <tr><td>ACT_CLIENT_VIEWDOC            </td><td>ERP_LOGVIEWDOC     </td></tr>
	/// <tr><td>ACT_CLIENT_ERASEDOC           </td><td>ERP_LOGERADOC      </td></tr>
	/// <tr><td>ACT_CLIENT_MOVEDOC            </td><td>ERP_LOGMOVEDOC     </td></tr>
	/// <tr><td>ACT_CLIENT_REFDOC             </td><td>ERP_LOGREFDOC      </td></tr>
	/// <tr><td>ACT_CLIENT_CHANGEKEY          </td><td>ERP_LOGCHANGEKEY   </td></tr>
	/// <tr><td>ACT_CLIENT_CHANGEKIND         </td><td>ERP_LOGCHANGEKIND  </td></tr>
	/// <tr><td>ACT_CLIENT_CONVERT_FORMAT     </td><td>ERP_CONVERT_FORMAT </td></tr>
	/// <tr><td>ACT_CLIENT_CHECKOUT           </td><td>ERP_CHECKOUT       </td></tr>
	/// <tr><td>ACT_CLIENT_CHECKIN            </td><td>ERP_CHECKIN        </td></tr>
	/// <tr><td>ACT_CLIENT_CREATESOR          </td><td>ERP_LOGCREATESOR   </td></tr>
	/// <tr><td>ACT_CLIENT_CHANGESOR          </td><td>ERP_LOGEDITDATA    </td></tr>
	/// <tr><td>ACT_CLIENT_EDITSOR            </td><td>ERP_LOGEDITDATA    </td></tr>
	/// <tr><td>ACT_CLIENT_ERASESOR           </td><td>ERP_LOGERASOR      </td></tr>
	/// <tr><td>ACT_CLIENT_MOVESOR            </td><td>ERP_LOGMOVESOR     </td></tr>
	/// <tr><td>ACT_CLIENT_REFSOR             </td><td>ERP_LOGREFSOR      </td></tr>
	/// <tr><td>ACT_CLIENT_ADDREF             </td><td>ERP_LOGREFDOC      </td></tr>
	/// <tr><td>ACT_CLIENT_ERASEREF           </td><td>ERP_LOGERAREF      </td></tr>
	/// <tr><td>ACT_CLIENT_MOVEREF            </td><td>ERP_LOGMOVEDOC     </td></tr>
	/// <tr><td>ACT_CLIENT_WVNEW              </td><td>ERP_WV             </td></tr>
	/// <tr><td>ACT_CLIENT_WVCHANGE           </td><td>ERP_WV             </td></tr>
	/// <tr><td>ACT_CLIENT_WVDELETE           </td><td>ERP_WV             </td></tr>
	/// <tr><td>ACT_CLIENT_WVSEND             </td><td>ERP_WV             </td></tr>
	/// <tr><td>ACT_CLIENT_WVRECEIVE          </td><td>ERP_WV             </td></tr>
	/// <tr><td>ACT_CLIENT_WVNEWSEND          </td><td>ERP_WV             </td></tr>
	/// <tr><td>ACT_CLIENT_WVCHANGESEND       </td><td>ERP_WV             </td></tr>
	/// <tr><td>ACT_CLIENT_POSTFIRST          </td><td>ERP_POSTBOX        </td></tr>
	/// <tr><td>ACT_CLIENT_POSTDELETE         </td><td>ERP_POSTBOX        </td></tr>
	/// <tr><td>ACT_CLIENT_POSTDOCBUILD       </td><td>ERP_POSTBOX        </td></tr>
	/// <tr><td>ACT_CLIENT_POSTEDIT           </td><td>ERP_POSTBOX        </td></tr>
	/// <tr><td>ACT_CLIENT_POSTSCHLAGWORT     </td><td>ERP_POSTBOX        </td></tr>
	/// <tr><td>ACT_CLIENT_POSTCOPYTO         </td><td>ERP_POSTBOX        </td></tr>
	/// <tr><td>ACT_CLIENT_POSTMOVETO         </td><td>ERP_POSTBOX        </td></tr>
	/// <tr><td>ACT_CLIENT_POSTMOVE           </td><td>ERP_POSTBOX        </td></tr>
	/// <tr><td>ACT_CLIENT_POSTCOLLECT        </td><td>ERP_POSTBOX        </td></tr>
	/// <tr><td>ACT_CLIENT_POSTNEWOLE         </td><td>ERP_POSTBOX        </td></tr>
	/// <tr><td>ACT_CLIENT_POSTEXPAND         </td><td>ERP_POSTBOX        </td></tr>
	/// <tr><td>ACT_CLIENT_POSTIMPORT         </td><td>ERP_POSTBOX        </td></tr>
	/// <tr><td>ACT_CLIENT_POSTLAST           </td><td>ERP_POSTBOX        </td></tr>
	/// <tr><td>ACT_CLIENT_CREATEFLOWTEMPL    </td><td>ERP_CREATEFLOWTEMPL</td></tr>
	/// <tr><td>ACT_CLIENT_EDITFLOWTEMPL      </td><td>ERP_EDITFLOWTEMPL  </td></tr>
	/// <tr><td>ACT_CLIENT_DELFLOWTEMPL       </td><td>ERP_DELFLOWTEMPL   </td></tr>
	/// <tr><td>ACT_CLIENT_STARTFLOW          </td><td>ERP_STARTFLOW      </td></tr>
	/// <tr><td>ACT_CLIENT_RECEIVEFLOW        </td><td>ERP_RECEIVEFLOW    </td></tr>
	/// <tr><td>ACT_CLIENT_FORWARDFLOW        </td><td>ERP_FORWARDFLOW    </td></tr>
	/// <tr><td>ACT_CLIENT_EDITFLOWACTIVE     </td><td>ERP_EDITFLOWACTIVE </td></tr>
	/// <tr><td>ACT_CLIENT_DELFLOWACTIVE      </td><td>ERP_DELFLOWACTIVE  </td></tr>
	/// <tr><td>ACT_CLIENT_FLOWTIMELIMIT      </td><td>ERP_FLOWTIMELIMT   </td></tr>
	/// <tr><td>ACT_CLIENT_FLOWERRORYESNO     </td><td>ERP_FLOWERRORYESNO </td></tr>
	/// <tr><td>ACT_CLIENT_REPORTCHANGED      </td><td>ERP_VERSCHIEDEN    </td></tr>
	/// <tr><td>ACT_CLIENT_MASKTEXTTOOLONG    </td><td>ERP_VERSCHIEDEN    </td></tr>
	/// <tr><td>ACT_CLIENT_NEWVERT         </td><td>ERP_NEWVERT    </td></tr>
	/// <tr><td>ACT_CLIENT_DELVERT         </td><td>ERP_DELVERT    </td></tr>
	/// <tr><td>ACT_CLIENT_FREEVERT        </td><td>ERP_FREEVERT   </td></tr>
	/// <tr><td>ACT_CLIENT_REMOVEVERT         </td><td>ERP_REMOVEVERT     </td></tr>
	/// <tr><td>ACT_CLIENT_SETVERT         </td><td>ERP_SETVERT    </td></tr>
	/// <tr><td>ACT_CLIENT_RESETVERT          </td><td>ERP_RESETVERT      </td></tr>
	/// <tr><td>ACT_CLIENT_SHOWDOC            </td><td>ERP_SHOWDOC        </td></tr>
	/// <tr><td>ACT_CLIENT_SHOWSOR            </td><td>ERP_SHOWSOR        </td></tr>
	/// <tr><td>ACT_CLIENT_DELVERSION         </td><td>ERP_DELVERSION     </td></tr>
	/// <tr><td>ACT_CLIENT_PICKPOST           </td><td>ERP_PICKPOST       </td></tr>
	/// <tr><td>ACT_DM_READDOC                </td><td>ERP_LOGVIEWDOC     </td></tr>
	/// <tr><td>ACT_IX_LOGIN                   </td><td>ERP_LOGOPENARC</td></tr>
	/// <tr><td>ACT_IX_LOGOUT                  </td><td>ERP_LOGCLOSEARC</td></tr>
	/// <tr><td>ACT_IX_LOCK_ARCHIVE            </td><td>ERP_LOGCHANGEKEY</td></tr>
	/// <tr><td>ACT_IX_CREATE_USER             </td><td>ERP_LOGUSERDATA</td></tr>
	/// <tr><td>ACT_IX_CHECKIN_USER            </td><td>ERP_LOGUSERDATA</td></tr>
	/// <tr><td>ACT_IX_DELETE_USER             </td><td>ERP_LOGUSERDATA</td></tr>
	/// <tr><td>ACT_IX_CREATE_KEY              </td><td>ERP_LOGCHANGEKEY</td></tr>
	/// <tr><td>ACT_IX_CHECKIN_KEY             </td><td>ERP_LOGCHANGEKEY</td></tr>
	/// <tr><td>ACT_IX_DELETE_KEY              </td><td>ERP_LOGCHANGEKEY</td></tr>
	/// <tr><td>ACT_IX_CREATE_SORD             </td><td>ERP_LOGCREATEDOC</td></tr>
	/// <tr><td>ACT_IX_CHECKOUT_SORD           </td><td>ERP_LOGVIEWDOC</td></tr>
	/// <tr><td>ACT_IX_CHECKIN_SORD            </td><td>ERP_LOGEDITDOC</td></tr>
	/// <tr><td>ACT_IX_DELETE_SORD             </td><td>ERP_LOGERADOC</td></tr>
	/// <tr><td>ACT_IX_DELETE_REFERENCE        </td><td>ERP_LOGERAREF</td></tr>
	/// <tr><td>ACT_IX_COPY_SORD               </td><td>ERP_LOGCREATEDOC</td></tr>
	/// <tr><td>ACT_IX_REFERENCE_SORD          </td><td>ERP_LOGREFDOC</td></tr>
	/// <tr><td>ACT_IX_MOVE_SORD               </td><td>ERP_LOGMOVEDOC</td></tr>
	/// <tr><td>ACT_IX_LINK_SORD               </td><td>ERP_LOGREFDOC</td></tr>
	/// <tr><td>ACT_IX_UNLINK_SORD             </td><td>ERP_LOGREFDOC</td></tr>
	/// <tr><td>ACT_IX_CHECKOUT_DOCVERSION     </td><td>ERP_LOGVIEWDOC</td></tr>
	/// <tr><td>ACT_IX_CHECKIN_DOCVERSION      </td><td>ERP_CHECKIN</td></tr>
	/// <tr><td>ACT_IX_CREATE_DOC_MASK         </td><td>ERP_LOGMASKDATA</td></tr>
	/// <tr><td>ACT_IX_CHECKIN_DOC_MASK        </td><td>ERP_LOGMASKDATA</td></tr>
	/// <tr><td>ACT_IX_DELETE_DOC_MASK         </td><td>ERP_LOGMASKDATA</td></tr>
	/// <tr><td>ACT_IX_CHECKIN_REPL_NAME       </td><td>ERP_LOGKEYDATA</td></tr>
	/// <tr><td>ACT_IX_CHECKIN_REPORT_OPTIONS  </td><td>ERP_LOGKEYDATA</td></tr>
	/// <tr><td>ACT_IX_DELETE_REPORT           </td><td>ERP_LOGKEYDATA</td></tr>
	/// <tr><td>ACT_IX_CHECKIN_COLOR           </td><td>ERP_LOGCOLORDATA</td></tr>
	/// <tr><td>ACT_IX_CHECKIN_USER_PROFILE    </td><td>ERP_LOGKEYDATA</td></tr>
	/// <tr><td>ACT_IX_DELETE_USER_PROFILE     </td><td>ERP_LOGKEYDATA</td></tr>
	/// <tr><td>ACT_IX_CREATE_WORKFLOW         </td><td>ERP_CREATEFLOWTEMPL</td></tr>
	/// <tr><td>ACT_IX_CHECKIN_WORKFLOW        </td><td>ERP_EDITFLOWTEMPL</td></tr>
	/// <tr><td>ACT_IX_DELETE_WORKFLOW         </td><td>ERP_DELFLOWTEMPL</td></tr>
	/// <tr><td>ACT_IX_EDIT_WORKFLOW_NODE      </td><td>ERP_FORWARDFLOW</td></tr>
	/// <tr><td>ACT_IX_START_WORKFLOW          </td><td>ERP_STARTFLOW</td></tr>
	/// <tr><td>ACT_IX_START_ADHOC_WORKFLOW    </td><td>ERP_STARTFLOW</td></tr>
	/// <tr><td>ACT_IX_TERMINATE_WORKFLOW      </td><td>ERP_FORWARDFLOW</td></tr>
	/// <tr><td>ACT_IX_TAKE_WORKFLOW_NODE    </td><td>ERP_FORWARDFLOW</td></tr>
	/// <tr><td>ACT_IX_CHECKIN_CONFIG_FILE     </td><td>ERP_LOGKEYDATA</td></tr>
	/// <tr><td>ACT_IX_DELETE_CONFIG_FILE      </td><td>ERP_LOGKEYDATA</td></tr>
	/// <tr><td>ACT_IX_CHECKIN_COUNTER         </td><td>ERP_LOGKEYDATA</td></tr>
	/// <tr><td>ACT_IX_DELETE_COUNTER          </td><td>ERP_LOGKEYDATA</td></tr>
	/// <tr><td>ACT_IX_INCREMENT_COUNTER       </td><td>ERP_LOGKEYDATA</td></tr>
	/// <tr><td>ACT_IX_CHECKIN_SORD_TYPE       </td><td>ERP_LOGKEYDATA</td></tr>
	/// <tr><td>ACT_IX_DELETE_SORD_TYPE        </td><td>ERP_LOGKEYDATA</td></tr>
	/// <tr><td>ACT_IX_CREATE_NOTE             </td><td>ERP_LOGKEYDATA</td></tr>
	/// <tr><td>ACT_IX_CHECKIN_NOTE            </td><td>ERP_LOGEDITDOC</td></tr>
	/// <tr><td>ACT_IX_CHECKOUT_NOTE           </td><td>ERP_LOGEDITDOC</td></tr>
	/// <tr><td>ACT_IX_DELETE_NOTE             </td><td>ERP_LOGEDITDOC</td></tr>
	/// <tr><td>ACT_IX_NEWVERT                   </td><td>ERP_NEWVERT   </td></tr>
	/// <tr><td>ACT_IX_DELVERT                   </td><td>ERP_DELVERT   </td></tr>
	/// <tr><td>ACT_IX_FREEVERT          </td><td>ERP_FREEVERT    </td></tr>
	/// <tr><td>ACT_IX_REMOVEVERT              </td><td>ERP_REMOVEVERT</td></tr>
	/// <tr><td>ACT_IX_SETVERT                   </td><td>ERP_SETVERT   </td></tr>
	/// <tr><td>ACT_IX_RESETVERT               </td><td>ERP_RESETVERT </td></tr>
	/// <tr><td>ACT_DM_READDOC                </td><td>ERP_DM_READDOC </td></tr>
	/// </table>
	/// </remarks>
	public class ReportInfoC : EloixClient.IndexServer.ReportC, BSerializable
	{
	
		#region Constructors
		
		public ReportInfoC() {
		}		
		
		public ReportInfoC(ReportInfoC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		public const int ACT_CLIENT_NONE = 0;

		/// <summary>
		/// Login.
		/// </summary>
		public const int ACT_CLIENT_ELOSTART = 1;

		/// <summary>
		/// Logout.
		/// </summary>
		public const int ACT_CLIENT_ELOEND = 2;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_COMPLAIN = 3;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_DELETEDOCS = 4;

		/// <summary>
		/// Used to report a write access session.
		/// </summary>
		public const int ACT_ISWRITESESSION = 5;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_KEYCHANGED = 10;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_USERCHANGED = 11;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_COLORCHANGED = 12;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_PATHCHANGED = 13;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_MASKCHANGED = 14;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_REPORTCHANGED = 15;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_PWDCHANGED = 16;

		/// <summary>
		/// Used to report search completed
		/// </summary>
		public const int ACT_CLIENT_SEARCH = 17;

		/// <summary>
		/// Create a new document entry (for indexing information) in the archive database.
		/// </summary>
		/// <remarks>
		/// ReportInfo.text contains the document name (short description).
		/// </remarks>
		public const int ACT_CLIENT_CREATEDOC = 100;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_CHANGEDOC = 101;

		/// <summary>
		/// Write the indexing information of a document.
		/// </summary>
		public const int ACT_CLIENT_EDITDOC = 102;

		/// <summary>
		/// Read the indexing information of a document.
		/// </summary>
		public const int ACT_CLIENT_VIEWDOC = 103;

		/// <summary>
		/// Delete/undelete document.
		/// </summary>
		/// <remarks>
		/// <table border="2">
		/// <tr><td>ReportInfo.extra1</td><td>parent ID.</td></tr>
		/// <tr><td>ReportInfo.extra2</td><td>0 if deleted, 1 if undeleted.</td></tr>
		/// <tr><td>ReportInfo.text</td><td>sord name.</td></tr>
		/// </table>
		/// </remarks>
		public const int ACT_CLIENT_ERASEDOC = 104;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_MOVEDOC = 105;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_REFDOC = 106;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_CHANGEKEY = 107;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_CHANGEKIND = 108;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_CHANGEATTACH = 109;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_CONVERT_FORMAT = 110;

		/// <summary>
		/// Get document file for editing.
		/// </summary>
		/// <remarks>
		/// This report information is written,
		/// if IXServicePortIF.checkoutDoc is called with lock.
		/// </remarks>
		public const int ACT_CLIENT_CHECKOUT = 111;

		/// <summary>
		/// Checkin a new document file.
		/// </summary>
		/// <remarks>
		/// ReportInfo.extra1 ist set to the new document ID
		/// </remarks>
		public const int ACT_CLIENT_CHECKIN = 112;

		/// <summary>
		/// Get document file to display (not to edit).
		/// </summary>
		/// <remarks>
		/// This report information is written,
		/// if IXServicePortIF.checkoutDoc is called without lock.
		/// </remarks>
		public const int ACT_CLIENT_SHOWDOC = 113;

		public const int ACT_CLIENT_DELVERSION = 114;

		/// <summary>
		/// Create new Sord object
		/// </summary>
		public const int ACT_CLIENT_CREATESOR = 150;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_CHANGESOR = 151;

		/// <summary>
		/// Edited new Sord object
		/// </summary>
		public const int ACT_CLIENT_EDITSOR = 152;

		/// <summary>
		/// Checkout Sord object without lock
		/// </summary>
		public const int ACT_CLIENT_VIEWSOR = 153;

		/// <summary>
		/// Delete/undelete document.
		/// </summary>
		/// <remarks>
		/// <table border="2">
		/// <tr><td>ReportInfo.extra1</td><td>parent ID.</td></tr>
		/// <tr><td>ReportInfo.extra2</td><td>0 if deleted, 1 if undeleted.</td></tr>
		/// <tr><td>ReportInfo.text</td><td>sord name.</td></tr>
		/// </table>
		/// </remarks>
		public const int ACT_CLIENT_ERASESOR = 154;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_MOVESOR = 155;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_REFSOR = 156;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_SHOWSOR = 157;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_ADDREF = 200;

		/// <summary>
		/// Delete/undelete document.
		/// </summary>
		/// <remarks>
		/// <table border="2">
		/// <tr><td>ReportInfo.extra1</td><td>parent ID.</td></tr>
		/// <tr><td>ReportInfo.extra2</td><td>0 if deleted, 1 if undeleted.</td></tr>
		/// </table>
		/// </remarks>
		public const int ACT_CLIENT_ERASEREF = 201;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_MOVEREF = 202;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_WVFIRST = 220;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_WVNEW = 220;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_WVCHANGE = 221;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_WVDELETE = 222;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_WVSEND = 223;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_WVRECEIVE = 224;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_WVNEWSEND = 225;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_WVCHANGESEND = 226;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_WVLAST = 239;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_POSTFIRST = 240;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_POSTDELETE = 241;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_POSTDOCBUILD = 242;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_POSTEDIT = 243;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_POSTSCHLAGWORT = 244;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_POSTCOPYTO = 245;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_POSTMOVETO = 246;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_POSTMOVE = 247;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_POSTCOLLECT = 248;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_POSTNEWOLE = 249;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_POSTEXPAND = 250;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_POSTIMPORT = 251;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_POSTRECEIVE = 252;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_POSTLAST = 259;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_CREATEFLOWTEMPL = 300;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_EDITFLOWTEMPL = 301;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_DELFLOWTEMPL = 302;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_STARTFLOW = 303;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_RECEIVEFLOW = 304;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_FORWARDFLOW = 305;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_EDITFLOWACTIVE = 306;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_DELFLOWACTIVE = 307;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_FLOWTIMELIMIT = 308;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_FLOWERRORYESNO = 309;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_MASKTEXTTOOLONG = 351;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_NEWVERT = 370;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_DELVERT = 371;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_FREEVERT = 372;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_REMOVEVERT = 373;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_SETVERT = 374;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_RESETVERT = 375;

		/// <summary>
		/// unused
		/// </summary>
		public const int ACT_CLIENT_PICKPOST = 376;

		/// <summary>
		/// Delete note.
		/// </summary>
		public const int ACT_CLIENT_DELETENOTE = 380;

		/// <summary>
		/// Create note.
		/// </summary>
		public const int ACT_CLIENT_CREATENOTE = 381;

		/// <summary>
		/// Overwrite note.
		/// </summary>
		public const int ACT_CLIENT_EDITNOTE = 382;

		/// <summary>
		/// Read document file from DM.
		/// </summary>
		public const int ACT_DM_READDOC = 2000;

		/// <summary>
		/// IndexServer specific report codes are higher than ACT_IX_FIRST
		/// </summary>
		public const int ACT_IX_FIRST = 500;

		public const int ACT_IX_LAST = 1000;

		public const int ACT_IX_LOGIN = 501;

		public const int ACT_IX_LOGOUT = 502;

		/// <summary>
		/// Reporteintrag fÃ¼r Mini-App-Login.
		/// </summary>
		/// <remarks>
		/// RID11587
		/// </remarks>
		public const int ACT_IX_MINI_APP_LOGIN = 503;

		public const int ACT_IX_LOCK_ARCHIVE = 511;

		public const int ACT_IX_CREATE_USER = 520;

		public const int ACT_IX_CHECKIN_USER = 521;

		public const int ACT_IX_DELETE_USER = 522;

		public const int ACT_IX_CREATE_KEY = 530;

		public const int ACT_IX_CHECKIN_KEY = 531;

		public const int ACT_IX_DELETE_KEY = 532;

		public const int ACT_IX_CREATE_SORD = 540;

		public const int ACT_IX_CHECKOUT_SORD = 541;

		public const int ACT_IX_CHECKIN_SORD = 542;

		public const int ACT_IX_DELETE_SORD = 543;

		public const int ACT_IX_DELETE_REFERENCE = 544;

		public const int ACT_IX_CHANGE_ACL = 545;

		public const int ACT_IX_CHANGE_RS = 546;

		public const int ACT_IX_CREATE_DOCUMENT = 547;

		public const int ACT_IX_CHANGE_DELDATE = 548;

		public const int ACT_IX_COPY_SORD = 551;

		public const int ACT_IX_REFERENCE_SORD = 552;

		public const int ACT_IX_MOVE_SORD = 553;

		public const int ACT_IX_LINK_SORD = 555;

		public const int ACT_IX_UNLINK_SORD = 556;

		public const int ACT_IX_CHECKOUT_DOCVERSION = 561;

		public const int ACT_IX_CHECKIN_DOCVERSION = 562;

		public const int ACT_IX_CREATE_DOC_MASK = 570;

		public const int ACT_IX_CHECKIN_DOC_MASK = 571;

		public const int ACT_IX_DELETE_DOC_MASK = 572;

		public const int ACT_IX_CHECKIN_REPL_NAME = 581;

		public const int ACT_IX_CHECKIN_REPORT_OPTIONS = 591;

		public const int ACT_IX_DELETE_REPORT = 592;

		public const int ACT_IX_CHECKIN_COLOR = 601;

		public const int ACT_IX_CHECKIN_USER_PROFILE = 611;

		public const int ACT_IX_DELETE_USER_PROFILE = 612;

		public const int ACT_IX_CREATE_WORKFLOW = 620;

		public const int ACT_IX_CHECKIN_WORKFLOW = 622;

		public const int ACT_IX_DELETE_WORKFLOW = 623;

		public const int ACT_IX_EDIT_WORKFLOW_NODE = 624;

		public const int ACT_IX_START_WORKFLOW = 625;

		public const int ACT_IX_START_ADHOC_WORKFLOW = 626;

		public const int ACT_IX_TERMINATE_WORKFLOW = 627;

		public const int ACT_IX_TAKE_WORKFLOW_NODE = 628;

		public const int ACT_IX_DELEGATE_WORKFLOW = 629;

		public const int ACT_IX_CHECKIN_CONFIG_FILE = 651;

		public const int ACT_IX_DELETE_CONFIG_FILE = 652;

		public const int ACT_IX_CHECKIN_COUNTER = 701;

		public const int ACT_IX_DELETE_COUNTER = 702;

		public const int ACT_IX_INCREMENT_COUNTER = 703;

		public const int ACT_IX_CHECKIN_SORD_TYPE = 711;

		public const int ACT_IX_DELETE_SORD_TYPE = 712;

		public const int ACT_IX_CREATE_NOTE = 720;

		public const int ACT_IX_CHECKIN_NOTE = 721;

		public const int ACT_IX_CHECKOUT_NOTE = 722;

		public const int ACT_IX_DELETE_NOTE = 723;

		public const int ACT_IX_NEWVERT = 724;

		public const int ACT_IX_DELVERT = 725;

		public const int ACT_IX_FREEVERT = 726;

		public const int ACT_IX_REMOVEVERT = 727;

		public const int ACT_IX_SETVERT = 728;

		public const int ACT_IX_RESETVERT = 729;

		/// <summary>
		/// Custom client specific report codes are higher than ACT_CUSTOM_FIRST
		/// </summary>
		public const int ACT_CUSTOM_FIRST = 3000;

		/// <summary>
		/// Custom client specific report codes are lower than ACT_CUSTOM_LAST
		/// </summary>
		public const int ACT_CUSTOM_LAST = 4000;

		public const int EXTRA2_LOCK = 1;

		public const int EXTRA2_FORCE = 2;

		public const int EXTRA2_DOCVERSION = 4;

		public const int EXTRA2_ATTACHMENT = 8;

		public const int EXTRA2_SIGNATURE = 16;

		public const int EXTRA2_PREVIEW = 32;

		public const int EXTRA2_FINALLY = 64;

		public const int EXTRA2_WF_ACTIVE = 128;

		public const int EXTRA2_WF_TEMPLATE = 256;

		public const int EXTRA2_WF_FINISHED = 512;

		public const int EXTRA2_WF_TERMINATE = 1024;

		public const int EXTRA2_WF_CANCEL = 2048;

		public const int EXTRA2_NOTE_NORMAL = 4096;

		public const int EXTRA2_NOTE_PERSONAL = 8192;

		public const int EXTRA2_NOTE_STAMP = 16384;

		public const int EXTRA2_SSO_LOGIN = 32768;

		public const int EXTRA2_ANNOTATION_MARKER = 65536;

		public const int EXTRA2_ANNOTATION_NOTE = 131072;

		public const int EXTRA2_REPORT_AS_LOGIN = 262144;

		/// <summary>
		/// Extra2 value used when all notes of a Sord are read.
		/// </summary>
		public const int EXTRA2_ALL_NOTES_OF_SORD = 225280;

		public const int EXTRA2_INDEXSEARCH = 1;

		public const long mbAction = 2L;

		public const long mbComment = 2L;

		public const long mbActTimeISO = 8L;

		public const long mbUserName = 4L;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1071192839L;		
	} // end class
}  // end namespace
