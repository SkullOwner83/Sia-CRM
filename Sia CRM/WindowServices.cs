using System.Media;
using System.Runtime.InteropServices;

namespace SiaCRM
{
	public partial class WindowServices : FormFather
	{		
		private int Index;
		private bool CollectData = true;
		private bool ModifyService = false;
		private Service ServiceSelected = new Service();
		private List<Service> ServicesList = new List<Service>();

        public WindowServices()
        {
            InitializeComponent();
			MinWindowSize = new Size(this.Width, this.Height);
        }

		private void WindowLoad(object sender, EventArgs e)
		{
			//Draw.ListView(this, BxServices);

			//Load data if database file exists
			if (File.Exists("Database.dll"))
			{
				using(StreamReader LoadData = new StreamReader("Database.dll"))
				{
					while(LoadData.EndOfStream != true)
					{
						//Create one instance for each line reading and save into service list
						Service ServiceLoading = new Service();
						string? Line = LoadData.ReadLine(); //Data.DecryptMD5(LoadData.ReadLine());
						string Folio = "", Customer = "", Status = "";
						int Index = 0;

						if (Line != null)
						{
							foreach (char Digit in Line)
							{
								//Read each character and concatenate them into their property
								if (Digit == ',')
								{
									Index += 1;
									continue;
								}

								switch (Index)
								{
									case 0: Folio += Digit; break;
									case 1: Customer += Digit; break;
									case 2: ServiceLoading.Name += Digit; break;
									case 3: ServiceLoading.AdmissionDate += Digit; break;
									case 4: ServiceLoading.DeliveryDate += Digit; break;
									case 5: Status += Digit; break;
									case 6: ServiceLoading.Diagnostic += Digit; break;
								}
							}
						}

						ServiceLoading.Folio = Convert.ToInt32(Folio);
						ServiceLoading.Customer = Convert.ToInt32(Customer);
						ServiceLoading.Status = Convert.ToInt32(Status);
						ServicesList.Add(ServiceLoading);
					}
				}

				//Refresh data in listview with instances in service list
				Service.Load(BxServices, ServicesList);
			}
		}

		private void ButtonClicked(object Sender, EventArgs e)
		{
			var ObjButton = (Button)Sender;

			switch(ObjButton.Name)
			{
				case "BtnNewService":
					Function.ClearTextBox(PnlBody);
					Function.LockControls(PnlBody);
					TbxDiagnostic.Text = "";
					TbxProblem.Text = "";
					DateTime ThisDay = DateTime.Today;
					TbxAdmissionDate.Text = Convert.ToString(ThisDay.ToShortDateString());
					BxStatus.SelectedIndex = 0;
					BxServicesDetails.SelectedTab = BxProblemPage;
					CollectData = false;
				break;

				case "BtnModify":
					//Search in services list the selected items in listview
					if (BxServices.SelectedIndices.Count > 0)
					{
						foreach (var Object in ServicesList)
						{
							if (Convert.ToString(Object.Folio) == Convert.ToString(BxServices.SelectedItems[0].SubItems[1].Text))
							{
								Index = ServicesList.IndexOf(Object);
								ServiceSelected = Object;
								ModifyService = true;
								CollectData = false;
							}
						}

						//Set the properties of selected object in the textboxes of the form
						if (ModifyService == true)
						{
							TbxFolio.Text = Convert.ToString(ServiceSelected.Folio);
							TbxCustomerNumber.Text = Convert.ToString(ServiceSelected.Customer);
							TbxCustomerName.Text = ServiceSelected.Name;
							TbxAdmissionDate.Text = ServiceSelected.AdmissionDate;
							Function.LockControls(PnlBody);
						}
					}
					else
					{
						MessageBox.Show("Selecciona un servicio a modificar.");
					}
				break;

				case "BtnDelete":
					//Delete selected items in view list
					Form Background = new Form();
					Background.StartPosition = FormStartPosition.Manual;
					Background.FormBorderStyle = FormBorderStyle.None;
					Background.Opacity = .70d;
					Background.BackColor = Color.Black;
					Background.WindowState = FormWindowState.Maximized;
					Background.TopMost = true;
					Background.Location = this.Location;
					Background.ShowInTaskbar = false;
					Background.Show();

					SystemSounds.Exclamation.Play();
					DialogResult Delete = MessageBox.Show("¿Estas seguro de eliminar este elemento?", "Eliminar", MessageBoxButtons.YesNo); ;

					if (Delete == DialogResult.Yes)
					{
						foreach (ListViewItem ServicesSelected in BxServices.SelectedItems)
						{
							ServicesSelected.Remove();
						}
					}

					Background.Dispose();
				break;

				case "BtnAcept":
					//Validate that no space is empty
					if (TbxFolio.Text != string.Empty && TbxCustomerNumber.Text != string.Empty && TbxCustomerName.Text != string.Empty)
					{
						if (ModifyService == false)
						{
							//Create one instance with the form data and save instances in list
							Service NewService = new Service();
							NewService.Folio = Convert.ToInt32(TbxFolio.Text);
							NewService.Customer = Convert.ToInt32(TbxCustomerNumber.Text);
							NewService.Name = TbxCustomerName.Text;
							NewService.AdmissionDate = TbxAdmissionDate.Text;
							NewService.DeliveryDate = TbxDeliveryDate.Text;
							NewService.Status = BxStatus.SelectedIndex;
							NewService.Diagnostic = TbxDiagnostic.Text;
							ServicesList.Add(NewService);	
							
							//Save data one text file
							StreamWriter DataBase = new StreamWriter("Database.dll", true);
							//string Message = Data.EncryptMD5(NewService.Folio + "," + NewService.Customer + "," + NewService.Name + "," + NewService.AdmissionDate + "," + NewService.DeliveryDate + "," + NewService.Diagnostic);
							string Message = NewService.Folio + "," + NewService.Customer + "," + NewService.Name + "," + NewService.AdmissionDate + "," + NewService.DeliveryDate + "," + NewService.Status + "," + NewService.Diagnostic;
							DataBase.WriteLine(Message);
							DataBase.Close();
						}
						else
						{
							//Replace service selected with a new instane in service list
							ServiceSelected.Folio = Convert.ToInt32(TbxFolio.Text);
							ServiceSelected.Customer = Convert.ToInt32(TbxCustomerNumber.Text);
							ServiceSelected.Name = TbxCustomerName.Text;
							ServiceSelected.AdmissionDate = TbxAdmissionDate.Text;
							ServiceSelected.DeliveryDate = TbxDeliveryDate.Text;
							ServiceSelected.Status = BxStatus.SelectedIndex;
							ServicesList.RemoveAt(Index);
							ServicesList.Insert(Index,ServiceSelected);
							ModifyService = false;
						}

						//Refresh data in listview with instances in service list
						Service.Load(BxServices, ServicesList);
						Function.LockControls(PnlBody);
						CollectData = true;
					}
					else
					{
						MessageBox.Show("Algunos espacios aun estan vacios.");
					}
				break;

				case "BtnCancel":
					Function.ClearTextBox(PnlBody);
					Function.LockControls(PnlBody);
					TbxDiagnostic.Text = "";
					TbxProblem.Text= "";
					ModifyService = false;
					CollectData = true;
				break;
			}
		}

