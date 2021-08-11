namespace Scheme.Expression
{
    /// <summary>
    /// The type of one expression
    /// it can be built-in (primitive)  or compound
    /// </summary>
    public enum ExpressionType
    {
        // primitive types
        NUMBER,
        STRING,
        BOOLEAN,

        // operators for primitive types
        // rank-0 functions
        OPERATORADD,
        
        // higher rank functions
        EXPRESSION,
    }
}
