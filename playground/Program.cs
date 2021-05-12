
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
    public virtual string _Save() {return "Error";}
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
        return $"<{Name}>{Value.ToString()}</{Name}>";
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
        xml.AppendLine($"<{Name}>");
        foreach (var node in Value)
        {
            xml.AppendLine(node._Save());
        }
        xml.AppendLine($"</{Name}>");
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

public static void Main() {
_node node = new("root");
foreach (var i in Range(1, 5))
{
node._add(_fac._attr(i, i));
}


_attribute attr = new("Alice", "Wonderland");
node._add(attr);
node._add(_fac._node("Child", _fac._attr("ChildrenAge", 20)
,
_fac._node("SubChild", _fac._attr("AliceName", "Alice")
)
));

{
    var xml = node._Save();
    File.WriteAllText("my.xml", xml);
}
}
}
