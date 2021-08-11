namespace Scheme.Expression
{
    /// <summary>
    /// The built-in procedure for number add '+'
    /// </summary>
    public class NumberAdd : IExpression
    {
        /// <inheritdoc/>
        public ExpressionType Type
        {
            get
            {
                return ExpressionType.OPERATORADD;
            }
            set;
        }

        public IExpression[] SubExpressions { get; set; }


    }
}
