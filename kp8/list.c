#include "stdio.h"

#include "struct.h"

//iter
List *end(List *current) {
    while (current -> next != NULL)
    {
        current = current -> next;
    }
    return current;
}

List *next(List *current) {
    if(current -> next != NULL) {
        current = current -> next;
    }
    return current;
}

List *list_create(enum Dwarves value) {
    List *list = (List *)malloc(sizeof(List));
    list -> dwarf = value;
    list -> next = NULL;
    return list;
}

int list_size(List *l, int count) {
    if(l -> next != NULL) {
        return list_size(l -> next, count + 1);
    } 
    return count;
}

void list_insert(List *root, enum Dwarves newd) {
    root = end(root);
    List *new = list_create(newd);
    root -> next = new;
}

void list_delete(List *root, enum Dwarves delete) {
    List *prev = root;
    int size = list_size(root, 0);
    for (int i = 0; i < size + 1; i++)
    {
        if(i == 0 && root -> dwarf == delete) {
            if(root -> next != NULL) {
                root -> dwarf = root -> next -> dwarf;
                root -> next = root -> next -> next;
                continue;
            } else {
                free(root);
                return;
            }
        }
        if(root -> dwarf == delete) {
            if(root -> next == NULL) {
                prev -> next = NULL;
                free(root);
                return;
            } 
            prev -> next = root -> next;
            root = prev -> next;
            continue;
        }
        prev = root;
        root = root -> next;
    }
}

void dwarfToString(enum Dwarves value) {
    switch (value)
    {
    case Thorin:
        printf("Thorin ");
        break;
    case Bifur:
        printf("Bifur ");
        break;
    case Bofur:
        printf("Bofur ");
        break;
    case Balin:
        printf("Balin ");
        break;
    case Ori:
        printf("Ori ");
        break;
    default:
        break;
    }
}

void list_print(List *l) {
    dwarfToString(l -> dwarf);
    if(l -> next != NULL) {
        list_print(l -> next);
    }
}

List *list_swap_halves(List *l) {
    int middle;
    int size = list_size(l, 0) + 1;
    if(size == 2) {
        List *ans = l -> next;
        l -> next -> next = l;
        l -> next = NULL;
        return ans;
    }
    List *endl, *mid; 
    endl = end(l);
    mid = l;
    middle = size / 2;
    if(size % 2 == 1){
        for(int i = 0;i < middle - 1; ++i) {
            mid = mid -> next;
        }
        List *base = mid -> next;
        List *roott = base -> next;
        base -> next = l;
        mid -> next = NULL;
        endl -> next = base;
        return roott;

    } else {
        for (int i = 0; i < middle - 1; i++)
        {
            mid = mid -> next;
        }
        List *root = mid -> next;
        endl -> next = l;
        mid -> next = NULL;
        return root;
    }
}
