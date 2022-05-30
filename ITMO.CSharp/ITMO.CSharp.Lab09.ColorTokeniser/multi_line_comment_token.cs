
namespace ITMO.CSharp.Lab09.ColorTokeniser {
    internal sealed class MultiLineComment {
        internal static bool Match(Position begin, Position end) {
            return (end - begin >= 2 && Utility.Equal(begin, begin + 2, "/*"));
        }
        internal static Position Eat(Position begin, Position end) {
            return Utility.AdjacentFind(begin, end, starForwardSlash);
        }
        internal static
        ICommentToken MakeToken(Position begin, Position end) {
            return new MultiLineCommentToken(begin, end);
        }
        private sealed class MultiLineCommentToken : Token, ICommentToken {
            internal MultiLineCommentToken(Position begin, Position end)
              : base(begin, end) {
            }
            internal override void Accept(ITokenVisitor visitor) {
                visitor.Visit(this);
            }
        }
        private static readonly StarForwardSlash starForwardSlash
            = new StarForwardSlash();
        private sealed class StarForwardSlash : Utility.IPredicate2 {
            public bool Execute(char previous, char current) {
                return previous == '*' && current == '/';
            }
        }
        private MultiLineComment() { }
    }
}
