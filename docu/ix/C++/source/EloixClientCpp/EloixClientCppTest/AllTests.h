#pragma once

#include "testfw.h"
#include "Byps.h"
#include "Bypshttp.h"
#include "TestBase.h"
#include "TestUtilHttp.h"
#include "BLogger.h"

using namespace de::elo::test;

void AllTests_run(void* app);

TestCase* TestCheckinDoc_create(void* app);
TestCase* TestEventBus_create(void* app);
TestCase* TestFeed_create(void* app);

