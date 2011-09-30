using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.events
{

    public class EventException : Exception
    {
        public EventException(short code, JsString message) : base(message)
        {
            this.code = code;
        }
        public const short UNSPECIFIED_EVENT_TYPE_ERR = 0;
        public const short DISPATCH_REQUEST_ERR = 1;
        public short code;
    }

}