#ifndef __tree_h__
#define __tree_h__

#include <stdbool.h>

#include "symbol.h"

typedef struct _TN {
    symbol t;
    struct _TN* l;
    struct _TN* r;
} TN;

#endif
