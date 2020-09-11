#include <stdio.h> 
#include <stdlib.h>

#include "struct.h"

vector *vector_create(int findex, float fvalue) {
    vector *root = (vector *)malloc(sizeof (vector));
    root -> index = findex;
    root -> value = fvalue;
    root -> next = NULL;
    root -> prev = NULL;
    return root;
}

void vector_add(vector *root, int findex, float fvalue) {
    while (root -> next)
    {
        root = root -> next;
    }
    vector *tmp = vector_create(findex, fvalue);
    root -> next = tmp;
    tmp -> prev = root;
}

void vector_output(vector *root) {
    while (root)
    {
        printf("%d %.3f |", root -> index, root -> value);
        root = root -> next;
    }
    printf("\n");
}

int matrix_height(vector *root) {
    int height = 0;
    while (root -> next)
    {
        if(root -> index == 0 && root -> value != 0) {
            if(root -> value > height) {
                height = root -> value;
            }
        }
        root = root -> next;
    }
    return height;
}

int matrix_width(vector *root) {
    int width = 0;
    while (root -> next)
    {
        if(root -> index != 0 && root -> value != 0){
            if(root -> index > width) {
                width = root -> index;
            }
        }
        root = root -> next;
    }
    return width;
}

void matrix_output(vector *root) {
    int height = matrix_height(root);
    int width = matrix_width(root);
    for(int i = 0; i < height; ++i){
        root = root -> next;
        for (int j = 0; j < width; ++j) {
            if(root -> index - 1 == j) {
                printf("%.3f ", root -> value);
                root = root -> next;
            } else {
                printf("0    ");
            }
        }
        printf("\n");
    }
}

vector *vector_input() {
    vector *v1 = NULL;
    int findex;
    float fvalue;
    for(;;)
    {
        scanf("%d", &findex);
        scanf("%f", &fvalue);
        if(findex == 0 && fvalue == 0) {
            vector_add(v1, findex, fvalue);
            printf("Break time!\n");
            break;
        }
        if(!v1) {
            v1 = vector_create(findex, fvalue);
            printf("Created!\n");
        } else {
            vector_add(v1, findex, fvalue);
            printf("Added!\n");
        }
    }
    return v1;
}

float absFloat(float a) {
    if(a > 0){
        return a;
    }
    a *= (-1);
    return a;
}

float closest_element(vector *root, float fvalue) {
    float delta = 101;
    float element = 101;
    while (root)
    {
        if(root -> index != 0 && root -> value != 0) {
            if(absFloat(root -> value - fvalue) < delta) {
                element = root -> value;
                delta = absFloat(root -> value - fvalue);
            }
        }
        root = root -> next;
    }
    return element;
}

void closest_elements(vector *root, float fvalue, int *ind, int *col) {
    int cur = 0;
    while (root)
    {
        if(root -> index == 0 && root -> value != 0) {
            cur = root -> value;
        }
        if(root -> index != 0 && root -> value != 0) {
            if(root -> value == fvalue) {
                *ind = 10 * (*ind) + cur;
                *col = 10 * (*col) + root -> index;
            }
        }
        root = root -> next;
    }
}

void correct_elements(vector *tmp, float fvalue, int *ind, int *col) {
    int out = 0;
    while (tmp) {
        if(tmp -> index == 0 && tmp -> value != 0) {
            out = tmp -> value;
        } else {
            int curi = *ind;
            int coli = *col;
            while (coli > 0) {
                if(tmp -> index == coli % 10) {
                    tmp -> value /= fvalue;
                    coli /= 10;
                    curi /= 10;
                    continue;
                }
                if (out == curi % 10)
                {
                    tmp -> value /= fvalue;
                    
                }
                coli /= 10;
                curi /= 10;
            }
        }
        tmp = tmp -> next;
    }
}
