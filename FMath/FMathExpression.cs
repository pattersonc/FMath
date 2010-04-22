using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FMath
{
    public partial class FMathExpression<T>
    {
        private StringBuilder expression = new StringBuilder();

        public static implicit operator T(FMathExpression<T> arg)
        {
            return arg.Value;
        }

        public T Value
        {
            get
            {
                return Execute();
            }
        }

        public FMathExpression<T> Add(T value)
        {
            expression.Append("+" + value);

            return this;
        }

        public FMathExpression<T> Subtract(T value)
        {
            expression.Append("-" + value);

            return this;
        }

        public FMathExpression<T> Multiply(T value)
        {
            expression.Append("*" + value);

            return this;
        }

        public FMathExpression<T> Divide(T value)
        {
            expression.Append("/" + value);

            return this;
        }

        public T Execute()
        {
            return CSharpMathParser.Parse<T>(expression.ToString());
        }

        public FMathExpression<T> StartWith(T value)
        {
            expression.Append(value);
            return this;
        }

    }

}
