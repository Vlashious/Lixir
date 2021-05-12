using System.Collections.Generic;

public abstract class Node
{
}

public abstract class Literal : Node
{
}

public abstract class Manipulation : Node
{
}

public class IntegerLiteral : Literal
{
    public int Value { get; set; }
}

public class StringLiteral : Literal
{
    public string Value { get; set; }
}

public class AttributeLiteral : Literal
{
    public string Name { get; set; }
    public Literal Value { get; set; }
}

public class NodeLiteral : Literal
{
    public string Name { get; set; }
    public List<AttributeLiteral> Attributes { get; set; }
    public List<NodeLiteral> ChildNodes { get; set; }
}

public class VariableLiteral : Literal
{
    public string Name { get; set; }
}

public class MethodLiteral : Literal
{
    public string Name { get; set; }
}

public class NodeWithChildren : Node
{
    public List<Node> ChildrenNodes { get; set; } = new();
}

public class IntegerVariable : Node
{
    public string Name { get; set; }
    public int Value { get; set; }
}

public class StringVariable : Node
{
    public string Name { get; set; }
    public string Value { get; set; }
}

public class AttributeVariable : Node
{
    public string VariableName { get; set; }
    public AttributeLiteral Literal { get; set; }
}

public class NodeVariable : Node
{
    public string VariableName { get; set; }
    public NodeLiteral Literal { get; set; }
}

public class NameManipulation : Manipulation
{
    public string VariableName { get; set; }
    public string NewNamePropertyValue { get; set; }
}

public class ValueManipulation : Manipulation
{
    public string VariableName { get; set; }
    public Literal NewValue { get; set; }
}

public class AddChildManipulation : Manipulation
{
    public string VariableName { get; set; }
    public Literal Child { get; set; }
}

public class RemoveChildManipulation : Manipulation
{
    public string VariableName { get; set; }
    public string NameOfChildToDelete { get; set; }
}

public class InnerMethodManipulation : Manipulation
{
    public string VariableName { get; set; }
    public string MethodName { get; set; }
    public string Argument { get; set; }
}

public class VariableAssignmentManipulation : Manipulation
{
    public string VariableName { get; set; }
    public Node NewVariableValue { get; set; }
}

public class MathExpr : Node
{
    public string LeftOperand { get; set; }
    public string Op { get; set; }
    public string RightOperand { get; set; }
}

public class MethodVariable : Node
{
    public string Name { get; set; }
    public string Type { get; set; }
}

public class ReturnInstruction : Node
{
    public Literal ReturnValue { get; set; }
}

public class CodeBlock : Node
{
    public List<Node> Instructions { get; set; } = new();
}

public class MethodDeclaration : Node
{
    public string MethodName { get; set; }
    public List<MethodVariable> MethodVariables { get; set; } = new ();
    public string ReturnType { get; set; }
    public CodeBlock CodeBlock { get; set; }
}

public class MethodCall : Node
{
    public string MethodName { get; set; }
    public List<Literal> Parameters { get; set; } = new();
}

public class BooleanHasChildExpression : Node
{
    public string VariableName { get; set; }
    public string ChildName { get; set; }
}

public class BooleanExpression : Node
{
    public string VariableName { get; set; }
    public string Op { get; set; }
    public Node Value { get; set; }
}

public class RangeOperator : Node
{
    public int From { get; set; }
    public int To { get; set; }
}

public class LoopBlock : Node
{
    public string LoopVariable { get; set; }
    public Node Iterable { get; set; }
    public CodeBlock Block { get; set; }
}

public class ConditionalBlock : Node
{
    public Node Condition { get; set; }
    public CodeBlock CodeBlock { get; set; }
    public CodeBlock ElseCodeBlock { get; set; }
}