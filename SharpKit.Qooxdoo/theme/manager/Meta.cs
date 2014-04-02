// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.theme.manager
{
    /// <summary>
	/// <para>Manager for meta themes</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.theme.manager.Meta", OmitOptionalParameters = true, Export = false)]
    public partial class Meta : qx.core.Object
    {
		#region Properties

		/// <summary>
		/// <para>Meta theme. Applies the defined color, decoration, ... themes to
		/// the corresponding managers.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "theme", NativeField = true)]
		public Theme Theme { get; set; }

		#endregion Properties

		#region Methods

		public Meta() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property theme.</para>
		/// </summary>
		[JsMethod(Name = "getTheme")]
		public Theme GetTheme() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Initialize the themes which were selected using the settings. Should only
		/// be called from qooxdoo based application.</para>
		/// </summary>
		[JsMethod(Name = "initialize")]
		public void Initialize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property theme
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property theme.</param>
		[JsMethod(Name = "initTheme")]
		public void InitTheme(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property theme.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTheme")]
		public void ResetTheme() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property theme.</para>
		/// </summary>
		/// <param name="value">New value for property theme.</param>
		[JsMethod(Name = "setTheme")]
		public void SetTheme(Theme value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.theme.manager.Meta GetInstance() { throw new NotImplementedException(); }

		#endregion Methods
    }
}