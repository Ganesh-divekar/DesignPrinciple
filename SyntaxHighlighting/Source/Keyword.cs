using System;
namespace SyntaxHighlighting
{
    public class Keyword
    {
        public string InputKeyword {get;private set;}
        public string Color {get;private set;}

        public Keyword(string keyword,string color)
        {
            this.InputKeyword = keyword;
            this.Color = color;
        }
    }
}
