using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AST
{
    public class AstVisitor : AstAbstractVisitor<string>
    {
        private Dictionary<string, Node> _declaredVariables = new();
        public override string Visit(IntegerLiteral intLit)
        {
            return intLit.Value.ToString();
        }

        public override string Visit(StringLiteral stringLit)
        {
            return stringLit.Value;
        }

        public override string Visit(AttributeLiteral attrLit)
        {
            var attrValue = Visit(attrLit.Value);
            return $"({attrLit.Name}, {attrValue})";
        }

        public override string Visit(VariableLiteral varLit)
        {
            return $"{varLit.Name}";
        }

        public override string Visit(NodeLiteral nodeLit)
        {
            var nodeDecl = new StringBuilder();
            var liters = new List<Node>();
            liters.AddRange(nodeLit.Attributes);
            liters.AddRange(nodeLit.ChildNodes);
            if (liters.Count > 0)
            {
            
                foreach (var liter in liters)
                {
                    if (nodeLit.Attributes.Contains(liter))
                    {
                        nodeDecl.AppendLine($"_fac._attr{Visit(liter)}");
                    }

                    if (nodeLit.ChildNodes.Contains(liter))
                    {
                        nodeDecl.AppendLine($"_fac._node{Visit(liter)}");
                    }

                    if (liters[^1] != liter) nodeDecl.AppendLine(",");
                }

                return $"({nodeLit.Name}, {nodeDecl})";   
            }

            return $"({nodeLit.Name})";
        }

        public override string Visit(IntegerVariable intVar)
        {
            _declaredVariables.Add(intVar.Name, intVar);
            return $"var {intVar.Name} = {intVar.Value};";
        }

        public override string Visit(StringVariable stringVar)
        {
            _declaredVariables.Add(stringVar.Name, stringVar);
            return $"var {stringVar.Name} = {stringVar.Value}";
        }

        public override string Visit(AttributeVariable attributeVariable)
        {
            _declaredVariables.Add(attributeVariable.VariableName, attributeVariable);
            var literal = Visit(attributeVariable.Literal);
            return $@"_attribute {attributeVariable.VariableName} = new{literal};";
        }

        public override string Visit(NodeVariable nodeVar)
        {
            _declaredVariables.Add(nodeVar.VariableName, nodeVar);
            var literal = Visit(nodeVar.Literal);
            return $"_node {nodeVar.VariableName} = new{literal};";
        }

        public override string Visit(NodeWithChildren mother)
        {
            var code = new StringBuilder();
            code.AppendLine(@"
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
record _lixirType 
{
    public string Name {get; set;}
    public _lixirType(string name)
    {
        Name = name;
    }
    public virtual string _Save() {return ""Error"";}
}
record _attribute : _lixirType
{
    public object Value {get; set;}
    public _attribute(string name, object value) : base(name)
    {
        Value = value;
    }
    public override string _Save()
    {
        return $""<{Name}>{Value.ToString()}</{Name}>"";
    }
}
record _node : _lixirType
{
    public List<_lixirType> Value {get; set;}
    public _node(string name, params _lixirType[] value) : base(name)
    {
        Value = value.ToList();
    }
    public void _add(_lixirType value)
    {
        Value.Add(value);
    }
    public void _remove(string name)
    {
        var valToRemove = Value.SingleOrDefault(val => val.Name == name);
        Value.Remove(valToRemove);
    }
    public bool _has(string name)
    {
        return Value.SingleOrDefault(val => val.Name == name) != default;
    }
    public override string _Save()
    {
        var xml = new StringBuilder();
        xml.AppendLine($""<{Name}>"");
        foreach (var node in Value)
        {
            xml.AppendLine(node._Save());
        }
        xml.AppendLine($""</{Name}>"");
        return xml.ToString();
    }
}
static class _fac
{
    public static _attribute _attr(object name, object value) => new(name.ToString(), value);
    public static _node _node(object name, params _lixirType[] value) => new(name.ToString(), value);
}
public static class Transpiled
{
    static IEnumerable<int> Range(int from, int to)
    {
        for(int i = from; i < to; i++)
        {
            yield return i;
        }
    }
");
            code.AppendLine("public static void Main() {");
            foreach (var child in mother.ChildrenNodes)
            {
                var codeLine = Visit(child);
                code.AppendLine(codeLine);
            }

            code.AppendLine("}");
            code.AppendLine("}");

            return code.ToString();
        }

        public override string Visit(NameManipulation nameManipulation)
        {
            return $"{nameManipulation.VariableName}.Name = {nameManipulation.NewNamePropertyValue};";
        }

        public override string Visit(ValueManipulation valueManipulation)
        {
            return $"{valueManipulation.VariableName}.Value = {valueManipulation.NewValue};";
        }

        public override string Visit(InnerMethodManipulation innerMethod)
        {
            switch (innerMethod.MethodName)
            {
                case ".Save":
                    return $@"
{{
    var xml = {innerMethod.VariableName}._Save();
    File.WriteAllText({innerMethod.Argument}, xml);
}}";
                case ".Open":
                    return "";
            }

            return "";
        }

        public override string Visit(AddChildManipulation addChild)
        {
            var code = new StringBuilder();
            switch (addChild.Child)
            {
                case AttributeLiteral atrLit:
                    code.Append($"{addChild.VariableName}._add(_fac._attr{Visit(addChild.Child)});");
                    break;
                case NodeLiteral nodeLit:
                    code.Append($"{addChild.VariableName}._add(_fac._node{Visit(addChild.Child)});");
                    break;
                case VariableLiteral varLit:
                    code.Append($"{addChild.VariableName}._add({varLit.Name});");
                    break;
            }

            return code.ToString();
        }

        public override string Visit(RemoveChildManipulation removeChild)
        {
            return $"{removeChild.VariableName}._remove({removeChild.NameOfChildToDelete});";
        }

        public override string Visit(VariableAssignmentManipulation varAssign)
        {
            return $"{varAssign.VariableName} = {Visit(varAssign.NewVariableValue)};";
        }

        public override string Visit(BooleanExpression booleanExpression)
        {
            var condVal = Visit(booleanExpression.Value);
            return $"{booleanExpression.VariableName} {booleanExpression.Op} {condVal}";
        }

        public override string Visit(RangeOperator rangeOperator)
        {
            return $"Range({rangeOperator.From}, {rangeOperator.To})";
        }

        public override string Visit(LoopBlock loopBlock)
        {
            var code = new StringBuilder();
            code.AppendLine($"foreach (var {loopBlock.LoopVariable} in {Visit(loopBlock.Iterable)})");
            code.AppendLine(Visit(loopBlock.Block));
            return code.ToString();
        }

        public override string Visit(CodeBlock codeBlock)
        {
            var block = new StringBuilder();
            block.AppendLine("{");
            foreach (var instruction in codeBlock.Instructions)
            {
                block.AppendLine(Visit(instruction));
            }
            block.AppendLine("}");
            return block.ToString();
        }

        public override string Visit(ConditionalBlock conditionalBlock)
        {
            var block = new StringBuilder();
            block.AppendLine($"if ({Visit(conditionalBlock.Condition)})");
            block.AppendLine(Visit(conditionalBlock.CodeBlock));
            if (conditionalBlock.ElseCodeBlock == default) return block.ToString();
            block.AppendLine("else");
            block.AppendLine(Visit(conditionalBlock.ElseCodeBlock));

            return block.ToString();
        }

        public override string Visit(BooleanHasChildExpression hasChildExpression)
        {
            return $"{hasChildExpression.VariableName}._has({hasChildExpression.ChildName})";
        }

        public override string Visit(MethodDeclaration methodDeclaration)
        {
            var code = new StringBuilder();
            code.Append($"{methodDeclaration.ReturnType} {methodDeclaration.MethodName} (");
            foreach (var methodVariable in methodDeclaration.MethodVariables)
            {
                code.Append(Visit(methodVariable));
                if (methodDeclaration.MethodVariables[^1] != methodVariable) code.Append(", ");
            }

            code.Append(")");
            code.Append(Visit(methodDeclaration.CodeBlock));

            return code.ToString();
        }

        public override string Visit(ReturnInstruction returnInstruction)
        {
            return $"return {Visit(returnInstruction.ReturnValue)};";
        }

        public override string Visit(MethodVariable methodVariable)
        {
            return $"{methodVariable.Type} {methodVariable.Name}";
        }

        public override string Visit(MethodCall methodCall)
        {
            return $"{methodCall.MethodName}({string.Join(", ", methodCall.Parameters.Select(Visit))})";
        }
    }
}