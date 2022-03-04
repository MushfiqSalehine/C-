using System.IO;
using System;
class Program
{
  static void Main()
  {
    string ans="";
    string str=Console.ReadLine();
    str+=" ";
    int sz=str.Length;
    int k=Convert.ToInt32(Console.ReadLine());
    int [] end=new int[sz+10];
    for(int i=0;i<sz;i++){
      end[i]=0;
      if(str[i]==' '){
        end[i-1]=1;
      }
    }
    int ptr=0;
    while(ptr<sz-1){
      if(end[ptr+k-1]==1){
        for(int i=ptr;i<ptr+k;i++){
          ans+=str[i];
        }
        ans+='\n';
        ptr=ptr+k+1;
      }
      else{
        int j=ptr+k-1,cn=0;
        while(j>=0 && end[j]!=1){
          j--;
          cn++;
        }
        for(int i=0;i<cn;i++){
          ans+=" ";
        }//it is for left align
        for(int i=ptr;i<=j;i++){
          ans+=str[i];
        }
        /*for(int i=0;i<cn;i++){
          ans+=" ";
        }*///it is for right align
        ans+='\n';
        ptr=j+2;
      }
    }
    Console.Write(ans);
  }
}
