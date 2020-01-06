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
	/// The DateBox is a widget that displays a date and time in a specified format, and enables a user to pick or type in the required date/time value.
	/// </summary>
	public class dxDateBox : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxDateBox"/> class.
		/// </summary>
		public dxDateBox() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxDateBox"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxDateBox(object options) : base("dxDateBox", options)
		{
			this.WidgetWiredEvents = new[] {
				"cut",
				"copy",
				"input",
				"change",
				"closed",
				"enterKey",
				"keyPress",
				"valueChanged"
			};
		}
	}
}
