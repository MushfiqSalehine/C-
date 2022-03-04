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
    string prefix=Console.ReadLine();
    Stack<string>st=new Stack<string>();
    for(int i=prefix.Length-1;i>=0;i--){
      char ch=prefix[i];
      if(isOperator(ch)){
        string op1=st.Pop();
        string op2=st.Pop();
        string x='('+op1+ch+op2+')';
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