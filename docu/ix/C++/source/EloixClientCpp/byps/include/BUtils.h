/* USE THIS FILE ACCORDING TO THE COPYRIGHT RULES IN LICENSE.TXT WHICH IS PART OF THE SOURCE CODE PACKAGE */
#ifndef BUTILS_H_
#define BUTILS_H_

#include "Byps.h"

namespace byps {

using namespace ::std;

#ifndef BHASH_CSTRING
#define BHASH_CSTRING
	
inline BTYPEID BHash(const char* s, int bias) {
	if (!s) return 0;
	int h = bias;
	while (*s) {
         h = 31*h + *s;
         s++;
	}
	return (BTYPEID)h;
}

#endif

//wstring BToStdWString(const string& str);
//wstring BToStdWString(const char* str, size_t len = string::npos, bool isUtf8 = false);

BINLINE string toUtf8(const wstring& str);
BINLINE wstring fromUtf8(const string& str);

}


#endif /* BUTILS_H_ */
