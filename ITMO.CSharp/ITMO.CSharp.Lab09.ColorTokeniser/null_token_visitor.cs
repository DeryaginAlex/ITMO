
namespace ITMO.CSharp.Lab09.ColorTokeniser
{
    public abstract class NullTokenVisitor : ITokenVisitor // Inherits from ITokenVisitor
    {
        // Compiler wouldn't let me proceed without implementing the methods listed below
        public virtual void Visit(ILineStartToken t)
        {
            //throw new System.NotImplementedException();
        }

        public virtual void Visit(ILineEndToken t)
        {
            //throw new System.NotImplementedException();
        }

        public virtual void Visit(ICommentToken t)
        {
            //throw new System.NotImplementedException();
        }

        public virtual void Visit(IDirectiveToken t)
        {
            //throw new System.NotImplementedException();
        }

        public virtual void Visit(IIdentifierToken t)
        {
            //throw new System.NotImplementedException();
        }

        public virtual void Visit(IKeywordToken t)
        {
            //throw new System.NotImplementedException();
        }

        public virtual void Visit(IWhiteSpaceToken t)
        {
            //throw new System.NotImplementedException();
        }

        public virtual void Visit(IOtherToken t)
        {
            //throw new System.NotImplementedException();
        }

      
    }
}
