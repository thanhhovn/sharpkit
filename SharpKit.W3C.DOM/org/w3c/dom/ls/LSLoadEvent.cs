//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.ls
{

using SharpKit.JavaScript;
using Document = org.w3c.dom.Document;
using Event = org.w3c.dom.events.Event;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class LSLoadEvent : Event
{

	// LSLoadEvent
	public Document newDocument {get { return default(Document); } }
	public LSInput input {get { return default(LSInput); } }
}

}