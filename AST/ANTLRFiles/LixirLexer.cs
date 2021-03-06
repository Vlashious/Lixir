//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Lixir.g4 by ANTLR 4.9.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.CLSCompliant(false)]
public partial class LixirLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		PRINT=1, METHOD=2, IS=3, ADD=4, OF=5, REMOVE=6, NAME_PROP=7, VALUE_PROP=8, 
		HAS=9, OPEN_METH=10, SAVE_METH=11, IF=12, ELSE=13, FOR=14, IN=15, RETURN=16, 
		DOCUMENT=17, NODE=18, ATTRIBUTE=19, STRING=20, INT=21, SEMICOLON=22, OPEN_BRACKET=23, 
		CLOSE_BRACKET=24, QUOTE=25, EQUALS=26, GT=27, LT=28, COMMA=29, DOUBLE_DOT=30, 
		PLUS=31, MINUS=32, MULTIPLY=33, DIVISION=34, VALID_NAME=35, VALID_INTEGER=36, 
		STRING_LINE=37, WS=38;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"PRINT", "METHOD", "IS", "ADD", "OF", "REMOVE", "NAME_PROP", "VALUE_PROP", 
		"HAS", "OPEN_METH", "SAVE_METH", "IF", "ELSE", "FOR", "IN", "RETURN", 
		"DOCUMENT", "NODE", "ATTRIBUTE", "STRING", "INT", "SEMICOLON", "OPEN_BRACKET", 
		"CLOSE_BRACKET", "QUOTE", "EQUALS", "GT", "LT", "COMMA", "DOUBLE_DOT", 
		"PLUS", "MINUS", "MULTIPLY", "DIVISION", "VALID_NAME", "VALID_INTEGER", 
		"STRING_LINE", "WS"
	};


	public LixirLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public LixirLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'print'", "'meth'", "'.is'", "'.add'", "'of'", "'.remove'", "'.name'", 
		"'.value'", "'.has'", "'.Open'", "'.Save'", "'if'", "'else'", "'for'", 
		"'in'", "'return'", "'Document'", "'Node'", "'Attribute'", "'String'", 
		"'Int'", "':'", "'('", "')'", "'\"'", "'='", "'>'", "'<'", "','", "'..'", 
		"'+'", "'-'", "'*'", "'/'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "PRINT", "METHOD", "IS", "ADD", "OF", "REMOVE", "NAME_PROP", "VALUE_PROP", 
		"HAS", "OPEN_METH", "SAVE_METH", "IF", "ELSE", "FOR", "IN", "RETURN", 
		"DOCUMENT", "NODE", "ATTRIBUTE", "STRING", "INT", "SEMICOLON", "OPEN_BRACKET", 
		"CLOSE_BRACKET", "QUOTE", "EQUALS", "GT", "LT", "COMMA", "DOUBLE_DOT", 
		"PLUS", "MINUS", "MULTIPLY", "DIVISION", "VALID_NAME", "VALID_INTEGER", 
		"STRING_LINE", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Lixir.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static LixirLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '(', '\xFE', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', 
		'\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', 
		'\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', 
		'\x1D', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', 
		'\x1F', '\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!', '\x3', '\"', '\x3', 
		'\"', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', '$', '\a', '$', '\xE3', 
		'\n', '$', '\f', '$', '\xE', '$', '\xE6', '\v', '$', '\x3', '%', '\x3', 
		'%', '\x3', '%', '\a', '%', '\xEB', '\n', '%', '\f', '%', '\xE', '%', 
		'\xEE', '\v', '%', '\x5', '%', '\xF0', '\n', '%', '\x3', '&', '\x3', '&', 
		'\a', '&', '\xF4', '\n', '&', '\f', '&', '\xE', '&', '\xF7', '\v', '&', 
		'\x3', '&', '\x3', '&', '\x3', '\'', '\x3', '\'', '\x3', '\'', '\x3', 
		'\'', '\x2', '\x2', '(', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', 
		'\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', 
		'\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', 
		'\x1F', '\x11', '!', '\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', 
		'\x16', '+', '\x17', '-', '\x18', '/', '\x19', '\x31', '\x1A', '\x33', 
		'\x1B', '\x35', '\x1C', '\x37', '\x1D', '\x39', '\x1E', ';', '\x1F', '=', 
		' ', '?', '!', '\x41', '\"', '\x43', '#', '\x45', '$', 'G', '%', 'I', 
		'&', 'K', '\'', 'M', '(', '\x3', '\x2', '\t', '\x4', '\x2', '\x43', '\\', 
		'\x63', '|', '\x5', '\x2', '\x32', ';', '\x43', '\\', '\x63', '|', '\x3', 
		'\x2', '\x32', '\x32', '\x3', '\x2', '\x33', ';', '\x3', '\x2', '\x32', 
		';', '\a', '\x2', '\"', '\"', '\x30', '\x30', '\x32', ';', '\x43', '\\', 
		'\x63', '|', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', 
		'\x101', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', 
		'\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', '\x2', '\x41', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'I', '\x3', '\x2', '\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'M', '\x3', '\x2', '\x2', '\x2', '\x3', 'O', '\x3', '\x2', 
		'\x2', '\x2', '\x5', 'U', '\x3', '\x2', '\x2', '\x2', '\a', 'Z', '\x3', 
		'\x2', '\x2', '\x2', '\t', '^', '\x3', '\x2', '\x2', '\x2', '\v', '\x63', 
		'\x3', '\x2', '\x2', '\x2', '\r', '\x66', '\x3', '\x2', '\x2', '\x2', 
		'\xF', 'n', '\x3', '\x2', '\x2', '\x2', '\x11', 't', '\x3', '\x2', '\x2', 
		'\x2', '\x13', '{', '\x3', '\x2', '\x2', '\x2', '\x15', '\x80', '\x3', 
		'\x2', '\x2', '\x2', '\x17', '\x86', '\x3', '\x2', '\x2', '\x2', '\x19', 
		'\x8C', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x8F', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', '\x94', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x98', '\x3', 
		'\x2', '\x2', '\x2', '!', '\x9B', '\x3', '\x2', '\x2', '\x2', '#', '\xA2', 
		'\x3', '\x2', '\x2', '\x2', '%', '\xAB', '\x3', '\x2', '\x2', '\x2', '\'', 
		'\xB0', '\x3', '\x2', '\x2', '\x2', ')', '\xBA', '\x3', '\x2', '\x2', 
		'\x2', '+', '\xC1', '\x3', '\x2', '\x2', '\x2', '-', '\xC5', '\x3', '\x2', 
		'\x2', '\x2', '/', '\xC7', '\x3', '\x2', '\x2', '\x2', '\x31', '\xC9', 
		'\x3', '\x2', '\x2', '\x2', '\x33', '\xCB', '\x3', '\x2', '\x2', '\x2', 
		'\x35', '\xCD', '\x3', '\x2', '\x2', '\x2', '\x37', '\xCF', '\x3', '\x2', 
		'\x2', '\x2', '\x39', '\xD1', '\x3', '\x2', '\x2', '\x2', ';', '\xD3', 
		'\x3', '\x2', '\x2', '\x2', '=', '\xD5', '\x3', '\x2', '\x2', '\x2', '?', 
		'\xD8', '\x3', '\x2', '\x2', '\x2', '\x41', '\xDA', '\x3', '\x2', '\x2', 
		'\x2', '\x43', '\xDC', '\x3', '\x2', '\x2', '\x2', '\x45', '\xDE', '\x3', 
		'\x2', '\x2', '\x2', 'G', '\xE0', '\x3', '\x2', '\x2', '\x2', 'I', '\xEF', 
		'\x3', '\x2', '\x2', '\x2', 'K', '\xF1', '\x3', '\x2', '\x2', '\x2', 'M', 
		'\xFA', '\x3', '\x2', '\x2', '\x2', 'O', 'P', '\a', 'r', '\x2', '\x2', 
		'P', 'Q', '\a', 't', '\x2', '\x2', 'Q', 'R', '\a', 'k', '\x2', '\x2', 
		'R', 'S', '\a', 'p', '\x2', '\x2', 'S', 'T', '\a', 'v', '\x2', '\x2', 
		'T', '\x4', '\x3', '\x2', '\x2', '\x2', 'U', 'V', '\a', 'o', '\x2', '\x2', 
		'V', 'W', '\a', 'g', '\x2', '\x2', 'W', 'X', '\a', 'v', '\x2', '\x2', 
		'X', 'Y', '\a', 'j', '\x2', '\x2', 'Y', '\x6', '\x3', '\x2', '\x2', '\x2', 
		'Z', '[', '\a', '\x30', '\x2', '\x2', '[', '\\', '\a', 'k', '\x2', '\x2', 
		'\\', ']', '\a', 'u', '\x2', '\x2', ']', '\b', '\x3', '\x2', '\x2', '\x2', 
		'^', '_', '\a', '\x30', '\x2', '\x2', '_', '`', '\a', '\x63', '\x2', '\x2', 
		'`', '\x61', '\a', '\x66', '\x2', '\x2', '\x61', '\x62', '\a', '\x66', 
		'\x2', '\x2', '\x62', '\n', '\x3', '\x2', '\x2', '\x2', '\x63', '\x64', 
		'\a', 'q', '\x2', '\x2', '\x64', '\x65', '\a', 'h', '\x2', '\x2', '\x65', 
		'\f', '\x3', '\x2', '\x2', '\x2', '\x66', 'g', '\a', '\x30', '\x2', '\x2', 
		'g', 'h', '\a', 't', '\x2', '\x2', 'h', 'i', '\a', 'g', '\x2', '\x2', 
		'i', 'j', '\a', 'o', '\x2', '\x2', 'j', 'k', '\a', 'q', '\x2', '\x2', 
		'k', 'l', '\a', 'x', '\x2', '\x2', 'l', 'm', '\a', 'g', '\x2', '\x2', 
		'm', '\xE', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\a', '\x30', '\x2', 
		'\x2', 'o', 'p', '\a', 'p', '\x2', '\x2', 'p', 'q', '\a', '\x63', '\x2', 
		'\x2', 'q', 'r', '\a', 'o', '\x2', '\x2', 'r', 's', '\a', 'g', '\x2', 
		'\x2', 's', '\x10', '\x3', '\x2', '\x2', '\x2', 't', 'u', '\a', '\x30', 
		'\x2', '\x2', 'u', 'v', '\a', 'x', '\x2', '\x2', 'v', 'w', '\a', '\x63', 
		'\x2', '\x2', 'w', 'x', '\a', 'n', '\x2', '\x2', 'x', 'y', '\a', 'w', 
		'\x2', '\x2', 'y', 'z', '\a', 'g', '\x2', '\x2', 'z', '\x12', '\x3', '\x2', 
		'\x2', '\x2', '{', '|', '\a', '\x30', '\x2', '\x2', '|', '}', '\a', 'j', 
		'\x2', '\x2', '}', '~', '\a', '\x63', '\x2', '\x2', '~', '\x7F', '\a', 
		'u', '\x2', '\x2', '\x7F', '\x14', '\x3', '\x2', '\x2', '\x2', '\x80', 
		'\x81', '\a', '\x30', '\x2', '\x2', '\x81', '\x82', '\a', 'Q', '\x2', 
		'\x2', '\x82', '\x83', '\a', 'r', '\x2', '\x2', '\x83', '\x84', '\a', 
		'g', '\x2', '\x2', '\x84', '\x85', '\a', 'p', '\x2', '\x2', '\x85', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x86', '\x87', '\a', '\x30', '\x2', '\x2', 
		'\x87', '\x88', '\a', 'U', '\x2', '\x2', '\x88', '\x89', '\a', '\x63', 
		'\x2', '\x2', '\x89', '\x8A', '\a', 'x', '\x2', '\x2', '\x8A', '\x8B', 
		'\a', 'g', '\x2', '\x2', '\x8B', '\x18', '\x3', '\x2', '\x2', '\x2', '\x8C', 
		'\x8D', '\a', 'k', '\x2', '\x2', '\x8D', '\x8E', '\a', 'h', '\x2', '\x2', 
		'\x8E', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\a', 'g', 
		'\x2', '\x2', '\x90', '\x91', '\a', 'n', '\x2', '\x2', '\x91', '\x92', 
		'\a', 'u', '\x2', '\x2', '\x92', '\x93', '\a', 'g', '\x2', '\x2', '\x93', 
		'\x1C', '\x3', '\x2', '\x2', '\x2', '\x94', '\x95', '\a', 'h', '\x2', 
		'\x2', '\x95', '\x96', '\a', 'q', '\x2', '\x2', '\x96', '\x97', '\a', 
		't', '\x2', '\x2', '\x97', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x98', 
		'\x99', '\a', 'k', '\x2', '\x2', '\x99', '\x9A', '\a', 'p', '\x2', '\x2', 
		'\x9A', ' ', '\x3', '\x2', '\x2', '\x2', '\x9B', '\x9C', '\a', 't', '\x2', 
		'\x2', '\x9C', '\x9D', '\a', 'g', '\x2', '\x2', '\x9D', '\x9E', '\a', 
		'v', '\x2', '\x2', '\x9E', '\x9F', '\a', 'w', '\x2', '\x2', '\x9F', '\xA0', 
		'\a', 't', '\x2', '\x2', '\xA0', '\xA1', '\a', 'p', '\x2', '\x2', '\xA1', 
		'\"', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', '\a', '\x46', '\x2', 
		'\x2', '\xA3', '\xA4', '\a', 'q', '\x2', '\x2', '\xA4', '\xA5', '\a', 
		'\x65', '\x2', '\x2', '\xA5', '\xA6', '\a', 'w', '\x2', '\x2', '\xA6', 
		'\xA7', '\a', 'o', '\x2', '\x2', '\xA7', '\xA8', '\a', 'g', '\x2', '\x2', 
		'\xA8', '\xA9', '\a', 'p', '\x2', '\x2', '\xA9', '\xAA', '\a', 'v', '\x2', 
		'\x2', '\xAA', '$', '\x3', '\x2', '\x2', '\x2', '\xAB', '\xAC', '\a', 
		'P', '\x2', '\x2', '\xAC', '\xAD', '\a', 'q', '\x2', '\x2', '\xAD', '\xAE', 
		'\a', '\x66', '\x2', '\x2', '\xAE', '\xAF', '\a', 'g', '\x2', '\x2', '\xAF', 
		'&', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xB1', '\a', '\x43', '\x2', 
		'\x2', '\xB1', '\xB2', '\a', 'v', '\x2', '\x2', '\xB2', '\xB3', '\a', 
		'v', '\x2', '\x2', '\xB3', '\xB4', '\a', 't', '\x2', '\x2', '\xB4', '\xB5', 
		'\a', 'k', '\x2', '\x2', '\xB5', '\xB6', '\a', '\x64', '\x2', '\x2', '\xB6', 
		'\xB7', '\a', 'w', '\x2', '\x2', '\xB7', '\xB8', '\a', 'v', '\x2', '\x2', 
		'\xB8', '\xB9', '\a', 'g', '\x2', '\x2', '\xB9', '(', '\x3', '\x2', '\x2', 
		'\x2', '\xBA', '\xBB', '\a', 'U', '\x2', '\x2', '\xBB', '\xBC', '\a', 
		'v', '\x2', '\x2', '\xBC', '\xBD', '\a', 't', '\x2', '\x2', '\xBD', '\xBE', 
		'\a', 'k', '\x2', '\x2', '\xBE', '\xBF', '\a', 'p', '\x2', '\x2', '\xBF', 
		'\xC0', '\a', 'i', '\x2', '\x2', '\xC0', '*', '\x3', '\x2', '\x2', '\x2', 
		'\xC1', '\xC2', '\a', 'K', '\x2', '\x2', '\xC2', '\xC3', '\a', 'p', '\x2', 
		'\x2', '\xC3', '\xC4', '\a', 'v', '\x2', '\x2', '\xC4', ',', '\x3', '\x2', 
		'\x2', '\x2', '\xC5', '\xC6', '\a', '<', '\x2', '\x2', '\xC6', '.', '\x3', 
		'\x2', '\x2', '\x2', '\xC7', '\xC8', '\a', '*', '\x2', '\x2', '\xC8', 
		'\x30', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xCA', '\a', '+', '\x2', 
		'\x2', '\xCA', '\x32', '\x3', '\x2', '\x2', '\x2', '\xCB', '\xCC', '\a', 
		'$', '\x2', '\x2', '\xCC', '\x34', '\x3', '\x2', '\x2', '\x2', '\xCD', 
		'\xCE', '\a', '?', '\x2', '\x2', '\xCE', '\x36', '\x3', '\x2', '\x2', 
		'\x2', '\xCF', '\xD0', '\a', '@', '\x2', '\x2', '\xD0', '\x38', '\x3', 
		'\x2', '\x2', '\x2', '\xD1', '\xD2', '\a', '>', '\x2', '\x2', '\xD2', 
		':', '\x3', '\x2', '\x2', '\x2', '\xD3', '\xD4', '\a', '.', '\x2', '\x2', 
		'\xD4', '<', '\x3', '\x2', '\x2', '\x2', '\xD5', '\xD6', '\a', '\x30', 
		'\x2', '\x2', '\xD6', '\xD7', '\a', '\x30', '\x2', '\x2', '\xD7', '>', 
		'\x3', '\x2', '\x2', '\x2', '\xD8', '\xD9', '\a', '-', '\x2', '\x2', '\xD9', 
		'@', '\x3', '\x2', '\x2', '\x2', '\xDA', '\xDB', '\a', '/', '\x2', '\x2', 
		'\xDB', '\x42', '\x3', '\x2', '\x2', '\x2', '\xDC', '\xDD', '\a', ',', 
		'\x2', '\x2', '\xDD', '\x44', '\x3', '\x2', '\x2', '\x2', '\xDE', '\xDF', 
		'\a', '\x31', '\x2', '\x2', '\xDF', '\x46', '\x3', '\x2', '\x2', '\x2', 
		'\xE0', '\xE4', '\t', '\x2', '\x2', '\x2', '\xE1', '\xE3', '\t', '\x3', 
		'\x2', '\x2', '\xE2', '\xE1', '\x3', '\x2', '\x2', '\x2', '\xE3', '\xE6', 
		'\x3', '\x2', '\x2', '\x2', '\xE4', '\xE2', '\x3', '\x2', '\x2', '\x2', 
		'\xE4', '\xE5', '\x3', '\x2', '\x2', '\x2', '\xE5', 'H', '\x3', '\x2', 
		'\x2', '\x2', '\xE6', '\xE4', '\x3', '\x2', '\x2', '\x2', '\xE7', '\xF0', 
		'\t', '\x4', '\x2', '\x2', '\xE8', '\xEC', '\t', '\x5', '\x2', '\x2', 
		'\xE9', '\xEB', '\t', '\x6', '\x2', '\x2', '\xEA', '\xE9', '\x3', '\x2', 
		'\x2', '\x2', '\xEB', '\xEE', '\x3', '\x2', '\x2', '\x2', '\xEC', '\xEA', 
		'\x3', '\x2', '\x2', '\x2', '\xEC', '\xED', '\x3', '\x2', '\x2', '\x2', 
		'\xED', '\xF0', '\x3', '\x2', '\x2', '\x2', '\xEE', '\xEC', '\x3', '\x2', 
		'\x2', '\x2', '\xEF', '\xE7', '\x3', '\x2', '\x2', '\x2', '\xEF', '\xE8', 
		'\x3', '\x2', '\x2', '\x2', '\xF0', 'J', '\x3', '\x2', '\x2', '\x2', '\xF1', 
		'\xF5', '\x5', '\x33', '\x1A', '\x2', '\xF2', '\xF4', '\t', '\a', '\x2', 
		'\x2', '\xF3', '\xF2', '\x3', '\x2', '\x2', '\x2', '\xF4', '\xF7', '\x3', 
		'\x2', '\x2', '\x2', '\xF5', '\xF3', '\x3', '\x2', '\x2', '\x2', '\xF5', 
		'\xF6', '\x3', '\x2', '\x2', '\x2', '\xF6', '\xF8', '\x3', '\x2', '\x2', 
		'\x2', '\xF7', '\xF5', '\x3', '\x2', '\x2', '\x2', '\xF8', '\xF9', '\x5', 
		'\x33', '\x1A', '\x2', '\xF9', 'L', '\x3', '\x2', '\x2', '\x2', '\xFA', 
		'\xFB', '\t', '\b', '\x2', '\x2', '\xFB', '\xFC', '\x3', '\x2', '\x2', 
		'\x2', '\xFC', '\xFD', '\b', '\'', '\x2', '\x2', '\xFD', 'N', '\x3', '\x2', 
		'\x2', '\x2', '\a', '\x2', '\xE4', '\xEC', '\xEF', '\xF5', '\x3', '\b', 
		'\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
