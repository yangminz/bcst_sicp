namespace Scheme.Expression
{
    /// <summary>
    /// The interface of a common expression in Scheme
    /// </summary>
    public interface IExpression
    {
        /// <summary>
        /// The type of this expression
        /// </summary>
        public ExpressionType Type { get; set; }

        /// <summary>
        /// The sub-expressions of this expression
        /// </summary>
        public IExpression[] SubExpressions { get; set; }

        /// <summary>
        /// The evaluation method
        /// First, evaluate all sub-expressions in any order
        /// Then apply the value of first sub-expression to all other
        /// </summary>
        /// <returns>The evaluated expression. It can be a primitive type or expression type</returns>
        public IExpression Evaluate();
    }
}
