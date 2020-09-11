#include "stdio.h"
#include "stdlib.h"

#include "element.h"
#include "keys.h"

void bubblesort(keys *p_k, element *allwords, int *counter) {
    for (int  k = 0; k < (*counter); ++k) { 
        for(int i = 0; i < (*counter) - 1; ++i) {
            if(p_k[i].primary_key >= p_k[i + 1].primary_key) {
                char a[15];
                char b[15];
                for (int j = 0; j < sizeof(allwords[i].word) / sizeof(allwords[i].word[0]); j++) {
                    a[j] = allwords[i].word[j];
                }
                for (int j = 0; j < sizeof(allwords[i + 1].word) / sizeof(allwords[i + 1].word[0]); j++) {
                    b[j] = allwords[i + 1].word[j];
                }
                for (int j = 0; j < sizeof(allwords[i].word) / sizeof(allwords[i].word[0]); j++) {
                    allwords[i + 1].word[j] = a[j];
                }
                for (int j = 0; j < sizeof(allwords[i + 1].word) / sizeof(allwords[i + 1].word[0]); j++) {
                    allwords[i].word[j] = b[j];
                }

                float tmp = p_k[i].primary_key;
                p_k[i].primary_key = p_k[i + 1].primary_key;
                p_k[i + 1].primary_key = tmp;
            }
        }
    }
}
