namespace FMath
{
    public static class FMathExpressionExtensions
    {
        public static FMathExpression<T> Start<T>(this T value)
        {
            return new FMathExpression<T>().StartWith(value);
        }
    }
}