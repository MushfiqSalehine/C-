using System.IO;
using System;
using System.Collections.Generic;
class Program
{
  static void Main()
  {
    int n=Convert.ToInt32(Console.ReadLine());
    info[] tree=new info[n];
    for(int i=0;i<n;i++){
      var x=Console.ReadLine().Split();
      tree[i].nodeId=Convert.ToInt32(x[0]);
      tree[i].nodeName=Convert.ToString(x[1]);
      tree[i].parentId=Convert.ToInt32(x[2]);
    }
    foreach(var el in tree){
      Console.Write(el.nodeId+" ");
      Console.Write(el.nodeName+" ");
      Console.Write(el.parentId+" ");
      Console.WriteLine();
    }
    Dictionary<int,info>trackNode=new Dictionary<int,info>();
    foreach(var el in tree){
      trackNode[el.nodeId]=el;
    }
    foreach(var el in trackNode){
      Console.WriteLine(el.Key+" "+el.Value.nodeName);
    }
  }
}
struct info
{
  public int nodeId;
  public string nodeName;
  public int parentId;
}