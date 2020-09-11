#include <stdio.h> 
#include <stdlib.h>

#include "vector.c"
#include "struct.h"

int main() {
    printf("Start\n");
    printf("Input your matrix in one vector: \n");
    vector *root = vector_input();
    printf("Your matrix in vector: \n");
    vector_output(root);
    printf("Matrix form: \n");
    matrix_output(root);
    printf("Print in the number for funtion: ");
    float value = 0;
    int ind = 0;
    int col = 0;
    scanf("%f", &value);
    value = closest_element(root, value);
    printf("Closest to your element is:  %.3f  ", value);
    printf("\n");
    closest_elements(root, value, &ind, &col);
    correct_elements(root, value, &ind, &col);
    matrix_output(root);
    printf("Done\n");
}
