using System.Windows.Forms;

namespace SiaCRM
{
    public class Function
    {
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

		//Validate only numeric inputs by his ASCII code range
		public static void OnlyNumericInputs(object Sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
			{
				e.Handled = true;
			}
		}

		//Validate only alphabet inputs by his ASCII code range
		public static void OnlyAlphabetInputs(object Sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
			{
				e.Handled = true;
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
