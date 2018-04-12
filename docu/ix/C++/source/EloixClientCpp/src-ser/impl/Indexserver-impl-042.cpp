#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

PApiDescriptor BApiDescriptor_Indexserver::instance() {
	return PApiDescriptor((new BApiDescriptor(
	"Indexserver",
	"de.elo.ix.client",
	VERSION,
	false)) // uniqueObjects
	->addRegistry(PRegistry(new BRegistry_Indexserver()))
	);
};

}}}}

namespace de { namespace elo { namespace ix { namespace client { 

PClient_Indexserver BClient_Indexserver::createClient(PTransportFactory transportFactory) {
	return PClient_Indexserver(new BClient_Indexserver(transportFactory));
}
PClient_Indexserver BClient_Indexserver::createClientR(PTransport transport) {
	return PClient_Indexserver(new BClient_Indexserver(transport));
}
void BClient_Indexserver::addRemote(PSkeleton_IXEventBusHandler remoteSkeleton) {
	if (!serverR) throw BException(BExceptionC::NO_REVERSE_CONNECTIONS, L"No reverse connections.");
	serverR->server->addRemote(627994447, remoteSkeleton);
}

void BClient_Indexserver::addRemote(PSkeleton_IXServerEvents remoteSkeleton) {
	if (!serverR) throw BException(BExceptionC::NO_REVERSE_CONNECTIONS, L"No reverse connections.");
	serverR->server->addRemote(1938363825, remoteSkeleton);
}

void BClient_Indexserver::addRemote(de::elo::ix::client::feed::PSkeleton_FeedNotification remoteSkeleton) {
	if (!serverR) throw BException(BExceptionC::NO_REVERSE_CONNECTIONS, L"No reverse connections.");
	serverR->server->addRemote(320199695, remoteSkeleton);
}

void BClient_Indexserver::addRemote(de::elo::ix::client::notify::PSkeleton_ClientNotification remoteSkeleton) {
	if (!serverR) throw BException(BExceptionC::NO_REVERSE_CONNECTIONS, L"No reverse connections.");
	serverR->server->addRemote(2104055021, remoteSkeleton);
}

BClient_Indexserver::BClient_Indexserver(PTransportFactory transportFactory) 
	: BClient(
		transportFactory->createClientTransport(), 
		transportFactory->createServerR(
			BServer_Indexserver::createServerR(transportFactory->createServerTransport())
		)
	)
	{
	initStubs(transport);
}
BClient_Indexserver::BClient_Indexserver(PTransport transport) 
	: BClient(transport, NULL)
	{
	initStubs(transport);
}
BINLINE de::elo::ix::client::PIXEventBusHandler BClient_Indexserver::getIXEventBusHandler() {
	return iXEventBusHandler;
}
BINLINE de::elo::ix::client::PIXServerEvents BClient_Indexserver::getIXServerEvents() {
	return iXServerEvents;
}
BINLINE de::elo::ix::client::PIXServicePortIFAuth BClient_Indexserver::getIXServicePortIF() {
	return iXServicePortIF;
}
BINLINE de::elo::ix::client::compatibility::PRawStreamServiceAuth BClient_Indexserver::getRawStreamService() {
	return rawStreamService;
}
BINLINE de::elo::ix::client::compatibility::PWClientServiceAuth BClient_Indexserver::getWClientService() {
	return wClientService;
}
BINLINE de::elo::ix::client::feed::PFeedNotification BClient_Indexserver::getFeedNotification() {
	return feedNotification;
}
BINLINE de::elo::ix::client::feed::PFeedServiceAuth BClient_Indexserver::getFeedService() {
	return feedService;
}
BINLINE de::elo::ix::client::health::PHealthCheckServiceAuth BClient_Indexserver::getHealthCheckService() {
	return healthCheckService;
}
BINLINE de::elo::ix::client::myelo::PMyELOServiceAuth BClient_Indexserver::getMyELOService() {
	return myELOService;
}
BINLINE de::elo::ix::client::notify::PClientNotification BClient_Indexserver::getClientNotification() {
	return clientNotification;
}
BINLINE de::elo::ix::client::system::PSystemInformationAuth BClient_Indexserver::getSystemInformation() {
	return systemInformation;
}
PRemote BClient_Indexserver::getStub(int remoteId) {
	if (remoteId == 627994447) return iXEventBusHandler;
	if (remoteId == 1938363825) return iXServerEvents;
	if (remoteId == 1795705954) return iXServicePortIF;
	if (remoteId == 354585327) return rawStreamService;
	if (remoteId == 1887299447) return wClientService;
	if (remoteId == 320199695) return feedNotification;
	if (remoteId == 1670701039) return feedService;
	if (remoteId == 969424915) return healthCheckService;
	if (remoteId == 1063633807) return myELOService;
	if (remoteId == 2104055021) return clientNotification;
	if (remoteId == 708455930) return systemInformation;
	return PRemote();
}
BINLINE void BClient_Indexserver::initStubs(PTransport transport) {
	iXEventBusHandler = de::elo::ix::client::PIXEventBusHandler(new BStub_IXEventBusHandler(transport));
	iXServerEvents = de::elo::ix::client::PIXServerEvents(new BStub_IXServerEvents(transport));
	iXServicePortIF = de::elo::ix::client::PIXServicePortIFAuth(new BStub_IXServicePortIF(transport));
	rawStreamService = de::elo::ix::client::compatibility::PRawStreamServiceAuth(new de::elo::ix::client::compatibility::BStub_RawStreamService(transport));
	wClientService = de::elo::ix::client::compatibility::PWClientServiceAuth(new de::elo::ix::client::compatibility::BStub_WClientService(transport));
	feedNotification = de::elo::ix::client::feed::PFeedNotification(new de::elo::ix::client::feed::BStub_FeedNotification(transport));
	feedService = de::elo::ix::client::feed::PFeedServiceAuth(new de::elo::ix::client::feed::BStub_FeedService(transport));
	healthCheckService = de::elo::ix::client::health::PHealthCheckServiceAuth(new de::elo::ix::client::health::BStub_HealthCheckService(transport));
	myELOService = de::elo::ix::client::myelo::PMyELOServiceAuth(new de::elo::ix::client::myelo::BStub_MyELOService(transport));
	clientNotification = de::elo::ix::client::notify::PClientNotification(new de::elo::ix::client::notify::BStub_ClientNotification(transport));
	systemInformation = de::elo::ix::client::system::PSystemInformationAuth(new de::elo::ix::client::system::BStub_SystemInformation(transport));
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 

PServer_Indexserver BServer_Indexserver::createServer(PTransportFactory transportFactory) {
	return PServer_Indexserver(new BServer_Indexserver(transportFactory));
}
PServer_Indexserver BServer_Indexserver::createServerR(PTransport transport) {
	return PServer_Indexserver(new BServer_Indexserver(transport));
}
void BServer_Indexserver::addRemote(PSkeleton_IXEventBusHandler remoteSkeleton) {
	BServer::addRemote(627994447, remoteSkeleton);
}

void BServer_Indexserver::addRemote(PSkeleton_IXServerEvents remoteSkeleton) {
	BServer::addRemote(1938363825, remoteSkeleton);
}

void BServer_Indexserver::addRemote(de::elo::ix::client::feed::PSkeleton_FeedNotification remoteSkeleton) {
	BServer::addRemote(320199695, remoteSkeleton);
}

void BServer_Indexserver::addRemote(de::elo::ix::client::notify::PSkeleton_ClientNotification remoteSkeleton) {
	BServer::addRemote(2104055021, remoteSkeleton);
}

BServer_Indexserver::BServer_Indexserver(PTransportFactory transportFactory) 
	: BServer(
		transportFactory->createServerTransport(), 
		transportFactory->createClientR(
			BClient_Indexserver::createClientR(transportFactory->createClientTransport())
		)
	)
	{
}
BServer_Indexserver::BServer_Indexserver(PTransport transport) 
	: BServer(transport, NULL)
	{
}
}}}}

