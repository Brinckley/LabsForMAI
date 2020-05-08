#include <stdio.h>
#include <malloc.h>

#include "Struct.c"

int max(int a, int b){
    if(a >= b){
        return a;
    }
    return b;
}

int max3(int a, int b, int c){
    if( a > max(c, b)){
        return a;
    }
    return max(b, c);
}

int min(int a, int b){
    if(a <= b){
        return a;
    }
    return b;
}

int min3(int a, int b, int c){
    if(a < min(b, c)){
        return a;
    }
    return min(b, c);
}

int maxLevel(btree *p){
    if(p != NULL){
        int ml = 0;
        int mr = 0;
        if(p -> left != NULL){
            ml = maxLevel(p -> left);
        } 
        if(p -> right != NULL){
            mr = maxLevel(p -> right);
        } 
        return max3(mr, ml, p -> level);
    }
}

int minLevel(btree *p, int max){
    if(p != NULL){
        int ml = max;
        int mr = max;
        if(p != NULL && p -> left == NULL && p -> right == NULL){
            return p -> level;
        }
        if(p -> left != NULL){
            ml = minLevel(p -> left, max);
        } 
        if(p -> right != NULL){
            mr = minLevel(p -> right, max);
        } 
        return min(mr, ml);
    }
}

void levelCheck(btree *tree){
    int max = maxLevel(tree);
    int min = minLevel(tree, 0);
    if(min - max != 0){
        printf("All leaves are not on the same level\n");
    } else {
        printf("All leaves are on the same level\n");
    }  
}
