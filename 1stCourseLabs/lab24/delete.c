#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

#include "symbol.h"
#include "stack.h"
#include "tree.h"
#include "delete.h"

int max(int a, int b){
    if(a > b) {
        return a;
    } 
    return b;
}

float updater(TN *root) {
    if(root -> t.type == symb_OP){
        OP op = root -> t.data.op;
        if(op == OP_MINUS){
            root -> t.value = updater(root -> l) - updater(root -> r);
            return root -> t.value;
        }
        if(op == OP_PLUS){
            root -> t.value = updater(root -> l) + updater(root -> r);
            return root -> t.value;
        }
        if(op == OP_MULT){
            root -> t.value = updater(root -> l) * updater(root -> r);
            return root -> t.value;
        }
        if(op == OP_DIVIDE){
            root -> t.value = updater(root -> l) / updater(root -> r);
            return root -> t.value;
        }
        if(op == OP_POW){
            int lu = updater(root -> l);
            int lr = updater(root -> r);
            root -> t.value = 1;
            for(int i = 0; i < lr; ++i) {
                root -> t.value = root -> t.value * lu;
            }
            return root -> t.value;
        }
    }
    root -> t.value = root -> t.data.number;
    return root -> t.data.number;
}

void deleteNull(TN *root) {
    if(root -> t.data.op == OP_PLUS) {
        if(root -> l -> t.value == 0 && root -> r -> t.value == 0){
            free(root -> l);
            free(root -> r);
            root -> l = NULL;
            root -> r = NULL;
        } else {
            if(root -> r -> t.value == 0) {
                free(root -> r);
                root -> t = root -> l -> t;
                root -> r = root -> l -> r;
                root -> l = root -> l -> l;
            } else {
                if(root -> l -> t.value == 0) {
                    free(root -> l);
                    root -> l = root -> r -> l;
                    root -> t = root -> r -> t;
                    root -> r = root -> r -> r;
                }
            }
        }
    }
}

void walking(TN *root){
    if(root != NULL){
        deleteNull(root);
        walking(root -> l);
        walking(root -> r);
    }
}
