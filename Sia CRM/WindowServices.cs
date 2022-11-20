using System.ComponentModel.DataAnnotations;
using System.Media;
using System.Xml.Linq;
using Sia_CRM;

namespace SiaCRM
{
    public partial class WindowServices : Form
	{		
		bool ModifyService = false;
		List<Service> ServicesList = new List<Service>();

        public WindowServices()
        {
            InitializeComponent();
        }

		private void ButtonClicked(object Sender, EventArgs e)
		{
			var ObjButton = (Button)Sender;

			switch(ObjButton.Name)
			{
				case "BtnNewService":
					Function.ClearTextBox(this);
					Function.LockControls(this);
					DateTime ThisDay = DateTime.Today;
					TbxAdmissionDate.Text = ThisDay.ToString("d");
					BxStatus.SelectedIndex = 0;
					BxServicesDetails.SelectedTab = BxProblemPage;
				break;

				case "BtnModify":
					//FALTA Validar si se tiene un elemento seleccionado
						ModifyService = true;
						Function.LockControls(this);
						TbxFolio.Text = Convert.ToString(BxServices.SelectedItems[0].SubItems[0].Text);
						TbxCustomerName.Text = Convert.ToString(BxServices.SelectedItems[0].SubItems[1].Text);
						TbxAdmissionDate.Text = Convert.ToString(BxServices.SelectedItems[0].SubItems[2].Text);
				break;

				case "BtnDelete":
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
							ServicesList.Add(NewService);

							//Refresh data in listview with service instance list
							BxServices.Items.Clear();

							foreach(var Object in ServicesList)
							{
								ListViewItem Item = new ListViewItem();
								Item = BxServices.Items.Add(Convert.ToString(Object.Folio));
								Item.SubItems.Add(Convert.ToString(Object.Name));
								Item.SubItems.Add(Object.AdmissionDate);
							}
						}
						else
						{

							BxServices.SelectedItems[0].SubItems[0].Text = TbxFolio.Text;
							BxServices.SelectedItems[0].SubItems[1].Text = TbxCustomerName.Text;
							BxServices.SelectedItems[0].SubItems[2].Text = TbxAdmissionDate.Text;
						}

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
					ModifyService = false;
				break;
			}
		}

		//Set the current date to select delivery status
		private void BxStatus_SelectedIndexChanged(object Sender, EventArgs e)
		{
			int Index = BxStatus.SelectedIndex;

			if (Convert.ToString(BxStatus.Items[Index]) == "Entregado")
			{
				DateTime ThisDay = DateTime.Today;
				TbxDeliveryDate.Text = ThisDay.ToString("d");
			}
		}
		
	}
}