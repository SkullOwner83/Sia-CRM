using System.Media;

namespace SiaCRM
{
	public partial class Interface : Form
	{
		public static int PageCounter = 1;
		public static int CurrentPage = 1;
		public static Color ColorWhite = Color.FromArgb(240, 240, 240);

		public Interface()
		{
			InitializeComponent();
		}

		private void ButtonClicked(object sender, EventArgs e)
		{
			var Object = (Button)sender;

			switch (Object.Name)
			{
				case "BtnServices": Create.Form(new WindowServices(), PnlWorkArea); break;
				case "BtnNotepad": Create.Form(new Notepad(), PnlWorkArea); break;

				case "BtnExit":
					SystemSounds.Exclamation.Play();
					DialogResult ExitMsg = MessageBox.Show("¿Estas seguro de salir?", "Salir", MessageBoxButtons.YesNo); ;

					if (ExitMsg == DialogResult.Yes)
					{
						Application.Exit();
					}
					break;

				case "BtnNewPage":
					var Btn = (Button)sender;

					PageCounter += 1;
					CurrentPage = PageCounter;
					Btn.Location = new Point(240 + 240 * (PageCounter - 1));

					//Create tab for the new page
					Button NewPage = new Button();
					NewPage.Size = new Size(240, 32);
					NewPage.Margin = new Padding(0);
					NewPage.Name = "BtnPage" + PageCounter;
					NewPage.Tag = PageCounter;
					NewPage.Text = "New Page " + PageCounter;
					NewPage.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
					NewPage.TextAlign = ContentAlignment.MiddleLeft;
					NewPage.FlatStyle = FlatStyle.Flat;
					NewPage.FlatAppearance.BorderSize = 0;
					NewPage.Click += new EventHandler(FocusPage);
					PnlPagesArea.Controls.Add(NewPage);

					//Create close button for the new page
					Button BtnClose = new Button();
					BtnClose.Size = new Size(32, 32);
					BtnClose.Tag = PageCounter;
					BtnClose.Text = "x";
					BtnClose.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
					BtnClose.BackColor = Color.FromArgb(240, 240, 240);
					BtnClose.FlatStyle = FlatStyle.Flat;
					BtnClose.FlatAppearance.BorderSize = 0;
					BtnClose.Cursor = Cursors.Hand;
					BtnClose.Location = new Point(NewPage.Width - 32, 0);
					BtnClose.Click += new EventHandler(ClosePage);
					NewPage.Controls.Add(BtnClose);

					//Create container for the new page
					Panel Container = new Panel();
					Container.BackColor = ColorWhite;
					Container.Dock = DockStyle.Fill;
					Container.Tag = PageCounter;
					PnlWorkArea.Controls.Add(Container);

					foreach (Control Item in PnlPagesArea.Controls)
					{
						if (Item is Button)
						{
							if (Item.Name == "BtnNewPage")
							{
								PnlPagesArea.Controls.Remove(Item);
							}
						}
					}
					


					Button New = new Button();
					New.Name = "BtnNewPage";
					New.BackColor = SystemColors.Control;
					New.Cursor = Cursors.Hand;
					New.FlatStyle = FlatStyle.Flat;
					New.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
					New.Location = new Point(240, 0);
					New.Margin = new Padding(0);
					New.Name = "BtnNewPage";
					New.Size = new Size(32, 32);
					New.TabIndex = 0;
					New.Text = "+";
					New.UseVisualStyleBackColor = false;
					New.Click += new EventHandler(this.ButtonClicked);
					PnlPagesArea.Controls.Add(New);
					

					//Set the focus to new page and hide the others
					Page.SetFocus(PnlPagesArea);
					Page.HidePanels(PnlWorkArea);
					
				break;
			}
		}

		private void FocusPage(object sender, EventArgs e)
		{
			var Btn = (Button)sender;

			CurrentPage = Convert.ToInt32(Btn.Tag);
			Page.SetFocus(PnlPagesArea);
			Page.HidePanels(PnlWorkArea);
		}

		private void ClosePage(object sender, EventArgs e)
		{
			var This = (Button)sender;

			foreach (Control Object in PnlWorkArea.Controls)
			{
				if (Object is Panel)
				{
					if (Convert.ToString(Object.Tag) == Convert.ToString(This.Tag))
					{
						PnlWorkArea.Controls.Remove(Object);
					}
				}
			}

			foreach (Control Object in PnlPagesArea.Controls)
			{
				if (Object is Button)
				{
					if (Convert.ToString(Object.Tag) == Convert.ToString(This.Tag))
					{
						Object.Controls.Remove(This);
						PnlPagesArea.Controls.Remove(Object);
					}
				}
			}

			PageCounter -= 1;
			Page.SetFocus(PnlPagesArea);
			BtnNewPage.Location = new Point(240 + 240 * (PageCounter - 1));
		}
	}
}
