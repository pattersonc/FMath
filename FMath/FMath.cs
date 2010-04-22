using System;

namespace FMath
{
    public static class FMath<T>
    {
        public static T Evaluate(Action<FMathExpression<T>> result)
        {
            var expression = new FMathExpression<T>();

            result(expression);

            return expression.Execute();
        }

        public static FMathExpression<T> Start(T value)
        {
            return new FMathExpression<T>().StartWith(value);
        }

    }
}