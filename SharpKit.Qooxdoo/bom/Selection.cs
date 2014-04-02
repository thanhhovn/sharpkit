// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>Low-level selection API to select elements like input and textarea elements
	/// as well as text nodes or elements which their child nodes.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.Selection", OmitOptionalParameters = true, Export = false)]
    public partial class Selection 
    {
		#region Methods

		public Selection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the current selected text.</para>
		/// </summary>
		/// <param name="node">node to retrieve the selection for</param>
		/// <returns>selected text as string</returns>
		[JsMethod(Name = "get")]
		public static string Get(Node node) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the end of the selection</para>
		/// </summary>
		/// <param name="node">node to check</param>
		/// <returns>end of current selection</returns>
		[JsMethod(Name = "getEnd")]
		public static double GetEnd(Node node) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the length of the selection</para>
		/// </summary>
		/// <param name="node">Form node or document/window to check.</param>
		/// <returns>length of the selection or null</returns>
		[JsMethod(Name = "getLength")]
		public static double GetLength(Node node) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the native selection object.</para>
		/// </summary>
		/// <param name="documentNode">Document node to retrieve the connected selection from</param>
		/// <returns>native selection object</returns>
		[JsMethod(Name = "getSelectionObject")]
		public static Selection GetSelectionObject(Document documentNode) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the start of the selection</para>
		/// </summary>
		/// <param name="node">node to check for</param>
		/// <returns>start of current selection or &#8221;-1&#8221; if the current selection is not within the given node</returns>
		[JsMethod(Name = "getStart")]
		public static double GetStart(Node node) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets a selection at the given node with the given start and end.
		/// For text nodes, input and textarea elements the start and end parameters
		/// set the boundaries at the text.
		/// For element nodes the start and end parameters are used to select the
		/// childNodes of the given element.</para>
		/// </summary>
		/// <param name="node">node to set the selection at</param>
		/// <param name="start">start of the selection</param>
		/// <param name="end">end of the selection</param>
		/// <returns>whether a selection is drawn</returns>
		[JsMethod(Name = "set")]
		public static bool Set(Node node, double start, double end) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Selects all content/childNodes of the given node</para>
		/// </summary>
		/// <param name="node">text, element or document node</param>
		/// <returns>whether a selection is drawn</returns>
		[JsMethod(Name = "setAll")]
		public static bool SetAll(Node node) { throw new NotImplementedException(); }

		#endregion Methods
    }
}