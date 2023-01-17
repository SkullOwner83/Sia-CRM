using System.ComponentModel;

namespace SiaCRM
{
	public static class Extension
	{
		//Get form controls including his nested controls
		public static List<ControlType> GetControls<ControlType>(this Control Container) where ControlType : Control
		{
			List<ControlType> ControlsObtained = new List<ControlType>();

			//Walk through the collection of controls obtained in compile time
			foreach (Control Object in Container.Controls)
			{
				//Check if the current object is of the type specified by the user
				if (Object is ControlType)
				{
					ControlsObtained.Add((ControlType)Object);
				}

				ControlsObtained.AddRange(GetControls<ControlType>(Object));
			}

			return ControlsObtained;
		}
	}

    public class Function
    {
        //Clear all textboxes from control or form specified
        public static void ClearTextBox(Form Container)
        {
            Container.GetControls<TextBox>().ForEach(p => p.Text = string.Empty);
        }

		public static void ClearTextBox(Control Container)
        {
            Container.GetControls<TextBox>().ForEach(p => p.Text = string.Empty);
        }

		//Toggle between enabling and disabling controls from control or form specified
		public static void LockControls(Form Container)
		{
			Container.GetControls<TextBox>().ForEach(p => p.ReadOnly = !p.ReadOnly);
			Container.GetControls<Button>().ForEach(p =>
			{
				if (Convert.ToString(p.Tag) == "Lockable")
				{
					p.Enabled = !p.Enabled;
				}
			});
		}

		public static void LockControls(Control Container)
        {
            Container.GetControls<TextBox>().ForEach(p => p.ReadOnly = !p.ReadOnly);
            Container.GetControls<ComboBox>().ForEach(p => p.Enabled = !p.Enabled);
			Container.GetControls<Button>().ForEach(p => {
				if (Convert.ToString(p.Tag) == "Lockable")
				{
					p.Enabled = !p.Enabled;
				}
			});
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
