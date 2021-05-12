using System;
using System.Collections.Generic;
using System.Linq;

namespace AST
{
    public class AstCheckVisitor: AstAbstractVisitor<bool>
    {
        private Dictionary<string, string> _declaredVariables = new();
        private Dictionary<string, string> _declaredMethods = new();
        public override bool Visit(IntegerLiteral intLit)
        {
            return true;
        }

        public override bool Visit(StringLiteral stringLit)
        {
            return true;
        }

        public override bool Visit(AttributeLiteral attrLit)
        {
            return true;
        }

        public override bool Visit(VariableLiteral varLit)
        {
            return true;
        }

        public override bool Visit(NodeLiteral nodeLit)
        {
            return true;
        }

        public override bool Visit(IntegerVariable intVar)
        {
            if (_declaredVariables.ContainsKey(intVar.Name))
            {
                throw new Exception($"Duplicate variable {intVar.Name} declaration...");
            }
            _declaredVariables.Add(intVar.Name, "int");
            return true;
        }

        public override bool Visit(StringVariable stringVar)
        {
            if (_declaredVariables.ContainsKey(stringVar.Name))
            {
                throw new Exception($"Duplicate {stringVar.Name} variable declaration...");
            }
            _declaredVariables.Add(stringVar.Name, "string");
            return true;
        }

        public override bool Visit(AttributeVariable attributeVariable)
        {
            if (_declaredVariables.ContainsKey(attributeVariable.VariableName))
            {
                throw new Exception($"Duplicate {attributeVariable.VariableName} variable declaration...");
            }
            _declaredVariables.Add(attributeVariable.VariableName, "_attribute");
            return true;
        }

        public override bool Visit(NodeVariable nodeVar)
        {
            if (_declaredVariables.ContainsKey(nodeVar.VariableName))
            {
                throw new Exception($"Duplicate {nodeVar.VariableName} variable declaration...");
            }
            _declaredVariables.Add(nodeVar.VariableName, "_node");
            return true;
        }

        public override bool Visit(NodeWithChildren mother)
        {
            foreach (var childNode in mother.ChildrenNodes)
            {
                Visit(childNode);
            }

            return true;
        }

        public override bool Visit(NameManipulation nameManipulation)
        {
            if (!_declaredVariables.ContainsKey(nameManipulation.VariableName))
            {
                throw new Exception($"Using undeclared variable {nameManipulation.VariableName}...");
            }

            var varType = _declaredVariables[nameManipulation.VariableName];

            if (varType == "attribute" || varType == "node")
            {
                
            }
            else
            {
                throw new Exception($"Wrong type of {varType}... Attribute or node type is expected.");
            }

            return true;
        }

        public override bool Visit(ValueManipulation valueManipulation)
        {
            if (!_declaredVariables.ContainsKey(valueManipulation.VariableName))
            {
                throw new Exception($"Using undeclared variable {valueManipulation.VariableName}...");
            }

            var varType = _declaredVariables[valueManipulation.VariableName];

            if (varType == "attribute" || varType == "node")
            {
                
            }
            else
            {
                throw new Exception($"Wrong type of {varType}... Attribute or node type is expected.");
            }
            

            return true;
        }

        public override bool Visit(InnerMethodManipulation innerMethod)
        {
            if (!_declaredVariables.ContainsKey(innerMethod.VariableName))
            {
                throw new Exception($"Undeclared variable {innerMethod.VariableName}...");
            }
            return true;
        }

        public override bool Visit(AddChildManipulation addChild)
        {
            if (!_declaredVariables.ContainsKey(addChild.VariableName))
            {
                throw new Exception($"Undeclared variable {addChild.VariableName}...");
            }
            return true;
        }

        public override bool Visit(RemoveChildManipulation removeChild)
        {
            if (!_declaredVariables.ContainsKey(removeChild.VariableName))
            {
                throw new Exception($"Undeclared variable {removeChild.VariableName}...");
            }
            return true;
        }

        public override bool Visit(VariableAssignmentManipulation varAssign)
        {
            if (!varAssign.VariableName.Contains("var") && !_declaredVariables.ContainsKey(varAssign.VariableName))
            {
                throw new Exception($"Undeclared variable {varAssign.VariableName}...");
            }
            return true;
        }

        public override bool Visit(BooleanExpression booleanExpression)
        {
            return true;
        }

        public override bool Visit(RangeOperator rangeOperator)
        {
            return true;
        }

        public override bool Visit(LoopBlock loopBlock)
        {
            return true;
        }

        public override bool Visit(CodeBlock codeBlock)
        {
            return true;
        }

        public override bool Visit(ConditionalBlock conditionalBlock)
        {
            return true;
        }

        public override bool Visit(BooleanHasChildExpression hasChildExpression)
        {
            if (!_declaredVariables.ContainsKey(hasChildExpression.VariableName))
            {
                throw new Exception($"Undeclared variable {hasChildExpression.VariableName}...");
            }
            return true;
        }

        public override bool Visit(MethodDeclaration methodDeclaration)
        {
            if (_declaredMethods.ContainsKey(methodDeclaration.MethodName))
            {
                throw new Exception($"Method {methodDeclaration.MethodName} is already declared...");
            }
            _declaredMethods.Add(methodDeclaration.MethodName, methodDeclaration.ReturnType);
            return true;
        }

        public override bool Visit(ReturnInstruction returnInstruction)
        {
            return true;
        }

        public override bool Visit(MethodVariable methodVariable)
        {
            return true;
        }

        public override bool Visit(MethodCall methodCall)
        {
            return true;
        }
    }
}