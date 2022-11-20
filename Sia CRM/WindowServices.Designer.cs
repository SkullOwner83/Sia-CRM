namespace SiaCRM
{
    partial class WindowServices
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.BtnAcept = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.LblPeriod = new System.Windows.Forms.Label();
			this.BtnModify = new System.Windows.Forms.Button();
			this.BtnNewService = new System.Windows.Forms.Button();
			this.BxServices = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.LblStatus = new System.Windows.Forms.Label();
			this.TbxDeliveryDate = new System.Windows.Forms.TextBox();
			this.LblCustomer = new System.Windows.Forms.Label();
			this.TbxFolio = new System.Windows.Forms.TextBox();
			this.LblName = new System.Windows.Forms.Label();
			this.BxStatus = new System.Windows.Forms.ComboBox();
			this.TbxCustomerNumber = new System.Windows.Forms.TextBox();
			this.LblFolio = new System.Windows.Forms.Label();
			this.TbxAdmissionDate = new System.Windows.Forms.TextBox();
			this.LblAdmissionDate = new System.Windows.Forms.Label();
			this.TbxCustomerName = new System.Windows.Forms.TextBox();
			this.LblDeliveryDate = new System.Windows.Forms.Label();
			this.BxServicesDetails = new System.Windows.Forms.TabControl();
			this.BxDiagnosticPage = new System.Windows.Forms.TabPage();
			this.TbxDiagnostic = new System.Windows.Forms.TextBox();
			this.BxProblemPage = new System.Windows.Forms.TabPage();
			this.TbxProblem = new System.Windows.Forms.TextBox();
			this.BtnDelete = new System.Windows.Forms.Button();
			this.BxServicesDetails.SuspendLayout();
			this.BxDiagnosticPage.SuspendLayout();
			this.BxProblemPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnAcept
			// 
			this.BtnAcept.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnAcept.Enabled = false;
			this.BtnAcept.Location = new System.Drawing.Point(379, 537);
			this.BtnAcept.Name = "BtnAcept";
			this.BtnAcept.Size = new System.Drawing.Size(89, 33);
			this.BtnAcept.TabIndex = 5;
			this.BtnAcept.Text = "Aceptar";
			this.BtnAcept.UseVisualStyleBackColor = true;
			this.BtnAcept.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnCancel.Enabled = false;
			this.BtnCancel.Location = new System.Drawing.Point(474, 537);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(89, 33);
			this.BtnCancel.TabIndex = 6;
			this.BtnCancel.Text = "Cancelar";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.IntegralHeight = false;
			this.comboBox2.Location = new System.Drawing.Point(136, 35);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(425, 26);
			this.comboBox2.TabIndex = 17;
			// 
			// LblPeriod
			// 
			this.LblPeriod.AutoSize = true;
			this.LblPeriod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblPeriod.Location = new System.Drawing.Point(52, 39);
			this.LblPeriod.Name = "LblPeriod";
			this.LblPeriod.Size = new System.Drawing.Size(82, 22);
			this.LblPeriod.TabIndex = 18;
			this.LblPeriod.Text = "Periodo:";
			// 
			// BtnModify
			// 
			this.BtnModify.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnModify.Location = new System.Drawing.Point(147, 537);
			this.BtnModify.Name = "BtnModify";
			this.BtnModify.Size = new System.Drawing.Size(89, 33);
			this.BtnModify.TabIndex = 20;
			this.BtnModify.Text = "Modificar";
			this.BtnModify.UseVisualStyleBackColor = true;
			this.BtnModify.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// BtnNewService
			// 
			this.BtnNewService.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnNewService.Location = new System.Drawing.Point(52, 537);
			this.BtnNewService.Name = "BtnNewService";
			this.BtnNewService.Size = new System.Drawing.Size(89, 33);
			this.BtnNewService.TabIndex = 21;
			this.BtnNewService.Text = "Nuevo";
			this.BtnNewService.UseVisualStyleBackColor = true;
			this.BtnNewService.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// BxServices
			// 
			this.BxServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BxServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.BxServices.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BxServices.Location = new System.Drawing.Point(52, 76);
			this.BxServices.MultiSelect = false;
			this.BxServices.Name = "BxServices";
			this.BxServices.Size = new System.Drawing.Size(509, 148);
			this.BxServices.TabIndex = 22;
			this.BxServices.UseCompatibleStateImageBehavior = false;
			this.BxServices.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Folio";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Nombre";
			this.columnHeader2.Width = 300;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Fecha";
			this.columnHeader3.Width = 100;
			// 
			// LblStatus
			// 
			this.LblStatus.AutoSize = true;
			this.LblStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblStatus.Location = new System.Drawing.Point(362, 349);
			this.LblStatus.Name = "LblStatus";
			this.LblStatus.Size = new System.Drawing.Size(75, 22);
			this.LblStatus.TabIndex = 0;
			this.LblStatus.Text = "Estado:";
			// 
			// TbxDeliveryDate
			// 
			this.TbxDeliveryDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbxDeliveryDate.Location = new System.Drawing.Point(449, 274);
			this.TbxDeliveryDate.Margin = new System.Windows.Forms.Padding(4);
			this.TbxDeliveryDate.Name = "TbxDeliveryDate";
			this.TbxDeliveryDate.ReadOnly = true;
			this.TbxDeliveryDate.Size = new System.Drawing.Size(112, 26);
			this.TbxDeliveryDate.TabIndex = 8;
			// 
			// LblCustomer
			// 
			this.LblCustomer.AutoSize = true;
			this.LblCustomer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblCustomer.Location = new System.Drawing.Point(52, 278);
			this.LblCustomer.Name = "LblCustomer";
			this.LblCustomer.Size = new System.Drawing.Size(74, 22);
			this.LblCustomer.TabIndex = 0;
			this.LblCustomer.Text = "Cliente:";
			// 
			// TbxFolio
			// 
			this.TbxFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbxFolio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TbxFolio.Location = new System.Drawing.Point(136, 240);
			this.TbxFolio.Margin = new System.Windows.Forms.Padding(4);
			this.TbxFolio.Name = "TbxFolio";
			this.TbxFolio.ReadOnly = true;
			this.TbxFolio.Size = new System.Drawing.Size(112, 26);
			this.TbxFolio.TabIndex = 1;
			// 
			// LblName
			// 
			this.LblName.AutoSize = true;
			this.LblName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblName.Location = new System.Drawing.Point(52, 316);
			this.LblName.Name = "LblName";
			this.LblName.Size = new System.Drawing.Size(83, 22);
			this.LblName.TabIndex = 0;
			this.LblName.Text = "Nombre:";
			// 
			// BxStatus
			// 
			this.BxStatus.BackColor = System.Drawing.SystemColors.Window;
			this.BxStatus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BxStatus.Enabled = false;
			this.BxStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BxStatus.FormattingEnabled = true;
			this.BxStatus.Items.AddRange(new object[] {
            "En servicio",
            "Terminado",
            "Entregado"});
			this.BxStatus.Location = new System.Drawing.Point(449, 345);
			this.BxStatus.Name = "BxStatus";
			this.BxStatus.Size = new System.Drawing.Size(112, 26);
			this.BxStatus.TabIndex = 9;
			this.BxStatus.SelectedIndexChanged += new System.EventHandler(this.BxStatus_SelectedIndexChanged);
			// 
			// TbxCustomerNumber
			// 
			this.TbxCustomerNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbxCustomerNumber.Location = new System.Drawing.Point(136, 274);
			this.TbxCustomerNumber.Margin = new System.Windows.Forms.Padding(4);
			this.TbxCustomerNumber.Name = "TbxCustomerNumber";
			this.TbxCustomerNumber.ReadOnly = true;
			this.TbxCustomerNumber.Size = new System.Drawing.Size(112, 26);
			this.TbxCustomerNumber.TabIndex = 2;
			// 
			// LblFolio
			// 
			this.LblFolio.AutoSize = true;
			this.LblFolio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblFolio.Location = new System.Drawing.Point(52, 244);
			this.LblFolio.Name = "LblFolio";
			this.LblFolio.Size = new System.Drawing.Size(57, 22);
			this.LblFolio.TabIndex = 0;
			this.LblFolio.Text = "Folio:";
			// 
			// TbxAdmissionDate
			// 
			this.TbxAdmissionDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbxAdmissionDate.Location = new System.Drawing.Point(449, 240);
			this.TbxAdmissionDate.Margin = new System.Windows.Forms.Padding(4);
			this.TbxAdmissionDate.Name = "TbxAdmissionDate";
			this.TbxAdmissionDate.ReadOnly = true;
			this.TbxAdmissionDate.Size = new System.Drawing.Size(112, 26);
			this.TbxAdmissionDate.TabIndex = 7;
			// 
			// LblAdmissionDate
			// 
			this.LblAdmissionDate.AutoSize = true;
			this.LblAdmissionDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblAdmissionDate.Location = new System.Drawing.Point(362, 244);
			this.LblAdmissionDate.Name = "LblAdmissionDate";
			this.LblAdmissionDate.Size = new System.Drawing.Size(80, 22);
			this.LblAdmissionDate.TabIndex = 0;
			this.LblAdmissionDate.Text = "Ingreso:";
			// 
			// TbxCustomerName
			// 
			this.TbxCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbxCustomerName.Location = new System.Drawing.Point(136, 312);
			this.TbxCustomerName.Margin = new System.Windows.Forms.Padding(4);
			this.TbxCustomerName.Name = "TbxCustomerName";
			this.TbxCustomerName.ReadOnly = true;
			this.TbxCustomerName.Size = new System.Drawing.Size(425, 26);
			this.TbxCustomerName.TabIndex = 3;
			// 
			// LblDeliveryDate
			// 
			this.LblDeliveryDate.AutoSize = true;
			this.LblDeliveryDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblDeliveryDate.Location = new System.Drawing.Point(362, 278);
			this.LblDeliveryDate.Name = "LblDeliveryDate";
			this.LblDeliveryDate.Size = new System.Drawing.Size(81, 22);
			this.LblDeliveryDate.TabIndex = 0;
			this.LblDeliveryDate.Text = "Entrega:";
			// 
			// BxServicesDetails
			// 
			this.BxServicesDetails.Controls.Add(this.BxDiagnosticPage);
			this.BxServicesDetails.Controls.Add(this.BxProblemPage);
			this.BxServicesDetails.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BxServicesDetails.HotTrack = true;
			this.BxServicesDetails.Location = new System.Drawing.Point(52, 345);
			this.BxServicesDetails.Multiline = true;
			this.BxServicesDetails.Name = "BxServicesDetails";
			this.BxServicesDetails.SelectedIndex = 0;
			this.BxServicesDetails.Size = new System.Drawing.Size(509, 181);
			this.BxServicesDetails.TabIndex = 23;
			// 
			// BxDiagnosticPage
			// 
			this.BxDiagnosticPage.Controls.Add(this.TbxDiagnostic);
			this.BxDiagnosticPage.Location = new System.Drawing.Point(4, 31);
			this.BxDiagnosticPage.Name = "BxDiagnosticPage";
			this.BxDiagnosticPage.Padding = new System.Windows.Forms.Padding(3);
			this.BxDiagnosticPage.Size = new System.Drawing.Size(501, 146);
			this.BxDiagnosticPage.TabIndex = 0;
			this.BxDiagnosticPage.Text = "Diagnóstico";
			this.BxDiagnosticPage.UseVisualStyleBackColor = true;
			// 
			// TbxDiagnostic
			// 
			this.TbxDiagnostic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbxDiagnostic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TbxDiagnostic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TbxDiagnostic.Location = new System.Drawing.Point(3, 3);
			this.TbxDiagnostic.Multiline = true;
			this.TbxDiagnostic.Name = "TbxDiagnostic";
			this.TbxDiagnostic.Size = new System.Drawing.Size(495, 140);
			this.TbxDiagnostic.TabIndex = 0;
			// 
			// BxProblemPage
			// 
			this.BxProblemPage.Controls.Add(this.TbxProblem);
			this.BxProblemPage.Location = new System.Drawing.Point(4, 31);
			this.BxProblemPage.Name = "BxProblemPage";
			this.BxProblemPage.Padding = new System.Windows.Forms.Padding(3);
			this.BxProblemPage.Size = new System.Drawing.Size(501, 146);
			this.BxProblemPage.TabIndex = 1;
			this.BxProblemPage.Text = "Problema";
			this.BxProblemPage.UseVisualStyleBackColor = true;
			// 
			// TbxProblem
			// 
			this.TbxProblem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbxProblem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TbxProblem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TbxProblem.Location = new System.Drawing.Point(3, 3);
			this.TbxProblem.Multiline = true;
			this.TbxProblem.Name = "TbxProblem";
			this.TbxProblem.Size = new System.Drawing.Size(495, 140);
			this.TbxProblem.TabIndex = 1;
			// 
			// BtnDelete
			// 
			this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnDelete.Location = new System.Drawing.Point(242, 537);
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(89, 33);
			this.BtnDelete.TabIndex = 24;
			this.BtnDelete.Text = "Borrar";
			this.BtnDelete.UseVisualStyleBackColor = true;
			this.BtnDelete.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// WindowServices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 601);
			this.Controls.Add(this.BtnDelete);
			this.Controls.Add(this.BxServices);
			this.Controls.Add(this.LblPeriod);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.LblFolio);
			this.Controls.Add(this.TbxFolio);
			this.Controls.Add(this.LblCustomer);
			this.Controls.Add(this.TbxCustomerNumber);
			this.Controls.Add(this.LblName);
			this.Controls.Add(this.TbxCustomerName);
			this.Controls.Add(this.LblAdmissionDate);
			this.Controls.Add(this.TbxAdmissionDate);
			this.Controls.Add(this.LblDeliveryDate);
			this.Controls.Add(this.TbxDeliveryDate);
			this.Controls.Add(this.BtnNewService);
			this.Controls.Add(this.BtnModify);
			this.Controls.Add(this.BxStatus);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.BtnAcept);
			this.Controls.Add(this.LblStatus);
			this.Controls.Add(this.BxServicesDetails);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "WindowServices";
			this.ShowIcon = false;
			this.Text = "Servicios";
			this.BxServicesDetails.ResumeLayout(false);
			this.BxDiagnosticPage.ResumeLayout(false);
			this.BxDiagnosticPage.PerformLayout();
			this.BxProblemPage.ResumeLayout(false);
			this.BxProblemPage.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Label LblPeriod;
        private ComboBox comboBox1;
        private Button BtnNewService;
        private Button BtnAcept;
        private Button BtnModify;
        private Button BtnCancel;
        private ComboBox comboBox2;
        private ListView BxServices;
        private Label LblStatus;
        private TextBox TbxDeliveryDate;
        private Label LblCustomer;
        private TextBox TbxFolio;
        private Label LblName;
        private ComboBox BxStatus;
        private TextBox TbxCustomerNumber;
        private Label LblFolio;
        private TextBox TbxAdmissionDate;
        private Label LblAdmissionDate;
        private TextBox TbxCustomerName;
        private Label LblDeliveryDate;
		private TabControl BxServicesDetails;
		private TabPage BxDiagnosticPage;
		private TabPage BxProblemPage;
		private TextBox TbxDiagnostic;
		private TextBox TbxProblem;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private Button BtnDelete;
	}
}