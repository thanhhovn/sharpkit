//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.indexeddb
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class IDBCursorRequest : IDBCursor
{

	// IDBCursorRequest
	public IDBRequest request {get { return default(IDBRequest); } }
	public object key {get { return default(object); } }
	public object value {get { return default(object); } }
	public long count {get { return default(long); } }
	public void update(object value) {}
	public void _continue() {}
	public void _continue(object key) {}
	public void remove() {}
}

}