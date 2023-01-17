namespace SiaCRM
{
	public class Page
	{
		public class Tab
		{
		
		}

		//Set focus on selected page
		public static void SetFocus(Control PageArea)
		{
			PageArea.GetControls<Button>().ForEach(p => {
				if (Interface.PageCounter == 1)
				{
						Interface.CurrentPage = 1;
				}

				if (Convert.ToString(p.Tag) == Convert.ToString(Interface.CurrentPage))
				{
					p.BackColor = Interface.ColorWhite;
					p.FlatAppearance.MouseOverBackColor = Interface.ColorWhite;
					p.FlatAppearance.MouseDownBackColor = Interface.ColorWhite;
				}
				else
				{
					p.BackColor = Color.FromArgb(180, 180, 180);
					p.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 150, 150);
					p.FlatAppearance.MouseDownBackColor = Interface.ColorWhite;
				}
			});
		}

		//Hide panels when they don't have focus
		public static void HidePanels(Control WorkArea)
		{
			foreach (Control Container in WorkArea.Controls)
			{
				if (Container is Panel)
				{
					if (Convert.ToString(Container.Tag) == Convert.ToString(Interface.CurrentPage))
					{
						Container.Visible = true;
						Container.BringToFront();
					}
					else
					{
						Container.Visible = false;
					}
				}
			}
		}
	}
}
