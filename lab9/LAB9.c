#include <stdio.h>

long long mod(long long n, long long m){
    return (n%m>=0) ? n%m:(n%m+m);
}

long long min(long long n1,long long n2,long long n3){
    if(n1 < n2){return (n1 < n3) ? n1:n3;}
    return (n2<n3) ? n2:n3;
}

long long max(long long n1,long long n2,long long n3){
    if(n1 > n2){return (n1 > n3) ? n1:n3;}
    return (n2>n3) ? n2:n3;
}

int ifend(long long i, long long j){
    return ((i+20)*(i+20)+(j+20)*(j+20)<=100&&(i+10)*(i+10)+(j+10)*(j+10)<=100);
}

int main(){
    long long i0=6,j0=27,l0=-15,k;
    long long i,j,l;
    int count=0;
    while(scanf("%d %d %d",i0,j0,l0)!=EOF){
        for(k=1;k<51;++k){
            count++;
            i=mod(i0*i0*i0-j0*j0*j0+l0*l0*l0-k,20);
            j=mod(min(i0*j0*j0-k,i0*i0*l0-k,j0*l0*l0-k),30);
            l=mod(max(i0*j0*j0-k,i0*i0*l0-k,j0*l0*l0-k),30);
            if(ifend(i,j)){break;}
            i0=i; j0=j; l0=l;
            printf("i=%lld j=%lld l=%lld\n", i,j,l);            
            }
            
            if(k==51){printf("\nMiss! \n");}
            else{printf("\nHit! %lld\n", k);}
            printf("i=%lld j=%lld l=%lld\n", i,j,l);
    }
    return 0;
}
