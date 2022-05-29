
namespace ITMO.CSharp.Lab09.ColorTokeniser
{
    using System;

    public sealed class HTMLTokenVisitor : ITokenVisitor
    {
        // Add methods here
        
        private void SpannedFilteredWhite(string spanName, IToken token)
        {
            Console.Write("<span class=\"{0}\">", spanName);
            FilteredWhite(token);
            Console.Write("</span>");

        }
        private void FilteredWhite(IToken token)
        {
            string src = token.ToString();
            for (int i = 0; i != src.Length; i++)
            {
                string dst;
                switch (src[i])
                {
                    case '<':
                        dst = "&lt;"; break;
                    case '>':
                        dst = "&gt;"; break;
                    case '&':
                        dst = "&amp;"; break;
                    default:
                        dst = new string(src[i], 1); break;
                }
                Console.Write(dst);
            }
        }

        public void Visit(IDirectiveToken token)
        {
            SpannedFilteredWhite("directive", token);
        }
        public void Visit(ILineStartToken line)
        {
            Console.Write("<span class=\"line_number\">");
            Console.Write("{0,3}", line.Number());
            Console.Write("</span>");

        }
        public void Visit(ILineEndToken t)
        {
            Console.WriteLine(); // Not Write
        }

        public void Visit(IIdentifierToken token)
        {
            SpannedFilteredWhite("identifier", token);
        }

        public void Visit(ICommentToken token)
        {
            SpannedFilteredWhite("comment", token);
        }

        public void Visit(IKeywordToken token)
        {
            SpannedFilteredWhite("keyword", token);

        }

        public void Visit(IOtherToken token)
        {
            FilteredWhite(token);
        }

        public void Visit(IWhiteSpaceToken token)
        {
            Console.Write(token.ToString());
        }
    }
}
