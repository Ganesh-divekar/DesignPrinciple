using System;
using Xunit;
using SyntaxHighlighting;
using System.Collections.Generic;
namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReplaceTextWithKeyword()
        {            
            string[] inputKeywords = {"as", "we", "if", "then"};
			const string toDecorateWith = "[blue]";
            string statementToSearchIn = "if we write";
            KeywordHighlighter highlighter=new  KeywordHighlighter(toDecorateWith,inputKeywords) ;    
            string output= highlighter.HighlightKeyword(statementToSearchIn);
            Assert.Equal(string.Concat(toDecorateWith, "if", toDecorateWith, toDecorateWith, "we", toDecorateWith, "write"), output);
        }

        [Fact]
        public void ShouldReplaceTextWithKeywordCase2()
        {            

            Keyword key1= new Keyword("if","blue");
            Keyword key2 = new Keyword("we","red");
            List<Keyword> lstkw = new  List<Keyword>();
            lstkw.Add(key1);
            lstkw.Add(key2);
            string statementToSearchIn = "if we write";
            KeywordHighlighterCase2 highlighter=new  KeywordHighlighterCase2(lstkw) ;    
            string output= highlighter.HighlightKeyword(statementToSearchIn);
            Assert.Equal(string.Concat("[",key1.Color,"]", "if", "[",key1.Color,"]", "[",key2.Color,"]", "we", "[",key2.Color,"]", "write"), output);
        }
    }
}
