using System;
using System.Collections.Generic;

namespace AST
{
    public class Visitor : LixirBaseVisitor<Node>
    {
        public override NodeWithChildren VisitLixir_parser(LixirParser.Lixir_parserContext context)
        {
            var root = new NodeWithChildren();
            foreach (var codeContext in context.code())
            {
                var node = Visit(codeContext);
                root.ChildrenNodes.Add(node);
            }

            return root;
        }

        public override Node VisitVariable_declaration(LixirParser.Variable_declarationContext context)
        {
            var variableName = context.VALID_NAME(0).GetText();
            switch (context.var_type?.Type)
            {
                case LixirLexer.VALID_INTEGER:
                    return new IntegerVariable()
                        {Name = variableName, Value = int.Parse(context.VALID_INTEGER().GetText())};
                case LixirLexer.STRING_LINE:
                    return new StringVariable() {Name = variableName, Value = context.STRING_LINE().GetText()};
                case LixirLexer.ATTRIBUTE:
                {
                    if (context.attribute_literal() != default)
                    {
                        var attrLit = VisitAttribute_literal(context.attribute_literal());
                        return new AttributeVariable()
                            {VariableName = variableName, Literal = attrLit};
                    }

                    return new AttributeVariable()
                    {
                        VariableName = variableName
                    };
                }
                case LixirLexer.NODE:
                {
                    if (context.node_literal() != default)
                    {
                        var nodeLit = VisitNode_literal(context.node_literal());
                        return new NodeVariable()
                        {
                            VariableName = variableName,
                            Literal = nodeLit
                        };
                    }

                    return new NodeVariable()
                    {
                        VariableName = variableName
                    };
                }
            }

            return new VariableAssignmentManipulation
            {
                VariableName = $"var {variableName}",
                NewVariableValue = new VariableLiteral() {Name = context.VALID_NAME(1).GetText()}
            };
            
            throw new Exception("Something went wrong...");
        }

        public override Literal VisitType_literal(LixirParser.Type_literalContext context)
        {
            if (context.attribute_literal() != default)
            {
                return VisitAttribute_literal(context.attribute_literal());
            }

            if (context.node_literal() != default)
            {
                return VisitNode_literal(context.node_literal());
            }

            if (context.VALID_INTEGER() != default)
            {
                return new IntegerLiteral() {Value = int.Parse(context.VALID_INTEGER().GetText())};
            }

            if (context.STRING_LINE() != default)
            {
                return new StringLiteral() {Value = context.STRING_LINE().GetText()};
            }

            throw new Exception("Something went wrong...");
        }

        public override AttributeLiteral VisitAttribute_literal(LixirParser.Attribute_literalContext context)
        {
            var attributeName = "";
            if (context.STRING_LINE(0) != null)
            {
                attributeName = context.STRING_LINE(0).GetText();
            }
            else if (context.VALID_NAME(0) != null)
            {
                attributeName = context.VALID_NAME(0).GetText();
            }

            Literal attributeValue = null;
            if (context.STRING_LINE(1) != null)
            {
                attributeValue = new StringLiteral() {Value = context.STRING_LINE(1).GetText()};
            }

            if (context.VALID_INTEGER() != null)
            {
                attributeValue = new IntegerLiteral() {Value = int.Parse(context.VALID_INTEGER().GetText())};
            }

            if (context.VALID_NAME(1) != null)
            {
                attributeValue = new VariableLiteral() {Name = context.VALID_NAME(1).GetText()};
            }
            
            return new AttributeLiteral()
            {
                Name = attributeName,
                Value = attributeValue
            };
        }

