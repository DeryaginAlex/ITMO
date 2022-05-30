
namespace ITMO.CSharp.Lab09.ColorTokeniser {
    internal sealed class LineEnd {
        internal sealed class Token : ILineEndToken {
            private int number;
            internal Token(int number) {
                this.number = number;
            }
            public static Token operator ++(Token t) {
                t.number++;
                return t;
            }
            int ILineEndToken.Number() {
                return number;
            }
        }
    }
}
