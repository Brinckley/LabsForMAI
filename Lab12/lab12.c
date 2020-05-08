#include<stdio.h>


int main()
{
    char num1,num2;
    num2='a';
    int count=0;
    int flag=0;
    while (scanf ("%c", &num1) != EOF)
    {
        if(num1=='\n'||num1==' '){
            if(flag!=0){
                printf("%s\n", "true");
            }
            else
            {
                printf("%s\n", "false");
            }
            
            num2 = 'a';
            flag=0;
            continue;
        }
        if(num2=='a'){
            num2 = num1;
        }
        else
        {
            if(num1==num2){
                flag++;
            }
            num2=num1;
        }
        
    }
    return 0;
}