//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.button
namespace Ext.button
{
    #region Cycle
    /// <summary>
    /// A specialized SplitButton that contains a menu of Ext.menu.CheckItem elements.  The button automatically
    /// cycles through each menu item on click, raising the button&#39;s change event (or calling the button&#39;s
    /// changeHandler function, if supplied) for the active menu item. Clicking on the arrow section of the
    /// button displays the dropdown menu just like a normal SplitButton.
    /// Example usage: Ext.create(&#39;Ext.button.Cycle&#39;, {
    /// showText: true,
    /// prependText: &#39;View as &#39;,
    /// renderTo: Ext.getBody(),
    /// menu: {
    /// id: &#39;view-type-menu&#39;,
    /// items: [{
    /// text:&#39;text only&#39;,
    /// iconCls:&#39;view-text&#39;,
    /// checked:true
    /// },{
    /// text:&#39;HTML&#39;,
    /// iconCls:&#39;view-html&#39;
    /// }]
    /// },
    /// changeHandler:function(cycleBtn, activeItem){
    /// Ext.Msg.alert(&#39;Change View&#39;, activeItem.text);
    /// }
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Cycle : Split, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Gets the currently active menu item. ...
        /// </summary>
        public Ext.menu.CheckItem getActiveItem(){return null;}
        /// <summary>
        /// Sets the button's active menu item. ...
        /// </summary>
        public object setActiveItem(Ext.menu.CheckItem item, bool suppressEvent){return null;}
        /// <summary>
        /// This is normally called internally on button click, but can be called externally to advance the button's
        /// active item ...
        /// </summary>
        public object toggleSelected(){return null;}
        public new Ext.menu.Menu menu{get;set;}
        public Cycle(CycleConfig config){}
        public Cycle(){}
    }
    #endregion
    #region CycleConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class CycleConfig : SplitConfig
    {
        /// <summary>
        /// A callback function that will be invoked each time the active menu
        /// item in the button's menu has changed. ...
        /// </summary>
        public JsAction changeHandler{get;set;}
        /// <summary>
        /// A css class which sets an image to be used as the static icon for this button. ...
        /// </summary>
        public JsString forceIcon{get;set;}
        /// <summary>
        /// Deprecated as of 4.0. ...
        /// </summary>
        public JsArray items{get;set;}
        /// <summary>
        /// A static string to prepend before the active item's text when displayed as the
        /// button's text (only applies when showT...
        /// </summary>
        public JsString prependText{get;set;}
        /// <summary>
        /// True to display the active item's text as the button text (defaults to false). ...
        /// </summary>
        public bool showText{get;set;}
    }
    #endregion
    #region CycleEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class CycleEvents : SplitEvents
    {
        /// <summary>
        /// Fires after the button's active menu item has changed. ...
        /// </summary>
        public static JsString change="change";
    }
    #endregion
}
#endregion
