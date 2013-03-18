// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.tree
{
    /// <summary>
	/// <para>The tree item is a tree element for the <see cref="VirtualTree"/>, which can have
	/// nested tree elements.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.tree.VirtualTreeItem", OmitOptionalParameters = true, Export = false)]
    public partial class VirtualTreeItem : qx.ui.tree.core.AbstractItem
    {
		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		#endregion Properties

		#region Methods

		public VirtualTreeItem() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the item&#8217;s nesting level. If the item is not part of a tree
		/// this function will return null.</para>
		/// </summary>
		/// <returns>The item&#8217;s nesting level or null.</returns>
		[JsMethod(Name = "getLevel")]
		public double GetLevel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the item has any children</para>
		/// </summary>
		/// <returns>Whether the item has any children.</returns>
		[JsMethod(Name = "hasChildren")]
		public bool HasChildren() { throw new NotImplementedException(); }

		#endregion Methods
    }
}