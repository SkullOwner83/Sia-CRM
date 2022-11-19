using System.Xml.Linq;

namespace SiaCRM
{
    public partial class window_services : Form
	{
        public window_services()
        {
            InitializeComponent();
        }

        private void window_services_Load(object sender, EventArgs e)
        {
            BxStatus.Items.Add("En servicio");
            BxStatus.Items.Add("Terminado");
            BxStatus.Items.Add("Entregado");
        }
        private void BtnNewService_Click(object sender, EventArgs e)
        {
            Function.ClearTextBox(this);
            Function.LockControls(this);
			DateTime ThisDay = DateTime.Today;
			TbxAdmissionDate.Text = ThisDay.ToString("d");
			BxStatus.SelectedIndex = 0;
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            Function.LockControls(this);
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            LbxServices.Items.Add(TbxFolio.Text + " " + TbxName.Text + " " + TbxAdmissionDate.Text);
            Function.LockControls(this);
        }
    }
}