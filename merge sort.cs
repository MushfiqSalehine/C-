using System;
using System.Collections.Generic;
class program
{
  static public info[] temp=new info[100010];
  static void sort(int left,int right,info[] arr)
  {
    if(left>=right){
      return ;
    }
    int mid=(left+right)/2;
    sort(left,mid,arr);
    sort(mid+1,right,arr);
    merge(left,mid,right,arr);
  }
  static void merge(int left,int mid,int right,info[] arr)
  {
    int i=left,j=mid+1,k=0;
    while(i<=mid && j<=right){
      if(arr[i].second==arr[j].second){
        if(arr[i].first<arr[j].first){
          temp[k++]=arr[i++];
        }
        else{
          temp[k++]=arr[j++];
        }
      }
      else if(arr[i].second>arr[j].second){
        temp[k++]=arr[j++];
      }
      else{
        temp[k++]=arr[i++];
      }
    }
    while(i<=mid){
      temp[k++]=arr[i++];
    }
    while(j<=right){
      temp[k++]=arr[j++];
    }
    for(i=left,j=0;i<=right;i++,j++){
      arr[i]=temp[j];
    }
  }
  static void Main()
  {
    int n=Convert.ToInt32(Console.ReadLine());
    info[] arr=new info[n];
    for(int i=0;i<n;i++){
      var x=Console.ReadLine().Split();
      arr[i].first=Convert.ToInt32(x[0]);
      arr[i].second=Convert.ToInt32(x[1]);
    }
    Console.WriteLine("Before Sort: ");
    for(int i=0;i<n;i++){
      Console.WriteLine(arr[i].first+" "+arr[i].second);
    }
    sort(0,n-1,arr);
    Console.WriteLine("After Sort: ");
    for(int i=0;i<n;i++){
      Console.WriteLine(arr[i].first+" "+arr[i].second);
    }
  }
}
struct info
{
  public int first,second;
}