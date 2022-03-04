using System;
using System.Collections.Generic;
namespace graphDataStructure
{
  static public int mxn=10000;
  class graph
  {
    public List<int> arr;
    public int node;
    public LinkedList<int>[] adj;
    public int []vis;
    public graph(int n) /// Constructor
    {
      vis=new int [n+1];
      arr=new List<int>();
      node=n;
      adj=new LinkedList<int>[n+1];
      for(int i=0;i<=n;i++){
        vis[i]=0;
        adj[i]=new LinkedList<int>();
      }
    }
    public void addEdge(int u,int v)
    {
      adj[u].AddLast(v);
      adj[v].AddLast(u);
    }
    public void printGraph()
    {
      for(int i=1;i<adj.Length;i++){
        Console.Write("{0} -> ",i);
        foreach(int item in adj[i]){
          Console.Write("{0} ",item);
        }
        Console.WriteLine();
      }
    }
    public void dfs(int src)
    {
      vis[src]=1;
      arr.Add(src);
      foreach(int item in adj[src]){
        if(vis[item]==0){
          dfs(item);
        }
      }
    }
  }
  class program
  {
    static void Main()
    {
      int n=Convert.ToInt32(Console.ReadLine());
      int m=Convert.ToInt32(Console.ReadLine());
      graph obj=new graph(n);
      for(int i=0;i<m;i++){
        var x=Console.ReadLine().Split();
        int u=Convert.ToInt32(x[0]);
        int v=Convert.ToInt32(x[1]);
        obj.addEdge(u,v);
      }
      obj.printGraph();
      obj.dfs(1);
      /// Print dfs traversal array
      for(int i=0;i<obj.arr.Count;i++){
        Console.Write(obj.arr[i]+" ");
      }
    }
  }
}
/*
Input:
5
6
1 2
1 3
2 5
3 5
4 5
3 2
*/