using System.Windows.Forms;

namespace SiaCRM
{
    public class Function
    {
		//Clear string of all textbox
        public static void ClearTextBox(Form Window)
        {
            foreach(Control Object in Window.Controls)
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
			foreach(Control Object in Window.Controls)
			{
				if (Object is TextBox || Object is Button || Object is ComboBox)
				{
					Object.Enabled = !Object.Enabled;
				}
			}
		}
    }
}
