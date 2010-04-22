namespace FMath 
{
  public partial class FMathExpression<T>
  {
        public static class Operations
        {
            public static T Add(T arg1, T arg2)
            {
                dynamic a1 = arg1, a2 = arg2;
                return a1 + a2;
            }

            public static T Subtract(T arg1, T arg2)
            {
                dynamic a1 = arg1, a2 = arg2;
                return a1 - a2;
            }
        }
    }
}
