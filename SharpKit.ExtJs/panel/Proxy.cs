//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
using Ext.Unknown;
#region Ext.panel
namespace Ext.panel
{
    #region Proxy
    /// <summary>
    /// A custom drag proxy implementation specific to Ext.panel.Panels. This class
    /// is primarily used internally for the Panel&#39;s drag drop implementation, and
    /// should never need to be created directly.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Proxy
    {
        /// <summary>
        /// Creates new panel proxy. ...
        /// </summary>
        public Proxy(Ext.panel.Panel panel, object config=null){}
        /// <summary>
        /// Gets the proxy's element ...
        /// </summary>
        public Ext.Element getEl(){return null;}
        /// <summary>
        /// Gets the proxy's ghost Panel ...
        /// </summary>
        public Panel getGhost(){return null;}
        /// <summary>
        /// Gets the proxy element. ...
        /// </summary>
        public Ext.Element getProxy(){return null;}
        /// <summary>
        /// Hides the proxy ...
        /// </summary>
        public object hide(){return null;}
        /// <summary>
        /// Moves the proxy to a different position in the DOM. ...
        /// </summary>
        public object moveProxy(HTMLElement parentNode, HTMLElement before=null){return null;}
        /// <summary>
        /// Shows the proxy ...
        /// </summary>
        public object show(){return null;}
        public Ext.panel.Panel panel{get;set;}
        public Proxy(Ext.panel.ProxyConfig config){}
        public Proxy(){}
    }
    #endregion
    #region ProxyConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ProxyConfig
    {
        /// <summary>
        /// True to insert a placeholder proxy element
        /// while dragging the panel, false to drag with no proxy (defaults to true). ...
        /// </summary>
        public bool insertProxy{get;set;}
    }
    #endregion
    #region ProxyEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ProxyEvents
    {
    }
    #endregion
}
#endregion