        public override NodeLiteral VisitNode_literal(LixirParser.Node_literalContext context)
        {
            var nodeName = "";
            if (context.VALID_NAME() != null)
            {
                nodeName = context.VALID_NAME().GetText();
            }

            if (context.STRING_LINE() != null)
            {
                nodeName = context.STRING_LINE().GetText();
            }

            List<AttributeLiteral> attributes = new();
            foreach (var attributeLiteralContext in context.attribute_literal())
            {
                var attribute = VisitAttribute_literal(attributeLiteralContext);
                attributes.Add(attribute);
            }

            List<NodeLiteral> childNodes = new();
            foreach (var nodeLiteralContext in context.node_literal())
            {
                var childNode = VisitNode_literal(nodeLiteralContext);
                childNodes.Add(childNode);
            }

            return new NodeLiteral()
            {
                Name = nodeName,
                Attributes = attributes,
                ChildNodes = childNodes
            };
        }

        public override Node VisitVARIABLE_NAME_PROP(LixirParser.VARIABLE_NAME_PROPContext context)
        {
            return new NameManipulation()
            {
                VariableName = context.VALID_NAME().GetText(),
                NewNamePropertyValue = context.STRING_LINE().GetText()
            };
        }

        public override Node VisitVARIABLE_VALUE_PROP(LixirParser.VARIABLE_VALUE_PROPContext context)
        {
            var variableName = context.VALID_NAME(0).GetText();
            if (context.type_literal() != default)
            {
                var typeLiteral = VisitType_literal(context.type_literal());
                return new ValueManipulation()
                {
                    VariableName = variableName,
                    NewValue = typeLiteral
                };   
            }

            return new ValueManipulation()
            {
                VariableName = variableName,
                NewValue = new VariableLiteral()
                {
                    Name = context.VALID_NAME(1).GetText()
                }
            };
        }

        public override Node VisitVARIABLE_ADD_CHILD(LixirParser.VARIABLE_ADD_CHILDContext context)
        {
            var variableName = context.VALID_NAME(0).GetText();
            if (context.type_literal() != default)
            {
                var childLiteral = VisitType_literal(context.type_literal());
                return new AddChildManipulation()
                {
                    VariableName = variableName,
                    Child = childLiteral
                };
            }

            return new AddChildManipulation()
            {
                VariableName = variableName,
                Child = new VariableLiteral()
                {
                    Name = context.VALID_NAME(1).GetText()
                }
            };
        }

        public override Node VisitVARIABLE_REMOVE_CHILD(LixirParser.VARIABLE_REMOVE_CHILDContext context)
        {
            if (context.STRING_LINE() != default)
            {
                return new RemoveChildManipulation()
                {
                    VariableName = context.VALID_NAME(0).GetText(),
                    NameOfChildToDelete = context.STRING_LINE().GetText()
                };   
            }

            return new RemoveChildManipulation()
            {
                VariableName = context.VALID_NAME(0).GetText(),
                NameOfChildToDelete = context.VALID_NAME(1).GetText()
            };
        }

        public override Node VisitVARIABLE_INNER_METHOD(LixirParser.VARIABLE_INNER_METHODContext context)
        {
            var methodName = context.inner_method.Type switch
            {
                LixirLexer.OPEN_METH => context.OPEN_METH().GetText(),
                LixirLexer.SAVE_METH => context.SAVE_METH().GetText()
            };

            return new InnerMethodManipulation()
            {
                VariableName = context.VALID_NAME().GetText(),
                MethodName = methodName,
                Argument = context.STRING_LINE().GetText()
            };
        }

