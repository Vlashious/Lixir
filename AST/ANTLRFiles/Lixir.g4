grammar Lixir;

PRINT: 'print';
METHOD: 'meth';
IS: '.is';
ADD: '.add';
OF: 'of';
REMOVE: '.remove';
NAME_PROP: '.name';
VALUE_PROP: '.value';
HAS: '.has';
OPEN_METH: '.Open';
SAVE_METH: '.Save';

IF: 'if';
ELSE: 'else';
FOR: 'for';
IN: 'in';
RETURN: 'return';

DOCUMENT: 'Document';
NODE: 'Node';
ATTRIBUTE: 'Attribute';
STRING: 'String';
INT: 'Int';

SEMICOLON: ':';
OPEN_BRACKET: '(';
CLOSE_BRACKET: ')';
QUOTE: '"';
EQUALS: '=';
GT: '>';
LT: '<';
COMMA: ',';
DOUBLE_DOT: '..';
PLUS: '+';
MINUS: '-';
MULTIPLY: '*';
DIVISION: '/';

VALID_NAME: [A-Za-z][A-Za-z0-9]*;
VALID_INTEGER: [0]|[1-9][0-9]*;
STRING_LINE: QUOTE [A-Za-z0-9 .]* QUOTE;

lixir_parser: code* EOF;

code
    : instruction
    | method
    ;

type
    : DOCUMENT
    | NODE
    | ATTRIBUTE
    | STRING
    | INT
    ;
    
type_literal
    : node_literal
    | attribute_literal
    | STRING_LINE
    | VALID_INTEGER
    ;

instruction
    : variable_declaration
    | conditional_instruction
    | loop_instruction
    | variable_manipulation
    | return_instruction
    ;

variable_declaration
    : VALID_NAME IS var_type=(STRING_LINE|VALID_INTEGER)
    | VALID_NAME IS var_type=(NODE|ATTRIBUTE) (node_literal|attribute_literal)?
    | VALID_NAME IS VALID_NAME
    ;
    
variable_manipulation
    : VALID_NAME NAME_PROP EQUALS STRING_LINE # VARIABLE_NAME_PROP
    | VALID_NAME VALUE_PROP EQUALS (VALID_NAME|OPEN_BRACKET type_literal CLOSE_BRACKET) # VARIABLE_VALUE_PROP
    | VALID_NAME ADD (VALID_NAME| OPEN_BRACKET type_literal CLOSE_BRACKET) # VARIABLE_ADD_CHILD
    | VALID_NAME REMOVE (STRING_LINE|VALID_NAME) # VARIABLE_REMOVE_CHILD
    | VALID_NAME inner_method=(OPEN_METH|SAVE_METH) STRING_LINE # VARIABLE_INNER_METHOD
    | VALID_NAME EQUALS (VALID_NAME|method_call|mathematics) # VARIABLE_ASSIGNMENT
    ;
    
method_call
    : VALID_NAME OPEN_BRACKET (type_literal|VALID_NAME)* CLOSE_BRACKET
    ;
    
mathematics
    : (VALID_INTEGER|VALID_NAME) op=(PLUS|MINUS|MULTIPLY|DIVISION) (VALID_INTEGER|VALID_NAME)
    ;
    
conditional_instruction
    : IF boolean_instruction SEMICOLON code_block (ELSE code_block)?
    ;
    
boolean_instruction
    : VALID_NAME HAS STRING_LINE
    | VALID_NAME NAME_PROP boolean_operator (STRING_LINE|VALID_INTEGER)
    | VALID_NAME boolean_operator value=(VALID_NAME|STRING_LINE|VALID_INTEGER)
    ;
    
boolean_operator
    : EQUALS EQUALS
    | GT
    | LT
    ;
    
loop_instruction
    : FOR VALID_NAME IN range_operator SEMICOLON code_block
    | FOR VALID_NAME IN VALID_NAME SEMICOLON code_block
    ;
    
range_operator: VALID_INTEGER DOUBLE_DOT VALID_INTEGER;
    
return_instruction
    : RETURN type_literal
    | RETURN VALID_NAME
    ;

method
    : METHOD type VALID_NAME method_variable* SEMICOLON code_block;

method_variable
    : type SEMICOLON VALID_NAME
    ;

code_block: OPEN_BRACKET instruction* CLOSE_BRACKET;

node_literal:
    (STRING_LINE|VALID_NAME)
    SEMICOLON
    OPEN_BRACKET
    (attribute_literal|node_literal)*
    CLOSE_BRACKET;
    
attribute_literal:
    (STRING_LINE|VALID_NAME) EQUALS (VALID_INTEGER|STRING_LINE|VALID_NAME) COMMA?
    ;

WS: [ \n\t\r] -> skip;
