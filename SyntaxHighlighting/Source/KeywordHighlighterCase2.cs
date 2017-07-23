using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace SyntaxHighlighting
{

public class KeywordHighlighterCase2
{    
    public List<Keyword> InputKeywords {get;private set;}

    public KeywordHighlighterCase2(List<Keyword> inputKeywords)
    {
         this.InputKeywords = inputKeywords;
    }
    public string HighlightKeyword(string statementToSearchIn)
    {
   
      var searchInArray = statementToSearchIn.Split(' ');
            var stringBuilder = new StringBuilder();
            foreach(var item in searchInArray){

               Keyword key= InputKeywords.FirstOrDefault(c=>c.InputKeyword==item);
                if(key!=null){					
                    stringBuilder.Append(string.Concat("[",key.Color,"]", item,"[" , key.Color,"]"));


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