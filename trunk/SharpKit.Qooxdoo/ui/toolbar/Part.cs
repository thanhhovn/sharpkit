// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;

namespace qx.ui.toolbar
{
    /// <summary>
	/// <para>A part is a container for multiple toolbar buttons. Each part comes
	/// with a handle which may be used in later versions to drag the part
	/// around and move it to another position. Currently mainly used
	/// for structuring large toolbars beyond the capabilities of the
	/// <see cref="Separator"/>.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.toolbar.Part", OmitOptionalParameters = true, Export = false)]
    public partial class Part : qx.ui.core.Widget
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Show"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeShow;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		/// <summary>
		/// <para>Whether icons, labels, both or none should be shown.</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "both","label","icon"
		/// </remarks>
		[JsProperty(Name = "show", NativeField = true)]
		public object Show { get; set; }

		/// <summary>
		/// <para>The spacing between every child of the toolbar</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "spacing", NativeField = true)]
		public double Spacing { get; set; }

		#endregion Properties

		#region Methods

		public Part() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a separator to the toolbar part.</para>
		/// </summary>
		[JsMethod(Name = "addSeparator")]
		public void AddSeparator() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the widget which contains the children and
		/// is relevant for laying them out. This is from the user point of
		/// view and may not be identical to the technical structure.</para>
		/// </summary>
		/// <returns>Widget which contains the children.</returns>
		[JsMethod(Name = "getChildrenContainer")]
		public qx.ui.core.Widget GetChildrenContainer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns all nested buttons which contains a menu to show. This is mainly
		/// used for keyboard support.</para>
		/// </summary>
		/// <returns>List of all menu buttons</returns>
		[JsMethod(Name = "getMenuButtons")]
		public JsArray GetMenuButtons() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property show.</para>
		/// </summary>
		[JsMethod(Name = "getShow")]
		public object GetShow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property spacing.</para>
		/// </summary>
		[JsMethod(Name = "getSpacing")]
		public double GetSpacing() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property show
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property show.</param>
		[JsMethod(Name = "initShow")]
		public void InitShow(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property spacing
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property spacing.</param>
		[JsMethod(Name = "initSpacing")]
		public void InitSpacing(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property show.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetShow")]
		public void ResetShow() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property spacing.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSpacing")]
		public void ResetSpacing() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property show.</para>
		/// </summary>
		/// <param name="value">New value for property show.</param>
		[JsMethod(Name = "setShow")]
		public void SetShow(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property spacing.</para>
		/// </summary>
		/// <param name="value">New value for property spacing.</param>
		[JsMethod(Name = "setSpacing")]
		public void SetSpacing(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a new child widget.</para>
		/// <para>The supported keys of the layout options map depend on the layout manager
		/// used to position the widget. The options are documented in the class
		/// documentation of each layout manager <see cref="qx.ui.layout"/>.</para>
		/// </summary>
		/// <param name="child">the item to add.</param>
		/// <param name="options">Optional layout data for item.</param>
		/// <returns>This object (for chaining support)</returns>
		[JsMethod(Name = "add")]
		public Widget Add(LayoutItem child, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add an item after another already inserted item</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">item to add</param>
		/// <param name="after">item, after which the new item will be inserted</param>
		/// <param name="options">Optional layout data for item.</param>
		[JsMethod(Name = "addAfter")]
		public void AddAfter(LayoutItem child, LayoutItem after, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a child at the specified index</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">item to add</param>
		/// <param name="index">Index, at which the item will be inserted</param>
		/// <param name="options">Optional layout data for item.</param>
		[JsMethod(Name = "addAt")]
		public void AddAt(LayoutItem child, double index, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add an item before another already inserted item</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">item to add</param>
		/// <param name="before">item before the new item will be inserted.</param>
		/// <param name="options">Optional layout data for item.</param>
		[JsMethod(Name = "addBefore")]
		public void AddBefore(LayoutItem child, LayoutItem before, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the children list</para>
		/// </summary>
		/// <returns>The children array (Arrays are reference types, please to not modify them in-place)</returns>
		[JsMethod(Name = "getChildren")]
		public LayoutItem GetChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the widget contains children.</para>
		/// </summary>
		/// <returns>Returns true when the widget has children.</returns>
		[JsMethod(Name = "hasChildren")]
		public bool HasChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the index position of the given item if it is
		/// a child item. Otherwise it returns -1.</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">the item to query for</param>
		/// <returns>The index position or -1 when the given item is no child of this layout.</returns>
		[JsMethod(Name = "indexOf")]
		public double IndexOf(LayoutItem child) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the given child item.</para>
		/// </summary>
		/// <param name="child">the item to remove</param>
		/// <returns>This object (for chaining support)</returns>
		[JsMethod(Name = "remove")]
		public Widget Remove(LayoutItem child) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove all children.</para>
		/// </summary>
		/// <returns>An array containing the removed children.</returns>
		[JsMethod(Name = "removeAll")]
		public JsArray RemoveAll() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the item at the specified index.</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="index">Index of the item to remove.</param>
		/// <returns>The removed item</returns>
		[JsMethod(Name = "removeAt")]
		public qx.ui.core.LayoutItem RemoveAt(double index) { throw new NotImplementedException(); }

		#endregion Methods
    }
}