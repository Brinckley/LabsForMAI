#define SIZE 100 

#ifndef _data_type_h_
#define _data_type_h_
typedef struct {
    int value; 
} data_type;
#endif 

#ifndef _Deque_h_
#define _Deque_h_
typedef struct {
    data_type data[SIZE]; //массив данных
    int last; //указатель на конец
} Deque;
#endif

#ifndef DEQUEUE_H
#define DEQUEUE_H
void deque_create(Deque *);//
int deque_empty(Deque *);
int deque_size(Deque *);
void deque_push_front(Deque *);//
void deque_push_back(Deque *);//
void deque_pop_front(Deque *);//
void deque_pop_back(Deque *);//
void deque_print(Deque *);//
void deque_sort_bubble(Deque *);//

#endif