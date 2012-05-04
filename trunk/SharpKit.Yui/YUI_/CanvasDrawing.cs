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
    /// <a href="http://www.w3.org/TR/html5/the-canvas-element.html">Canvas</a> implementation of the <a href="Drawing.html">`Drawing`</a> class.
    /// `CanvasDrawing` is not intended to be used directly. Instead, use the <a href="Drawing.html">`Drawing`</a> class.
    /// If the browser lacks <a href="http://www.w3.org/TR/SVG/">SVG</a> capabilities but has
    /// <a href="http://www.w3.org/TR/html5/the-canvas-element.html">Canvas</a> capabilities, the <a href="Drawing.html">`Drawing`</a>
    /// class will point to the `CanvasDrawing` class.
    /// </summary>
    public partial class CanvasDrawing
    {
        /// <summary>
        /// Clears the graphics object.
        /// </summary>
        public void clear(){}
        /// <summary>
        /// Ends a fill and stroke
        /// </summary>
        public void closePath(){}
        /// <summary>
        /// Draws a bezier curve.
        /// </summary>
        public void curveTo(YUI_.DataType_.Number cp1x, YUI_.DataType_.Number cp1y, YUI_.DataType_.Number cp2x, YUI_.DataType_.Number cp2y, YUI_.DataType_.Number x, YUI_.DataType_.Number y){}
        /// <summary>
        /// Draws a circle. Used internally by `CanvasCircle` class.
        /// </summary>
        protected void drawCircle(YUI_.DataType_.Number x, YUI_.DataType_.Number y, YUI_.DataType_.Number r){}
        /// <summary>
        /// Draws a diamond.
        /// </summary>
        protected void drawDiamond(YUI_.DataType_.Number x, YUI_.DataType_.Number y, YUI_.DataType_.Number width, YUI_.DataType_.Number height){}
        /// <summary>
        /// Draws an ellipse. Used internally by `CanvasEllipse` class.
        /// </summary>
        protected void drawEllipse(YUI_.DataType_.Number x, YUI_.DataType_.Number y, YUI_.DataType_.Number w, YUI_.DataType_.Number h){}
        /// <summary>
        /// Draws a rectangle.
        /// </summary>
        public void drawRect(YUI_.DataType_.Number x, YUI_.DataType_.Number y, YUI_.DataType_.Number w, YUI_.DataType_.Number h){}
        /// <summary>
        /// Draws a rectangle with rounded corners.
        /// </summary>
        public void drawRect(YUI_.DataType_.Number x, YUI_.DataType_.Number y, YUI_.DataType_.Number w, YUI_.DataType_.Number h, YUI_.DataType_.Number ew, YUI_.DataType_.Number eh){}
        /// <summary>
        /// Completes a drawing operation.
        /// </summary>
        public void end(){}
        /// <summary>
        /// Draws a line segment using the current line style from the current drawing position to the specified x and y coordinates.
        /// </summary>
        public void lineTo(YUI_.DataType_.Number point1, YUI_.DataType_.Number point2){}
        /// <summary>
        /// Moves the current drawing position to specified x and y coordinates.
        /// </summary>
        public void moveTo(YUI_.DataType_.Number x, YUI_.DataType_.Number y){}
        /// <summary>
        /// Draws a quadratic bezier curve.
        /// </summary>
        public void quadraticCurveTo(YUI_.DataType_.Number cpx, YUI_.DataType_.Number cpy, YUI_.DataType_.Number x, YUI_.DataType_.Number y){}
    }
}
