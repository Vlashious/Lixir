namespace AST
{
    public abstract class AstAbstractVisitor<T>
    {
        public abstract T Visit(IntegerLiteral intLit);
        public abstract T Visit(StringLiteral stringLit);
        public abstract T Visit(AttributeLiteral attrLit);
        public abstract T Visit(VariableLiteral varLit);
        public abstract T Visit(NodeLiteral nodeLit);
        public abstract T Visit(IntegerVariable intVar);
        public abstract T Visit(StringVariable stringVar);
        public abstract T Visit(AttributeVariable attributeVariable);
        public abstract T Visit(NodeVariable nodeVar);
        public abstract T Visit(NodeWithChildren mother);
        public abstract T Visit(NameManipulation nameManipulation);
        public abstract T Visit(ValueManipulation valueManipulation);
        public abstract T Visit(InnerMethodManipulation innerMethod);
        public abstract T Visit(AddChildManipulation addChild);
        public abstract T Visit(RemoveChildManipulation removeChild);
        public abstract T Visit(VariableAssignmentManipulation varAssign);
        public abstract T Visit(BooleanExpression booleanExpression);
        public abstract T Visit(RangeOperator rangeOperator);
        public abstract T Visit(LoopBlock loopBlock);
        public abstract T Visit(CodeBlock codeBlock);
        public abstract T Visit(ConditionalBlock conditionalBlock);
        public abstract T Visit(BooleanHasChildExpression hasChildExpression);
        public abstract T Visit(MethodDeclaration methodDeclaration);
        public abstract T Visit(ReturnInstruction returnInstruction);
        public abstract T Visit(MethodVariable methodVariable);
        public abstract T Visit(MethodCall methodCall);

        public T Visit(Node node)
        {
            return Visit((dynamic) node);
        }
    }
}