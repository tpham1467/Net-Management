#include<iostream>
using namespace std;
int main()
{
    int n;
    cin>>n;
    int a[n];
    for(int i=0;i<n;i++)
    {
        cin>>a[i];
    }   
    int index =-1;
    for(int i=0;i<n;i++)
    {
        if(a[i]==0&&index==-1)
        {
            index = i;
        }
        if(index!=-1&&a[i]!=0)
        {
            int temp =a[index];
            a[index] = a[i];
            a[i] = temp;
            index++;
        }
    }
     for(int i=0;i<n;i++)
    {
        cout<<a[i]<<" ";
    }   
}