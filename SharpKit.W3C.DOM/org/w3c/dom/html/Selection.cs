//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.html
{

using SharpKit.JavaScript;
using Node = org.w3c.dom.Node;
using Range = org.w3c.dom.ranges.Range;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class Selection
{

	// Selection
	public Node anchorNode {get { return default(Node); } }
	public int anchorOffset {get { return default(int); } }
	public Node focusNode {get { return default(Node); } }
	public int focusOffset {get { return default(int); } }
	public bool isCollapsed {get { return default(bool); } }
	public void collapse(Node parentNode, int offset) {}
	public void collapseToStart() {}
	public void collapseToEnd() {}
	public void selectAllChildren(Node parentNode) {}
	public void deleteFromDocument() {}
	public int rangeCount {get { return default(int); } }
	public Range getRangeAt(int index) { return default(Range); }
	public void addRange(Range range) {}
	public void removeRange(Range range) {}
	public void removeAllRanges() {}
	public string toString() { return default(string); }
}

}