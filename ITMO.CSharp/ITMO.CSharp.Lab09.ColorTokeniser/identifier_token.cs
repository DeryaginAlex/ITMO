namespace ITMO.CSharp.Lab09.ColorTokeniser {
    using Ctype = System.Char;
    internal sealed class Identifier {
        internal static bool Match(Position begin, Position end) {
            if(begin == end) {
                return false;
            }
            char read = begin.Get();
            return Ctype.IsLetter(read) || read == '_';
        }
        internal static Position Eat(Position begin, Position end) {
            return Utility.FindIf(begin, end, notIdentifier);
        }
        internal static
        IIdentifierToken MakeToken(Position begin, Position end) {
            return new IdentifierToken(begin, end);
        }
        private sealed class IdentifierToken : Token, IIdentifierToken {
            internal IdentifierToken(Position begin, Position end)
              : base(begin, end) {
            }
            internal override void Accept(ITokenVisitor visitor) {
                visitor.Visit(this);
            }
        }
        private static readonly NotIdentifier notIdentifier
            = new NotIdentifier();

        private sealed class NotIdentifier : Utility.IPredicate1 {
            public bool Execute(char current) {
                return !(Ctype.IsLetter(current)
                      || Ctype.IsDigit(current)
                      || current == '_');
            }
        }
        private Identifier() { }
    }
}
