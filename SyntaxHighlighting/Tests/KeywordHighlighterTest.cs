using System;
using Xunit;
using SyntaxHighlighting;

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
            //Assert.Equal(output, output + "1");
            Assert.Equal(string.Concat(toDecorateWith, "if", toDecorateWith, toDecorateWith, "we", toDecorateWith, "write"), output);



        }
    }
}
