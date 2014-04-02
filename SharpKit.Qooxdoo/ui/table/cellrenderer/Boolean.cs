// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table.cellrenderer
{
    /// <summary>
	/// <para>A data cell renderer for boolean values.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.table.cellrenderer.Boolean", OmitOptionalParameters = true, Export = false)]
    public partial class Boolean : qx.ui.table.cellrenderer.AbstractImage
    {
		#region Properties

		/// <summary>
		/// <para>The icon used to indicate the false state</para>
		/// </summary>
		[JsProperty(Name = "iconFalse", NativeField = true)]
		public string IconFalse { get; set; }

		/// <summary>
		/// <para>The icon used to indicate the true state</para>
		/// </summary>
		[JsProperty(Name = "iconTrue", NativeField = true)]
		public string IconTrue { get; set; }

		#endregion Properties

		#region Methods

		public Boolean() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property iconFalse.</para>
		/// </summary>
		[JsMethod(Name = "getIconFalse")]
		public string GetIconFalse() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property iconTrue.</para>
		/// </summary>
		[JsMethod(Name = "getIconTrue")]
		public string GetIconTrue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property iconFalse
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property iconFalse.</param>
		[JsMethod(Name = "initIconFalse")]
		public void InitIconFalse(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property iconTrue
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property iconTrue.</param>
		[JsMethod(Name = "initIconTrue")]
		public void InitIconTrue(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property iconFalse.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetIconFalse")]
		public void ResetIconFalse() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property iconTrue.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetIconTrue")]
		public void ResetIconTrue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property iconFalse.</para>
		/// </summary>
		/// <param name="value">New value for property iconFalse.</param>
		[JsMethod(Name = "setIconFalse")]
		public void SetIconFalse(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property iconTrue.</para>
		/// </summary>
		/// <param name="value">New value for property iconTrue.</param>
		[JsMethod(Name = "setIconTrue")]
		public void SetIconTrue(string value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}