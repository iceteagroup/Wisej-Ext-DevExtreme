﻿using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxDropDownBox : TestBase
	{
		public dxDropDownBox()
		{
			InitializeComponent();

			this.dxDropDownBox1.Value = "3";

			//this.dxDropDownBox1.Options.dataSource = Wisej.Core.WisejSerializer.Parse(File.ReadAllText(Application.MapPath("Data/DropDownBox/customers.json")));

			this.dxDropDownBox1.Instance.input += new WidgetEventHandler(dxDropDownBox1_WidgetEvent);
			this.dxDropDownBox1.Instance.valueChanged += new WidgetEventHandler(dxDropDownBox1_WidgetEvent);
		}

		private void dxDropDownBox1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);

			this.dxDropDownBox1.Update();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxDropDownBox1.Options.showClearButton = this.checkBox1.Checked;
			this.dxDropDownBox1.Options.showDropDownButton = this.checkBox2.Checked;
			this.dxDropDownBox1.Options.acceptCustomValue = this.checkBox3.Checked;
			this.dxDropDownBox1.Options.openOnFieldClick = this.checkBox4.Checked;

			this.dxDropDownBox1.Update();
		}
	}
}
