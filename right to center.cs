using System;
class program
{
  static void Main()
  {
    string rightAlignedText="        1\r\n      1 1\r\n    1 2 1\r\n  1 3 3 1\r\n1 4 6 4 1\r\n";
    string centerAlignedText=rightToCenter(rightAlignedText);
    Console.WriteLine(rightAlignedText);
    Console.WriteLine(centerAlignedText);
  }
  static string rightToCenter(string text)
  {
    string[] seperator={"\r\n"};
    string[] line=text.Split(seperator,StringSplitOptions.RemoveEmptyEntries);
    for(int i=0;i<line.Length;i++){
      line[i]=line[i].Trim();
    }
    int width=line[line.Length-1].Length;
    string centerAlignedText="";
    for(int i=0;i<line.Length;i++){
      int space=(width-line[i].Length)/2;
      centerAlignedText+=generateSpaces(space);
      centerAlignedText+=line[i]+"\r\n";
    }
    return centerAlignedText;
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