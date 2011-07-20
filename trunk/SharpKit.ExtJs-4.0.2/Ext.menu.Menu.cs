//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:52:01
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.menu
namespace Ext.menu
{
    #region Menu
    /// <summary>
    /// A menu object. This is the container to which you may add menu items. Menus may contain either menu items, or general Components.
    /// Menus may also contain docked items because it extends Ext.panel.Panel. To make a contained general Component line up with other menu items,
    /// specify iconCls: &#39;no-icon&#39; or indent: true.
    /// This reserves a space for an icon, and indents the Component in line with the other menu items.
    /// See Ext.form.field.ComboBox.getListParent for an example. By default, Menus are absolutely positioned, floating Components. By configuring a Menu with floating:false,
    /// a Menu may be used as a child of a Container.  Example Usage Ext.create(&#39;Ext.menu.Menu&#39;, {
    /// width: 100,
    /// height: 100,
    /// margin: &#39;0 0 10 0&#39;,
    /// floating: false,  // usually you want this set to True (default)
    /// renderTo: Ext.getBody(),  // usually rendered by it&#39;s containing component
    /// items: [{
    /// text: &#39;regular item 1&#39;
    /// },{
    /// text: &#39;regular item 2&#39;
    /// },{
    /// text: &#39;regular item 3&#39;
    /// }]
    /// });
    /// Ext.create(&#39;Ext.menu.Menu&#39;, {
    /// width: 100,
    /// height: 100,
    /// plain: true,
    /// floating: false,  // usually you want this set to True (default)
    /// renderTo: Ext.getBody(),  // usually rendered by it&#39;s containing component
    /// items: [{
    /// text: &#39;plain item 1&#39;
    /// },{
    /// text: &#39;plain item 2&#39;
    /// },{
    /// text: &#39;plain item 3&#39;
    /// }]
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Menu : Ext.panel.Panel, Ext.util.Floating, Ext.util.Observable, Ext.util.Animate, Ext.state.Stateful
    {
        /// <summary>
        /// Returns whether a menu item can be activated or not. ...
        /// </summary>
        public bool canActivateItem(object item){return false;}
        /// <summary>
        /// Deactivates the current active item on the menu, if one exists. ...
        /// </summary>
        public object deactivateActiveItem(){return null;}
        /// <summary>
        /// Shows the floating menu by the specified Component or Element. ...
        /// </summary>
        public Menu showBy(object The, JsString position=null, JsArray offsets=null){return null;}
    }
    #endregion
    #region MenuConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class MenuConfig
    {
        /// <summary>
        /// True to allow multiple menus to be displayed at the same time. ...
        /// </summary>
        public bool allowOtherMenus{get;set;}
        /// <summary>
        /// The default Ext.core.Element#getAlignToXY anchor position value for this menu
        /// relative to its element of origin. ...
        /// </summary>
        public JsString defaultAlign{get;set;}
        /// <summary>
        /// A Menu configured as floating: true (the default) will be rendered as an absolutely positioned,
        /// floating Component. ...
        /// </summary>
        public bool floating{get;set;}
        /// <summary>
        /// True to initially render the Menu as hidden, requiring to be shown manually. ...
        /// </summary>
        public bool hidden{get;set;}
        /// <summary>
        /// True to ignore clicks on any item in this menu that is a parent item (displays a submenu)
        /// so that the submenu is not ...
        /// </summary>
        public bool ignoreParentClicks{get;set;}
        /// <summary>
        /// The minimum width of the Menu. ...
        /// </summary>
        public JsNumber minWidth{get;set;}
        /// <summary>
        /// True to remove the incised line down the left side of the menu and to not
        /// indent general Component items. ...
        /// </summary>
        public bool plain{get;set;}
        /// <summary>
        /// True to show the icon separator. ...
        /// </summary>
        public bool showSeparator{get;set;}
    }
    #endregion
    #region MenuEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class MenuEvents
    {
        /// <summary>
        /// Fires when this menu is clicked ...
        /// </summary>
        public static JsString click="click";
        /// <summary>
        /// Fires when the mouse enters this menu ...
        /// </summary>
        public static JsString mouseenter="mouseenter";
        /// <summary>
        /// Fires when the mouse leaves this menu ...
        /// </summary>
        public static JsString mouseleave="mouseleave";
        /// <summary>
        /// Fires when the mouse is hovering over this menu ...
        /// </summary>
        public static JsString mouseover="mouseover";
    }
    #endregion
}
#endregion
