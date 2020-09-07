﻿///////////////////////////////////////////////////////////////////////////////
//
// (C) 2019 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
// 
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////

namespace Wisej.Web.Ext.DevExtreme
{
	/// <summary>
	/// The PivotGrid is a widget that allows you to display and analyze multi-dimensional data from a local storage or an OLAP cube.
	/// </summary>
	public class dxPivotGrid : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxPivotGrid"/> class.
		/// </summary>
		public dxPivotGrid() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxPivotGrid"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxPivotGrid(object options) : base("dxPivotGrid", options)
		{
			this.WiredEvents = new[] {
				"cellClick",
			};
		}


	}
}
