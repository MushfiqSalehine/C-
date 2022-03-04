using System;
using System.Collections.Generic;
class program
{
  static public List<List<int>>adj=new List<List<int>>();
  static void Main()
  {
    int n=Convert.ToInt32(Console.ReadLine());
    for(int i=0;i<=n;i++){
      adj.Add(new List<int>());
    }
    for(int i=0;i<n-1;i++){
      var x=Console.ReadLine().Split();
      int u=Convert.ToInt32(x[0]);
      int v=Convert.ToInt32(x[1]);
      adj[u].Add(v);
      adj[v].Add(u);
    }
    Queue<int>qu=new Queue<int>();
    bool[] vis=new bool[n+5];
    qu.Enqueue(1);
    vis[1]=true;
    while(qu.Count!=0){
      int u=qu.Dequeue();
      Console.WriteLine(u+" ");
      foreach(int el in adj[u]){
        if(vis[el]==false){
          qu.Enqueue(el);
          vis[el]=true;
        }
      }
    }
  }
}