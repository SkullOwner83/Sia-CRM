using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SiaCRM
{
    public class Function
    {
        public static List<Control> FormGetControls(Form Window, Control ControlsToGet)
        {
            List<Control> ControlsObtained = new List<Control>();

			foreach (Control Object in Window.Controls)
			{
                switch (ControlsToGet)
                {
                    case TextBox:
						if (Object is TextBox)
							ControlsObtained.Add(Object);
                            Object.Text = "Holi";
					break;

                    case Button:
						if (Object is Button)
						{
							ControlsObtained.Add(Object);
						}
					break;
                }
			}
			return ControlsObtained;
        }

        //Clear string of all textbox
        public static void ClearTextBox(Form Window)
        {
            foreach (Control Object in Window.Controls)
            {
                if (Object is TextBox)
                {
                    Object.Text = "";
                }
            }
        }

        //Toggle between enabling and disabling controls
        public static void LockControls(Form Window)
        {
            foreach (Control Object in Window.Controls)
            {
                //Disable buttons and combobox
                if (Object is Button || Object is ComboBox)
                {
                    Object.Enabled = !Object.Enabled;
                }

                //Make read only the textbox
                if (Object is TextBox)
                {
                    var TxtBox = (TextBox)Object;
                    TxtBox.ReadOnly = !TxtBox.ReadOnly;
                }
            }
        }

		//Validate if the textbox is empty
		public static int EmptyTextBoxCount(params Control[] TxtBoxValidate)
		{
			int TxtBoxEmptys = 0;

			foreach(var Object in TxtBoxValidate)
			{
				if (Object is TextBox)
				{
					var TxtBox = (TextBox)Object;

					if (TxtBox.Text == string.Empty)
					{
						TxtBoxEmptys += 1;
					}
				}
			}

			return TxtBoxEmptys;
		}
    }
}