        public override Node VisitVARIABLE_ASSIGNMENT(LixirParser.VARIABLE_ASSIGNMENTContext context)
        {
            if (context.mathematics() != null)
            {
                var mathExpr = VisitMathematics(context.mathematics());
                return new VariableAssignmentManipulation()
                {
                    VariableName = context.VALID_NAME(0).GetText(),
                    NewVariableValue = mathExpr
                };
            }

            if (context.method_call() != null)
            {
                List<Literal> parameters = new();
                var methodCallContext = context.method_call();
                if (methodCallContext.type_literal() != null)
                {
                    foreach (var typeLiteralContext in methodCallContext.type_literal())
                    {
                        var literal = VisitType_literal(typeLiteralContext);
                        parameters.Add(literal);
                    }
                }

                if (methodCallContext.VALID_NAME() != null)
                {
                    for (int i = 1; i < methodCallContext.VALID_NAME().Length; i++)
                    {
                        var ctx = methodCallContext.VALID_NAME(i);
                        var variableLiteral = new VariableLiteral() {Name = ctx.GetText()};
                        parameters.Add(variableLiteral);
                    }
                }

                var methodCallNode = new MethodCall()
                {
                    MethodName = context.method_call().VALID_NAME(0).GetText(),
                    Parameters = parameters
                };
                return new VariableAssignmentManipulation()
                {
                    VariableName = context.VALID_NAME(0).GetText(),
                    NewVariableValue = methodCallNode
                };
            }

            return new VariableAssignmentManipulation
            {
                VariableName = context.VALID_NAME(0).GetText(),
                NewVariableValue = new VariableLiteral {Name = context.VALID_NAME(1).GetText()}
            };

            throw new Exception("Something went wrong...");
        }

        public override Node VisitMathematics(LixirParser.MathematicsContext context)
        {
            var leftOperand = "";
            var rightOperand = "";
            
            if (context.VALID_INTEGER(0) != null) leftOperand = context.VALID_INTEGER(0).GetText();
            if (context.VALID_INTEGER(1) != null) rightOperand = context.VALID_INTEGER(1).GetText();

            if (context.VALID_NAME(0) != null) leftOperand = context.VALID_NAME(0).GetText();
            if (context.VALID_NAME(1) != null) rightOperand = context.VALID_NAME(1).GetText();
            
            return new MathExpr()
            {
                LeftOperand = leftOperand,
                Op = context.op.Text,
                RightOperand = rightOperand
            };
        }

        public override MethodVariable VisitMethod_variable(LixirParser.Method_variableContext context)
        {
            var variableType = GetReturnType(context);
            return new MethodVariable()
            {
                Name = context.VALID_NAME().GetText(),
                Type = variableType
            };
        }

        public override Node VisitMethod(LixirParser.MethodContext context)
        {
            List<MethodVariable> variables = new();
            foreach (var methodVariableContext in context.method_variable())
            {
                var variable = VisitMethod_variable(methodVariableContext);
                variables.Add(variable);
            }

            var code = VisitCode_block(context.code_block());
            return new MethodDeclaration()
            {
                MethodName = context.VALID_NAME().GetText(),
                MethodVariables = variables,
                ReturnType = GetReturnType(context),
                CodeBlock = code
            };
        }

        public override CodeBlock VisitCode_block(LixirParser.Code_blockContext context)
        {
            CodeBlock block = new();
            foreach (var instructionContext in context.instruction())
            {
                var instruction = VisitInstruction(instructionContext);
                block.Instructions.Add(instruction);
            }

            return block;
        }

        public override Node VisitInstruction(LixirParser.InstructionContext context)
        {
            if (context.variable_declaration() != default)
            {
                return VisitVariable_declaration(context.variable_declaration());
            }

            if (context.variable_manipulation() != default)
            {
                return Visit(context.variable_manipulation());
            }

            if (context.return_instruction() != default)
            {
                return VisitReturn_instruction(context.return_instruction());
            }

            if (context.loop_instruction() != default)
            {
                return VisitLoop_instruction(context.loop_instruction());
            }

            if (context.conditional_instruction() != default)
            {
                return VisitConditional_instruction(context.conditional_instruction());
            }

            throw new Exception("Something went wrong...");
        }

        public override ReturnInstruction VisitReturn_instruction(LixirParser.Return_instructionContext context)
        {
            if (context.type_literal() != default)
            {
                return new ReturnInstruction()
                {
                    ReturnValue = VisitType_literal(context.type_literal())
                };
            }

            return new ReturnInstruction()
            {
                ReturnValue = new VariableLiteral()
                {
                    Name = context.VALID_NAME().GetText()
                }
            };
        }

