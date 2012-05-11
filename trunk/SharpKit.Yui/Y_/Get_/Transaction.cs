//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_.Get_
{
    /// <summary>
    /// Represents a Get transaction, which may contain requests for one or more JS or
    /// CSS files.
    /// This class should not be instantiated manually. Instances will be created and
    /// returned as needed by Y.Get's `css()`, `js()`, and `load()` methods.
    /// </summary>
    public partial class Transaction
    {
        /// <summary>
        /// Aborts this transaction.
        /// This will cause the transaction's `onFailure` callback to be called and
        /// will prevent any new script and link nodes from being added to the document,
        /// but any resources that have already been requested will continue loading
        /// (there's no safe way to prevent this, unfortunately).
        /// </summary>
        public void abort(){}
        /// <summary>
        /// Aborts this transaction.
        /// This will cause the transaction's `onFailure` callback to be called and
        /// will prevent any new script and link nodes from being added to the document,
        /// but any resources that have already been requested will continue loading
        /// (there's no safe way to prevent this, unfortunately).
        /// </summary>
        public void abort(object msg){}
        /// <summary>
        /// Begins execting the transaction.
        /// There's usually no reason to call this manually, since Get will call it
        /// automatically when other pending transactions have finished. If you really
        /// want to execute your transaction before Get does, you can, but be aware that
        /// this transaction's scripts may end up executing before the scripts in other
        /// pending transactions.
        /// If the transaction is already executing, the specified callback (if any)
        /// will be queued and called after execution finishes. If the transaction has
        /// already finished, the callback will be called immediately (the transaction
        /// will not be executed again).
        /// </summary>
        public void execute(JsAction callback){}
        /// <summary>
        /// Manually purges any `<script>` or `<link>` nodes this transaction has
        /// created.
        /// Be careful when purging a transaction that contains CSS requests, since
        /// removing `<link>` nodes will also remove any styles they applied.
        /// </summary>
        public void purge(){}
        /// <summary>
        /// Id of the most recent transaction.
        /// </summary>
        protected Y_.DataType_.Number _lastId{get;set;}
        /// <summary>
        /// Arbitrary data object associated with this transaction.
        /// This object comes from the options passed to `Get.css()`, `Get.js()`, or
        /// `Get.load()`, and will be `undefined` if no data object was specified.
        /// </summary>
        public object data{get;set;}
        /// <summary>
        /// Numeric id for this transaction, unique among all transactions within the same
        /// YUI sandbox in the current pageview.
        /// </summary>
        public Y_.DataType_.Number id{get;set;}
        /// <summary>
        /// Options associated with this transaction.
        /// See `Get.options` for the full list of available options.
        /// </summary>
        public object options{get;set;}
        /// <summary>
        /// Request objects contained in this transaction. Each request object represents
        /// one CSS or JS URL that will be (or has been) requested and loaded into the page.
        /// </summary>
        public object requests{get;set;}
    }
}