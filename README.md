# Lixir
My language for working with XML documents. Uses Antlr4 and C# as its target language.
Please, feel free to use it, learn from it, or make it even better :)
## Documentation
### Supported types
Supported types are Int, String, Attribute and Node. These are then transpiled to C# alternatives - int, string. For Attribute and Node types, Lixir uses
boilerplate classes _attribute and _node. Namings start from the underline, yes! It was intended.
### Variable declaration
Declaration uses special keyword `.is`. For example:  
`myInt.is 10` - declares variable `myInt` of type `Int` with value `10`  
`myStr.is "Alice"` - declares variable of type `String` with value `"Alice"`  
`attr.is Attribute "MyAttribute" = 10` - declares var of type `Attribute`, which translates to `<MyAttribute>10</MyAttribute>` in XML  
`node.is Node "root": ()` - delcares var of type `Node`, which is empty. Translates to `<root></root>` in XML  
# I hope I will finish this in the future =)
