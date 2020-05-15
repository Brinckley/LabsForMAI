#include "stdio.h"
#include "stdlib.h"

#include "deque.h"

void deque_create(Deque *D) {
    D -> last = 0;
}

int deque_empty(Deque *D) {
    if (D -> last == 0) return 1;
    else return 0;
}

int deque_size(Deque *D) {
    return D -> last;
}

void deque_push_front(Deque *D) {
    if (D -> last == SIZE) {
        printf("\nДек заполнен\n\n");
        return;
    }
    int value;
    printf("Введите число: ");
    scanf("%d", &value);

    for (int i = D -> last; i > 0; i--) {
        D -> data[i].value = D -> data[i-1].value;
    }
    D -> data[0].value = value;
        D -> last++;
    printf("Элемент добавлен\n");
}

void deque_push_back(Deque *D) {
    if (D -> last == SIZE) {
        printf("\nДек заполнен\n\n");
        return;
    }
    int value;
    printf("Введите число: ");
    scanf("%d", &value);
    D -> data[D -> last++].value = value;
    printf("Элемент добавлен\n");
}

void deque_pop_front(Deque *D) {
    for (int i = 0; i < D -> last; i++) {
        D -> data[i].value = D -> data[i+1].value;
        D -> last--;
    }
}

void deque_pop_back(Deque *D) {
    D -> last--;
}

void deque_print(Deque *D) {
    if(deque_empty(D) != 1) {
        for(int i = 0;i < deque_size(D); ++i) {
            printf("%d  ", D -> data[i].value);
        }
    }
    printf("\n");
}

void deque_sort_bubble(Deque *D){
    if(deque_empty(D) != 1){
        for(int i = 0; i < deque_size(D); ++i) {
            for (int j = 1; j < deque_size(D); ++j)
            {
                if(D -> data[j - 1].value > D -> data[j].value) {
                    int tmp = D -> data[j - 1].value;
                    D -> data[j - 1].value = D -> data[j].value;
                    D -> data[j].value = tmp;
                }
            }
        }
    }
    
}