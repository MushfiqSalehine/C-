using System;
using System.Collections.Generic;
class program
{
  public static bool isOperator(char ch)
  {
    return ch=='+' || ch=='-' || ch=='/' || ch=='*' || ch=='^';
  }
  public static void inorder(node cur)
  {
    if(cur==null){
      return ;
    }
    inorder(cur.left);
    Console.Write(cur.nodeId);
    inorder(cur.right);
  }
  static void Main()
  {
    string prefix=Console.ReadLine();
    node x;
    node y;
    node z;
    Stack<node>st=new Stack<node>();
    for(int i=prefix.Length-1;i>=0;i--){
      char ch=prefix[i];
      if(isOperator(ch)){
        x=st.Pop();
        y=st.Pop();
        z=new node(ch);
        z.left=x;
        z.right=y;
        st.Push(z);
      }
      else{
        z=new node(ch);
        st.Push(z);
      }
    }
    Console.Write("Postorder -> ");
    inorder(st.Peek());
  }
}
public class node
{
  public char nodeId;
  public node left;
  public node right;
  public node(char ch)
  {
    this.nodeId=ch;
    this.left=null;
    this.right=null;
  }
}