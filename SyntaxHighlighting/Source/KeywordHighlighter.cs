using System;
using System.Text;
namespace SyntaxHighlighting
{

public class KeywordHighlighter
{
    public string ToDecorateWith {get;private set;}
    public string [] InputKeywords {get;private set;}

    public KeywordHighlighter(string toDecorateWith,string [] inputKeywords)
    {
        this.ToDecorateWith = toDecorateWith;
        this.InputKeywords = inputKeywords;
    }
    public string HighlightKeyword(string statementToSearchIn)
    {
   
      var searchInArray = statementToSearchIn.Split(' ');
            var stringBuilder = new StringBuilder();
            foreach(var item in searchInArray){
                if(Array.IndexOf(InputKeywords, item.ToLower())>-1){					
                    stringBuilder.Append(string.Concat(ToDecorateWith, item, ToDecorateWith));


                }
                else
                {
                    stringBuilder.Append(item);
                }
            }

            return stringBuilder.ToString();

    }
}
}