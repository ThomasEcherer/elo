#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { namespace search { 

//-------------------------------------------------
// Implementation of class SearchIndexerConfig
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SearchIndexerConfig::SearchIndexerConfig() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::search::SearchIndexerConfig::SearchIndexerConfig(const PUpdaterConfig& updaterConfig, const POptimizerConfig& optimizerConfig, const PReindexerConfig& reindexerConfig, const PLanguageConfig& languageConfig)
	: updaterConfig(updaterConfig)
	, optimizerConfig(optimizerConfig)
	, reindexerConfig(reindexerConfig)
	, languageConfig(languageConfig)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::search::SearchIndexerConfig::BSerializable_getTypeId() {
	return 1425319615; 
}
void SearchIndexerConfig::setUpdaterConfig(PUpdaterConfig v) {
	updaterConfig = v;
}
void SearchIndexerConfig::setOptimizerConfig(POptimizerConfig v) {
	optimizerConfig = v;
}
void SearchIndexerConfig::setReindexerConfig(PReindexerConfig v) {
	reindexerConfig = v;
}
void SearchIndexerConfig::setLanguageConfig(PLanguageConfig v) {
	languageConfig = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SearchIndexerConfig::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->optimizerConfig;
	ar & this->reindexerConfig;
	ar & this->updaterConfig;
	if (version >= 1000000000000005) {
		ar & this->languageConfig;
	}
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1425319615(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::search::SearchIndexerConfig>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace search { 

//-------------------------------------------------
// Implementation of class UpdaterConfig
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
UpdaterConfig::UpdaterConfig() {
	status = de::elo::ix::client::search::SearchIndexerStatus::Inactive;
	intervalMinutes = 0;
	progressInPercent = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::search::UpdaterConfig::UpdaterConfig(SearchIndexerStatus status, const BDateTime& nextRunAt, int32_t intervalMinutes, const BDateTime& updateNewerThan, int32_t progressInPercent, const ::std::wstring& ixid, const ::std::wstring& lastException, const ::std::wstring& lockName)
	: status(status)
	, nextRunAt(nextRunAt)
	, intervalMinutes(intervalMinutes)
	, updateNewerThan(updateNewerThan)
	, progressInPercent(progressInPercent)
	, ixid(ixid)
	, lastException(lastException)
	, lockName(lockName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::search::UpdaterConfig::BSerializable_getTypeId() {
	return 1275243126; 
}
void UpdaterConfig::setStatus(SearchIndexerStatus v) {
	status = v;
}
void UpdaterConfig::setNextRunAt(BDateTime v) {
	nextRunAt = v;
}
void UpdaterConfig::setIntervalMinutes(int32_t v) {
	intervalMinutes = v;
}
void UpdaterConfig::setUpdateNewerThan(BDateTime v) {
	updateNewerThan = v;
}
void UpdaterConfig::setProgressInPercent(int32_t v) {
	progressInPercent = v;
}
void UpdaterConfig::setIxid(::std::wstring v) {
	ixid = v;
}
void UpdaterConfig::setLastException(::std::wstring v) {
	lastException = v;
}
void UpdaterConfig::setLockName(::std::wstring v) {
	lockName = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UpdaterConfig::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->intervalMinutes;
	ar & this->ixid;
	ar & this->lastException;
	ar & this->nextRunAt;
	ar & this->progressInPercent;
	ar & this->status;
	ar & this->updateNewerThan;
	if (version >= 1000000000000007) {
		ar & this->lockName;
	}
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1275243126(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::search::UpdaterConfig>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace system { 

//-------------------------------------------------
// Implementation of class ArchivReport
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ArchivReport::ArchivReport() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::system::ArchivReport::ArchivReport(const ::std::wstring& archivGUID, const PVectorArchivValue& elodmdocs, const PVectorArchivValue& objecte)
	: archivGUID(archivGUID)
	, elodmdocs(elodmdocs)
	, objecte(objecte)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::system::ArchivReport::BSerializable_getTypeId() {
	return 1383534582; 
}
void ArchivReport::setArchivGUID(::std::wstring v) {
	archivGUID = v;
}
void ArchivReport::setElodmdocs(PVectorArchivValue v) {
	elodmdocs = v;
}
void ArchivReport::setObjecte(PVectorArchivValue v) {
	objecte = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ArchivReport::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->archivGUID;
	ar & this->elodmdocs;
	ar & this->objecte;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1383534582(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::system::ArchivReport>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace system { 

//-------------------------------------------------
// Implementation of class ArchivValue
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ArchivValue::ArchivValue() {
	year = 0;
	count = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::system::ArchivValue::ArchivValue(int32_t year, int32_t count)
	: year(year)
	, count(count)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::system::ArchivValue::BSerializable_getTypeId() {
	return 1695870218; 
}
void ArchivValue::setYear(int32_t v) {
	year = v;
}
void ArchivValue::setCount(int32_t v) {
	count = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ArchivValue::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->count;
	ar & this->year;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1695870218(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::system::ArchivValue>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace system { 

//-------------------------------------------------
// Implementation of class BRequest_SystemInformation_archivReport
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_SystemInformation_archivReport::BRequest_SystemInformation_archivReport() : BMethodRequest(708455930) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::system::BRequest_SystemInformation_archivReport::BRequest_SystemInformation_archivReport(const PSystemInfo& si)
	: BMethodRequest(708455930) 
	, si(si)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::system::BRequest_SystemInformation_archivReport::BSerializable_getTypeId() {
	return 1995041693; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_SystemInformation_archivReport::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->si;
}
void de::elo::ix::client::system::BRequest_SystemInformation_archivReport::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PSystemInformation __byps__remoteT = byps_ptr_cast<SystemInformation>(__byps__remote);
	__byps__remoteT->archivReport(ci, si, [__byps__asyncResult](PArchivReport __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1383534582(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::system::BRequest_SystemInformation_archivReport::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1995041693(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::system::BRequest_SystemInformation_archivReport>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace system { 

//-------------------------------------------------
// Implementation of class BRequest_SystemInformation_countDocsInStorePath
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_SystemInformation_countDocsInStorePath::BRequest_SystemInformation_countDocsInStorePath() : BMethodRequest(708455930) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::system::BRequest_SystemInformation_countDocsInStorePath::BRequest_SystemInformation_countDocsInStorePath(const PSystemInfo& si)
	: BMethodRequest(708455930) 
	, si(si)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::system::BRequest_SystemInformation_countDocsInStorePath::BSerializable_getTypeId() {
	return 1786633213; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_SystemInformation_countDocsInStorePath::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->si;
}
void de::elo::ix::client::system::BRequest_SystemInformation_countDocsInStorePath::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PSystemInformation __byps__remoteT = byps_ptr_cast<SystemInformation>(__byps__remote);
	__byps__remoteT->countDocsInStorePath(ci, si, [__byps__asyncResult](PSystemReport __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_276702696(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::system::BRequest_SystemInformation_countDocsInStorePath::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1786633213(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::system::BRequest_SystemInformation_countDocsInStorePath>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace system { 

//-------------------------------------------------
// Implementation of class BRequest_SystemInformation_licenseReport
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_SystemInformation_licenseReport::BRequest_SystemInformation_licenseReport() : BMethodRequest(708455930) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::system::BRequest_SystemInformation_licenseReport::BRequest_SystemInformation_licenseReport(const PSystemInfo& si)
	: BMethodRequest(708455930) 
	, si(si)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::system::BRequest_SystemInformation_licenseReport::BSerializable_getTypeId() {
	return 821360905; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_SystemInformation_licenseReport::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->si;
}
void de::elo::ix::client::system::BRequest_SystemInformation_licenseReport::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PSystemInformation __byps__remoteT = byps_ptr_cast<SystemInformation>(__byps__remote);
	__byps__remoteT->licenseReport(ci, si, [__byps__asyncResult](PLicenseReport __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1320348587(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::system::BRequest_SystemInformation_licenseReport::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_821360905(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::system::BRequest_SystemInformation_licenseReport>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace system { 

//-------------------------------------------------
// Implementation of class BRequest_SystemInformation_userReport
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_SystemInformation_userReport::BRequest_SystemInformation_userReport() : BMethodRequest(708455930) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::system::BRequest_SystemInformation_userReport::BRequest_SystemInformation_userReport(const PSystemInfo& si)
	: BMethodRequest(708455930) 
	, si(si)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::system::BRequest_SystemInformation_userReport::BSerializable_getTypeId() {
	return 2081672491; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_SystemInformation_userReport::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->si;
}
void de::elo::ix::client::system::BRequest_SystemInformation_userReport::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PSystemInformation __byps__remoteT = byps_ptr_cast<SystemInformation>(__byps__remote);
	__byps__remoteT->userReport(ci, si, [__byps__asyncResult](PUserReport __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_18214274(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::system::BRequest_SystemInformation_userReport::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2081672491(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::system::BRequest_SystemInformation_userReport>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace system { 

//-------------------------------------------------
// Implementation of class LicenseCounter
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
LicenseCounter::LicenseCounter() {
	sumAccess = 0;
	disabled = false;
	countType = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::system::LicenseCounter::LicenseCounter(int32_t JAVA_CLIENT, int32_t WINWOS_CLIENT, int32_t FULL_USER, int32_t IX_USER, int32_t DELETED_USER, int32_t FREE_USER, const de::elo::ix::client::PUserInfo& userInfo, const byps::PMapIntegerInteger& accessMap, int32_t sumAccess, bool disabled, int32_t countType)
	: userInfo(userInfo)
	, accessMap(accessMap)
	, sumAccess(sumAccess)
	, disabled(disabled)
	, countType(countType)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::system::LicenseCounter::BSerializable_getTypeId() {
	return 189487184; 
}
void LicenseCounter::setUserInfo(de::elo::ix::client::PUserInfo v) {
	userInfo = v;
}
void LicenseCounter::setAccessMap(byps::PMapIntegerInteger v) {
	accessMap = v;
}
void LicenseCounter::setSumAccess(int32_t v) {
	sumAccess = v;
}
void LicenseCounter::setDisabled(bool v) {
	disabled = v;
}
void LicenseCounter::setCountType(int32_t v) {
	countType = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void LicenseCounter::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->countType;
	ar & this->disabled;
	ar & this->sumAccess;
	ar & this->accessMap;
	ar & this->userInfo;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_189487184(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::system::LicenseCounter>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace system { 

//-------------------------------------------------
// Implementation of class LicenseReport
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
LicenseReport::LicenseReport() {
	nbOfServerLicenses = 0;
	nbOfIgLicenses = 0;
	fullUser = 0;
	ixUser = 0;
	deletedUser = 0;
	freeUser = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::system::LicenseReport::LicenseReport(int32_t nbOfServerLicenses, int32_t nbOfIgLicenses, const ::std::wstring& serno, const PVectorLicenseCounter& counterList, int32_t fullUser, int32_t ixUser, int32_t deletedUser, int32_t freeUser)
	: nbOfServerLicenses(nbOfServerLicenses)
	, nbOfIgLicenses(nbOfIgLicenses)
	, serno(serno)
	, counterList(counterList)
	, fullUser(fullUser)
	, ixUser(ixUser)
	, deletedUser(deletedUser)
	, freeUser(freeUser)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::system::LicenseReport::BSerializable_getTypeId() {
	return 1320348587; 
}
void LicenseReport::setNbOfServerLicenses(int32_t v) {
	nbOfServerLicenses = v;
}
void LicenseReport::setNbOfIgLicenses(int32_t v) {
	nbOfIgLicenses = v;
}
void LicenseReport::setSerno(::std::wstring v) {
	serno = v;
}
void LicenseReport::setCounterList(PVectorLicenseCounter v) {
	counterList = v;
}
void LicenseReport::setFullUser(int32_t v) {
	fullUser = v;
}
void LicenseReport::setIxUser(int32_t v) {
	ixUser = v;
}
void LicenseReport::setDeletedUser(int32_t v) {
	deletedUser = v;
}
void LicenseReport::setFreeUser(int32_t v) {
	freeUser = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void LicenseReport::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->deletedUser;
	ar & this->freeUser;
	ar & this->fullUser;
	ar & this->ixUser;
	ar & this->nbOfIgLicenses;
	ar & this->nbOfServerLicenses;
	ar & this->serno;
	ar & this->counterList;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1320348587(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::system::LicenseReport>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace system { 

//-------------------------------------------------
// Implementation of class SystemInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SystemInfo::SystemInfo() {
	storePathID = 0;
	startDate = 0;
	endDate = 0;
	userReportMode = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::system::SystemInfo::SystemInfo(int32_t storePathID, int64_t startDate, int64_t endDate, int64_t userReportMode)
	: storePathID(storePathID)
	, startDate(startDate)
	, endDate(endDate)
	, userReportMode(userReportMode)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::system::SystemInfo::BSerializable_getTypeId() {
	return 2061316528; 
}
void SystemInfo::setStorePathID(int32_t v) {
	storePathID = v;
}
void SystemInfo::setStartDate(int64_t v) {
	startDate = v;
}
void SystemInfo::setEndDate(int64_t v) {
	endDate = v;
}
void SystemInfo::setUserReportMode(int64_t v) {
	userReportMode = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SystemInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->endDate;
	ar & this->startDate;
	ar & this->storePathID;
	ar & this->userReportMode;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2061316528(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::system::SystemInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace system { 

//-------------------------------------------------
// Implementation of class SystemReport
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SystemReport::SystemReport() {
	doccount = 0;
	docsize = 0;
	ftsize = 0;
	previewsize = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::system::SystemReport::SystemReport(int64_t doccount, int64_t docsize, int64_t ftsize, int64_t previewsize)
	: doccount(doccount)
	, docsize(docsize)
	, ftsize(ftsize)
	, previewsize(previewsize)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::system::SystemReport::BSerializable_getTypeId() {
	return 276702696; 
}
void SystemReport::setDoccount(int64_t v) {
	doccount = v;
}
void SystemReport::setDocsize(int64_t v) {
	docsize = v;
}
void SystemReport::setFtsize(int64_t v) {
	ftsize = v;
}
void SystemReport::setPreviewsize(int64_t v) {
	previewsize = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SystemReport::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->doccount;
	ar & this->docsize;
	ar & this->ftsize;
	ar & this->previewsize;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_276702696(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::system::SystemReport>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace system { 

//-------------------------------------------------
// Implementation of class UserReport
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
UserReport::UserReport() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::system::UserReport::BSerializable_getTypeId() {
	return 18214274; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UserReport::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_18214274(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::system::UserReport>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_100361105(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< int32_t > >(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1888107655(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< ::std::wstring > >(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2063419988(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::PWFDiagram >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1549980077(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::PWFNodeHistory >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1434022628(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< int32_t , int32_t >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1556767716(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< ::std::wstring , de::elo::ix::client::feed::PHashTag >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1535847981(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::set< de::elo::ix::client::feed::PHashTag >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_189813709(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::PInvalidateCacheInfoParam >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2111020589(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::PNote >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_881442092(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::PPublicDownload >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_907729609(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::PResolveRightsResult >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2106404937(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::PSord >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1773247378(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::PSordPath >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1546602844(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::PSubsInfo >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1241863010(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::PValueClass >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1399835671(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::feed::PActionHistory >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1644858720(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::feed::EActionType >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1403472717(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::feed::PHashTagRelation >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1270538819(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::health::PHealthCheckInfo >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_164573046(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::system::PArchivValue >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2005491011(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< de::elo::ix::client::system::PLicenseCounter >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_181681714(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< int32_t >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2123584667(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< ::std::wstring >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1489667803(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< byps::PVectorString >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1319324274(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::vector< byps::PMapStringString >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_893011331(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< int32_t , de::elo::ix::client::POrgUnitInfo >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1870226832(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< int32_t , de::elo::ix::client::PUserInfo >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1874463571(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< int32_t , de::elo::ix::client::PUserName >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1085717935(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< int32_t , de::elo::ix::client::PWFDiagram >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1347703734(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< int32_t , int32_t >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_498630295(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< int32_t , ::std::wstring >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1741591604(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< int32_t , de::elo::ix::client::PVectorWFDiagram >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_689498285(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< int32_t , de::elo::ix::client::PVectorWFNodeHistory >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1129834343(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< ::std::wstring , de::elo::ix::client::PMapValue >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1147263971(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< ::std::wstring , de::elo::ix::client::PNotification >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1862275569(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< ::std::wstring , de::elo::ix::client::PSubscription >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_425536672(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< ::std::wstring , de::elo::ix::client::feed::PFeed >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1239602222(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< ::std::wstring , de::elo::ix::client::feed::PHashTag >>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1710660846(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::std::map< ::std::wstring , ::std::wstring >>(bio, pObj, pObjS, pBase);	
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BSkeleton_IXEventBusHandler::BSerializable_getTypeId() {
	return 627994447; 
}
void BSkeleton_IXEventBusHandler::processEventBusEvents(int64_t subsId, const PArrayEvent& events)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXEventBusHandler::processEventBusEvents(int64_t subsId, const PArrayEvent& events, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		processEventBusEvents(subsId, events);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
}}}}



namespace de { namespace elo { namespace ix { namespace client { 
BStub_IXEventBusHandler::BStub_IXEventBusHandler(PTransport transport) 
	: BStub(transport) {}
}}}}

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BStub_IXEventBusHandler::BSerializable_getTypeId() {
	return 627994447; 
}
namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXEventBusHandler::processEventBusEvents(int64_t subsId, const PArrayEvent& events)  {
	BSyncResultT< bool > syncResult;	
	processEventBusEvents(subsId, events, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXEventBusHandler::processEventBusEvents(int64_t subsId, const PArrayEvent& events, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXEventBusHandler_processEventBusEvents(subsId, events));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

// checkpoint byps.gen.cpp.GenRemoteStub:224
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_627994447(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* reserved){
	BSerializer_16_Template<de::elo::ix::client::BStub_IXEventBusHandler, 627994447>(bio, pObj, pObjS, reserved);
}
}}}}


namespace de { namespace elo { namespace ix { namespace client { 

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BSkeleton_IXServerEvents::BSerializable_getTypeId() {
	return 1938363825; 
}
::std::wstring BSkeleton_IXServerEvents::getAppInfo(const PIXServerEventsContext& ec)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::getAppInfo(const PIXServerEventsContext& ec, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	::std::wstring __byps__ret = ::std::wstring();
	try {
		__byps__ret = getAppInfo(ec);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
bool BSkeleton_IXServerEvents::hasMethod(const PIXServerEventsContext& ec, const ::std::wstring& methodName)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::hasMethod(const PIXServerEventsContext& ec, const ::std::wstring& methodName, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = bool();
	try {
		__byps__ret = hasMethod(ec, methodName);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onBeforeCheckinSord(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onBeforeCheckinSord(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onBeforeCheckinSord(ec, sord, sordDB, parentSord, sordZ, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onAfterCheckinSord(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onAfterCheckinSord(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onAfterCheckinSord(ec, sord, sordDB, parentSord, sordZ, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onBeforeCheckinDocEnd(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PDocument& doc, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onBeforeCheckinDocEnd(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PDocument& doc, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onBeforeCheckinDocEnd(ec, sord, sordDB, parentSord, doc, sordZ, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onAfterCheckinDocEnd(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PDocument& doc, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onAfterCheckinDocEnd(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PDocument& doc, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onAfterCheckinDocEnd(ec, sord, sordDB, parentSord, doc, sordZ, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onBeforeDeleteSord(const PIXServerEventsContext& ec, const PSord& parentSord, const PSord& sord, const PLockZ& unlockZ, const PDeleteOptions& delOpts)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onBeforeDeleteSord(const PIXServerEventsContext& ec, const PSord& parentSord, const PSord& sord, const PLockZ& unlockZ, const PDeleteOptions& delOpts, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onBeforeDeleteSord(ec, parentSord, sord, unlockZ, delOpts);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onAfterDeleteSord(const PIXServerEventsContext& ec, const PSord& parentSord, const PSord& sord, const PLockZ& unlockZ, const PDeleteOptions& delOpts, bool ret)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onAfterDeleteSord(const PIXServerEventsContext& ec, const PSord& parentSord, const PSord& sord, const PLockZ& unlockZ, const PDeleteOptions& delOpts, bool ret, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onAfterDeleteSord(ec, parentSord, sord, unlockZ, delOpts, ret);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onBeforeRefSord(const PIXServerEventsContext& ec, const PSord& parentSordOld, const PSord& parentSordNew, const PSord& sord, int32_t manSortIndex)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onBeforeRefSord(const PIXServerEventsContext& ec, const PSord& parentSordOld, const PSord& parentSordNew, const PSord& sord, int32_t manSortIndex, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onBeforeRefSord(ec, parentSordOld, parentSordNew, sord, manSortIndex);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onAfterRefSord(const PIXServerEventsContext& ec, const PSord& parentSordOld, const PSord& parentSordNew, const PSord& sord, int32_t manSortIndex)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onAfterRefSord(const PIXServerEventsContext& ec, const PSord& parentSordOld, const PSord& parentSordNew, const PSord& sord, int32_t manSortIndex, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onAfterRefSord(ec, parentSordOld, parentSordNew, sord, manSortIndex);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onAfterEndEditWorkFlowNode(const PIXServerEventsContext& ec, const PWFDiagram& workflow, int32_t nodeId, const PSord& sord, const PSordZ& sordZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onAfterEndEditWorkFlowNode(const PIXServerEventsContext& ec, const PWFDiagram& workflow, int32_t nodeId, const PSord& sord, const PSordZ& sordZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onAfterEndEditWorkFlowNode(ec, workflow, nodeId, sord, sordZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onAfterCheckinReminder(const PIXServerEventsContext& ec, const PArrayReminder& remiArray, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onAfterCheckinReminder(const PIXServerEventsContext& ec, const PArrayReminder& remiArray, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onAfterCheckinReminder(ec, remiArray, sord, sordZ, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
PAny BSkeleton_IXServerEvents::executeRegisteredFunction(const PIXServerEventsContext& ec, const ::std::wstring& functionName, const PAny& any)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::executeRegisteredFunction(const PIXServerEventsContext& ec, const ::std::wstring& functionName, const PAny& any, ::std::function< void (PAny, BException ex) > asyncResult)  {
	PAny __byps__ret = PAny();
	try {
		__byps__ret = executeRegisteredFunction(ec, functionName, any);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
::std::wstring BSkeleton_IXServerEvents::executeRegisteredFunctionString(const PIXServerEventsContext& ec, const ::std::wstring& functionName, const ::std::wstring& args)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::executeRegisteredFunctionString(const PIXServerEventsContext& ec, const ::std::wstring& functionName, const ::std::wstring& args, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	::std::wstring __byps__ret = ::std::wstring();
	try {
		__byps__ret = executeRegisteredFunctionString(ec, functionName, args);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onBeforeStartWorkFlow(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PSord& sord, const PSordZ& sordZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onBeforeStartWorkFlow(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PSord& sord, const PSordZ& sordZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onBeforeStartWorkFlow(ec, workflow, sord, sordZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onAfterStartWorkFlow(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PSord& sord, const PSordZ& sordZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onAfterStartWorkFlow(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PSord& sord, const PSordZ& sordZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onAfterStartWorkFlow(ec, workflow, sord, sordZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onBeforeCheckinActivity(const PIXServerEventsContext& ec, const PActivity& act, bool isNew, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onBeforeCheckinActivity(const PIXServerEventsContext& ec, const PActivity& act, bool isNew, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onBeforeCheckinActivity(ec, act, isNew, sord, sordZ, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onAfterCheckinActivity(const PIXServerEventsContext& ec, const PActivity& act, bool isNew, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onAfterCheckinActivity(const PIXServerEventsContext& ec, const PActivity& act, bool isNew, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onAfterCheckinActivity(ec, act, isNew, sord, sordZ, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onBeforeCheckinNotes(const PIXServerEventsContext& ec, const PArrayNote& notes, const PArraySord& sords, int64_t noteC, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onBeforeCheckinNotes(const PIXServerEventsContext& ec, const PArrayNote& notes, const PArraySord& sords, int64_t noteC, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onBeforeCheckinNotes(ec, notes, sords, noteC, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onAfterCheckinNotes(const PIXServerEventsContext& ec, const PArrayNote& notes, const PArraySord& sords, int64_t noteC, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onAfterCheckinNotes(const PIXServerEventsContext& ec, const PArrayNote& notes, const PArraySord& sords, int64_t noteC, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onAfterCheckinNotes(ec, notes, sords, noteC, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onFileUploadBuildResponse(const PIXServerEventsContext& ec, const PDocVersion& dv, const ::std::wstring& fileName, const PHttpRequestInfo& requestInfo, const PHttpResponseInfo& responseInfo)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onFileUploadBuildResponse(const PIXServerEventsContext& ec, const PDocVersion& dv, const ::std::wstring& fileName, const PHttpRequestInfo& requestInfo, const PHttpResponseInfo& responseInfo, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onFileUploadBuildResponse(ec, dv, fileName, requestInfo, responseInfo);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
PArrayUserName BSkeleton_IXServerEvents::getUserNames(const PIXServerEventsContext& ec, const PArrayString& ids, const PCheckoutUsersZ& checkoutUsersZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::getUserNames(const PIXServerEventsContext& ec, const PArrayString& ids, const PCheckoutUsersZ& checkoutUsersZ, ::std::function< void (PArrayUserName, BException ex) > asyncResult)  {
	PArrayUserName __byps__ret = PArrayUserName();
	try {
		__byps__ret = getUserNames(ec, ids, checkoutUsersZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onReadSord(const PIXServerEventsContext& ec, const PSord& sord, const PSordZ& sordZ, const PDocument& doc, const PLockZ& lockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onReadSord(const PIXServerEventsContext& ec, const PSord& sord, const PSordZ& sordZ, const PDocument& doc, const PLockZ& lockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onReadSord(ec, sord, sordZ, doc, lockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
bool BSkeleton_IXServerEvents::onCheckSordAccess(const PIXServerEventsContext& ec, const PSord& sord, const PSordZ& sordZ, int32_t lur, const PCheckAccessOptions& opts)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onCheckSordAccess(const PIXServerEventsContext& ec, const PSord& sord, const PSordZ& sordZ, int32_t lur, const PCheckAccessOptions& opts, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = bool();
	try {
		__byps__ret = onCheckSordAccess(ec, sord, sordZ, lur, opts);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onBeforeLogin(const PIXServerEventsContext& ec, const ::std::wstring& userName, const PLoginScriptOptions& opts)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onBeforeLogin(const PIXServerEventsContext& ec, const ::std::wstring& userName, const PLoginScriptOptions& opts, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onBeforeLogin(ec, userName, opts);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onAfterLogin(const PIXServerEventsContext& ec, const ::std::wstring& userName, const PLoginScriptOptions& opts)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onAfterLogin(const PIXServerEventsContext& ec, const ::std::wstring& userName, const PLoginScriptOptions& opts, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onAfterLogin(ec, userName, opts);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
PEditInfo BSkeleton_IXServerEvents::onCreateSord(const PIXServerEventsContext& ec, const ::std::wstring& parentId, const ::std::wstring& maskId, const PEditInfoZ& editZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onCreateSord(const PIXServerEventsContext& ec, const ::std::wstring& parentId, const ::std::wstring& maskId, const PEditInfoZ& editZ, ::std::function< void (PEditInfo, BException ex) > asyncResult)  {
	PEditInfo __byps__ret = PEditInfo();
	try {
		__byps__ret = onCreateSord(ec, parentId, maskId, editZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
PEditInfo BSkeleton_IXServerEvents::onCreateDoc(const PIXServerEventsContext& ec, const ::std::wstring& parentId, const ::std::wstring& maskId, const ::std::wstring& docTemplate, const PEditInfoZ& editInfoZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onCreateDoc(const PIXServerEventsContext& ec, const ::std::wstring& parentId, const ::std::wstring& maskId, const ::std::wstring& docTemplate, const PEditInfoZ& editInfoZ, ::std::function< void (PEditInfo, BException ex) > asyncResult)  {
	PEditInfo __byps__ret = PEditInfo();
	try {
		__byps__ret = onCreateDoc(ec, parentId, maskId, docTemplate, editInfoZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
PArrayUserInfo BSkeleton_IXServerEvents::onBeforeCheckinUsers(const PIXServerEventsContext& ec, const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onBeforeCheckinUsers(const PIXServerEventsContext& ec, const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ, ::std::function< void (PArrayUserInfo, BException ex) > asyncResult)  {
	PArrayUserInfo __byps__ret = PArrayUserInfo();
	try {
		__byps__ret = onBeforeCheckinUsers(ec, userInfos, checkinUsersZ, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onAfterCheckinUsers(const PIXServerEventsContext& ec, const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onAfterCheckinUsers(const PIXServerEventsContext& ec, const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onAfterCheckinUsers(ec, userInfos, checkinUsersZ, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
PArrayKeyValue BSkeleton_IXServerEvents::onBeforeCheckinMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onBeforeCheckinMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ, ::std::function< void (PArrayKeyValue, BException ex) > asyncResult)  {
	PArrayKeyValue __byps__ret = PArrayKeyValue();
	try {
		__byps__ret = onBeforeCheckinMap(ec, domainName, id, objId, data, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onAfterCheckinMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onAfterCheckinMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onAfterCheckinMap(ec, domainName, id, objId, data, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
PArrayString BSkeleton_IXServerEvents::onBeforeDeleteMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onBeforeDeleteMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ, ::std::function< void (PArrayString, BException ex) > asyncResult)  {
	PArrayString __byps__ret = PArrayString();
	try {
		__byps__ret = onBeforeDeleteMap(ec, domainName, id, keyNames, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onAfterDeleteMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onAfterDeleteMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onAfterDeleteMap(ec, domainName, id, keyNames, unlockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onBeforeTakeWorkFlowNode(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PWFNode& node, const PUserInfo& user, int32_t flags, const PLockZ& lockZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onBeforeTakeWorkFlowNode(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PWFNode& node, const PUserInfo& user, int32_t flags, const PLockZ& lockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onBeforeTakeWorkFlowNode(ec, workflow, node, user, flags, lockZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onBeforeFindSords(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onBeforeFindSords(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onBeforeFindSords(ec, findInfo, sordZ);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onBeforeFindSordsInternalSQL(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ, const PFindInfoAsInternalSQL& findSql)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onBeforeFindSordsInternalSQL(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ, const PFindInfoAsInternalSQL& findSql, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onBeforeFindSordsInternalSQL(ec, findInfo, sordZ, findSql);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onFindSordsResult(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ, const PFindResult& findResult)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onFindSordsResult(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ, const PFindResult& findResult, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onFindSordsResult(ec, findInfo, sordZ, findResult);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_IXServerEvents::onFindClose(const PIXServerEventsContext& ec, const PSerializable& findInfo)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onFindClose(const PIXServerEventsContext& ec, const PSerializable& findInfo, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		onFindClose(ec, findInfo);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
InheritKeywordingResult BSkeleton_IXServerEvents::onInheritKeywording(const PIXServerEventsContext& ec, const PSord& sord, const PSord& parentSord, const PArrayString& okeyNames, const PSerializable& reserved)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_IXServerEvents::onInheritKeywording(const PIXServerEventsContext& ec, const PSord& sord, const PSord& parentSord, const PArrayString& okeyNames, const PSerializable& reserved, ::std::function< void (InheritKeywordingResult, BException ex) > asyncResult)  {
	InheritKeywordingResult __byps__ret = InheritKeywordingResult();
	try {
		__byps__ret = onInheritKeywording(ec, sord, parentSord, okeyNames, reserved);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
}}}}

