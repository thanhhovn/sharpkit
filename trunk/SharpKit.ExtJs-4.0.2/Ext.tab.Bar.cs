//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:52:01
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.tab
namespace Ext.tab
{
    #region Bar
    /// <summary>
    /// TabBar is used internally by a TabPanel and wouldn&#39;t usually need to be created manually.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Bar : Ext.panel.Header, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
    }
    #endregion
    #region BarConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class BarConfig
    {
        public bool Boolean{get;set;}
        /// <summary>
        /// The maximum width for each tab. ...
        /// </summary>
        public JsNumber maxTabWidth{get;set;}
        /// <summary>
        /// The minimum width for each tab. ...
        /// </summary>
        public JsNumber minTabWidth{get;set;}
    }
    #endregion
    #region BarEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class BarEvents
    {
        /// <summary>
        /// Fired when the currently-active tab has changed ...
        /// </summary>
        public static JsString change="change";
    }
    #endregion
}
#endregion