        public override Node VisitConditional_instruction(LixirParser.Conditional_instructionContext context)
        {
            var boolean = VisitBoolean_instruction(context.boolean_instruction());
            var ifBlock = VisitCode_block(context.code_block(0));
            if (context.code_block(1) != default)
            {
                return new ConditionalBlock()
                {
                    Condition = boolean,
                    CodeBlock = ifBlock,
                    ElseCodeBlock = VisitCode_block(context.code_block(1))
                };
            }

            return new ConditionalBlock()
            {
                Condition = boolean,
                CodeBlock = ifBlock
            };
        }

        public override Node VisitLoop_instruction(LixirParser.Loop_instructionContext context)
        {
            if (context.range_operator() != default)
            {
                return new LoopBlock()
                {
                    LoopVariable = context.VALID_NAME(0).GetText(),
                    Iterable = VisitRange_operator(context.range_operator()),
                    Block = VisitCode_block(context.code_block())
                };
            }

            return new LoopBlock()
            {
                LoopVariable = context.VALID_NAME(0).GetText(),
                Iterable = new VariableLiteral() {Name = context.VALID_NAME(1).GetText()},
                Block = VisitCode_block(context.code_block())
            };
        }

        public override Node VisitRange_operator(LixirParser.Range_operatorContext context)
        {
            return new RangeOperator()
            {
                From = int.Parse(context.VALID_INTEGER(0).GetText()),
                To = int.Parse(context.VALID_INTEGER(1).GetText())
            };
        }

        public override Node VisitBoolean_instruction(LixirParser.Boolean_instructionContext context)
        {
            var variableName = context.VALID_NAME(0).GetText();
            if (context.HAS() != default)
            {
                return new BooleanHasChildExpression()
                {
                    VariableName = variableName,
                    ChildName = context.STRING_LINE().GetText()
                };
            }

            if (context.NAME_PROP() != default)
            {
                Node literal = null;
                if (context.VALID_INTEGER() != null)
                {
                    literal = new IntegerLiteral() {Value = int.Parse(context.VALID_INTEGER().GetText())};
                }

                if (context.STRING_LINE() != default)
                {
                    literal = new StringLiteral() {Value = context.STRING_LINE().GetText()};
                }

                return new BooleanExpression()
                {
                    VariableName = variableName,
                    Op = GetBooleanOperator(context.boolean_operator()),
                    Value = literal
                };
            }

            return new BooleanExpression
            {
                VariableName = variableName,
                Op = GetBooleanOperator(context.boolean_operator()),
                Value = context.value.Type switch
                {
                    LixirLexer.VALID_INTEGER => new IntegerLiteral {Value = int.Parse(context.VALID_INTEGER().GetText())},
                    LixirLexer.STRING_LINE => new StringLiteral {Value = context.STRING_LINE().GetText()},
                    LixirLexer.VALID_NAME => new VariableLiteral {Name = context.VALID_NAME(1).GetText()}
                }
            };

            throw new Exception("Something went wrong...");
        }

        private string GetReturnType(LixirParser.Method_variableContext context)
        {
            if (context.type().INT() != null)
            {
                return "int";
            }

            if (context.type().STRING() != null)
            {
                return "string";
            }

            if (context.type().ATTRIBUTE() != null)
            {
                return "_attribute";
            }

            if (context.type().NODE() != null)
            {
                return "_node";
            }

            return "";
        }

        private string GetBooleanOperator(LixirParser.Boolean_operatorContext booleanOperatorContext)
        {
            if (booleanOperatorContext.GT() != default)
            {
                return ">";
            }

            if (booleanOperatorContext.LT() != default)
            {
                return "<";
            }

            return "==";
        }
        

        private string GetReturnType(LixirParser.MethodContext context)
        {
            if (context.type().INT() != null)
            {
                return "int";
            }

            if (context.type().STRING() != null)
            {
                return "string";
            }

            if (context.type().ATTRIBUTE() != null)
            {
                return "_attribute";
            }

            if (context.type().NODE() != null)
            {
                return "_node";
            }

            return "";
        }
    }
}