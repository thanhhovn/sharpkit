//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:51:04
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.direct
namespace Ext.direct
{
    #region Provider
    /// <summary>
    /// Ext.direct.Provider is an abstract class meant to be extended. For example ExtJs implements the following subclasses: Provider
    /// |
    /// +---JsonProvider
    /// |
    /// +---PollingProvider
    /// |
    /// +---RemotingProvider
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Provider : Ext.Base, Ext.util.Observable
    {
        /// <summary>
        /// Adds the specified events to the list of events which this Observable may fire. ...
        /// </summary>
        public object addEvents(object o, JsString more){return null;}
        /// <summary>
        /// Appends an event handler to this object. ...
        /// </summary>
        public object addListener(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Adds listeners to any Observable object (or Element) which are automatically removed when this Component is
        /// destroyed. ...
        /// </summary>
        public object addManagedListener(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Removes all listeners for this object including the managed listeners ...
        /// </summary>
        public object clearListeners(){return null;}
        /// <summary>
        /// Removes all managed listeners for this object. ...
        /// </summary>
        public object clearManagedListeners(){return null;}
        /// <summary>
        /// Abstract methods for subclasses to implement. ...
        /// </summary>
        public object connect(){return null;}
        /// <summary>
        /// Abstract methods for subclasses to implement. ...
        /// </summary>
        public object disconnect(){return null;}
        /// <summary>
        /// Enables events fired by this Observable to bubble up an owner hierarchy by calling this.getBubbleTarget() if
        /// present. ...
        /// </summary>
        public object enableBubble(object events){return null;}
        /// <summary>
        /// Fires the specified event with the passed parameters (minus the event name, plus the options object passed
        /// to addList...
        /// </summary>
        public bool fireEvent(JsString eventName, object args){return false;}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event ...
        /// </summary>
        public bool hasListener(JsString eventName){return false;}
        /// <summary>
        /// Returns whether or not the server-side is currently connected. ...
        /// </summary>
        public object isConnected(){return null;}
        /// <summary>
        /// Shorthand for addManagedListener. ...
        /// </summary>
        public object mon(object item, object ename, JsAction fn=null, object scope=null, object opt=null){return null;}
        /// <summary>
        /// Shorthand for removeManagedListener. ...
        /// </summary>
        public object mun(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Shorthand for addListener. ...
        /// </summary>
        public object on(JsString eventName, JsAction handler, object scope=null, object options=null){return null;}
        /// <summary>
        /// Relays selected events from the specified Observable as if the events were fired by this. ...
        /// </summary>
        public object relayEvents(object origin, JsString events, object prefix){return null;}
        /// <summary>
        /// Removes an event handler. ...
        /// </summary>
        public object removeListener(JsString eventName, JsAction handler, object scope=null){return null;}
        /// <summary>
        /// Removes listeners that were added by the mon method. ...
        /// </summary>
        public object removeManagedListener(object item, object ename, JsAction fn, object scope){return null;}
        /// <summary>
        /// Resumes firing events (see suspendEvents). ...
        /// </summary>
        public object resumeEvents(){return null;}
        /// <summary>
        /// Suspends the firing of all events. ...
        /// </summary>
        public object suspendEvents(bool queueSuspended){return null;}
        /// <summary>
        /// Shorthand for removeListener. ...
        /// </summary>
        public object un(JsString eventName, JsAction handler, object scope=null){return null;}
    }
    #endregion
    #region ProviderConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ProviderConfig
    {
        /// <summary>
        /// The unique id of the provider (defaults to an auto-assigned id). ...
        /// </summary>
        public JsString id{get;set;}
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public object listeners{get;set;}
    }
    #endregion
    #region ProviderEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ProviderEvents
    {
        /// <summary>
        /// Fires when the Provider connects to the server-side ...
        /// </summary>
        public static JsString connect="connect";
        /// <summary>
        /// Fires when the Provider receives data from the server-side ...
        /// </summary>
        public static JsString data="data";
        /// <summary>
        /// Fires when the Provider disconnects from the server-side ...
        /// </summary>
        public static JsString disconnect="disconnect";
        /// <summary>
        /// Fires when the Provider receives an exception from the server-side ...
        /// </summary>
        public static JsString exception="exception";
    }
    #endregion
}
#endregion
