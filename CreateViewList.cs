using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace SiaCRM
{
	public class DrawViewList
	{
		public DrawViewList()
		{
		}

		public static void Create(Form)
		{
			BxServices.AllowColumnReorder = true;
			BxServices.OwnerDraw = true;
			BxServices.BackColor = Color.Gray;
			BxServices.ForeColor = Color.White;
			BxServices.View = View.Details;
			BxServices.FullRowSelect = true;

			BxServices.Columns.Add("", 24, HorizontalAlignment.Left);
			BxServices.Columns.Add("Folio", 100, HorizontalAlignment.Left);
			BxServices.Columns.Add("Nombre", 500, HorizontalAlignment.Left);
			BxServices.Columns.Add("Fechha", 100, HorizontalAlignment.Left);

			BxServices += new DrawListViewItemEventHandler();
		}
	}
}