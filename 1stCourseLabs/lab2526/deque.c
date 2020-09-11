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


void deque_push_front(Deque *D, int value) {
    if (D -> last == SIZE) {
        printf("\nДек заполнен\n\n");
        return;
    }
    for (int i = D -> last; i > 0; i--) {
        D -> data[i].value = D -> data[i-1].value;
    }
    D -> data[0].value = value;
        D -> last++;
    printf("Элемент добавлен\n");
}

void deque_push_back(Deque *D, int value) {
    if (D -> last == SIZE) {
        printf("\nДек заполнен\n\n");
        return;
    }
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
    Deque* tmp;
    deque_create(tmp);
    if(deque_empty(D) != 1){
        for(int i = 0; i < deque_size(D); ++i) {
            if(tmp -> last == 0) {
                deque_push_back(tmp, D -> data[0].value);
                deque_pop_front(D);
                continue;
            }
            if(tmp -> data[tmp -> last - 1].value < D -> data[0].value) {
                deque_push_back(tmp, D -> data[0].value);
                deque_pop_front(D);
            } else {
                int mid = tmp -> data[tmp -> last - 1].value;
                tmp -> data[tmp -> last - 1].value = D -> data[0].value;
                deque_push_back(tmp, mid);
                deque_pop_front(D);
            }
        }
        D = tmp;
    }
}
