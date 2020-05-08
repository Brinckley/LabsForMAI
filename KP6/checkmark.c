#include <stdio.h>
#include <time.h>
#include <stdlib.h>
#include <assert.h>
#include <string.h>

#include "student.h"
#include "fileworker.h"

int check(char RAW_NAME[], char group[]) {
    int counter = 0;
    int number = 0;
    FILE *file;
    file = fopen(RAW_NAME, "r");
    student *p;
    if (file == NULL) {
        printf("Error!!!");
    } else {
        while (!feof(file))
        {
            p = malloc(sizeof(p));
            fread(&p, sizeof(p), 1, file);
            if(strcmp(p -> group, group)) {
                if(p -> m.disk = 3){ counter++; }
                if(p -> m.mat = 3){ counter++; }
                if(p -> m.hist = 3){ counter++; }
                if(p -> m.it = 3){ counter++; }
            }
            if(counter > 2) {
                number ++;
            }
            
             printf("\n");
        }
    }
    fclose(file);
    return number;
}