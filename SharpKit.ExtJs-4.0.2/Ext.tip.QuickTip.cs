//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.tip
namespace Ext.tip
{
    #region QuickTip
    /// <summary>
    /// A specialized tooltip class for tooltips that can be specified in markup and automatically managed by the global
    /// Ext.tip.QuickTipManager instance.  See the QuickTipManager class header for additional usage details and examples.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class QuickTip : ToolTip, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Hides a visible tip or cancels an impending show for a particular element. ...
        /// </summary>
        public object cancelShow(object el){return null;}
        /// <summary>
        /// Configures a new quick tip instance and assigns it to a target element. ...
        /// </summary>
        public object register(object config){return null;}
        /// <summary>
        /// Removes this quick tip from its element and destroys it. ...
        /// </summary>
        public object unregister(object el){return null;}
        public QuickTip(QuickTipConfig config){}
        public QuickTip(){}
    }
    #endregion
    #region QuickTipConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class QuickTipConfig : ToolTipConfig
    {
        public bool interceptTitles{get;set;}
        public new object target{get;set;}
    }
    #endregion
    #region QuickTipEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class QuickTipEvents : ToolTipEvents
    {
    }
    #endregion
}
#endregion
