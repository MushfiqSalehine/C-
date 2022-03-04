using System;
class program
{
  static void Main()
  {
    string rightAlignedText="      1\r\n    1 2\r\n  1 2 3\r\n1 2 3 4";
    string leftAlignedText=rightToLeft(rightAlignedText);
    Console.WriteLine(rightAlignedText);
    Console.WriteLine(leftAlignedText);
  }
  static string rightToLeft(string text)
  {
    string[] seperator={"\r\n"};
    string[] line=text.Split(seperator,StringSplitOptions.RemoveEmptyEntries);
    string rightAlignedText="";
    for(int i=0;i<line.Length;i++){
      rightAlignedText+=line[i].Trim()+"\r\n";
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