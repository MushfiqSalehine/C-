using System;
class program
{
  static string textAlign(string text,int width,bool type)
  {
    string[] words=text.Split();
    string res="";
    int i=0;
    while(i<words.Length){
      int cur=i,wordPick=0,letterPick=0;
      while(i<words.Length && wordPick+letterPick+words[i].Length<=width){
        wordPick++;
        letterPick+=words[i].Length;
        i++;
      }
      string spaces="";
      if(type==true){
        spaces+=generateSpaces(width-(wordPick+letterPick-1));
      }
      res+=spaces;
      for(int j=cur;j<i;j++){
        res+=words[j];
        if(j!=i-1){
          res+=" ";
        }
      }
      res+="\r\n";
    }
    return res;
  }
  static string generateSpaces(int cn)
  {
    string sp="";
    while(cn>0){
      sp+=" ";
      cn--;
    }
    return sp;
  }
  static void Main()
  {
    string str=Console.ReadLine();
    int width=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(textAlign(str,width,true));
    Console.WriteLine("-----------------------");
    Console.WriteLine(textAlign(str,width,false));
  }
}