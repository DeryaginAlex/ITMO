
namespace ITMO.CSharp.Lab09.ColorTokeniser {

    internal abstract class Token : IToken {
        protected Token(Position begin, Position end) {
            this.begin = begin;
            this.end = end;
        }
        public override string ToString() {
            return Position.MakeString(begin, end);
        }
        internal abstract void Accept(ITokenVisitor visitor);
        private readonly Position begin, end;
    }
}

