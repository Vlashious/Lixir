// Generated from /home/uladzimir/Labs/MPuIS/AST/ANTLRFiles/Lixir.g4 by ANTLR 4.8
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class LixirParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.8", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		PRINT=1, METHOD=2, IS=3, ADD=4, REMOVE=5, NAME_PROP=6, VALUE_PROP=7, HAS=8, 
		OPEN_METH=9, SAVE_METH=10, IF=11, ELSE=12, FOR=13, IN=14, RETURN=15, DOCUMENT=16, 
		NODE=17, ATTRIBUTE=18, STRING=19, INT=20, SEMICOLON=21, OPEN_BRACKET=22, 
		CLOSE_BRACKET=23, QUOTE=24, EQUALS=25, COMMA=26, DOUBLE_DOT=27, VALID_NAME=28, 
		VALID_INTEGER=29, STRING_LINE=30, WS=31;
	public static final int
		RULE_lixir_parser = 0, RULE_code = 1, RULE_type = 2, RULE_type_literal = 3, 
		RULE_instruction = 4, RULE_variable_declaration = 5, RULE_variable_manipulation = 6, 
		RULE_parameter = 7, RULE_conditional_instruction = 8, RULE_boolean_instruction = 9, 
		RULE_loop_instruction = 10, RULE_range_operator = 11, RULE_return_instruction = 12, 
		RULE_method = 13, RULE_method_variable = 14, RULE_code_block = 15, RULE_document_literal = 16, 
		RULE_node_literal = 17, RULE_attribute_literal = 18, RULE_value_literal = 19, 
		RULE_integer_literal = 20, RULE_string_literal = 21, RULE_print_instruction = 22;
	private static String[] makeRuleNames() {
		return new String[] {
			"lixir_parser", "code", "type", "type_literal", "instruction", "variable_declaration", 
			"variable_manipulation", "parameter", "conditional_instruction", "boolean_instruction", 
			"loop_instruction", "range_operator", "return_instruction", "method", 
			"method_variable", "code_block", "document_literal", "node_literal", 
			"attribute_literal", "value_literal", "integer_literal", "string_literal", 
			"print_instruction"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'print'", "'meth'", "'.is'", "'.add'", "'.remove'", "'.name'", 
			"'.value'", "'.has'", "'.Open'", "'.Save'", "'if'", "'else'", "'for'", 
			"'in'", "'return'", "'Document'", "'Node'", "'Attribute'", "'String'", 
			"'Int'", "':'", "'('", "')'", "'\"'", "'='", "','", "'..'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, "PRINT", "METHOD", "IS", "ADD", "REMOVE", "NAME_PROP", "VALUE_PROP", 
			"HAS", "OPEN_METH", "SAVE_METH", "IF", "ELSE", "FOR", "IN", "RETURN", 
			"DOCUMENT", "NODE", "ATTRIBUTE", "STRING", "INT", "SEMICOLON", "OPEN_BRACKET", 
			"CLOSE_BRACKET", "QUOTE", "EQUALS", "COMMA", "DOUBLE_DOT", "VALID_NAME", 
			"VALID_INTEGER", "STRING_LINE", "WS"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "Lixir.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public LixirParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class Lixir_parserContext extends ParserRuleContext {
		public CodeContext code() {
			return getRuleContext(CodeContext.class,0);
		}
		public TerminalNode EOF() { return getToken(LixirParser.EOF, 0); }
		public Lixir_parserContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_lixir_parser; }
	}

	public final Lixir_parserContext lixir_parser() throws RecognitionException {
		Lixir_parserContext _localctx = new Lixir_parserContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_lixir_parser);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(46);
			code();
			setState(47);
			match(EOF);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class CodeContext extends ParserRuleContext {
		public List<InstructionContext> instruction() {
			return getRuleContexts(InstructionContext.class);
		}
		public InstructionContext instruction(int i) {
			return getRuleContext(InstructionContext.class,i);
		}
		public List<MethodContext> method() {
			return getRuleContexts(MethodContext.class);
		}
		public MethodContext method(int i) {
			return getRuleContext(MethodContext.class,i);
		}
		public CodeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_code; }
	}

	public final CodeContext code() throws RecognitionException {
		CodeContext _localctx = new CodeContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_code);
		int _la;
		try {
			setState(61);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,2,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(52);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PRINT) | (1L << IF) | (1L << FOR) | (1L << RETURN) | (1L << VALID_NAME))) != 0)) {
					{
					{
					setState(49);
					instruction();
					}
					}
					setState(54);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(58);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==METHOD) {
					{
					{
					setState(55);
					method();
					}
					}
					setState(60);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TypeContext extends ParserRuleContext {
		public TerminalNode DOCUMENT() { return getToken(LixirParser.DOCUMENT, 0); }
		public TerminalNode NODE() { return getToken(LixirParser.NODE, 0); }
		public TerminalNode ATTRIBUTE() { return getToken(LixirParser.ATTRIBUTE, 0); }
		public TerminalNode STRING() { return getToken(LixirParser.STRING, 0); }
		public TerminalNode INT() { return getToken(LixirParser.INT, 0); }
		public TypeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_type; }
	}

	public final TypeContext type() throws RecognitionException {
		TypeContext _localctx = new TypeContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_type);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(63);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << DOCUMENT) | (1L << NODE) | (1L << ATTRIBUTE) | (1L << STRING) | (1L << INT))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Type_literalContext extends ParserRuleContext {
		public Document_literalContext document_literal() {
			return getRuleContext(Document_literalContext.class,0);
		}
		public Node_literalContext node_literal() {
			return getRuleContext(Node_literalContext.class,0);
		}
		public Attribute_literalContext attribute_literal() {
			return getRuleContext(Attribute_literalContext.class,0);
		}
		public String_literalContext string_literal() {
			return getRuleContext(String_literalContext.class,0);
		}
		public Integer_literalContext integer_literal() {
			return getRuleContext(Integer_literalContext.class,0);
		}
		public Type_literalContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_type_literal; }
	}

	public final Type_literalContext type_literal() throws RecognitionException {
		Type_literalContext _localctx = new Type_literalContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_type_literal);
		try {
			setState(70);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case DOCUMENT:
				enterOuterAlt(_localctx, 1);
				{
				setState(65);
				document_literal();
				}
				break;
			case NODE:
				enterOuterAlt(_localctx, 2);
				{
				setState(66);
				node_literal();
				}
				break;
			case ATTRIBUTE:
				enterOuterAlt(_localctx, 3);
				{
				setState(67);
				attribute_literal();
				}
				break;
			case STRING_LINE:
				enterOuterAlt(_localctx, 4);
				{
				setState(68);
				string_literal();
				}
				break;
			case VALID_INTEGER:
				enterOuterAlt(_localctx, 5);
				{
				setState(69);
				integer_literal();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class InstructionContext extends ParserRuleContext {
		public Variable_declarationContext variable_declaration() {
			return getRuleContext(Variable_declarationContext.class,0);
		}
		public Conditional_instructionContext conditional_instruction() {
			return getRuleContext(Conditional_instructionContext.class,0);
		}
		public Loop_instructionContext loop_instruction() {
			return getRuleContext(Loop_instructionContext.class,0);
		}
		public Variable_manipulationContext variable_manipulation() {
			return getRuleContext(Variable_manipulationContext.class,0);
		}
		public Return_instructionContext return_instruction() {
			return getRuleContext(Return_instructionContext.class,0);
		}
		public Print_instructionContext print_instruction() {
			return getRuleContext(Print_instructionContext.class,0);
		}
		public InstructionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_instruction; }
	}

	public final InstructionContext instruction() throws RecognitionException {
		InstructionContext _localctx = new InstructionContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_instruction);
		try {
			setState(78);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,4,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(72);
				variable_declaration();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(73);
				conditional_instruction();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(74);
				loop_instruction();
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(75);
				variable_manipulation();
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(76);
				return_instruction();
				}
				break;
			case 6:
				enterOuterAlt(_localctx, 6);
				{
				setState(77);
				print_instruction();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Variable_declarationContext extends ParserRuleContext {
		public TerminalNode VALID_NAME() { return getToken(LixirParser.VALID_NAME, 0); }
		public TerminalNode IS() { return getToken(LixirParser.IS, 0); }
		public Type_literalContext type_literal() {
			return getRuleContext(Type_literalContext.class,0);
		}
		public Variable_declarationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_variable_declaration; }
	}

	public final Variable_declarationContext variable_declaration() throws RecognitionException {
		Variable_declarationContext _localctx = new Variable_declarationContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_variable_declaration);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(80);
			match(VALID_NAME);
			setState(81);
			match(IS);
			setState(82);
			type_literal();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Variable_manipulationContext extends ParserRuleContext {
		public List<TerminalNode> VALID_NAME() { return getTokens(LixirParser.VALID_NAME); }
		public TerminalNode VALID_NAME(int i) {
			return getToken(LixirParser.VALID_NAME, i);
		}
		public TerminalNode NAME_PROP() { return getToken(LixirParser.NAME_PROP, 0); }
		public TerminalNode EQUALS() { return getToken(LixirParser.EQUALS, 0); }
		public String_literalContext string_literal() {
			return getRuleContext(String_literalContext.class,0);
		}
		public TerminalNode VALUE_PROP() { return getToken(LixirParser.VALUE_PROP, 0); }
		public Type_literalContext type_literal() {
			return getRuleContext(Type_literalContext.class,0);
		}
		public TerminalNode ADD() { return getToken(LixirParser.ADD, 0); }
		public TerminalNode REMOVE() { return getToken(LixirParser.REMOVE, 0); }
		public TerminalNode OPEN_METH() { return getToken(LixirParser.OPEN_METH, 0); }
		public TerminalNode SAVE_METH() { return getToken(LixirParser.SAVE_METH, 0); }
		public List<ParameterContext> parameter() {
			return getRuleContexts(ParameterContext.class);
		}
		public ParameterContext parameter(int i) {
			return getRuleContext(ParameterContext.class,i);
		}
		public Variable_manipulationContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_variable_manipulation; }
	}

	public final Variable_manipulationContext variable_manipulation() throws RecognitionException {
		Variable_manipulationContext _localctx = new Variable_manipulationContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_variable_manipulation);
		try {
			int _alt;
			setState(122);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,9,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(84);
				match(VALID_NAME);
				setState(85);
				match(NAME_PROP);
				setState(86);
				match(EQUALS);
				setState(87);
				string_literal();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(88);
				match(VALID_NAME);
				setState(89);
				match(VALUE_PROP);
				setState(90);
				match(EQUALS);
				setState(93);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case DOCUMENT:
				case NODE:
				case ATTRIBUTE:
				case VALID_INTEGER:
				case STRING_LINE:
					{
					setState(91);
					type_literal();
					}
					break;
				case VALID_NAME:
					{
					setState(92);
					match(VALID_NAME);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(95);
				match(VALID_NAME);
				setState(96);
				match(ADD);
				setState(99);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case VALID_NAME:
					{
					setState(97);
					match(VALID_NAME);
					}
					break;
				case DOCUMENT:
				case NODE:
				case ATTRIBUTE:
				case VALID_INTEGER:
				case STRING_LINE:
					{
					setState(98);
					type_literal();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(101);
				match(VALID_NAME);
				setState(102);
				match(REMOVE);
				setState(105);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case VALID_NAME:
					{
					setState(103);
					match(VALID_NAME);
					}
					break;
				case DOCUMENT:
				case NODE:
				case ATTRIBUTE:
				case VALID_INTEGER:
				case STRING_LINE:
					{
					setState(104);
					type_literal();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				break;
			case 5:
				enterOuterAlt(_localctx, 5);
				{
				setState(107);
				match(VALID_NAME);
				setState(108);
				match(OPEN_METH);
				setState(109);
				string_literal();
				}
				break;
			case 6:
				enterOuterAlt(_localctx, 6);
				{
				setState(110);
				match(VALID_NAME);
				setState(111);
				match(SAVE_METH);
				setState(112);
				string_literal();
				}
				break;
			case 7:
				enterOuterAlt(_localctx, 7);
				{
				setState(113);
				match(VALID_NAME);
				setState(114);
				match(EQUALS);
				setState(115);
				match(VALID_NAME);
				setState(119);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,8,_ctx);
				while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						setState(116);
						parameter();
						}
						} 
					}
					setState(121);
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,8,_ctx);
				}
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ParameterContext extends ParserRuleContext {
		public Integer_literalContext integer_literal() {
			return getRuleContext(Integer_literalContext.class,0);
		}
		public String_literalContext string_literal() {
			return getRuleContext(String_literalContext.class,0);
		}
		public TerminalNode VALID_NAME() { return getToken(LixirParser.VALID_NAME, 0); }
		public ParameterContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_parameter; }
	}

	public final ParameterContext parameter() throws RecognitionException {
		ParameterContext _localctx = new ParameterContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_parameter);
		try {
			setState(127);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case VALID_INTEGER:
				enterOuterAlt(_localctx, 1);
				{
				setState(124);
				integer_literal();
				}
				break;
			case STRING_LINE:
				enterOuterAlt(_localctx, 2);
				{
				setState(125);
				string_literal();
				}
				break;
			case VALID_NAME:
				enterOuterAlt(_localctx, 3);
				{
				setState(126);
				match(VALID_NAME);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Conditional_instructionContext extends ParserRuleContext {
		public TerminalNode IF() { return getToken(LixirParser.IF, 0); }
		public Boolean_instructionContext boolean_instruction() {
			return getRuleContext(Boolean_instructionContext.class,0);
		}
		public TerminalNode SEMICOLON() { return getToken(LixirParser.SEMICOLON, 0); }
		public List<Code_blockContext> code_block() {
			return getRuleContexts(Code_blockContext.class);
		}
		public Code_blockContext code_block(int i) {
			return getRuleContext(Code_blockContext.class,i);
		}
		public TerminalNode ELSE() { return getToken(LixirParser.ELSE, 0); }
		public Conditional_instructionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_conditional_instruction; }
	}

	public final Conditional_instructionContext conditional_instruction() throws RecognitionException {
		Conditional_instructionContext _localctx = new Conditional_instructionContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_conditional_instruction);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(129);
			match(IF);
			setState(130);
			boolean_instruction();
			setState(131);
			match(SEMICOLON);
			setState(132);
			code_block();
			setState(135);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==ELSE) {
				{
				setState(133);
				match(ELSE);
				setState(134);
				code_block();
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Boolean_instructionContext extends ParserRuleContext {
		public TerminalNode VALID_NAME() { return getToken(LixirParser.VALID_NAME, 0); }
		public TerminalNode HAS() { return getToken(LixirParser.HAS, 0); }
		public String_literalContext string_literal() {
			return getRuleContext(String_literalContext.class,0);
		}
		public TerminalNode NAME_PROP() { return getToken(LixirParser.NAME_PROP, 0); }
		public List<TerminalNode> EQUALS() { return getTokens(LixirParser.EQUALS); }
		public TerminalNode EQUALS(int i) {
			return getToken(LixirParser.EQUALS, i);
		}
		public Boolean_instructionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_boolean_instruction; }
	}

	public final Boolean_instructionContext boolean_instruction() throws RecognitionException {
		Boolean_instructionContext _localctx = new Boolean_instructionContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_boolean_instruction);
		try {
			setState(145);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,12,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(137);
				match(VALID_NAME);
				setState(138);
				match(HAS);
				setState(139);
				string_literal();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(140);
				match(VALID_NAME);
				setState(141);
				match(NAME_PROP);
				setState(142);
				match(EQUALS);
				setState(143);
				match(EQUALS);
				setState(144);
				string_literal();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Loop_instructionContext extends ParserRuleContext {
		public TerminalNode FOR() { return getToken(LixirParser.FOR, 0); }
		public List<TerminalNode> VALID_NAME() { return getTokens(LixirParser.VALID_NAME); }
		public TerminalNode VALID_NAME(int i) {
			return getToken(LixirParser.VALID_NAME, i);
		}
		public TerminalNode IN() { return getToken(LixirParser.IN, 0); }
		public Range_operatorContext range_operator() {
			return getRuleContext(Range_operatorContext.class,0);
		}
		public TerminalNode SEMICOLON() { return getToken(LixirParser.SEMICOLON, 0); }
		public Code_blockContext code_block() {
			return getRuleContext(Code_blockContext.class,0);
		}
		public Loop_instructionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_loop_instruction; }
	}

	public final Loop_instructionContext loop_instruction() throws RecognitionException {
		Loop_instructionContext _localctx = new Loop_instructionContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_loop_instruction);
		try {
			setState(160);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,13,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(147);
				match(FOR);
				setState(148);
				match(VALID_NAME);
				setState(149);
				match(IN);
				setState(150);
				range_operator();
				setState(151);
				match(SEMICOLON);
				setState(152);
				code_block();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(154);
				match(FOR);
				setState(155);
				match(VALID_NAME);
				setState(156);
				match(IN);
				setState(157);
				match(VALID_NAME);
				setState(158);
				match(SEMICOLON);
				setState(159);
				code_block();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Range_operatorContext extends ParserRuleContext {
		public List<Integer_literalContext> integer_literal() {
			return getRuleContexts(Integer_literalContext.class);
		}
		public Integer_literalContext integer_literal(int i) {
			return getRuleContext(Integer_literalContext.class,i);
		}
		public TerminalNode DOUBLE_DOT() { return getToken(LixirParser.DOUBLE_DOT, 0); }
		public Range_operatorContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_range_operator; }
	}

	public final Range_operatorContext range_operator() throws RecognitionException {
		Range_operatorContext _localctx = new Range_operatorContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_range_operator);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(162);
			integer_literal();
			setState(163);
			match(DOUBLE_DOT);
			setState(164);
			integer_literal();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Return_instructionContext extends ParserRuleContext {
		public TerminalNode RETURN() { return getToken(LixirParser.RETURN, 0); }
		public Type_literalContext type_literal() {
			return getRuleContext(Type_literalContext.class,0);
		}
		public TerminalNode VALID_NAME() { return getToken(LixirParser.VALID_NAME, 0); }
		public Return_instructionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_return_instruction; }
	}

	public final Return_instructionContext return_instruction() throws RecognitionException {
		Return_instructionContext _localctx = new Return_instructionContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_return_instruction);
		try {
			setState(170);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,14,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(166);
				match(RETURN);
				setState(167);
				type_literal();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(168);
				match(RETURN);
				setState(169);
				match(VALID_NAME);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class MethodContext extends ParserRuleContext {
		public TerminalNode METHOD() { return getToken(LixirParser.METHOD, 0); }
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public TerminalNode VALID_NAME() { return getToken(LixirParser.VALID_NAME, 0); }
		public TerminalNode SEMICOLON() { return getToken(LixirParser.SEMICOLON, 0); }
		public Code_blockContext code_block() {
			return getRuleContext(Code_blockContext.class,0);
		}
		public List<Method_variableContext> method_variable() {
			return getRuleContexts(Method_variableContext.class);
		}
		public Method_variableContext method_variable(int i) {
			return getRuleContext(Method_variableContext.class,i);
		}
		public MethodContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_method; }
	}

	public final MethodContext method() throws RecognitionException {
		MethodContext _localctx = new MethodContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_method);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(172);
			match(METHOD);
			setState(173);
			type();
			setState(174);
			match(VALID_NAME);
			setState(178);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << DOCUMENT) | (1L << NODE) | (1L << ATTRIBUTE) | (1L << STRING) | (1L << INT))) != 0)) {
				{
				{
				setState(175);
				method_variable();
				}
				}
				setState(180);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(181);
			match(SEMICOLON);
			setState(182);
			code_block();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Method_variableContext extends ParserRuleContext {
		public TypeContext type() {
			return getRuleContext(TypeContext.class,0);
		}
		public TerminalNode SEMICOLON() { return getToken(LixirParser.SEMICOLON, 0); }
		public TerminalNode VALID_NAME() { return getToken(LixirParser.VALID_NAME, 0); }
		public Method_variableContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_method_variable; }
	}

	public final Method_variableContext method_variable() throws RecognitionException {
		Method_variableContext _localctx = new Method_variableContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_method_variable);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(184);
			type();
			setState(185);
			match(SEMICOLON);
			setState(186);
			match(VALID_NAME);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Code_blockContext extends ParserRuleContext {
		public TerminalNode OPEN_BRACKET() { return getToken(LixirParser.OPEN_BRACKET, 0); }
		public TerminalNode CLOSE_BRACKET() { return getToken(LixirParser.CLOSE_BRACKET, 0); }
		public List<InstructionContext> instruction() {
			return getRuleContexts(InstructionContext.class);
		}
		public InstructionContext instruction(int i) {
			return getRuleContext(InstructionContext.class,i);
		}
		public Code_blockContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_code_block; }
	}

	public final Code_blockContext code_block() throws RecognitionException {
		Code_blockContext _localctx = new Code_blockContext(_ctx, getState());
		enterRule(_localctx, 30, RULE_code_block);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(188);
			match(OPEN_BRACKET);
			setState(192);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << PRINT) | (1L << IF) | (1L << FOR) | (1L << RETURN) | (1L << VALID_NAME))) != 0)) {
				{
				{
				setState(189);
				instruction();
				}
				}
				setState(194);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(195);
			match(CLOSE_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Document_literalContext extends ParserRuleContext {
		public TerminalNode DOCUMENT() { return getToken(LixirParser.DOCUMENT, 0); }
		public TerminalNode SEMICOLON() { return getToken(LixirParser.SEMICOLON, 0); }
		public TerminalNode OPEN_BRACKET() { return getToken(LixirParser.OPEN_BRACKET, 0); }
		public Value_literalContext value_literal() {
			return getRuleContext(Value_literalContext.class,0);
		}
		public TerminalNode CLOSE_BRACKET() { return getToken(LixirParser.CLOSE_BRACKET, 0); }
		public Document_literalContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_document_literal; }
	}

	public final Document_literalContext document_literal() throws RecognitionException {
		Document_literalContext _localctx = new Document_literalContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_document_literal);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(197);
			match(DOCUMENT);
			setState(198);
			match(SEMICOLON);
			setState(199);
			match(OPEN_BRACKET);
			setState(200);
			value_literal();
			setState(201);
			match(CLOSE_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Node_literalContext extends ParserRuleContext {
		public TerminalNode NODE() { return getToken(LixirParser.NODE, 0); }
		public TerminalNode SEMICOLON() { return getToken(LixirParser.SEMICOLON, 0); }
		public TerminalNode OPEN_BRACKET() { return getToken(LixirParser.OPEN_BRACKET, 0); }
		public Value_literalContext value_literal() {
			return getRuleContext(Value_literalContext.class,0);
		}
		public TerminalNode CLOSE_BRACKET() { return getToken(LixirParser.CLOSE_BRACKET, 0); }
		public Node_literalContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_node_literal; }
	}

	public final Node_literalContext node_literal() throws RecognitionException {
		Node_literalContext _localctx = new Node_literalContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_node_literal);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(203);
			match(NODE);
			setState(204);
			match(SEMICOLON);
			setState(205);
			match(OPEN_BRACKET);
			setState(206);
			value_literal();
			setState(207);
			match(CLOSE_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Attribute_literalContext extends ParserRuleContext {
		public TerminalNode ATTRIBUTE() { return getToken(LixirParser.ATTRIBUTE, 0); }
		public TerminalNode SEMICOLON() { return getToken(LixirParser.SEMICOLON, 0); }
		public TerminalNode OPEN_BRACKET() { return getToken(LixirParser.OPEN_BRACKET, 0); }
		public TerminalNode EQUALS() { return getToken(LixirParser.EQUALS, 0); }
		public TerminalNode CLOSE_BRACKET() { return getToken(LixirParser.CLOSE_BRACKET, 0); }
		public List<String_literalContext> string_literal() {
			return getRuleContexts(String_literalContext.class);
		}
		public String_literalContext string_literal(int i) {
			return getRuleContext(String_literalContext.class,i);
		}
		public List<TerminalNode> VALID_NAME() { return getTokens(LixirParser.VALID_NAME); }
		public TerminalNode VALID_NAME(int i) {
			return getToken(LixirParser.VALID_NAME, i);
		}
		public Integer_literalContext integer_literal() {
			return getRuleContext(Integer_literalContext.class,0);
		}
		public Attribute_literalContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_attribute_literal; }
	}

	public final Attribute_literalContext attribute_literal() throws RecognitionException {
		Attribute_literalContext _localctx = new Attribute_literalContext(_ctx, getState());
		enterRule(_localctx, 36, RULE_attribute_literal);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(209);
			match(ATTRIBUTE);
			setState(210);
			match(SEMICOLON);
			setState(211);
			match(OPEN_BRACKET);
			setState(214);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case STRING_LINE:
				{
				setState(212);
				string_literal();
				}
				break;
			case VALID_NAME:
				{
				setState(213);
				match(VALID_NAME);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			setState(216);
			match(EQUALS);
			setState(220);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case VALID_INTEGER:
				{
				setState(217);
				integer_literal();
				}
				break;
			case STRING_LINE:
				{
				setState(218);
				string_literal();
				}
				break;
			case VALID_NAME:
				{
				setState(219);
				match(VALID_NAME);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			setState(222);
			match(CLOSE_BRACKET);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Value_literalContext extends ParserRuleContext {
		public List<TerminalNode> EQUALS() { return getTokens(LixirParser.EQUALS); }
		public TerminalNode EQUALS(int i) {
			return getToken(LixirParser.EQUALS, i);
		}
		public List<TerminalNode> COMMA() { return getTokens(LixirParser.COMMA); }
		public TerminalNode COMMA(int i) {
			return getToken(LixirParser.COMMA, i);
		}
		public List<String_literalContext> string_literal() {
			return getRuleContexts(String_literalContext.class);
		}
		public String_literalContext string_literal(int i) {
			return getRuleContext(String_literalContext.class,i);
		}
		public List<TerminalNode> VALID_NAME() { return getTokens(LixirParser.VALID_NAME); }
		public TerminalNode VALID_NAME(int i) {
			return getToken(LixirParser.VALID_NAME, i);
		}
		public List<Type_literalContext> type_literal() {
			return getRuleContexts(Type_literalContext.class);
		}
		public Type_literalContext type_literal(int i) {
			return getRuleContext(Type_literalContext.class,i);
		}
		public Value_literalContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_value_literal; }
	}

	public final Value_literalContext value_literal() throws RecognitionException {
		Value_literalContext _localctx = new Value_literalContext(_ctx, getState());
		enterRule(_localctx, 38, RULE_value_literal);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(233);
			_errHandler.sync(this);
			_la = _input.LA(1);
			if (_la==VALID_NAME || _la==STRING_LINE) {
				{
				setState(226);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case STRING_LINE:
					{
					setState(224);
					string_literal();
					}
					break;
				case VALID_NAME:
					{
					setState(225);
					match(VALID_NAME);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(228);
				match(EQUALS);
				setState(231);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case DOCUMENT:
				case NODE:
				case ATTRIBUTE:
				case VALID_INTEGER:
				case STRING_LINE:
					{
					setState(229);
					type_literal();
					}
					break;
				case VALID_NAME:
					{
					setState(230);
					match(VALID_NAME);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
			}

			setState(247);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==COMMA) {
				{
				{
				setState(235);
				match(COMMA);
				setState(238);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case STRING_LINE:
					{
					setState(236);
					string_literal();
					}
					break;
				case VALID_NAME:
					{
					setState(237);
					match(VALID_NAME);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(240);
				match(EQUALS);
				setState(243);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case DOCUMENT:
				case NODE:
				case ATTRIBUTE:
				case VALID_INTEGER:
				case STRING_LINE:
					{
					setState(241);
					type_literal();
					}
					break;
				case VALID_NAME:
					{
					setState(242);
					match(VALID_NAME);
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				}
				setState(249);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Integer_literalContext extends ParserRuleContext {
		public TerminalNode VALID_INTEGER() { return getToken(LixirParser.VALID_INTEGER, 0); }
		public Integer_literalContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_integer_literal; }
	}

	public final Integer_literalContext integer_literal() throws RecognitionException {
		Integer_literalContext _localctx = new Integer_literalContext(_ctx, getState());
		enterRule(_localctx, 40, RULE_integer_literal);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(250);
			match(VALID_INTEGER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class String_literalContext extends ParserRuleContext {
		public TerminalNode STRING_LINE() { return getToken(LixirParser.STRING_LINE, 0); }
		public String_literalContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_string_literal; }
	}

	public final String_literalContext string_literal() throws RecognitionException {
		String_literalContext _localctx = new String_literalContext(_ctx, getState());
		enterRule(_localctx, 42, RULE_string_literal);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(252);
			match(STRING_LINE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Print_instructionContext extends ParserRuleContext {
		public TerminalNode PRINT() { return getToken(LixirParser.PRINT, 0); }
		public String_literalContext string_literal() {
			return getRuleContext(String_literalContext.class,0);
		}
		public Print_instructionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_print_instruction; }
	}

	public final Print_instructionContext print_instruction() throws RecognitionException {
		Print_instructionContext _localctx = new Print_instructionContext(_ctx, getState());
		enterRule(_localctx, 44, RULE_print_instruction);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(254);
			match(PRINT);
			setState(255);
			string_literal();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3!\u0104\4\2\t\2\4"+
		"\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t"+
		"\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\3\2\3\2\3"+
		"\2\3\3\7\3\65\n\3\f\3\16\38\13\3\3\3\7\3;\n\3\f\3\16\3>\13\3\5\3@\n\3"+
		"\3\4\3\4\3\5\3\5\3\5\3\5\3\5\5\5I\n\5\3\6\3\6\3\6\3\6\3\6\3\6\5\6Q\n\6"+
		"\3\7\3\7\3\7\3\7\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\5\b`\n\b\3\b\3\b"+
		"\3\b\3\b\5\bf\n\b\3\b\3\b\3\b\3\b\5\bl\n\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b"+
		"\3\b\3\b\3\b\7\bx\n\b\f\b\16\b{\13\b\5\b}\n\b\3\t\3\t\3\t\5\t\u0082\n"+
		"\t\3\n\3\n\3\n\3\n\3\n\3\n\5\n\u008a\n\n\3\13\3\13\3\13\3\13\3\13\3\13"+
		"\3\13\3\13\5\13\u0094\n\13\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f"+
		"\3\f\3\f\5\f\u00a3\n\f\3\r\3\r\3\r\3\r\3\16\3\16\3\16\3\16\5\16\u00ad"+
		"\n\16\3\17\3\17\3\17\3\17\7\17\u00b3\n\17\f\17\16\17\u00b6\13\17\3\17"+
		"\3\17\3\17\3\20\3\20\3\20\3\20\3\21\3\21\7\21\u00c1\n\21\f\21\16\21\u00c4"+
		"\13\21\3\21\3\21\3\22\3\22\3\22\3\22\3\22\3\22\3\23\3\23\3\23\3\23\3\23"+
		"\3\23\3\24\3\24\3\24\3\24\3\24\5\24\u00d9\n\24\3\24\3\24\3\24\3\24\5\24"+
		"\u00df\n\24\3\24\3\24\3\25\3\25\5\25\u00e5\n\25\3\25\3\25\3\25\5\25\u00ea"+
		"\n\25\5\25\u00ec\n\25\3\25\3\25\3\25\5\25\u00f1\n\25\3\25\3\25\3\25\5"+
		"\25\u00f6\n\25\7\25\u00f8\n\25\f\25\16\25\u00fb\13\25\3\26\3\26\3\27\3"+
		"\27\3\30\3\30\3\30\3\30\2\2\31\2\4\6\b\n\f\16\20\22\24\26\30\32\34\36"+
		" \"$&(*,.\2\3\3\2\22\26\2\u0113\2\60\3\2\2\2\4?\3\2\2\2\6A\3\2\2\2\bH"+
		"\3\2\2\2\nP\3\2\2\2\fR\3\2\2\2\16|\3\2\2\2\20\u0081\3\2\2\2\22\u0083\3"+
		"\2\2\2\24\u0093\3\2\2\2\26\u00a2\3\2\2\2\30\u00a4\3\2\2\2\32\u00ac\3\2"+
		"\2\2\34\u00ae\3\2\2\2\36\u00ba\3\2\2\2 \u00be\3\2\2\2\"\u00c7\3\2\2\2"+
		"$\u00cd\3\2\2\2&\u00d3\3\2\2\2(\u00eb\3\2\2\2*\u00fc\3\2\2\2,\u00fe\3"+
		"\2\2\2.\u0100\3\2\2\2\60\61\5\4\3\2\61\62\7\2\2\3\62\3\3\2\2\2\63\65\5"+
		"\n\6\2\64\63\3\2\2\2\658\3\2\2\2\66\64\3\2\2\2\66\67\3\2\2\2\67@\3\2\2"+
		"\28\66\3\2\2\29;\5\34\17\2:9\3\2\2\2;>\3\2\2\2<:\3\2\2\2<=\3\2\2\2=@\3"+
		"\2\2\2><\3\2\2\2?\66\3\2\2\2?<\3\2\2\2@\5\3\2\2\2AB\t\2\2\2B\7\3\2\2\2"+
		"CI\5\"\22\2DI\5$\23\2EI\5&\24\2FI\5,\27\2GI\5*\26\2HC\3\2\2\2HD\3\2\2"+
		"\2HE\3\2\2\2HF\3\2\2\2HG\3\2\2\2I\t\3\2\2\2JQ\5\f\7\2KQ\5\22\n\2LQ\5\26"+
		"\f\2MQ\5\16\b\2NQ\5\32\16\2OQ\5.\30\2PJ\3\2\2\2PK\3\2\2\2PL\3\2\2\2PM"+
		"\3\2\2\2PN\3\2\2\2PO\3\2\2\2Q\13\3\2\2\2RS\7\36\2\2ST\7\5\2\2TU\5\b\5"+
		"\2U\r\3\2\2\2VW\7\36\2\2WX\7\b\2\2XY\7\33\2\2Y}\5,\27\2Z[\7\36\2\2[\\"+
		"\7\t\2\2\\_\7\33\2\2]`\5\b\5\2^`\7\36\2\2_]\3\2\2\2_^\3\2\2\2`}\3\2\2"+
		"\2ab\7\36\2\2be\7\6\2\2cf\7\36\2\2df\5\b\5\2ec\3\2\2\2ed\3\2\2\2f}\3\2"+
		"\2\2gh\7\36\2\2hk\7\7\2\2il\7\36\2\2jl\5\b\5\2ki\3\2\2\2kj\3\2\2\2l}\3"+
		"\2\2\2mn\7\36\2\2no\7\13\2\2o}\5,\27\2pq\7\36\2\2qr\7\f\2\2r}\5,\27\2"+
		"st\7\36\2\2tu\7\33\2\2uy\7\36\2\2vx\5\20\t\2wv\3\2\2\2x{\3\2\2\2yw\3\2"+
		"\2\2yz\3\2\2\2z}\3\2\2\2{y\3\2\2\2|V\3\2\2\2|Z\3\2\2\2|a\3\2\2\2|g\3\2"+
		"\2\2|m\3\2\2\2|p\3\2\2\2|s\3\2\2\2}\17\3\2\2\2~\u0082\5*\26\2\177\u0082"+
		"\5,\27\2\u0080\u0082\7\36\2\2\u0081~\3\2\2\2\u0081\177\3\2\2\2\u0081\u0080"+
		"\3\2\2\2\u0082\21\3\2\2\2\u0083\u0084\7\r\2\2\u0084\u0085\5\24\13\2\u0085"+
		"\u0086\7\27\2\2\u0086\u0089\5 \21\2\u0087\u0088\7\16\2\2\u0088\u008a\5"+
		" \21\2\u0089\u0087\3\2\2\2\u0089\u008a\3\2\2\2\u008a\23\3\2\2\2\u008b"+
		"\u008c\7\36\2\2\u008c\u008d\7\n\2\2\u008d\u0094\5,\27\2\u008e\u008f\7"+
		"\36\2\2\u008f\u0090\7\b\2\2\u0090\u0091\7\33\2\2\u0091\u0092\7\33\2\2"+
		"\u0092\u0094\5,\27\2\u0093\u008b\3\2\2\2\u0093\u008e\3\2\2\2\u0094\25"+
		"\3\2\2\2\u0095\u0096\7\17\2\2\u0096\u0097\7\36\2\2\u0097\u0098\7\20\2"+
		"\2\u0098\u0099\5\30\r\2\u0099\u009a\7\27\2\2\u009a\u009b\5 \21\2\u009b"+
		"\u00a3\3\2\2\2\u009c\u009d\7\17\2\2\u009d\u009e\7\36\2\2\u009e\u009f\7"+
		"\20\2\2\u009f\u00a0\7\36\2\2\u00a0\u00a1\7\27\2\2\u00a1\u00a3\5 \21\2"+
		"\u00a2\u0095\3\2\2\2\u00a2\u009c\3\2\2\2\u00a3\27\3\2\2\2\u00a4\u00a5"+
		"\5*\26\2\u00a5\u00a6\7\35\2\2\u00a6\u00a7\5*\26\2\u00a7\31\3\2\2\2\u00a8"+
		"\u00a9\7\21\2\2\u00a9\u00ad\5\b\5\2\u00aa\u00ab\7\21\2\2\u00ab\u00ad\7"+
		"\36\2\2\u00ac\u00a8\3\2\2\2\u00ac\u00aa\3\2\2\2\u00ad\33\3\2\2\2\u00ae"+
		"\u00af\7\4\2\2\u00af\u00b0\5\6\4\2\u00b0\u00b4\7\36\2\2\u00b1\u00b3\5"+
		"\36\20\2\u00b2\u00b1\3\2\2\2\u00b3\u00b6\3\2\2\2\u00b4\u00b2\3\2\2\2\u00b4"+
		"\u00b5\3\2\2\2\u00b5\u00b7\3\2\2\2\u00b6\u00b4\3\2\2\2\u00b7\u00b8\7\27"+
		"\2\2\u00b8\u00b9\5 \21\2\u00b9\35\3\2\2\2\u00ba\u00bb\5\6\4\2\u00bb\u00bc"+
		"\7\27\2\2\u00bc\u00bd\7\36\2\2\u00bd\37\3\2\2\2\u00be\u00c2\7\30\2\2\u00bf"+
		"\u00c1\5\n\6\2\u00c0\u00bf\3\2\2\2\u00c1\u00c4\3\2\2\2\u00c2\u00c0\3\2"+
		"\2\2\u00c2\u00c3\3\2\2\2\u00c3\u00c5\3\2\2\2\u00c4\u00c2\3\2\2\2\u00c5"+
		"\u00c6\7\31\2\2\u00c6!\3\2\2\2\u00c7\u00c8\7\22\2\2\u00c8\u00c9\7\27\2"+
		"\2\u00c9\u00ca\7\30\2\2\u00ca\u00cb\5(\25\2\u00cb\u00cc\7\31\2\2\u00cc"+
		"#\3\2\2\2\u00cd\u00ce\7\23\2\2\u00ce\u00cf\7\27\2\2\u00cf\u00d0\7\30\2"+
		"\2\u00d0\u00d1\5(\25\2\u00d1\u00d2\7\31\2\2\u00d2%\3\2\2\2\u00d3\u00d4"+
		"\7\24\2\2\u00d4\u00d5\7\27\2\2\u00d5\u00d8\7\30\2\2\u00d6\u00d9\5,\27"+
		"\2\u00d7\u00d9\7\36\2\2\u00d8\u00d6\3\2\2\2\u00d8\u00d7\3\2\2\2\u00d9"+
		"\u00da\3\2\2\2\u00da\u00de\7\33\2\2\u00db\u00df\5*\26\2\u00dc\u00df\5"+
		",\27\2\u00dd\u00df\7\36\2\2\u00de\u00db\3\2\2\2\u00de\u00dc\3\2\2\2\u00de"+
		"\u00dd\3\2\2\2\u00df\u00e0\3\2\2\2\u00e0\u00e1\7\31\2\2\u00e1\'\3\2\2"+
		"\2\u00e2\u00e5\5,\27\2\u00e3\u00e5\7\36\2\2\u00e4\u00e2\3\2\2\2\u00e4"+
		"\u00e3\3\2\2\2\u00e5\u00e6\3\2\2\2\u00e6\u00e9\7\33\2\2\u00e7\u00ea\5"+
		"\b\5\2\u00e8\u00ea\7\36\2\2\u00e9\u00e7\3\2\2\2\u00e9\u00e8\3\2\2\2\u00ea"+
		"\u00ec\3\2\2\2\u00eb\u00e4\3\2\2\2\u00eb\u00ec\3\2\2\2\u00ec\u00f9\3\2"+
		"\2\2\u00ed\u00f0\7\34\2\2\u00ee\u00f1\5,\27\2\u00ef\u00f1\7\36\2\2\u00f0"+
		"\u00ee\3\2\2\2\u00f0\u00ef\3\2\2\2\u00f1\u00f2\3\2\2\2\u00f2\u00f5\7\33"+
		"\2\2\u00f3\u00f6\5\b\5\2\u00f4\u00f6\7\36\2\2\u00f5\u00f3\3\2\2\2\u00f5"+
		"\u00f4\3\2\2\2\u00f6\u00f8\3\2\2\2\u00f7\u00ed\3\2\2\2\u00f8\u00fb\3\2"+
		"\2\2\u00f9\u00f7\3\2\2\2\u00f9\u00fa\3\2\2\2\u00fa)\3\2\2\2\u00fb\u00f9"+
		"\3\2\2\2\u00fc\u00fd\7\37\2\2\u00fd+\3\2\2\2\u00fe\u00ff\7 \2\2\u00ff"+
		"-\3\2\2\2\u0100\u0101\7\3\2\2\u0101\u0102\5,\27\2\u0102/\3\2\2\2\33\66"+
		"<?HP_eky|\u0081\u0089\u0093\u00a2\u00ac\u00b4\u00c2\u00d8\u00de\u00e4"+
		"\u00e9\u00eb\u00f0\u00f5\u00f9";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}