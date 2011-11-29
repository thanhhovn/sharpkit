//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.html
{

using SharpKit.JavaScript;
using NodeList = org.w3c.dom.NodeList;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class HTMLSelectElement : HTMLElement
{

	// HTMLSelectElement
	public bool autofocus {get { return default(bool); } set {}}
	public bool disabled {get { return default(bool); } set {}}
	public HTMLFormElement form {get { return default(HTMLFormElement); } }
	public bool multiple {get { return default(bool); } set {}}
	public string name {get { return default(string); } set {}}
	public int size {get { return default(int); } set {}}
	public string type {get { return default(string); } }
	public HTMLOptionsCollection options {get { return default(HTMLOptionsCollection); } }
	public int length {get { return default(int); } set {}}
	[JsProperty(NativeIndexer = true)]
	public object this[int index] {get { return default(object); } }
	[JsProperty(NativeIndexer = true)]
	public object this[string name] {get { return default(object); } }
	public void add(HTMLElement element) {}
	public void add(HTMLElement element, HTMLElement before) {}
	public void add(HTMLElement element, int before) {}
	public void remove(int index) {}
	public HTMLCollection selectedOptions {get { return default(HTMLCollection); } }
	public int selectedIndex {get { return default(int); } set {}}
	public string value {get { return default(string); } set {}}
	public bool willValidate {get { return default(bool); } }
	public ValidityState validity {get { return default(ValidityState); } }
	public string validationMessage {get { return default(string); } }
	public bool checkValidity() { return default(bool); }
	public void setCustomValidity(string error) {}
	public NodeList labels {get { return default(NodeList); } }
}

}