//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.tip
namespace Ext.tip
{
    #region QuickTipManager
    /// <summary>
    /// Provides attractive and customizable tooltips for any element. The QuickTips
    /// singleton is used to configure and manage tooltips globally for multiple elements
    /// in a generic manner.  To create individual tooltips with maximum customizability,
    /// you should consider either Ext.tip.Tip or Ext.tip.ToolTip. Quicktips can be configured via tag attributes directly in markup, or by
    /// registering quick tips programmatically via the register method. The singleton&#39;s instance of Ext.tip.QuickTip is available via
    /// getQuickTip, and supports all the methods, and all the all the
    /// configuration properties of Ext.tip.QuickTip. These settings will apply to all
    /// tooltips shown by the singleton. Below is the summary of the configuration properties which can be used.
    /// For detailed descriptions see the config options for the QuickTip class QuickTips singleton configs (all are optional)  dismissDelay hideDelay maxWidth minWidth showDelay trackMouse  Target element configs (optional unless otherwise noted)  autoHide cls dismissDelay (overrides singleton value) target (required) text (required) title width  Here is an example showing how some of these config options could be used:  Code // Init the singleton.  Any tag-based quick tips will start working.
    /// Ext.tip.QuickTipManager.init();
    /// // Apply a set of config properties to the singleton
    /// Ext.apply(Ext.tip.QuickTipManager.getQuickTip(), {
    /// maxWidth: 200,
    /// minWidth: 100,
    /// showDelay: 50      // Show 50ms after entering target
    /// });
    /// // Create a small panel to add a quick tip to
    /// Ext.create(&#39;Ext.container.Container&#39;, {
    /// id: &#39;quickTipContainer&#39;,
    /// width: 200,
    /// height: 150,
    /// style: {
    /// backgroundColor:&#39;#000000&#39;
    /// },
    /// renderTo: Ext.getBody()
    /// });
    /// // Manually register a quick tip for a specific element
    /// Ext.tip.QuickTipManager.register({
    /// target: &#39;quickTipContainer&#39;,
    /// title: &#39;My Tooltip&#39;,
    /// text: &#39;This tooltip was added in code&#39;,
    /// width: 100,
    /// dismissDelay: 10000 // Hide after 10 seconds hover
    /// });
    /// To register a quick tip in markup, you simply add one or more of the valid QuickTip attributes prefixed with
    /// the data- namespace.  The HTML element itself is automatically set as the quick tip target. Here is the summary
    /// of supported attributes (optional unless otherwise noted):  hide: Specifying &quot;user&quot; is equivalent to setting autoHide = false.  Any other value will be the same as autoHide = true. qclass: A CSS class to be applied to the quick tip (equivalent to the &#39;cls&#39; target element config). qtip (required): The quick tip text (equivalent to the &#39;text&#39; target element config). qtitle: The quick tip title (equivalent to the &#39;title&#39; target element config). qwidth: The quick tip width (equivalent to the &#39;width&#39; target element config).  Here is an example of configuring an HTML element to display a tooltip from markup: // Add a quick tip to an HTML button
    /// &amp;lt;input type=&quot;button&quot; value=&quot;OK&quot; data-qtitle=&quot;OK Button&quot; data-qwidth=&quot;100&quot;
    /// data-qtip=&quot;This is a quick tip from markup!&quot;&amp;gt;&amp;lt;/input&amp;gt;
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class QuickTipManager : Ext.Base
    {
        /// <summary>
        /// Destroy the QuickTips instance. ...
        /// </summary>
        public object destroy(){return null;}
        /// <summary>
        /// Disable quick tips globally. ...
        /// </summary>
        public object disable(){return null;}
        /// <summary>
        /// Enable quick tips globally. ...
        /// </summary>
        public object enable(){return null;}
        /// <summary>
        /// Gets the single QuickTip instance used to show tips from all registered elements. ...
        /// </summary>
        public QuickTip getQuickTip(){return null;}
        /// <summary>
        /// Returns true if quick tips are enabled, else false. ...
        /// </summary>
        public bool isEnabled(){return false;}
    }
    #endregion
    #region QuickTipManagerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class QuickTipManagerConfig
    {
    }
    #endregion
    #region QuickTipManagerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class QuickTipManagerEvents
    {
    }
    #endregion
}
#endregion