		//Set the current date to select delivery status
		private void SelectStatus(object Sender, EventArgs e)
		{
			int Index = BxStatus.SelectedIndex;
			
			if (Convert.ToString(BxStatus.Items[Index]) == "Entregado")
			{
				DateTime ThisDay = DateTime.Today;
				TbxDeliveryDate.Text = ThisDay.ToShortDateString();
			}
		}

		private void SelecteServicesInListView(object sender, EventArgs e)
		{
			if (CollectData == true)
			{
				if (BxServices.SelectedItems.Count > 0)
				{
					//Get the selected services in service list through your folio
					foreach (var Object in ServicesList)
					{
						if (Convert.ToString(Object.Folio) == Convert.ToString(BxServices.SelectedItems[0].SubItems[1].Text))
						{
							Index = ServicesList.IndexOf(Object);
							ServiceSelected = Object;
						}
					}

					//Set the data of service selected in the form
					TbxFolio.Text = Convert.ToString(ServiceSelected.Folio);
					TbxCustomerNumber.Text = Convert.ToString(ServiceSelected.Customer);
					TbxCustomerName.Text = ServiceSelected.Name;
					TbxAdmissionDate.Text = ServiceSelected.AdmissionDate;
					TbxDeliveryDate.Text = ServiceSelected.DeliveryDate;
					BxStatus.SelectedIndex = ServiceSelected.Status;
					TbxDiagnostic.Text = ServiceSelected.Diagnostic;
				}

				//Enable the modify and delete buttons if selected one item in listview
				bool Lock = (BxServices.SelectedIndices.Count > 0);
				BtnModify.Enabled = Lock;
				BtnDelete.Enabled = Lock;
			}
		}

		
		private void ValidateInput(object Sender, KeyPressEventArgs Key)
		{
			var TxtBox = (TextBox)Sender;

			switch(TxtBox.Tag)
			{
				case "Numeric": Key.Handled = Data.OnlyNumeric(Key.KeyChar); break;
				case "Alphabet": Key.Handled = Data.OnlyAlphabet(Key.KeyChar); break;
			}
		}

		private void FilterServices(object sender, EventArgs e)
		{
			var TxtBox = (TextBox)sender;

			if (TxtBox.Text == String.Empty)
			{
				Service.Load(BxServices, ServicesList);
			}
			else
			{
				Service.Filter(BxServices, ServicesList, TbxFilter.Text);
			}
		}

		private void BxServicesDetails_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.GetState() == "Maximized")
			{
				this.Dock = DockStyle.None;
				this.Size = PrevWindowSize;
			}

			PrevWindowSize = this.Size;
			this.Size = MinWindowSize;

			if (BxServicesDetails.SelectedTab == BxDiagnosticPage)
			{
				BxServices.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
				BxServicesDetails.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
				PnlForm.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
			}

			if (BxServicesDetails.SelectedTab == BxProblemPage)
			{
				BxServices.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
				BxServicesDetails.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
				PnlForm.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
			}

			if (this.GetState() == "Maximized")
			{
				this.Dock = DockStyle.Fill;
			}

			this.Size = PrevWindowSize;
		}
	}
}