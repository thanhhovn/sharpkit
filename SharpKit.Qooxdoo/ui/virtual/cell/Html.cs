// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.cell
{
    /// <summary>
	/// <para>EXPERIMENTAL!</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.virtual.cell.Html", OmitOptionalParameters = true, Export = false)]
    public partial class Html : qx.ui.virtualx.cell.Cell
    {
		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this cell.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		#endregion Properties

		#region Methods

		public Html() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get cell&#8217;S HTML content</para>
		/// </summary>
		/// <param name="value">The cell&#8217;s data value</param>
		/// <param name="states">A map containing the cell&#8217;s state names as map keys.</param>
		/// <returns>The cell&#8217;s content as HTML fragment.</returns>
		[JsMethod(Name = "getContent")]
		public string GetContent(object value, object states) { throw new NotImplementedException(); }

		#endregion Methods
    }
}