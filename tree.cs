using System.IO;
using System;
using System.Collections.Generic;
class Program
{
  static public Dictionary<int,info>trackNode=new Dictionary<int,info>();
  static public List<List<int>>adj=new List<List<int>>();
  static void dfs(int src,int par,string s)
  {
    Console.WriteLine(s+trackNode[src].nodeName);
    foreach(var el in adj[src]){
      if(el!=par){
        dfs(el,src,s+"   ");
      }
    }
  }
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
      trackNode[el.nodeId]=el;
    }
    for(int i=1;i<=500;i++){
      adj.Add(new List<int>());
    }
    List<int>root=new List<int>();
    foreach(var el in tree){
      if(el.parentId==-1){
        root.Add(el.nodeId);
      }
      else{
        int u=el.nodeId,v=el.parentId;
        adj[u].Add(v);
        adj[v].Add(u);
      }
    }
    foreach(int el in root){
      dfs(el,-1,"");
    }
  }
}
struct info
{
  public int nodeId;
  public string nodeName;
  public int parentId;
}