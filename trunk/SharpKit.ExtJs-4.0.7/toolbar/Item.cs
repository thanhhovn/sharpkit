//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.toolbar
namespace Ext.toolbar
{
    #region Item
    /// <summary>
    /// The base class that other non-interacting Toolbar Item classes should extend in order to
    /// get some basic common toolbar item functionality.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Item : Ext.Component, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        public Item(Ext.toolbar.ItemConfig config){}
        public Item(){}
    }
    #endregion
    #region ItemConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ItemConfig : Ext.ComponentConfig
    {
        public JsString overflowText{get;set;}
    }
    #endregion
    #region ItemEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ItemEvents : Ext.ComponentEvents
    {
    }
    #endregion
}
#endregion