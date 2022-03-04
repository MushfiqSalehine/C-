using System;
using System.Text;
using System.Collections.Generic;
class program
{
  static bool isNotOperator(char ch)
  {
    return ch!='+' && ch!='-' && ch!='*' && ch!='/';
  }
  static int precedence(char x)
  {
    if(x=='/' || x=='*'){
      return 1;
    }
    if(x=='+' || x=='-'){
      return 0;
    }
    return -1;
  }
  static void Main()
  {
    string infix=Console.ReadLine();
    Stack<char>st=new Stack<char>();
    string postfix="";
    for(int i=0;i<infix.Length;i++){
      char ch=infix[i];
      if(isNotOperator(ch)){
        postfix+=ch;
      }
      else if(ch=='('){
        st.Push(ch);
      }
      else if(ch==')'){
        while(st.Peek()!='('){
          postfix+=st.Pop();
        }
        st.Pop();
      }
      else{
        while(st.Count!=0 && precedence(st.Peek())>=precedence(ch)){
          postfix+=st.Pop();
        }
        st.Push(ch);
      }
    }
    while(st.Count!=0){
      postfix+=st.Pop();
    }
    Console.Write(postfix);
  }
}
