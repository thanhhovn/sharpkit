//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_
{
    /// <summary>
    /// <p>Creates an rectangle shape with editable attributes.</p>
    /// <p>`Rect` instances can be created using the <a href="Graphic.html#method_addShape">`addShape`</a> method of the <a href="Graphic.html">`Graphic`</a>
    /// class. The method's `cfg` argument contains a `type` attribute. Assigning "rect" or `Y.Rect` to this attribute will create a `Rect` instance.
    /// Required attributes for instantiating a `Rect` are `type`, `width` and `height`. Optional attributes include:
    /// <ul>
    /// <li><a href="#attr_fill">fill</a></li>
    /// <li><a href="#attr_id">id</a></li>
    /// <li><a href="#attr_stroke">stroke</a></li>
    /// <li><a href="#attr_transform">transform</a></li>
    /// <li><a href="#attr_transformOrigin">transformOrigin</a></li>
    /// <li><a href="#attr_visible">visible</a></li>
    /// <li><a href="#attr_x">x</a></li>
    /// <li><a href="#attr_y">y</a></li>
    /// </ul>
    /// The below code creates a rectangle by defining the `type` attribute as "rect":</p>
    /// var myRect = myGraphic.addShape({
    /// type: "rect",
    /// width: 20,
    /// height: 10,
    /// fill: {
    /// color: "#9aa"
    /// },
    /// stroke: {
    /// weight: 1,
    /// color: "#000"
    /// }
    /// });
    /// Below, the same rectangle is created by defining the `type` attribute with a class reference:
    /// var myRect = myGraphic.addShape({
    /// type: Y.Rect,
    /// width: 20,
    /// height: 10,
    /// fill: {
    /// color: "#9aa"
    /// },
    /// stroke: {
    /// weight: 1,
    /// color: "#000"
    /// }
    /// });
    /// <p>`Rect` has the following implementations based on browser capability.
    /// <ul>
    /// <li><a href="SVGRect.html">`SVGRect`</a></li>
    /// <li><a href="VMLRect.html">`VMLRect`</a></li>
    /// <li><a href="CanvasRect.html">`CanvasRect`</a></li>
    /// </ul>
    /// It is not necessary to interact with these classes directly. `Rect` will point to the appropriate implemention.</p>
    /// </summary>
    public partial class Rect : Shape
    {
    }
}
