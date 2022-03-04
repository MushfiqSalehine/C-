using System;
class program
{
  static void Main()
  {
    string leftAlignedText="1\r\n1 1\r\n1 2 1\r\n1 3 3 1\r\n1 4 6 4 1\r\n";
    string rightAlignedText=leftToRight(leftAlignedText);
    Console.WriteLine(leftAlignedText);
    Console.WriteLine(rightAlignedText);
  }
  static string leftToRight(string text)
  {
    string[] seperator={"\r\n"};
    string[] line=text.Split(seperator,StringSplitOptions.RemoveEmptyEntries);
    int width=line[line.Length-1].Length;
    string rightAlignedText="";
    for(int i=0;i<line.Length;i++){
      int space=width-line[i].Length;
      rightAlignedText+=generateSpaces(space);
      rightAlignedText+=line[i]+"\r\n";
    }
    return rightAlignedText;
  }
  static string generateSpaces(int space)
  {
    string sp="";
    for(int i=0;i<space;i++){
      sp+=" ";
    }
    return sp;
  }
}