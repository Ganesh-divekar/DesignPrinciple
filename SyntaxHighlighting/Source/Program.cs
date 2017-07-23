using System;
using System.Text;


namespace SyntaxHighlighting
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            
            string[] inputKeywords = {"as", "we", "if", "then"};
			const string toDecorateWith = "[blue]";
            string statementToSearchIn = "If we write a program and compile it, then we can run the program to get output";
             KeywordHighlighter highlighter=new  KeywordHighlighter(toDecorateWith,inputKeywords) ;    
             string output= highlighter.HighlightKeyword(statementToSearchIn);
            Console.WriteLine(output);
        }
    }
}
