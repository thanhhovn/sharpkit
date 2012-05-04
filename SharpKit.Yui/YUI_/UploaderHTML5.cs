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
    /// This module provides a UI for file selection and multiple file upload capability using
    /// HTML5 XMLHTTPRequest Level 2 as a transport engine.
    /// </summary>
    public partial class UploaderHTML5 : Widget
    {
        /// <summary>
        /// Binds the specified drop area's drag and drop events to the
        /// uploader's custom handler.
        /// </summary>
        protected void _bindDropArea(){}
        /// <summary>
        /// Binds the instantiation of the file select dialog to the current file select
        /// control.
        /// </summary>
        protected void _bindSelectButton(){}
        /// <summary>
        /// Handles the drag and drop events from the uploader's specified drop
        /// area.
        /// </summary>
        protected void _ddEventHandler(){}
        /// <summary>
        /// Adds or removes a specified state CSS class to the underlying uploader button.
        /// </summary>
        protected void _setButtonClass(object state, object add){}
        /// <summary>
        /// Syncs the state of the `multipleFiles` attribute between this class
        /// and the file input field.
        /// </summary>
        protected void _setMultipleFiles(){}
        /// <summary>
        /// Adjusts the content of the `fileList` based on the results of file selection
        /// and the `appendNewFiles` attribute. If the `appendNewFiles` attribute is true,
        /// then selected files are appended to the existing list; otherwise, the list is
        /// cleared and populated with the newly selected files.
        /// </summary>
        protected void _updateFileList(Event ev){}
        /// <summary>
        /// Handles and retransmits events fired by `Y.File` and `Y.Uploader.Queue`.
        /// </summary>
        protected void _uploadEventHandler(object @event){}
        /// <summary>
        /// Converts an angle to a radian
        /// </summary>
        public YUI_.DataType_.Number angle2rad(object val){return null;}
        /// <summary>
        /// Binds to the UploaderHTML5 UI and subscribes to the necessary events.
        /// </summary>
        protected void bindUI(){}
        /// <summary>
        /// Compares to arrays or transform functions to ensure both contain the same functions in the same
        /// order.
        /// </summary>
        public object compareTransformSequence(YUI_.Array list1, YUI_.Array list2){return null;}
        /// <summary>
        /// Breaks up a 2d transform matrix into a series of transform operations.
        /// </summary>
        public YUI_.Array decompose(YUI_.Array _3x3){return null;}
        /// <summary>
        /// Converts a degree value to a radian.
        /// </summary>
        public YUI_.DataType_.Number deg2rad(YUI_.DataType_.Number deg){return null;}
        /// <summary>
        /// Returns the determinant of a given matrix.
        /// /                                             \
        /// | matrix[0][0]   matrix[1][0]    matrix[2][0] |
        /// | matrix[0][1]   matrix[1][1]    matrix[2][1] |
        /// | matrix[0][2]   matrix[1][2]    matrix[2][2] |
        /// | matrix[0][3]   matrix[1][3]    matrix[2][3] |
        /// \                                             /
        /// </summary>
        public YUI_.DataType_.Number getDeterminant(YUI_.Array matrix){return null;}
        /// <summary>
        /// Returns a matrix of minors based on a matrix, column index and row index.
        /// </summary>
        public YUI_.Array getMinors(YUI_.Array matrix, YUI_.DataType_.Number columnIndex, YUI_.DataType_.Number rowIndex){return null;}
        /// <summary>
        /// Converts a transform object to an array of column vectors.
        /// /                                             \
        /// | matrix[0][0]   matrix[1][0]    matrix[2][0] |
        /// | matrix[0][1]   matrix[1][1]    matrix[2][1] |
        /// | matrix[0][2]   matrix[1][2]    matrix[2][2] |
        /// \                                             /
        /// </summary>
        public YUI_.Array getnxn(){return null;}
        /// <summary>
        /// Parses a transform string and returns an array of transform arrays.
        /// </summary>
        public YUI_.Array getTransformArray(object val){return null;}
        /// <summary>
        /// Returns an array of transform arrays representing transform functions and arguments.
        /// </summary>
        public YUI_.Array getTransformFunctionArray(){return null;}
        /// <summary>
        /// Construction logic executed during UploaderHTML5 instantiation.
        /// </summary>
        protected void initializer(){}
        /// <summary>
        /// Returns the inverse of a matrix
        /// </summary>
        public object inverse(object Array){return null;}
        /// <summary>
        /// Opens the File Selection dialog by simulating a click on the file input field.
        /// </summary>
        public void openFileSelectDialog(){}
        /// <summary>
        /// Converts a radian value to a degree.
        /// </summary>
        public YUI_.DataType_.Number rad2deg(YUI_.DataType_.Number rad){return null;}
        /// <summary>
        /// Create the DOM structure for the UploaderHTML5.
        /// UploaderHTML5's DOM structure consists of a "Select Files" button that can
        /// be replaced by the developer's widget of choice; and a hidden file input field
        /// that is used to instantiate the File Select dialog.
        /// </summary>
        protected void renderUI(){}
        /// <summary>
        /// Multiplies a matrix by a numeric value.
        /// </summary>
        public YUI_.Array scalarMultiply(YUI_.Array matrix, YUI_.DataType_.Number multiplier){return null;}
        /// <summary>
        /// Returns the sign of value
        /// </summary>
        public YUI_.DataType_.Number sign(YUI_.DataType_.Number val){return null;}
        /// <summary>
        /// Returns the transpose for an nxn matrix.
        /// </summary>
        public YUI_.Array transpose(object matrix){return null;}
        /// <summary>
        /// Starts the upload of a specific file.
        /// </summary>
        public void upload(object file, object url, object postVars){}
        /// <summary>
        /// Starts the upload of all files on the file list, using an automated queue.
        /// </summary>
        public void uploadAll(object url, object postVars){}
        /// <summary>
        /// Starts the upload of the files specified in the first argument, using an automated queue.
        /// </summary>
        public void uploadThese(YUI_.Array files, object url, object postVars){}
        /// <summary>
        /// Multiplies a vector and a matrix
        /// </summary>
        public YUI_.Array vectorMatrixProduct(YUI_.Array vector, YUI_.Array matrix){return null;}
        /// <summary>
        /// Mapping of possible transform method names.
        /// </summary>
        public object transformMethods{get;set;}
    }
}
