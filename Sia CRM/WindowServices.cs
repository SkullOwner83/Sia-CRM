using System.Media;
using System.IO;

namespace SiaCRM
{
    public partial class WindowServices : Form
	{		
		int Index;
		bool ModifyService = false;
		Service ServiceToModify = new Service();
		Service ServiceSelected = new Service();
		List<Service> ServicesList = new List<Service>();

        public WindowServices()
        {
            InitializeComponent();
        }

		private void WindowLoad(object sender, EventArgs e)
		{
			this.MinimumSize = new Size(this.Width, this.Height);
			BxServices.AllowColumnReorder = true;

			//Load data if database file exists
			if (File.Exists("Database.dll"))
			{
				StreamReader LoadData = new StreamReader("Database.dll");
				string? LineRead, Line;

				do
				{
					//Save the current line reading and set data if is not null
					LineRead = LoadData.ReadLine();
					
					
					if (LineRead != null)
					{
						Line = Data.DecryptMD5(LineRead);

						//Create one instance for each line reading and save into service list
						Service ServiceLoading = new Service();
						var Index = 0;

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
								case 0: ServiceLoading.Folio += Digit; break; //Da problema porque esta concadenando un caracter a una propiedad integer
								case 1: ServiceLoading.Customer += Digit; break; //mismo problema de arriba
								case 2: ServiceLoading.Name += Digit; break;
								case 3: ServiceLoading.AdmissionDate += Digit; break;
								case 4: ServiceLoading.DeliveryDate += Digit; break;
								case 5: ServiceLoading.Diagnostic += Digit; break;
							}
						}

						ServicesList.Add(ServiceLoading);
					}
				}
				while(LineRead != null);

				//Refresh data in listview with instances in service list
				BxServices.Items.Clear();

				foreach(var Object in ServicesList)
				{
					ListViewItem Item = new ListViewItem();
					Item = BxServices.Items.Add(Convert.ToString(Object.Folio));
					Item.SubItems.Add(Convert.ToString(Object.Name));
					Item.SubItems.Add(Object.AdmissionDate);
				}

				LoadData.Close();
			}
		}

		private void ButtonClicked(object Sender, EventArgs e)
		{
			var ObjButton = (Button)Sender;

			switch(ObjButton.Name)
			{
				case "BtnNewService":
					Function.ClearTextBox(this);
					Function.LockControls(this);
					TbxDiagnostic.Text = "";
					TbxProblem.Text = "";
					DateTime ThisDay = DateTime.Today;
					TbxAdmissionDate.Text = Convert.ToString(ThisDay.ToShortDateString());
					BxStatus.SelectedIndex = 0;
					BxServicesDetails.SelectedTab = BxProblemPage;
				break;

				case "BtnModify":
					//Search in services list the selected items in listview
					if (BxServices.SelectedIndices.Count > 0)
					{
						foreach (var Object in ServicesList)
						{
							if (Convert.ToString(Object.Folio) == Convert.ToString(BxServices.SelectedItems[0].SubItems[0].Text))
							{
								Index = ServicesList.IndexOf(Object);
								ServiceToModify = Object;
								ModifyService = true;
							}
						}

						if (ModifyService == true)
						{
							TbxFolio.Text = Convert.ToString(ServiceToModify.Folio);
							TbxCustomerNumber.Text = Convert.ToString(ServiceToModify.Customer);
							TbxCustomerName.Text = ServiceToModify.Name;
							TbxAdmissionDate.Text = ServiceToModify.AdmissionDate;
							Function.LockControls(this);
						}
					}
					else
					{
						MessageBox.Show("Selecciona un servicio a modificar.");
					}
				break;

				case "BtnDelete":
					//Delete selected items in view list
					SystemSounds.Exclamation.Play();

					foreach (ListViewItem ServicesSelected in BxServices.SelectedItems)
					{
						ServicesSelected.Remove();
					}
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
							NewService.Diagnostic = TbxDiagnostic.Text;
							ServicesList.Add(NewService);	
							
							//Save data one text file
							StreamWriter DataBase = new StreamWriter("Database.dll", true);
							string Message = Data.EncryptMD5(NewService.Folio + "," + NewService.Customer + "," + NewService.Name + "," + NewService.AdmissionDate + "," + NewService.DeliveryDate + "," + NewService.Diagnostic);
							DataBase.WriteLine(Message);
							DataBase.Close();
						}
						else
						{
							//Replace service selected with a new instane in service list
							ServiceToModify.Folio = Convert.ToInt32(TbxFolio.Text);
							ServiceToModify.Customer = Convert.ToInt32(TbxCustomerNumber.Text);
							ServiceToModify.Name = TbxCustomerName.Text;
							ServiceToModify.AdmissionDate = TbxAdmissionDate.Text;
							ServiceToModify.DeliveryDate = TbxDeliveryDate.Text;
							ServicesList.RemoveAt(Index);
							ServicesList.Insert(Index,ServiceToModify);
							ModifyService = false;
						}

						//Refresh data in listview with instances in service list
						BxServices.Items.Clear();

						foreach(var Object in ServicesList)
						{
							ListViewItem Item = new ListViewItem();
							Item = BxServices.Items.Add(Convert.ToString(Object.Folio));
							Item.SubItems.Add(Convert.ToString(Object.Name));
							Item.SubItems.Add(Object.AdmissionDate);
						}

						TbxDiagnostic.ReadOnly = TbxDiagnostic.ReadOnly!;
						TbxProblem.ReadOnly = TbxProblem.ReadOnly!;
						Function.LockControls(this);
					}
					else
					{
						MessageBox.Show("Algunos espacios aun estan vacios.");
					}
				break;

				case "BtnCancel":
					Function.ClearTextBox(this);
					Function.LockControls(this);
					TbxDiagnostic.Text = "";
					TbxProblem.Text= "";
					ModifyService = false;
					//Index = null;
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
				TbxDeliveryDate.Text = ThisDay.ToString("d");
			}
		}

		private void SelecteServicesIListView(object sender, EventArgs e)
		{
			if (ModifyService == false)
			{
				if (BxServices.SelectedItems.Count > 0)
				{
					//Get the selected services in service list through your folio
					foreach (var Object in ServicesList)
					{
						if (Convert.ToString(Object.Folio) == Convert.ToString(BxServices.SelectedItems[0].SubItems[0].Text))
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
					TbxDiagnostic.Text = ServiceSelected.Diagnostic;
				}
			}

			/*
			bool Lock = (BxServices.SelectedIndices.Count > 0);
			BtnModify.Enabled = Lock;
			BtnDelete.Enabled = Lock;
			*/
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
	}
}