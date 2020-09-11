#include <stdio.h>
#include <locale.h>
#include <wchar.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    char str;
    int count=0;
    char zero;
    while(scanf ("%c",  &str ) != EOF){
        if(str!='U'&&str!='+'&&str!=' '&&str!=','&&str!='0'){
            if(str=='E'){
                if(scanf ("%c",  &zero ) != EOF){
                    if(zero=='4'){ count++; }
                }    
            }
            if(str=='F'){
               if(scanf ("%c",  &zero ) != EOF){
                   if(zero=='6'){ count++; }
                   if(zero=='C'){ count++; }
                }   
            }
            if(str=='4'){
                if(scanf ("%c",  &zero ) != EOF){
                   if(zero!='0'){ count++; }
                }   
            }
            if(str=='5'){
                if(scanf ("%c",  &zero ) != EOF){
                   if(zero!='A'||zero!='B'||zero!='C'||zero!='D'||zero!='E'||zero!='F')
                   { count++; }
                }   
            }
        }
    }
    printf("%d\n", count);
    return 0;
     
}