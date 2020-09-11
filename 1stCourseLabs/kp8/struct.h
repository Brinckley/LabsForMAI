#ifndef _LIST_H_
#define _LIST_H_

enum Dwarves {
    Thorin = 0,
    Bifur = 1,
    Bofur = 2,
    Balin = 3,
    Ori = 4
};

typedef struct List List;

struct List {
    enum Dwarves dwarf;
    List *next;
};

#endif