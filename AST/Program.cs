using System;
using System.IO;
using Antlr4.Runtime;

namespace AST
{
    static class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    // Generate AST
                    Console.ReadLine();
                    var code = File.ReadAllText(args[0]);
                    var inputStream = new AntlrInputStream(code);
                    var lexer = new LixirLexer(inputStream);
                    var tokenStream = new CommonTokenStream(lexer);
                    var parser = new LixirParser(tokenStream);

                    var visitor = new Visitor();
                    var tree = parser.lixir_parser();
                    var result = visitor.VisitLixir_parser(tree);
                
                    // Semantic check
                    var checker = new AstCheckVisitor();
                    checker.Visit(result);
                    
                    // Transpile
                    var transpiler = new AstVisitor();
                    var transpiledCode = transpiler.Visit(result);
                    File.WriteAllText(args[1], transpiledCode);
                    
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
