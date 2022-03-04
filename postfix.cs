using System;
using System.Text;
using System.Collections.Generic;
class Program
{
  static bool isDigit(char ch)
  {
    return ch>='0' && ch<='9';
  }
  static double operation(double u,double v,char ch)
  {
    if(ch=='+'){
      return u+v;
    }
    if(ch=='-'){
      return u-v;
    }
    if(ch=='*'){
      return u*v;
    }
    if(ch=='/'){
      return u/v;
    }
    return 0.0;
  }
  static void Main()
  {
    string postfix=Console.ReadLine();
    Stack<double>st=new Stack<double>();
    for(int i=0;i<postfix.Length;i++){
      char ch=postfix[i];
      if(isDigit(ch)){
        st.Push(ch-'0');
      }
      else{
        double u=st.Pop();
        double v=st.Pop();
        st.Push(operation(v,u,ch));
      }
    }
    Console.WriteLine(st.Peek());
  }
}