//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.app
namespace Ext.app
{
    #region Controller
    /// <summary>
    /// Controllers are the glue that binds an application together. All they really do is listen for events (usually from
    /// views) and take some action. Here&#39;s how we might create a Controller to manage Users: Ext.define(&#39;MyApp.controller.Users&#39;, {
    /// extend: &#39;Ext.app.Controller&#39;,
    /// init: function() {
    /// console.log(&#39;Initialized Users! This happens before the Application launch function is called&#39;);
    /// }
    /// });
    /// The init function is a special method that is called when your application boots. It is called before the
    /// Application&#39;s launch function is executed so gives a hook point to run any code before
    /// your Viewport is created. The init function is a great place to set up how your controller interacts with the view, and is usually used in
    /// conjunction with another Controller function - control. The control function
    /// makes it easy to listen to events on your view classes and take some action with a handler function. Let&#39;s update
    /// our Users controller to tell us when the panel is rendered: Ext.define(&#39;MyApp.controller.Users&#39;, {
    /// extend: &#39;Ext.app.Controller&#39;,
    /// init: function() {
    /// this.control({
    /// &#39;viewport &amp;gt; panel&#39;: {
    /// render: this.onPanelRendered
    /// }
    /// });
    /// },
    /// onPanelRendered: function() {
    /// console.log(&#39;The panel was rendered&#39;);
    /// }
    /// });
    /// We&#39;ve updated the init function to use this.control to set up listeners on views in our application. The control
    /// function uses the new ComponentQuery engine to quickly and easily get references to components on the page. If you
    /// are not familiar with ComponentQuery yet, be sure to check out THIS GUIDE for a full explanation. In brief though,
    /// it allows us to pass a CSS-like selector that will find every matching component on the page. In our init function above we supplied &#39;viewport &gt; panel&#39;, which translates to &quot;find me every Panel that is a direct
    /// child of a Viewport&quot;. We then supplied an object that maps event names (just &#39;render&#39; in this case) to handler
    /// functions. The overall effect is that whenever any component that matches our selector fires a &#39;render&#39; event, our
    /// onPanelRendered function is called. Using refs One of the most useful parts of Controllers is the new ref system. These use the new Ext.ComponentQuery to
    /// make it really easy to get references to Views on your page. Let&#39;s look at an example of this now: Ext.define(&#39;MyApp.controller.Users&#39;, {
    /// extend: &#39;Ext.app.Controller&#39;,
    /// refs: [
    /// {
    /// ref: &#39;list&#39;,
    /// selector: &#39;grid&#39;
    /// }
    /// ],
    /// init: function() {
    /// this.control({
    /// &#39;button&#39;: {
    /// click: this.refreshGrid
    /// }
    /// });
    /// },
    /// refreshGrid: function() {
    /// this.getList().store.load();
    /// }
    /// });
    /// This example assumes the existence of a Grid on the page, which contains a single button to
    /// refresh the Grid when clicked. In our refs array, we set up a reference to the grid. There are two parts to this -
    /// the &#39;selector&#39;, which is a ComponentQuery selector which finds any grid on the page and
    /// assigns it to the reference &#39;list&#39;. By giving the reference a name, we get a number of things for free. The first is the getList function that we use in
    /// the refreshGrid method above. This is generated automatically by the Controller based on the name of our ref, which
    /// was capitalized and prepended with get to go from &#39;list&#39; to &#39;getList&#39;. The way this works is that the first time getList is called by your code, the ComponentQuery selector is run and the
    /// first component that matches the selector (&#39;grid&#39; in this case) will be returned. All future calls to getList will
    /// use a cached reference to that grid. Usually it is advised to use a specific ComponentQuery selector that will only
    /// match a single View in your application (in the case above our selector will match any grid on the page). Bringing it all together, our init function is called when the application boots, at which time we call this.control
    /// to listen to any click on a button and call our refreshGrid function (again, this will
    /// match any button on the page so we advise a more specific selector than just &#39;button&#39;, but have left it this way for
    /// simplicity). When the button is clicked we use out getList function to refresh the grid. You can create any number of refs and control any number of components this way, simply adding more functions to
    /// your Controller as you go. For an example of real-world usage of Controllers see the Feed Viewer example in the
    /// examples/app/feed-viewer folder in the SDK download. Generated getter methods Refs aren&#39;t the only thing that generate convenient getter methods. Controllers often have to deal with Models and
    /// Stores so the framework offers a couple of easy ways to get access to those too. Let&#39;s look at another example: Ext.define(&#39;MyApp.controller.Users&#39;, {
    /// extend: &#39;Ext.app.Controller&#39;,
    /// models: [&#39;User&#39;],
    /// stores: [&#39;AllUsers&#39;, &#39;AdminUsers&#39;],
    /// init: function() {
    /// var User = this.getUserModel(),
    /// allUsers = this.getAllUsersStore();
    /// var ed = new User({name: &#39;Ed&#39;});
    /// allUsers.add(ed);
    /// }
    /// });
    /// By specifying Models and Stores that the Controller cares about, it again dynamically loads them from the appropriate
    /// locations (app/model/User.js, app/store/AllUsers.js and app/store/AdminUsers.js in this case) and creates getter
    /// functions for them all. The example above will create a new User model instance and add it to the AllUsers Store.
    /// Of course, you could do anything in this function but in this case we just did something simple to demonstrate the
    /// functionality. Further Reading For more information about writing Ext JS 4 applications, please see the
    /// application architecture guide. Also see the Ext.app.Application documentation.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Controller : Ext.Base, Ext.util.Observable
    {
        /// <summary>
        /// Creates new Controller. ...
        /// </summary>
        public Controller(object config=null){}
        /// <summary>
        /// Adds the specified events to the list of events which this Observable may fire. ...
        /// </summary>
        public object addEvents( object o, params object[] more ){return null;}
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
        /// Adds listeners to components selected via Ext.ComponentQuery. ...
        /// </summary>
        public object control(object selectors, object listeners){return null;}
        /// <summary>
        /// Enables events fired by this Observable to bubble up an owner hierarchy by calling this.getBubbleTarget() if
        /// present. ...
        /// </summary>
        public object enableBubble(object events){return null;}
        /// <summary>
        /// Fires the specified event with the passed parameters (minus the event name, plus the options object passed
        /// to addList...
        /// </summary>
        public bool fireEvent( JsString eventName, params object[] args ){return false;}
        /// <summary>
        /// Returns a reference to a controller with the given name ...
        /// </summary>
        public object getController(object name){return null;}
        /// <summary>
        /// Returns a reference to a Model with the given name ...
        /// </summary>
        public object getModel(object name){return null;}
        /// <summary>
        /// Returns a reference to a store with the given name ...
        /// </summary>
        public object getStore(object name){return null;}
        /// <summary>
        /// Returns a reference to a view with the given name ...
        /// </summary>
        public object getView(object name){return null;}
        /// <summary>
        /// Checks to see if this object has any listeners for a specified event ...
        /// </summary>
        public bool hasListener(JsString eventName){return false;}
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
        public object relayEvents( object origin, object events, object prefix ){return null;}
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
        public Controller(ControllerConfig config){}
    }
    #endregion
    #region ControllerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ControllerConfig : Ext.BaseConfig
    {
        /// <summary>
        /// The id of this controller. ...
        /// </summary>
        public JsString id{get;set;}
        /// <summary>
        /// A config object containing one or more event handlers to be added to this object during initialization. ...
        /// </summary>
        public object listeners{get;set;}

        public object[] views { get; set; }
        public object refs { get; set; }
    }
    #endregion
    #region ControllerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ControllerEvents : Ext.BaseEvents
    {
    }
    #endregion
}
#endregion
