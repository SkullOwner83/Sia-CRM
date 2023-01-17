using System.Runtime.InteropServices;

namespace SiaCRM
{
	public partial class FormFather : Form
	{
		//Declarate form father propertys
		public Size MinWindowSize = new Size(0, 0);
		public Size PrevWindowSize;
		private string State = "Normal";

		public string GetState()
		{
			return this.State;
		}

		//Declarate windows message constants for window resize
		private const int BorderSize = 4;
		private const int WinMarginLeft = 10;
		private const int WinMarginRight = 11;
		private const int WinMarginTop = 12;
		private const int WinMarginTopLeft = 13;
		private const int WinMarginTopRight = 14;
		private const int WinMarginBottom = 15;
		private const int WinMarginBottomLeft = 16;
		private const int WinMarginBottomRight = 17;


		//Import windows drag form native library
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		//Constructor Method
		public FormFather()
		{
			InitializeComponent();
		}

		//Set title of window on load according to the form
		private void WindowLoad(object sender, EventArgs e)
		{
			LblTitle.Text = this.Text;		
			this.Padding = new Padding(BorderSize); 
			this.SetStyle(ControlStyles.ResizeRedraw, true);
			this.DoubleBuffered = true;

			if (MinWindowSize != new Size(0, 0))
			{
				this.MinimumSize = MinWindowSize;
			}		 
		}

		//Drag window from his header
		private void DragWindow(object sender, MouseEventArgs e)
		{
			//Drag window if only click one time in header
			if (e.Button == MouseButtons.Left && e.Clicks == 1)
			{
				ReleaseCapture();
				SendMessage(this.Handle, 0x112, 0xf012, 0);
			}
		} 

		//Change window state on click in header
		private void HeaderDoubleClick(object sender, EventArgs e)
		{
			if (State == "Minimized" || State == "Maximized")
			{
				RestoreWindow();
			}
			else if (State == "Normal")
			{
				MaximizeWindow();
			}
		}

		//Change window state on click in header buttons
		private void WindowButtons(object sender, EventArgs e)
		{
			var Object = (Button)sender;

			//using(Window Window = new Window())
			switch (Object.Name)
			{
				case "BtnWindowMinimize": MinimizeWindow(); break;
				case "BtnWindowMaximize": MaximizeWindow(); break;
				case "BtnWindowRestore": RestoreWindow(); break;
				case "BtnWindowClose": this.Close(); break;
			}
		}

		//Set window state to minimize
		private void MinimizeWindow()
		{
			//this.WindowState = FormWindowState.Minimized;
			this.Padding = new Padding(0);
			this.Dock = DockStyle.None;
			this.PrevWindowSize = new Size(this.Width, this.Height);
			this.MinimumSize = new Size(128, 32);
			this.Size = new Size(128, 32);
			BtnWindowMinimize.Visible = false;
			BtnWindowMaximize.Visible = false;
			BtnWindowRestore.Visible = false;
			State = "Minimized";
		}

		//Set window state to maximized
		private void MaximizeWindow()
		{
			//this.WindowState = FormWindowState.Maximized;
			//this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

			this.Padding = new Padding(0);
			this.PrevWindowSize = new Size(this.Width, this.Height);
			this.Dock = DockStyle.Fill;
			BtnWindowMaximize.Visible = false;
			BtnWindowRestore.Visible = true;
			BtnWindowRestore.BringToFront();
			State = "Maximized";
		}

		//Restore the previous state of window
		private void RestoreWindow()
		{
			this.Padding = new Padding(BorderSize);
			this.Dock = DockStyle.None;
			this.Size = PrevWindowSize;
			this.MinimumSize = MinWindowSize;
			BtnWindowMinimize.Visible = true;
			BtnWindowMaximize.Visible = true;
			BtnWindowRestore.Visible = false;
			BtnWindowMaximize.BringToFront();
			State = "Normal";
		}

		//Overwrite window resize method
		protected override void WndProc(ref Message MsgCode)
		{
			if (MsgCode.Msg == 0x84)
			{
				//Get mouse position
				Point MousePos = new Point(MsgCode.LParam.ToInt32());
				MousePos = this.PointToClient(MousePos);

				//Resize window from Top left margin
				if (MousePos.X <= BorderSize && MousePos.Y <= BorderSize)
				{
					MsgCode.Result = (IntPtr)WinMarginTopLeft;
					return;
				}

				//Resize window from Top right margin
				if (MousePos.X >= this.ClientSize.Width - BorderSize && MousePos.Y <= BorderSize)
				{
					MsgCode.Result = (IntPtr)WinMarginTopRight;
					return;
				}

				//Rize window from bottom left corner
				if (MousePos.X <= BorderSize && MousePos.Y >= this.ClientSize.Height - BorderSize)
				{
					MsgCode.Result = (IntPtr)WinMarginBottomLeft;
					return;
				}

				//Resize window from bottom right corner
				if (MousePos.X >= this.ClientSize.Width - BorderSize && MousePos.Y >= this.ClientSize.Height - BorderSize)
				{
					MsgCode.Result = (IntPtr)WinMarginBottomRight;
					return;
				}

				//Resize window from Top margin
				if (MousePos.Y <= BorderSize)
				{
					MsgCode.Result = (IntPtr)WinMarginTop;
					return;
				}

				//Resize window from left margin
				if (MousePos.X <= BorderSize)
				{
					MsgCode.Result = (IntPtr)WinMarginLeft;
					return;
				}

				//Resize window from right margin
				if (MousePos.X >= ClientSize.Width - BorderSize)
				{
					MsgCode.Result = (IntPtr)WinMarginRight; 
					return;
				}

				//Resize window from Bottom margin
				if (MousePos.Y >= this.ClientSize.Height - BorderSize)
				{
					MsgCode.Result = (IntPtr)WinMarginBottom;
					return;
				}
			}

			base.WndProc(ref MsgCode);
		}
	}
}
