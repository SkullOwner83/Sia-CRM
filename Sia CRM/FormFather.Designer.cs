namespace SiaCRM
{
	partial class FormFather
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFather));
			this.PnlHeader = new System.Windows.Forms.Panel();
			this.BtnWindowMinimize = new System.Windows.Forms.Button();
			this.BtnWindowMaximize = new System.Windows.Forms.Button();
			this.BtnWindowClose = new System.Windows.Forms.Button();
			this.LblTitle = new System.Windows.Forms.Label();
			this.BtnWindowRestore = new System.Windows.Forms.Button();
			this.PnlHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// PnlHeader
			// 
			this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
			this.PnlHeader.Controls.Add(this.BtnWindowMinimize);
			this.PnlHeader.Controls.Add(this.BtnWindowMaximize);
			this.PnlHeader.Controls.Add(this.BtnWindowClose);
			this.PnlHeader.Controls.Add(this.BtnWindowRestore);
			this.PnlHeader.Controls.Add(this.LblTitle);
			this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlHeader.Location = new System.Drawing.Point(0, 0);
			this.PnlHeader.Margin = new System.Windows.Forms.Padding(0);
			this.PnlHeader.Name = "PnlHeader";
			this.PnlHeader.Size = new System.Drawing.Size(256, 32);
			this.PnlHeader.TabIndex = 0;
			// 
			// BtnWindowMinimize
			// 
			this.BtnWindowMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnWindowMinimize.BackColor = System.Drawing.Color.Transparent;
			this.BtnWindowMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnWindowMinimize.FlatAppearance.BorderSize = 0;
			this.BtnWindowMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(97)))), ((int)(((byte)(102)))));
			this.BtnWindowMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
			this.BtnWindowMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnWindowMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnWindowMinimize.Image")));
			this.BtnWindowMinimize.Location = new System.Drawing.Point(160, 1);
			this.BtnWindowMinimize.Margin = new System.Windows.Forms.Padding(0);
			this.BtnWindowMinimize.Name = "BtnWindowMinimize";
			this.BtnWindowMinimize.Size = new System.Drawing.Size(32, 32);
			this.BtnWindowMinimize.TabIndex = 35;
			this.BtnWindowMinimize.UseVisualStyleBackColor = false;
			this.BtnWindowMinimize.Click += new System.EventHandler(this.WindowButtons);
			// 
			// BtnWindowMaximize
			// 
			this.BtnWindowMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnWindowMaximize.BackColor = System.Drawing.Color.Transparent;
			this.BtnWindowMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnWindowMaximize.FlatAppearance.BorderSize = 0;
			this.BtnWindowMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(97)))), ((int)(((byte)(102)))));
			this.BtnWindowMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
			this.BtnWindowMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnWindowMaximize.Image = ((System.Drawing.Image)(resources.GetObject("BtnWindowMaximize.Image")));
			this.BtnWindowMaximize.Location = new System.Drawing.Point(192, 1);
			this.BtnWindowMaximize.Margin = new System.Windows.Forms.Padding(0);
			this.BtnWindowMaximize.Name = "BtnWindowMaximize";
			this.BtnWindowMaximize.Size = new System.Drawing.Size(32, 32);
			this.BtnWindowMaximize.TabIndex = 36;
			this.BtnWindowMaximize.UseVisualStyleBackColor = false;
			this.BtnWindowMaximize.Click += new System.EventHandler(this.WindowButtons);
			// 
			// BtnWindowClose
			// 
			this.BtnWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnWindowClose.BackColor = System.Drawing.Color.Transparent;
			this.BtnWindowClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnWindowClose.FlatAppearance.BorderSize = 0;
			this.BtnWindowClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(97)))), ((int)(((byte)(102)))));
			this.BtnWindowClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
			this.BtnWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnWindowClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnWindowClose.Image")));
			this.BtnWindowClose.Location = new System.Drawing.Point(224, 1);
			this.BtnWindowClose.Margin = new System.Windows.Forms.Padding(0);
			this.BtnWindowClose.Name = "BtnWindowClose";
			this.BtnWindowClose.Size = new System.Drawing.Size(32, 32);
			this.BtnWindowClose.TabIndex = 34;
			this.BtnWindowClose.UseVisualStyleBackColor = false;
			this.BtnWindowClose.Click += new System.EventHandler(this.WindowButtons);
			// 
			// LblTitle
			// 
			this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblTitle.ForeColor = System.Drawing.Color.White;
			this.LblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LblTitle.Location = new System.Drawing.Point(0, 0);
			this.LblTitle.Margin = new System.Windows.Forms.Padding(0);
			this.LblTitle.Name = "LblTitle";
			this.LblTitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LblTitle.Size = new System.Drawing.Size(256, 32);
			this.LblTitle.TabIndex = 32;
			this.LblTitle.Text = "Title";
			this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LblTitle.DoubleClick += new System.EventHandler(this.HeaderDoubleClick);
			this.LblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
			// 
			// BtnWindowRestore
			// 
			this.BtnWindowRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnWindowRestore.BackColor = System.Drawing.Color.Transparent;
			this.BtnWindowRestore.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnWindowRestore.FlatAppearance.BorderSize = 0;
			this.BtnWindowRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(97)))), ((int)(((byte)(102)))));
			this.BtnWindowRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
			this.BtnWindowRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnWindowRestore.Image = ((System.Drawing.Image)(resources.GetObject("BtnWindowRestore.Image")));
			this.BtnWindowRestore.Location = new System.Drawing.Point(192, 1);
			this.BtnWindowRestore.Margin = new System.Windows.Forms.Padding(0);
			this.BtnWindowRestore.Name = "BtnWindowRestore";
			this.BtnWindowRestore.Size = new System.Drawing.Size(32, 32);
			this.BtnWindowRestore.TabIndex = 33;
			this.BtnWindowRestore.UseVisualStyleBackColor = false;
			this.BtnWindowRestore.Visible = false;
			this.BtnWindowRestore.Click += new System.EventHandler(this.WindowButtons);
			// 
			// FormFather
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(256, 256);
			this.Controls.Add(this.PnlHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormFather";
			this.Text = "Window";
			this.Load += new System.EventHandler(this.WindowLoad);
			this.PnlHeader.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel PnlHeader;
		private Label LblTitle;
		private Button BtnWindowRestore;
		private Button BtnWindowMinimize;
		private Button BtnWindowMaximize;
		private Button BtnWindowClose;
	}
}