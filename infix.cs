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
  static int precedence(char ch)
  {
    if(ch=='/' || ch=='*'){
      return 1;
    }
    if(ch=='+' || ch=='-'){
      return 0;
    }
    return -1;
  }
  static void Main()
  {
    string infix=Console.ReadLine();
    Stack<double>opn=new Stack<double>();
    Stack<char>opr=new Stack<char>();
    for(int i=0;i<infix.Length;i++){
      char ch=infix[i];
      if(isDigit(ch)){
        double num=0.0;
        while(i<infix.Length && isDigit(infix[i])){
          num=num*10.0+(infix[i]-'0');
          i++;
        }
        i--;
        opn.Push(num);
      }
      else if(ch=='('){
        opr.Push(ch);
      }
      else if(ch==')'){
        while(opr.Peek()!='('){
          double u=opn.Pop();
          double v=opn.Pop();
          char x=opr.Pop();
          opn.Push(operation(v,u,x));
        }
        opr.Pop();
      }
      else{
        while(opr.Count!=0 && precedence(opr.Peek())>=precedence(ch)){
          double u=opn.Pop();
          double v=opn.Pop();
          char x=opr.Pop();
          opn.Push(operation(v,u,x));
        }
        opr.Push(ch);
      }
    }
    while(opr.Count!=0){
      double u=opn.Pop();
      double v=opn.Pop();
      char x=opr.Pop();
      opn.Push(operation(v,u,x));
    }
    Console.WriteLine(opn.Peek());
  }
}