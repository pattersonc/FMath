using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;
using Microsoft.CSharp;

namespace FMath
{
    public static class CSharpMathParser
    {
        private static readonly string source =
@"class MyType
{
    public static <!type!> Evaluate()
    {
        return <!expression!>;
    }
}";
        public static T Parse<T>(string expression)
        {
            string finalSource = source.Replace("<!expression!>", expression).Replace("<!type!>", typeof(T).FullName);

            CodeSnippetCompileUnit compileUnit = new CodeSnippetCompileUnit(finalSource);
            CodeDomProvider provider = new CSharpCodeProvider();

            CompilerParameters parameters = new CompilerParameters();

            CompilerResults results = provider.CompileAssemblyFromDom(parameters, compileUnit);

            Type type = results.CompiledAssembly.GetType("MyType");
            MethodInfo method = type.GetMethod("Evaluate");

            // The first parameter is the instance to invoke the method on. Because our Evaluate method is static, we pass null.
            var result = method.Invoke(null, null);

            return (T) Convert.ChangeType(result, typeof(T));
        }
    }
}