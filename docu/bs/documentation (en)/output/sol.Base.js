Ext.data.JsonP.sol_Base({"tagname":"class","name":"sol.Base","autodetected":{"aliases":true,"alternateClassNames":true,"mixins":true,"requires":true,"uses":true,"members":true,"code_type":true},"files":[{"filename":"lib_Class.js","href":"lib_Class.html#sol-Base"}],"extends":null,"author":[{"tagname":"author","name":"Pascal Zipfel, ELO Digital Office GmbH","email":null}],"version":["1.0"],"eloall":true,"aliases":{},"alternateClassNames":[],"mixins":[],"requires":[],"uses":[],"members":[{"name":"requiredConfig","tagname":"cfg","owner":"sol.Base","id":"cfg-requiredConfig","meta":{"protected":true}},{"name":"$className","tagname":"property","owner":"sol.Base","id":"property-S-className","meta":{"protected":true}},{"name":"logger","tagname":"property","owner":"sol.Base","id":"property-logger","meta":{"protected":true}},{"name":"$super","tagname":"method","owner":"sol.Base","id":"method-S-super","meta":{"private":true}},{"name":"initialize","tagname":"method","owner":"sol.Base","id":"method-initialize","meta":{"private":true}}],"code_type":"ext_define","id":"class-sol.Base","short_doc":"The Base class implements basic operations that are might be required by all child classes. ...","classIcon":"icon-class","superclasses":[],"subclasses":["sol.Logger","sol.common.AclUtils","sol.common.ActionBase","sol.common.AsUtils","sol.common.AsyncUtils","sol.common.Cache","sol.common.Config","sol.common.ConfigCache","sol.common.ConfigMixin","sol.common.CounterUtils","sol.common.DateUtils","sol.common.DecimalUtils","sol.common.ExceptionUtils","sol.common.ExecUtils","sol.common.FileUtils","sol.common.HttpUtils","sol.common.IxUtils","sol.common.JsonUtils","sol.common.Locale","sol.common.Map","sol.common.MapTable","sol.common.ObjectFormatter","sol.common.ObjectFormatter.BaseSord","sol.common.ObjectFormatter.BaseTask","sol.common.ObjectFormatter.BaseWfDiagramNode","sol.common.ObjectUtils","sol.common.RepoUtils","sol.common.Roles","sol.common.SordTypeUtils","sol.common.SordUtils","sol.common.StringUtils","sol.common.Template","sol.common.TemplateUtils","sol.common.TranslateTerms","sol.common.UserProfile","sol.common.UserProfileUtils","sol.common.UserUtils","sol.common.WfUtils","sol.common.XmlBuilder","sol.common.XmlUtils","sol.common.ZipUtils","sol.common.as.BarcodeUtils","sol.common.as.DocumentGenerator","sol.common.as.FunctionBase","sol.common.as.Mail","sol.common.as.PdfUtils","sol.common.as.Utils","sol.common.as.WfController","sol.common.as.renderer.Excel","sol.common.as.renderer.Fop","sol.common.as.renderer.Word","sol.common.forms.FileChooserVariants","sol.common.forms.Utils","sol.common.forms.Webcam","sol.common.ix.DynAdHocFlowUtils","sol.common.ix.DynKwlDatabaseIterator","sol.common.ix.DynKwlMixin","sol.common.ix.DynKwlSearchIterator","sol.common.ix.DynKwlUserNameIterator","sol.common.ix.DynKwlUtils","sol.common.ix.FunctionBase","sol.common.ix.GenericDynKwl","sol.common.ix.LocalizedKwlIterator","sol.common.ix.RfUtils","sol.common.ix.ServiceBase","sol.common.ix.SqlConnection","sol.common.ix.SubscriptionUtils","sol.common.ix.services.GetTemplates.Provider","sol.common.ix.services.KwlDataCollector.BaseDynKwl","sol.common.ix.services.KwlDataCollector.BaseKwl","sol.common.jc.ActionDefinitionUtils","sol.common.jc.ActionHandler","sol.common.jc.ActionHandler.Action","sol.common.jc.ActionHandler.Dialog","sol.common.jc.ActionHandler.Error","sol.common.jc.ActionHandler.EventChain","sol.common.jc.ActionHandler.Feedback","sol.common.jc.ActionHandler.Goto","sol.common.jc.ActionHandler.Refresh","sol.common.jc.ActionHelper","sol.common.jc.ClipboardUtils","sol.common.jc.CommonDialogs","sol.common.jc.WebcamUtils","sol.common.web.ActionDefinitionUtils","sol.common.web.ActionHandler","sol.common.web.ActionHelper","sol.common.web.ApiUtils","sol.common.web.BarcodeHandler","sol.common.web.BarcodeRegistry","sol.common_fx.ix.FxUtils","sol.common_monitoring.as.Monitor","sol.common_monitoring.as.MonitorUtils","sol.common_monitoring.as.analyzers.RetentionAnalyzer","sol.common_monitoring.as.analyzers.RuleAnalyzer","sol.common_monitoring.as.analyzers.ValueAnalyzer","sol.common_monitoring.as.collectors.ChildrenCollector","sol.common_monitoring.as.collectors.NextRunCollector","sol.common_monitoring.as.executors.SimpleExecutor","sol.common_monitoring.ix.MonitorUtils","sol.common_sig.forms.Signature","sol.connector_xml.Converter","sol.connector_xml.Converter.DateConverter","sol.connector_xml.Converter.DefaultConverter","sol.connector_xml.Converter.DynamicKwlLookup","sol.connector_xml.Converter.SetIfEmpty","sol.connector_xml.DocumentImporter","sol.connector_xml.Importer","sol.connector_xml.Utils","sol.dev.BuildPackage","sol.dev.BuildPackages","sol.dev.install.LoggerBase","sol.dev.install.MultiProperties","sol.dev.ix.ActionUtils","sol.dev.jc.BuildPackages","sol.dev.jc.CompareDocVersions","sol.dev.jc.Deploy","sol.dev.jc.DownloadBranches","sol.dev.jc.ExecuteRf","sol.dev.jc.GotoId","sol.dev.jc.Versions"],"mixedInto":[],"parentMixins":[],"html":"<div><pre class=\"hierarchy\"><h4>Subclasses</h4><div class='dependency'><a href='#!/api/sol.Logger' rel='sol.Logger' class='docClass'>sol.Logger</a></div><div class='dependency'><a href='#!/api/sol.common.AclUtils' rel='sol.common.AclUtils' class='docClass'>sol.common.AclUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ActionBase' rel='sol.common.ActionBase' class='docClass'>sol.common.ActionBase</a></div><div class='dependency'><a href='#!/api/sol.common.AsUtils' rel='sol.common.AsUtils' class='docClass'>sol.common.AsUtils</a></div><div class='dependency'><a href='#!/api/sol.common.AsyncUtils' rel='sol.common.AsyncUtils' class='docClass'>sol.common.AsyncUtils</a></div><div class='dependency'><a href='#!/api/sol.common.Cache' rel='sol.common.Cache' class='docClass'>sol.common.Cache</a></div><div class='dependency'><a href='#!/api/sol.common.Config' rel='sol.common.Config' class='docClass'>sol.common.Config</a></div><div class='dependency'><a href='#!/api/sol.common.ConfigCache' rel='sol.common.ConfigCache' class='docClass'>sol.common.ConfigCache</a></div><div class='dependency'><a href='#!/api/sol.common.ConfigMixin' rel='sol.common.ConfigMixin' class='docClass'>sol.common.ConfigMixin</a></div><div class='dependency'><a href='#!/api/sol.common.CounterUtils' rel='sol.common.CounterUtils' class='docClass'>sol.common.CounterUtils</a></div><div class='dependency'><a href='#!/api/sol.common.DateUtils' rel='sol.common.DateUtils' class='docClass'>sol.common.DateUtils</a></div><div class='dependency'><a href='#!/api/sol.common.DecimalUtils' rel='sol.common.DecimalUtils' class='docClass'>sol.common.DecimalUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ExceptionUtils' rel='sol.common.ExceptionUtils' class='docClass'>sol.common.ExceptionUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ExecUtils' rel='sol.common.ExecUtils' class='docClass'>sol.common.ExecUtils</a></div><div class='dependency'><a href='#!/api/sol.common.FileUtils' rel='sol.common.FileUtils' class='docClass'>sol.common.FileUtils</a></div><div class='dependency'><a href='#!/api/sol.common.HttpUtils' rel='sol.common.HttpUtils' class='docClass'>sol.common.HttpUtils</a></div><div class='dependency'><a href='#!/api/sol.common.IxUtils' rel='sol.common.IxUtils' class='docClass'>sol.common.IxUtils</a></div><div class='dependency'><a href='#!/api/sol.common.JsonUtils' rel='sol.common.JsonUtils' class='docClass'>sol.common.JsonUtils</a></div><div class='dependency'><a href='#!/api/sol.common.Locale' rel='sol.common.Locale' class='docClass'>sol.common.Locale</a></div><div class='dependency'><a href='#!/api/sol.common.Map' rel='sol.common.Map' class='docClass'>sol.common.Map</a></div><div class='dependency'><a href='#!/api/sol.common.MapTable' rel='sol.common.MapTable' class='docClass'>sol.common.MapTable</a></div><div class='dependency'><a href='#!/api/sol.common.ObjectFormatter' rel='sol.common.ObjectFormatter' class='docClass'>sol.common.ObjectFormatter</a></div><div class='dependency'><a href='#!/api/sol.common.ObjectFormatter.BaseSord' rel='sol.common.ObjectFormatter.BaseSord' class='docClass'>sol.common.ObjectFormatter.BaseSord</a></div><div class='dependency'><a href='#!/api/sol.common.ObjectFormatter.BaseTask' rel='sol.common.ObjectFormatter.BaseTask' class='docClass'>sol.common.ObjectFormatter.BaseTask</a></div><div class='dependency'><a href='#!/api/sol.common.ObjectFormatter.BaseWfDiagramNode' rel='sol.common.ObjectFormatter.BaseWfDiagramNode' class='docClass'>sol.common.ObjectFormatter.BaseWfDiagramNode</a></div><div class='dependency'><a href='#!/api/sol.common.ObjectUtils' rel='sol.common.ObjectUtils' class='docClass'>sol.common.ObjectUtils</a></div><div class='dependency'><a href='#!/api/sol.common.RepoUtils' rel='sol.common.RepoUtils' class='docClass'>sol.common.RepoUtils</a></div><div class='dependency'><a href='#!/api/sol.common.Roles' rel='sol.common.Roles' class='docClass'>sol.common.Roles</a></div><div class='dependency'><a href='#!/api/sol.common.SordTypeUtils' rel='sol.common.SordTypeUtils' class='docClass'>sol.common.SordTypeUtils</a></div><div class='dependency'><a href='#!/api/sol.common.SordUtils' rel='sol.common.SordUtils' class='docClass'>sol.common.SordUtils</a></div><div class='dependency'><a href='#!/api/sol.common.StringUtils' rel='sol.common.StringUtils' class='docClass'>sol.common.StringUtils</a></div><div class='dependency'><a href='#!/api/sol.common.Template' rel='sol.common.Template' class='docClass'>sol.common.Template</a></div><div class='dependency'><a href='#!/api/sol.common.TemplateUtils' rel='sol.common.TemplateUtils' class='docClass'>sol.common.TemplateUtils</a></div><div class='dependency'><a href='#!/api/sol.common.TranslateTerms' rel='sol.common.TranslateTerms' class='docClass'>sol.common.TranslateTerms</a></div><div class='dependency'><a href='#!/api/sol.common.UserProfile' rel='sol.common.UserProfile' class='docClass'>sol.common.UserProfile</a></div><div class='dependency'><a href='#!/api/sol.common.UserProfileUtils' rel='sol.common.UserProfileUtils' class='docClass'>sol.common.UserProfileUtils</a></div><div class='dependency'><a href='#!/api/sol.common.UserUtils' rel='sol.common.UserUtils' class='docClass'>sol.common.UserUtils</a></div><div class='dependency'><a href='#!/api/sol.common.WfUtils' rel='sol.common.WfUtils' class='docClass'>sol.common.WfUtils</a></div><div class='dependency'><a href='#!/api/sol.common.XmlBuilder' rel='sol.common.XmlBuilder' class='docClass'>sol.common.XmlBuilder</a></div><div class='dependency'><a href='#!/api/sol.common.XmlUtils' rel='sol.common.XmlUtils' class='docClass'>sol.common.XmlUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ZipUtils' rel='sol.common.ZipUtils' class='docClass'>sol.common.ZipUtils</a></div><div class='dependency'><a href='#!/api/sol.common.as.BarcodeUtils' rel='sol.common.as.BarcodeUtils' class='docClass'>sol.common.as.BarcodeUtils</a></div><div class='dependency'><a href='#!/api/sol.common.as.DocumentGenerator' rel='sol.common.as.DocumentGenerator' class='docClass'>sol.common.as.DocumentGenerator</a></div><div class='dependency'><a href='#!/api/sol.common.as.FunctionBase' rel='sol.common.as.FunctionBase' class='docClass'>sol.common.as.FunctionBase</a></div><div class='dependency'><a href='#!/api/sol.common.as.Mail' rel='sol.common.as.Mail' class='docClass'>sol.common.as.Mail</a></div><div class='dependency'><a href='#!/api/sol.common.as.PdfUtils' rel='sol.common.as.PdfUtils' class='docClass'>sol.common.as.PdfUtils</a></div><div class='dependency'><a href='#!/api/sol.common.as.Utils' rel='sol.common.as.Utils' class='docClass'>sol.common.as.Utils</a></div><div class='dependency'><a href='#!/api/sol.common.as.WfController' rel='sol.common.as.WfController' class='docClass'>sol.common.as.WfController</a></div><div class='dependency'><a href='#!/api/sol.common.as.renderer.Excel' rel='sol.common.as.renderer.Excel' class='docClass'>sol.common.as.renderer.Excel</a></div><div class='dependency'><a href='#!/api/sol.common.as.renderer.Fop' rel='sol.common.as.renderer.Fop' class='docClass'>sol.common.as.renderer.Fop</a></div><div class='dependency'><a href='#!/api/sol.common.as.renderer.Word' rel='sol.common.as.renderer.Word' class='docClass'>sol.common.as.renderer.Word</a></div><div class='dependency'><a href='#!/api/sol.common.forms.FileChooserVariants' rel='sol.common.forms.FileChooserVariants' class='docClass'>sol.common.forms.FileChooserVariants</a></div><div class='dependency'><a href='#!/api/sol.common.forms.Utils' rel='sol.common.forms.Utils' class='docClass'>sol.common.forms.Utils</a></div><div class='dependency'><a href='#!/api/sol.common.forms.Webcam' rel='sol.common.forms.Webcam' class='docClass'>sol.common.forms.Webcam</a></div><div class='dependency'><a href='#!/api/sol.common.ix.DynAdHocFlowUtils' rel='sol.common.ix.DynAdHocFlowUtils' class='docClass'>sol.common.ix.DynAdHocFlowUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ix.DynKwlDatabaseIterator' rel='sol.common.ix.DynKwlDatabaseIterator' class='docClass'>sol.common.ix.DynKwlDatabaseIterator</a></div><div class='dependency'><a href='#!/api/sol.common.ix.DynKwlMixin' rel='sol.common.ix.DynKwlMixin' class='docClass'>sol.common.ix.DynKwlMixin</a></div><div class='dependency'><a href='#!/api/sol.common.ix.DynKwlSearchIterator' rel='sol.common.ix.DynKwlSearchIterator' class='docClass'>sol.common.ix.DynKwlSearchIterator</a></div><div class='dependency'><a href='#!/api/sol.common.ix.DynKwlUserNameIterator' rel='sol.common.ix.DynKwlUserNameIterator' class='docClass'>sol.common.ix.DynKwlUserNameIterator</a></div><div class='dependency'><a href='#!/api/sol.common.ix.DynKwlUtils' rel='sol.common.ix.DynKwlUtils' class='docClass'>sol.common.ix.DynKwlUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ix.FunctionBase' rel='sol.common.ix.FunctionBase' class='docClass'>sol.common.ix.FunctionBase</a></div><div class='dependency'><a href='#!/api/sol.common.ix.GenericDynKwl' rel='sol.common.ix.GenericDynKwl' class='docClass'>sol.common.ix.GenericDynKwl</a></div><div class='dependency'><a href='#!/api/sol.common.ix.LocalizedKwlIterator' rel='sol.common.ix.LocalizedKwlIterator' class='docClass'>sol.common.ix.LocalizedKwlIterator</a></div><div class='dependency'><a href='#!/api/sol.common.ix.RfUtils' rel='sol.common.ix.RfUtils' class='docClass'>sol.common.ix.RfUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ix.ServiceBase' rel='sol.common.ix.ServiceBase' class='docClass'>sol.common.ix.ServiceBase</a></div><div class='dependency'><a href='#!/api/sol.common.ix.SqlConnection' rel='sol.common.ix.SqlConnection' class='docClass'>sol.common.ix.SqlConnection</a></div><div class='dependency'><a href='#!/api/sol.common.ix.SubscriptionUtils' rel='sol.common.ix.SubscriptionUtils' class='docClass'>sol.common.ix.SubscriptionUtils</a></div><div class='dependency'><a href='#!/api/sol.common.ix.services.GetTemplates.Provider' rel='sol.common.ix.services.GetTemplates.Provider' class='docClass'>sol.common.ix.services.GetTemplates.Provider</a></div><div class='dependency'><a href='#!/api/sol.common.ix.services.KwlDataCollector.BaseDynKwl' rel='sol.common.ix.services.KwlDataCollector.BaseDynKwl' class='docClass'>sol.common.ix.services.KwlDataCollector.BaseDynKwl</a></div><div class='dependency'><a href='#!/api/sol.common.ix.services.KwlDataCollector.BaseKwl' rel='sol.common.ix.services.KwlDataCollector.BaseKwl' class='docClass'>sol.common.ix.services.KwlDataCollector.BaseKwl</a></div><div class='dependency'><a href='#!/api/sol.common.jc.ActionDefinitionUtils' rel='sol.common.jc.ActionDefinitionUtils' class='docClass'>sol.common.jc.ActionDefinitionUtils</a></div><div class='dependency'><a href='#!/api/sol.common.jc.ActionHandler' rel='sol.common.jc.ActionHandler' class='docClass'>sol.common.jc.ActionHandler</a></div><div class='dependency'><a href='#!/api/sol.common.jc.ActionHandler.Action' rel='sol.common.jc.ActionHandler.Action' class='docClass'>sol.common.jc.ActionHandler.Action</a></div><div class='dependency'><a href='#!/api/sol.common.jc.ActionHandler.Dialog' rel='sol.common.jc.ActionHandler.Dialog' class='docClass'>sol.common.jc.ActionHandler.Dialog</a></div><div class='dependency'><a href='#!/api/sol.common.jc.ActionHandler.Error' rel='sol.common.jc.ActionHandler.Error' class='docClass'>sol.common.jc.ActionHandler.Error</a></div><div class='dependency'><a href='#!/api/sol.common.jc.ActionHandler.EventChain' rel='sol.common.jc.ActionHandler.EventChain' class='docClass'>sol.common.jc.ActionHandler.EventChain</a></div><div class='dependency'><a href='#!/api/sol.common.jc.ActionHandler.Feedback' rel='sol.common.jc.ActionHandler.Feedback' class='docClass'>sol.common.jc.ActionHandler.Feedback</a></div><div class='dependency'><a href='#!/api/sol.common.jc.ActionHandler.Goto' rel='sol.common.jc.ActionHandler.Goto' class='docClass'>sol.common.jc.ActionHandler.Goto</a></div><div class='dependency'><a href='#!/api/sol.common.jc.ActionHandler.Refresh' rel='sol.common.jc.ActionHandler.Refresh' class='docClass'>sol.common.jc.ActionHandler.Refresh</a></div><div class='dependency'><a href='#!/api/sol.common.jc.ActionHelper' rel='sol.common.jc.ActionHelper' class='docClass'>sol.common.jc.ActionHelper</a></div><div class='dependency'><a href='#!/api/sol.common.jc.ClipboardUtils' rel='sol.common.jc.ClipboardUtils' class='docClass'>sol.common.jc.ClipboardUtils</a></div><div class='dependency'><a href='#!/api/sol.common.jc.CommonDialogs' rel='sol.common.jc.CommonDialogs' class='docClass'>sol.common.jc.CommonDialogs</a></div><div class='dependency'><a href='#!/api/sol.common.jc.WebcamUtils' rel='sol.common.jc.WebcamUtils' class='docClass'>sol.common.jc.WebcamUtils</a></div><div class='dependency'><a href='#!/api/sol.common.web.ActionDefinitionUtils' rel='sol.common.web.ActionDefinitionUtils' class='docClass'>sol.common.web.ActionDefinitionUtils</a></div><div class='dependency'><a href='#!/api/sol.common.web.ActionHandler' rel='sol.common.web.ActionHandler' class='docClass'>sol.common.web.ActionHandler</a></div><div class='dependency'><a href='#!/api/sol.common.web.ActionHelper' rel='sol.common.web.ActionHelper' class='docClass'>sol.common.web.ActionHelper</a></div><div class='dependency'><a href='#!/api/sol.common.web.ApiUtils' rel='sol.common.web.ApiUtils' class='docClass'>sol.common.web.ApiUtils</a></div><div class='dependency'><a href='#!/api/sol.common.web.BarcodeHandler' rel='sol.common.web.BarcodeHandler' class='docClass'>sol.common.web.BarcodeHandler</a></div><div class='dependency'><a href='#!/api/sol.common.web.BarcodeRegistry' rel='sol.common.web.BarcodeRegistry' class='docClass'>sol.common.web.BarcodeRegistry</a></div><div class='dependency'><a href='#!/api/sol.common_fx.ix.FxUtils' rel='sol.common_fx.ix.FxUtils' class='docClass'>sol.common_fx.ix.FxUtils</a></div><div class='dependency'><a href='#!/api/sol.common_monitoring.as.Monitor' rel='sol.common_monitoring.as.Monitor' class='docClass'>sol.common_monitoring.as.Monitor</a></div><div class='dependency'><a href='#!/api/sol.common_monitoring.as.MonitorUtils' rel='sol.common_monitoring.as.MonitorUtils' class='docClass'>sol.common_monitoring.as.MonitorUtils</a></div><div class='dependency'><a href='#!/api/sol.common_monitoring.as.analyzers.RetentionAnalyzer' rel='sol.common_monitoring.as.analyzers.RetentionAnalyzer' class='docClass'>sol.common_monitoring.as.analyzers.RetentionAnalyzer</a></div><div class='dependency'><a href='#!/api/sol.common_monitoring.as.analyzers.RuleAnalyzer' rel='sol.common_monitoring.as.analyzers.RuleAnalyzer' class='docClass'>sol.common_monitoring.as.analyzers.RuleAnalyzer</a></div><div class='dependency'><a href='#!/api/sol.common_monitoring.as.analyzers.ValueAnalyzer' rel='sol.common_monitoring.as.analyzers.ValueAnalyzer' class='docClass'>sol.common_monitoring.as.analyzers.ValueAnalyzer</a></div><div class='dependency'><a href='#!/api/sol.common_monitoring.as.collectors.ChildrenCollector' rel='sol.common_monitoring.as.collectors.ChildrenCollector' class='docClass'>sol.common_monitoring.as.collectors.ChildrenCollector</a></div><div class='dependency'><a href='#!/api/sol.common_monitoring.as.collectors.NextRunCollector' rel='sol.common_monitoring.as.collectors.NextRunCollector' class='docClass'>sol.common_monitoring.as.collectors.NextRunCollector</a></div><div class='dependency'><a href='#!/api/sol.common_monitoring.as.executors.SimpleExecutor' rel='sol.common_monitoring.as.executors.SimpleExecutor' class='docClass'>sol.common_monitoring.as.executors.SimpleExecutor</a></div><div class='dependency'><a href='#!/api/sol.common_monitoring.ix.MonitorUtils' rel='sol.common_monitoring.ix.MonitorUtils' class='docClass'>sol.common_monitoring.ix.MonitorUtils</a></div><div class='dependency'><a href='#!/api/sol.common_sig.forms.Signature' rel='sol.common_sig.forms.Signature' class='docClass'>sol.common_sig.forms.Signature</a></div><div class='dependency'><a href='#!/api/sol.connector_xml.Converter' rel='sol.connector_xml.Converter' class='docClass'>sol.connector_xml.Converter</a></div><div class='dependency'><a href='#!/api/sol.connector_xml.Converter.DateConverter' rel='sol.connector_xml.Converter.DateConverter' class='docClass'>sol.connector_xml.Converter.DateConverter</a></div><div class='dependency'><a href='#!/api/sol.connector_xml.Converter.DefaultConverter' rel='sol.connector_xml.Converter.DefaultConverter' class='docClass'>sol.connector_xml.Converter.DefaultConverter</a></div><div class='dependency'><a href='#!/api/sol.connector_xml.Converter.DynamicKwlLookup' rel='sol.connector_xml.Converter.DynamicKwlLookup' class='docClass'>sol.connector_xml.Converter.DynamicKwlLookup</a></div><div class='dependency'><a href='#!/api/sol.connector_xml.Converter.SetIfEmpty' rel='sol.connector_xml.Converter.SetIfEmpty' class='docClass'>sol.connector_xml.Converter.SetIfEmpty</a></div><div class='dependency'><a href='#!/api/sol.connector_xml.DocumentImporter' rel='sol.connector_xml.DocumentImporter' class='docClass'>sol.connector_xml.DocumentImporter</a></div><div class='dependency'><a href='#!/api/sol.connector_xml.Importer' rel='sol.connector_xml.Importer' class='docClass'>sol.connector_xml.Importer</a></div><div class='dependency'><a href='#!/api/sol.connector_xml.Utils' rel='sol.connector_xml.Utils' class='docClass'>sol.connector_xml.Utils</a></div><div class='dependency'><a href='#!/api/sol.dev.BuildPackage' rel='sol.dev.BuildPackage' class='docClass'>sol.dev.BuildPackage</a></div><div class='dependency'><a href='#!/api/sol.dev.BuildPackages' rel='sol.dev.BuildPackages' class='docClass'>sol.dev.BuildPackages</a></div><div class='dependency'><a href='#!/api/sol.dev.install.LoggerBase' rel='sol.dev.install.LoggerBase' class='docClass'>sol.dev.install.LoggerBase</a></div><div class='dependency'><a href='#!/api/sol.dev.install.MultiProperties' rel='sol.dev.install.MultiProperties' class='docClass'>sol.dev.install.MultiProperties</a></div><div class='dependency'><a href='#!/api/sol.dev.ix.ActionUtils' rel='sol.dev.ix.ActionUtils' class='docClass'>sol.dev.ix.ActionUtils</a></div><div class='dependency'><a href='#!/api/sol.dev.jc.BuildPackages' rel='sol.dev.jc.BuildPackages' class='docClass'>sol.dev.jc.BuildPackages</a></div><div class='dependency'><a href='#!/api/sol.dev.jc.CompareDocVersions' rel='sol.dev.jc.CompareDocVersions' class='docClass'>sol.dev.jc.CompareDocVersions</a></div><div class='dependency'><a href='#!/api/sol.dev.jc.Deploy' rel='sol.dev.jc.Deploy' class='docClass'>sol.dev.jc.Deploy</a></div><div class='dependency'><a href='#!/api/sol.dev.jc.DownloadBranches' rel='sol.dev.jc.DownloadBranches' class='docClass'>sol.dev.jc.DownloadBranches</a></div><div class='dependency'><a href='#!/api/sol.dev.jc.ExecuteRf' rel='sol.dev.jc.ExecuteRf' class='docClass'>sol.dev.jc.ExecuteRf</a></div><div class='dependency'><a href='#!/api/sol.dev.jc.GotoId' rel='sol.dev.jc.GotoId' class='docClass'>sol.dev.jc.GotoId</a></div><div class='dependency'><a href='#!/api/sol.dev.jc.Versions' rel='sol.dev.jc.Versions' class='docClass'>sol.dev.jc.Versions</a></div><h4>Files</h4><div class='dependency'><a href='source/lib_Class.html#sol-Base' target='_blank'>lib_Class.js</a></div></pre><div class='doc-contents'><p>The Base class implements basic operations that are might be required by all child classes.</p>\n\n<p>It is always set as the root superclass for all class definitions if no inheritance was defined by 'extend'.</p>\n\n<pre><code>// the following class definition ...\n<a href=\"#!/api/sol-static-method-define\" rel=\"sol-static-method-define\" class=\"docClass\">sol.define</a>('sol.common.ix.DatabaseIterator', {  });\n<a href=\"#!/api/sol-static-method-define\" rel=\"sol-static-method-define\" class=\"docClass\">sol.define</a>('sol.invoice.ix.dynkwl.Company', {\n  extend: 'sol.common.ix.DatabaseIterator'\n}\n\n// ... will lead to following class inheritance structure\n<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\n  - sol.common.ix.DatabaseIterator\n     - sol.invoice.ix.dynkwl.Company\n</code></pre>\n\n<p>The initialize function of the Base Class handles a couple of operations and should always be called if a child class\noverrides initialize:</p>\n\n<ul>\n<li>instantiates logger for class with the current child's class name as scope config.</li>\n<li>applies all config properties to the class instance.</li>\n<li>checks if required config properties (defined by requiredConfig) are set</li>\n</ul>\n\n\n<h1>A note on config properties and class inheritance</h1>\n\n<p>Please mind that if config properties are different than class defaults that they get applied to the child class\nafter calling $super('<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>', 'initialize').</p>\n\n<pre><code><a href=\"#!/api/sol-static-method-define\" rel=\"sol-static-method-define\" class=\"docClass\">sol.define</a>('sol.invoice.ix.dynkwl.Company', {\n  extend: 'sol.common.ix.DatabaseIterator',\n\n  myConfig: 'not set yet',\n\n  initialize: function(config) {\n    var me = this;\n    // me.myConfig = \"not set yet\"\n    me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\n    // me.myConfig = \"is now set\"\n  }\n});\n\n<a href=\"#!/api/sol-static-method-create\" rel=\"sol-static-method-create\" class=\"docClass\">sol.create</a>('sol.invoice.ix.dynkwl.Company', {\n  myConfig: 'is now set'\n});\n</code></pre>\n      <p class='version-tag'>Version: <b>1.0</b></p>\n</div><div class='members'><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-cfg'>Config options</h3><div class='subsection'><div id='cfg-requiredConfig' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.Base'>sol.Base</span><br/><a href='source/lib_Class.html#sol-Base-cfg-requiredConfig' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-cfg-requiredConfig' class='name expandable'>requiredConfig</a> : Array<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>List of required config properties. ...</div><div class='long'><p>List of required config properties. <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a> throws an exception if one of the properties is null or undefined.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-property'>Properties</h3><div class='subsection'><div id='property-S-className' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.Base'>sol.Base</span><br/><a href='source/lib_Class.html#sol-Base-property-S-className' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-S-className' class='name expandable'>$className</a> : Object<span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'><p>{String}\nname of the class including its namespace.</p>\n</div><div class='long'><p>{String}\nname of the class including its namespace.</p>\n</div></div></div><div id='property-logger' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.Base'>sol.Base</span><br/><a href='source/lib_Class.html#sol-Base-property-logger' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-property-logger' class='name expandable'>logger</a> : <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a><span class=\"signature\"><span class='protected' >protected</span></span></div><div class='description'><div class='short'>Logger for this class instance. ...</div><div class='long'><p>Logger for this class instance. This logger is created by <a href=\"#!/api/sol.Base-method-initialize\" rel=\"sol.Base-method-initialize\" class=\"docClass\">sol.Base.initialize</a>.</p>\n\n<p>Please see <a href=\"#!/api/sol.Logger\" rel=\"sol.Logger\" class=\"docClass\">sol.Logger</a> class documentation for more information.</p>\n</div></div></div></div></div><div class='members-section'><div class='definedBy'>Defined By</div><h3 class='members-title icon-method'>Methods</h3><div class='subsection'><div id='method-S-super' class='member first-child not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.Base'>sol.Base</span><br/><a href='source/lib_Class.html#sol-Base-method-S-super' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-S-super' class='name expandable'>$super</a>( <span class='pre'>superClassName, functionName, arguments</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Calls a function of a superclass thanks to its name. ...</div><div class='long'><p>Calls a function of a superclass thanks to its name. Superclass must be part of the calling objects class hierarchy.</p>\n\n<p><b>Please note that calling superclass functions might lead to an infinitive loop if misused. Please validate that none class other than the classes superclass is passed as the superclass parent.</b></p>\n\n<pre><code>me.$super(superClassName, functionName, attributesArray);\n</code></pre>\n\n<p>A basic example of the initialize-function will look as followed.</p>\n\n<pre><code>me.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", [config]);\nme.$super(\"<a href=\"#!/api/sol.Base\" rel=\"sol.Base\" class=\"docClass\">sol.Base</a>\", \"initialize\", arguments);\n</code></pre>\n\n<p>A word on performance: The superclass name must be passed since the js rhino engine does not allow accessing the caller of the callee due to performance reasons.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>superClassName</span> : String<div class='sub-desc'><p>name of the super class.</p>\n</div></li><li><span class='pre'>functionName</span> : String<div class='sub-desc'><p>name of the function that should be called.</p>\n</div></li><li><span class='pre'>arguments</span> : Object[]<div class='sub-desc'><p>list of arguments that should be passed to the function.</p>\n</div></li></ul></div></div></div><div id='method-initialize' class='member  not-inherited'><a href='#' class='side expandable'><span>&nbsp;</span></a><div class='title'><div class='meta'><span class='defined-in' rel='sol.Base'>sol.Base</span><br/><a href='source/lib_Class.html#sol-Base-method-initialize' target='_blank' class='view-source'>view source</a></div><a href='#!/api/sol.Base-method-initialize' class='name expandable'>initialize</a>( <span class='pre'>config</span> )<span class=\"signature\"><span class='private' >private</span></span></div><div class='description'><div class='short'>Initialize class. ...</div><div class='long'><p>Initialize class.\nThis function is called after the class was instantiated.</p>\n<h3 class=\"pa\">Parameters</h3><ul><li><span class='pre'>config</span> : Object<div class='sub-desc'><p>parameters as defined. See documentation for more details.</p>\n</div></li></ul></div></div></div></div></div></div></div>","meta":{"eloall":true}});