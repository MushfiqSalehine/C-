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
  static string stringReverse(string str)
  {
    string res="";
    for(int i=str.Length-1;i>=0;i--){
      res+=str[i];
    }
    return res;
  }
  static void Main()
  {
    string infix=Console.ReadLine();
    StringBuilder str=new StringBuilder(infix);
    for(int i=0;i<infix.Length;i++){
      if(str[i]=='('){
        str[i]=')';
      }
      else if(str[i]==')'){
        str[i]='(';
      }
    }
    infix=Convert.ToString(str);
    Stack<char>st=new Stack<char>();
    string prefix="";
    for(int i=infix.Length-1;i>=0;i--){
      char ch=infix[i];
      if(isNotOperator(ch)){
        prefix+=ch;
      }
      else if(ch=='('){
        st.Push(ch);
      }
      else if(ch==')'){
        while(st.Peek()!='('){
          prefix+=st.Pop();
        }
        st.Pop();
      }
      else{
        while(st.Count!=0 && precedence(st.Peek())>=precedence(ch)){
          prefix+=st.Pop();
        }
        st.Push(ch);
      }
    }
    while(st.Count!=0){
      prefix+=st.Pop();
    }
    prefix=stringReverse(prefix);
    Console.Write(prefix);
  }
}