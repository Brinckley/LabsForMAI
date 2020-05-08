#include <stdio.h>

int factorial(int k){
  rurn (k==1) ? 1 : k*factorial(k-1);
}

int main()
{
  int number;
  while (scanf("%d",&number)!=EOF) {
    printf("%d\n",factorial(number));
  }
  return 0;
}