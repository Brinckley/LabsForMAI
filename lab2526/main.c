#include "stdio.h"
#include "stdlib.h"

#include "deque.h"

int main() {
    printf("Start: \n");
    Deque deq;
    deque_create(&deq);
    printf("1. Добавить элелмент в начало\n");
    printf("2. Добавить элемент в конец\n");
    printf("3. Удалить первый элемент\n");
    printf("4. Удалить последний элемент\n");
    printf("5. Вывести содержимое дека\n");
    printf("6. Сортриовка дека пузырьком\n");
    printf("7. Выход\n");
    int flag = 0;
    int value;
    
    while (flag != 7)
    {
        printf("Выбор функции:\n");
        scanf("%d", &flag);
        switch (flag) {
        case 1:
            printf("Введите число: ");
            scanf("%d", &value);
            deque_push_front(deq, value);
            printf("\n");
            break;
        case 2:
            printf("Введите число: ");
            scanf("%d", &value);
            deque_push_back(deq, value);
            break;
        case 3:
            deque_pop_front(&deq);
            break;
        case 4:
            deque_pop_back(&deq);
            break;
        case 5:
            deque_print(&deq);
            break;
        case 6:
            deque_sort_bubble(&deq);
            break;
        case 7:
            break;
        default:
            printf("\nОшибка!\n");
            break;
        }
    }
    printf("Done\n");
}
