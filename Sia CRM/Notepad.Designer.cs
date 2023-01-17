namespace SiaCRM
{
	partial class Notepad
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
			this.TbxNote = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// TbxNote
			// 
			this.TbxNote.AcceptsTab = true;
			this.TbxNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TbxNote.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TbxNote.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TbxNote.Location = new System.Drawing.Point(0, 32);
			this.TbxNote.Multiline = true;
			this.TbxNote.Name = "TbxNote";
			this.TbxNote.Size = new System.Drawing.Size(240, 208);
			this.TbxNote.TabIndex = 1;
			// 
			// Notepad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(240, 240);
			this.Controls.Add(this.TbxNote);
			this.Name = "Notepad";
			this.Text = "Notepad";
			this.Controls.SetChildIndex(this.TbxNote, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox TbxNote;
	}
}