#include "stdio.h"
#include "stdlib.h"

#include "list.c"

enum Dwarves chooseDwarf(int v) {
    switch (v)
    {
    case 0:
        return Thorin;
        break;
    case 1:
        return Bifur;
        break;
    case 2:
        return Bofur;
        break;
    case 3:
        return Balin;
        break;
    case 4:
        return Ori;
        break;
    default:
        break;
    }
}

int main() {
    printf("Start: \n");
    List *node = NULL;
    printf("1. Add\n");
    printf("2. Delete\n");
    printf("3. Size\n");
    printf("4. Print\n");
    printf("5. Swap\n");
    printf("6. Finish\n");
    int flag = 0;
    int value;
    while (flag != 6)
    {
        printf("\nFunc num:\n");
        scanf("%d", &flag);
        switch (flag) {
        case 1:
            printf("Dwarf to add: ");
            scanf("%d", &value);
            if(!node) {
                printf("\nCreated!\n");
                node = list_create(chooseDwarf(value));
                break;
            } else {
                list_insert(node, chooseDwarf(value));
                printf("Another one in squad\n");
            }
            break;
        case 2:
            printf("Dwarf to kill: ");
            scanf("%d", &value);
            if(node == NULL) {
                printf("\nNo list yet!\n");
                break;
            }
            list_delete(node, chooseDwarf(value));
            printf("One more, one less. Who cares?\n");
            break;
        case 3:
            if(node) {
                printf("%d ", list_size(node, 0) + 1);
                break;
            }
            printf("\nNo list yet!\n");
            break;
        case 4:
            if(node) {
                list_print(node);
                break;
            }
            printf("\nNo list yet!\n");
            break;
        case 5:
            if(node) {
                node = list_swap_halves(node);
                break;
            }
            printf("\nNo list yet!\n");
            break;
        case 6:
            break;
        default:
            printf("\nERROR!\n");
            break;
        }
    }
    printf("Done\n");
}