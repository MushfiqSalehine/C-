using System;
using System.Collections.Generic;
class program
{
  static bool isOperator(char ch)
  {
    return ch=='+' || ch=='-' || ch=='*' || ch=='/';
  }
  static void Main()
  {
    string postfix=Console.ReadLine();
    Stack<string>st=new Stack<string>();
    for(int i=0;i<postfix.Length;i++){
      char ch=postfix[i];
      if(isOperator(ch)){
        string op1=st.Pop();
        string op2=st.Pop();
        string x=ch+op2+op1;
        st.Push(x);
      }
      else{
        string x="";
        x+=ch;
        st.Push(x);
      }
    }
    Console.WriteLine(st.Peek());
  }
}