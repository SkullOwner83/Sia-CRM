using System.Drawing.Drawing2D;
using System.Globalization;

namespace SiaCRM
{
	public class Create
	{
		//Open forms in the container indicated
		public static void Form(Form Window, Control Container)
		{
			var Form = Window;
			Form.TopLevel = false;

            Container.GetControls<Panel>().ForEach(p => {
                if (Convert.ToString(p.Tag) == Convert.ToString(Interface.CurrentPage))
                {
                    p.Controls.Add(Form);
                }
            });

			Form.Show();
			Form.BringToFront();
		}
	}

    public class Draw
    {
        private Color BkgColor = Color.White;

        public static void ListView(Form Window, ListView ListV)
        {
            //Initialized the ListView control
            ListV.AllowColumnReorder = true;
            ListV.OwnerDraw = true;
            ListV.BackColor = Color.White;
            ListV.ForeColor = Color.Black;
            ListV.View = View.Details;
            ListV.FullRowSelect = true;

            /*Add columns in the ListView
			ListV.Columns.Add("", 24, HorizontalAlignment.Left);
			ListV.Columns.Add("Folio", 100, HorizontalAlignment.Left);
			ListV.Columns.Add("Nombre", 500, HorizontalAlignment.Left);
			ListV.Columns.Add("Fechha", 100, HorizontalAlignment.Left);*/

            // Assign the draw event handlers 
            ListV.DrawItem += new DrawListViewItemEventHandler(DrawItem);
            ListV.DrawSubItem += new DrawListViewSubItemEventHandler(DrawSubItem);
            ListV.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(DrawHeader);
        }

        private static void DrawItem(object Sender, DrawListViewItemEventArgs Item)
        {
            if ((Item.State & ListViewItemStates.Selected) != 0)
            {
                //Draw the background and focus rectangle for a selected item.
                Item.Graphics.FillRectangle(Brushes.CadetBlue, Item.Bounds);
                Item.DrawFocusRectangle();
            }
            else
            {
                //Draw the background for an unselected item.
                using (LinearGradientBrush brush = new LinearGradientBrush(Item.Bounds, Color.Orange, Color.Maroon, LinearGradientMode.Horizontal))
                {
                    Item.Graphics.FillRectangle(brush, Item.Bounds);
                }
            }

            Item.DrawText();
        }

        private static void DrawSubItem(object Sender, DrawListViewSubItemEventArgs SubItem)
        {
            TextFormatFlags Flags = TextFormatFlags.Left;

            using (StringFormat TextDesign = new StringFormat())
            {
                //Change the alignment according to the header
                switch (SubItem.Header.TextAlign)
                {
                    case HorizontalAlignment.Center:
                        TextDesign.Alignment = StringAlignment.Center;
                        Flags = TextFormatFlags.HorizontalCenter;
                        break;

                    case HorizontalAlignment.Right:
                        TextDesign.Alignment = StringAlignment.Far;
                        Flags = TextFormatFlags.Right;
                        break;
                }

                //Draw the text and background for subitems
                double SubItemValue;

                if (SubItem.ColumnIndex > 0 && double.TryParse(SubItem.SubItem.Text, NumberStyles.Currency, NumberFormatInfo.CurrentInfo, out SubItemValue) && SubItemValue < 0)
                {
                    if ((SubItem.ItemState & ListViewItemStates.Selected) == 0)
                    {
                        SubItem.DrawBackground();
                    }

                    Font TextFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
                    SubItem.Graphics.DrawString(SubItem.SubItem.Text, TextFont, Brushes.Red, SubItem.Bounds, TextDesign);
                    return;
                }

                SubItem.DrawText(Flags);
            }
        }

        private static void DrawHeader(object Sender, DrawListViewColumnHeaderEventArgs Header)
        {
            using (StringFormat TextDesign = new StringFormat())
            {
                //Change the alignment according to the header
                switch (Header.Header.TextAlign)
                {
                    case HorizontalAlignment.Center:
                        TextDesign.Alignment = StringAlignment.Center;
                        break;

                    case HorizontalAlignment.Right:
                        TextDesign.Alignment = StringAlignment.Far;
                        break;
                }

                Header.DrawBackground();

                using (Font TextFont = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point))
                {
                    Header.Graphics.DrawString(Header.Header.Text, TextFont, Brushes.Black, Header.Bounds, TextDesign);
                }
            }

            return;
        }
    }
}