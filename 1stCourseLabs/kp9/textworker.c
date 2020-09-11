#include "stdio.h"
#include "stdlib.h"

#include "element.h"
#include "keys.h"

void fileReader(keys *p_k, element *allwords, int *counter)
{
    FILE * file;
    file = fopen ("text.txt","r");
    fseek(file, 0L, SEEK_SET);
    while (fscanf(file, "%f %s", &p_k[*counter].primary_key, allwords[*counter].word) != EOF) {
        printf("%f %s \n", p_k[*counter].primary_key, allwords[*counter].word);
        ++(*counter);
    }
}