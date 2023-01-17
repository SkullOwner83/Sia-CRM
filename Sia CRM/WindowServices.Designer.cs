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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowServices));
			this.ImgStatus = new System.Windows.Forms.ImageList(this.components);
			this.PnlBody = new System.Windows.Forms.Panel();
			this.PnlForm = new System.Windows.Forms.Panel();
			this.LblFolio = new System.Windows.Forms.Label();
			this.TbxDeliveryDate = new System.Windows.Forms.TextBox();
			this.LblDeliveryDate = new System.Windows.Forms.Label();
			this.TbxAdmissionDate = new System.Windows.Forms.TextBox();
			this.LblAdmissionDate = new System.Windows.Forms.Label();
			this.TbxCustomerName = new System.Windows.Forms.TextBox();
			this.LblName = new System.Windows.Forms.Label();
			this.TbxCustomerNumber = new System.Windows.Forms.TextBox();
			this.TbxFolio = new System.Windows.Forms.TextBox();
			this.LblCustomer = new System.Windows.Forms.Label();
			this.BtnDelete = new System.Windows.Forms.Button();
			this.BxServices = new System.Windows.Forms.ListView();
			this.ListViewStatusColumn = new System.Windows.Forms.ColumnHeader();
			this.ListViewFolioColumn = new System.Windows.Forms.ColumnHeader();
			this.ListViewNameColumn = new System.Windows.Forms.ColumnHeader();
			this.ListViewAdmissionColumn = new System.Windows.Forms.ColumnHeader();
			this.LblFilter = new System.Windows.Forms.Label();
			this.LblPeriod = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.TbxFilter = new System.Windows.Forms.TextBox();
			this.BtnNewService = new System.Windows.Forms.Button();
			this.BtnModify = new System.Windows.Forms.Button();
			this.BxStatus = new System.Windows.Forms.ComboBox();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.BtnAcept = new System.Windows.Forms.Button();
			this.LblStatus = new System.Windows.Forms.Label();
			this.BxServicesDetails = new System.Windows.Forms.TabControl();
			this.BxDiagnosticPage = new System.Windows.Forms.TabPage();
			this.TbxDiagnostic = new System.Windows.Forms.TextBox();
			this.BxProblemPage = new System.Windows.Forms.TabPage();
			this.TbxProblem = new System.Windows.Forms.TextBox();
			this.PnlBody.SuspendLayout();
			this.PnlForm.SuspendLayout();
			this.BxServicesDetails.SuspendLayout();
			this.BxDiagnosticPage.SuspendLayout();
			this.BxProblemPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// ImgStatus
			// 
			this.ImgStatus.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ImgStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgStatus.ImageStream")));
			this.ImgStatus.TransparentColor = System.Drawing.Color.Transparent;
			this.ImgStatus.Images.SetKeyName(0, "a.png");
			this.ImgStatus.Images.SetKeyName(1, "b.png");
			this.ImgStatus.Images.SetKeyName(2, "c.png");
			// 
			// PnlBody
			// 
			this.PnlBody.BackColor = System.Drawing.Color.White;
			this.PnlBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PnlBody.Controls.Add(this.PnlForm);
			this.PnlBody.Controls.Add(this.BtnDelete);
			this.PnlBody.Controls.Add(this.BxServices);
			this.PnlBody.Controls.Add(this.LblFilter);
			this.PnlBody.Controls.Add(this.LblPeriod);
			this.PnlBody.Controls.Add(this.comboBox2);
			this.PnlBody.Controls.Add(this.TbxFilter);
			this.PnlBody.Controls.Add(this.BtnNewService);
			this.PnlBody.Controls.Add(this.BtnModify);
			this.PnlBody.Controls.Add(this.BxStatus);
			this.PnlBody.Controls.Add(this.BtnCancel);
			this.PnlBody.Controls.Add(this.BtnAcept);
			this.PnlBody.Controls.Add(this.LblStatus);
			this.PnlBody.Controls.Add(this.BxServicesDetails);
			this.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlBody.Location = new System.Drawing.Point(4, 36);
			this.PnlBody.Name = "PnlBody";
			this.PnlBody.Size = new System.Drawing.Size(616, 584);
			this.PnlBody.TabIndex = 1;
			// 
			// PnlForm
			// 
			this.PnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PnlForm.Controls.Add(this.LblFolio);
			this.PnlForm.Controls.Add(this.TbxDeliveryDate);
			this.PnlForm.Controls.Add(this.LblDeliveryDate);
			this.PnlForm.Controls.Add(this.TbxAdmissionDate);
			this.PnlForm.Controls.Add(this.LblAdmissionDate);
			this.PnlForm.Controls.Add(this.TbxCustomerName);
			this.PnlForm.Controls.Add(this.LblName);
			this.PnlForm.Controls.Add(this.TbxCustomerNumber);
			this.PnlForm.Controls.Add(this.TbxFolio);
			this.PnlForm.Controls.Add(this.LblCustomer);
			this.PnlForm.Location = new System.Drawing.Point(51, 234);
			this.PnlForm.Margin = new System.Windows.Forms.Padding(4);
			this.PnlForm.Name = "PnlForm";
			this.PnlForm.Size = new System.Drawing.Size(512, 94);
			this.PnlForm.TabIndex = 48;
			// 
			// LblFolio
			// 
			this.LblFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LblFolio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblFolio.Location = new System.Drawing.Point(0, 0);
			this.LblFolio.Name = "LblFolio";
			this.LblFolio.Size = new System.Drawing.Size(83, 26);
			this.LblFolio.TabIndex = 29;
			this.LblFolio.Text = "Folio:";
			this.LblFolio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TbxDeliveryDate
			// 
			this.TbxDeliveryDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.TbxDeliveryDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbxDeliveryDate.Location = new System.Drawing.Point(400, 34);
			this.TbxDeliveryDate.Margin = new System.Windows.Forms.Padding(4);
			this.TbxDeliveryDate.Name = "TbxDeliveryDate";
			this.TbxDeliveryDate.ReadOnly = true;
			this.TbxDeliveryDate.Size = new System.Drawing.Size(112, 26);
			this.TbxDeliveryDate.TabIndex = 38;
			// 
			// LblDeliveryDate
			// 
			this.LblDeliveryDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LblDeliveryDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblDeliveryDate.Location = new System.Drawing.Point(314, 34);
			this.LblDeliveryDate.Name = "LblDeliveryDate";
			this.LblDeliveryDate.Size = new System.Drawing.Size(83, 26);
			this.LblDeliveryDate.TabIndex = 26;
			this.LblDeliveryDate.Text = "Entrega:";
			this.LblDeliveryDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TbxAdmissionDate
			// 
			this.TbxAdmissionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.TbxAdmissionDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbxAdmissionDate.Location = new System.Drawing.Point(400, 0);
			this.TbxAdmissionDate.Margin = new System.Windows.Forms.Padding(4);
			this.TbxAdmissionDate.Name = "TbxAdmissionDate";
			this.TbxAdmissionDate.ReadOnly = true;
			this.TbxAdmissionDate.Size = new System.Drawing.Size(112, 26);
			this.TbxAdmissionDate.TabIndex = 37;
			// 
			// LblAdmissionDate
			// 
			this.LblAdmissionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LblAdmissionDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblAdmissionDate.Location = new System.Drawing.Point(314, 0);
			this.LblAdmissionDate.Name = "LblAdmissionDate";
			this.LblAdmissionDate.Size = new System.Drawing.Size(83, 26);
			this.LblAdmissionDate.TabIndex = 27;
			this.LblAdmissionDate.Text = "Ingreso:";
			this.LblAdmissionDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TbxCustomerName
			// 
			this.TbxCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TbxCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbxCustomerName.Location = new System.Drawing.Point(84, 68);
			this.TbxCustomerName.Margin = new System.Windows.Forms.Padding(4);
			this.TbxCustomerName.Name = "TbxCustomerName";
			this.TbxCustomerName.ReadOnly = true;
			this.TbxCustomerName.Size = new System.Drawing.Size(428, 26);
			this.TbxCustomerName.TabIndex = 34;
			this.TbxCustomerName.Tag = "Alphabet";
			// 
			// LblName
			// 
			this.LblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LblName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblName.Location = new System.Drawing.Point(0, 68);
			this.LblName.Margin = new System.Windows.Forms.Padding(0);
			this.LblName.Name = "LblName";
			this.LblName.Size = new System.Drawing.Size(83, 26);
			this.LblName.TabIndex = 25;
			this.LblName.Text = "Nombre:";
			this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TbxCustomerNumber
			// 
			this.TbxCustomerNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.TbxCustomerNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbxCustomerNumber.Location = new System.Drawing.Point(84, 34);
			this.TbxCustomerNumber.Margin = new System.Windows.Forms.Padding(4);
			this.TbxCustomerNumber.Name = "TbxCustomerNumber";
			this.TbxCustomerNumber.ReadOnly = true;
			this.TbxCustomerNumber.Size = new System.Drawing.Size(112, 26);
			this.TbxCustomerNumber.TabIndex = 33;
			this.TbxCustomerNumber.Tag = "Numeric";
			// 
			// TbxFolio
			// 
			this.TbxFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.TbxFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbxFolio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TbxFolio.Location = new System.Drawing.Point(84, 0);
			this.TbxFolio.Margin = new System.Windows.Forms.Padding(4);
			this.TbxFolio.Name = "TbxFolio";
			this.TbxFolio.ReadOnly = true;
			this.TbxFolio.Size = new System.Drawing.Size(112, 26);
			this.TbxFolio.TabIndex = 32;
			this.TbxFolio.Tag = "Numeric";
			// 
			// LblCustomer
			// 
			this.LblCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LblCustomer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblCustomer.Location = new System.Drawing.Point(0, 34);
			this.LblCustomer.Margin = new System.Windows.Forms.Padding(0);
			this.LblCustomer.Name = "LblCustomer";
			this.LblCustomer.Size = new System.Drawing.Size(83, 26);
			this.LblCustomer.TabIndex = 30;
			this.LblCustomer.Text = "Cliente:";
			this.LblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnDelete
			// 
			this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnDelete.Enabled = false;
			this.BtnDelete.FlatAppearance.BorderSize = 0;
			this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BtnDelete.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BtnDelete.ForeColor = System.Drawing.Color.Black;
			this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnDelete.Location = new System.Drawing.Point(237, 527);
			this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(89, 32);
			this.BtnDelete.TabIndex = 47;
			this.BtnDelete.Tag = "Lockable";
			this.BtnDelete.Text = "Borrar";
			this.BtnDelete.UseVisualStyleBackColor = false;
			this.BtnDelete.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// BxServices
			// 
			this.BxServices.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.BxServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BxServices.BackColor = System.Drawing.SystemColors.Window;
			this.BxServices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BxServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListViewStatusColumn,
            this.ListViewFolioColumn,
            this.ListViewNameColumn,
            this.ListViewAdmissionColumn});
			this.BxServices.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BxServices.ForeColor = System.Drawing.SystemColors.WindowText;
			this.BxServices.FullRowSelect = true;
			this.BxServices.Location = new System.Drawing.Point(51, 64);
			this.BxServices.Margin = new System.Windows.Forms.Padding(4);
			this.BxServices.MultiSelect = false;
			this.BxServices.Name = "BxServices";
			this.BxServices.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.BxServices.Size = new System.Drawing.Size(512, 140);
			this.BxServices.SmallImageList = this.ImgStatus;
			this.BxServices.TabIndex = 45;
			this.BxServices.UseCompatibleStateImageBehavior = false;
			this.BxServices.View = System.Windows.Forms.View.Details;
			this.BxServices.SelectedIndexChanged += new System.EventHandler(this.SelecteServicesInListView);
			// 
			// ListViewStatusColumn
			// 
			this.ListViewStatusColumn.Text = "";
			this.ListViewStatusColumn.Width = 24;
			// 
			// ListViewFolioColumn
			// 
			this.ListViewFolioColumn.Text = "Folio";
			this.ListViewFolioColumn.Width = 80;
			// 
			// ListViewNameColumn
			// 
			this.ListViewNameColumn.Text = "Nombre";
			this.ListViewNameColumn.Width = 300;
			// 
			// ListViewAdmissionColumn
			// 
			this.ListViewAdmissionColumn.Text = "Fecha";
			this.ListViewAdmissionColumn.Width = 100;
			// 
			// LblFilter
			// 
			this.LblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LblFilter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblFilter.Location = new System.Drawing.Point(280, 28);
			this.LblFilter.Name = "LblFilter";
			this.LblFilter.Size = new System.Drawing.Size(83, 26);
			this.LblFilter.TabIndex = 42;
			this.LblFilter.Text = "Filtro:";
			this.LblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblPeriod
			// 
			this.LblPeriod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblPeriod.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LblPeriod.Location = new System.Drawing.Point(51, 27);
			this.LblPeriod.Name = "LblPeriod";
			this.LblPeriod.Size = new System.Drawing.Size(83, 26);
			this.LblPeriod.TabIndex = 41;
			this.LblPeriod.Text = "Periodo:";
			this.LblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.IntegralHeight = false;
			this.comboBox2.Location = new System.Drawing.Point(135, 27);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(112, 26);
			this.comboBox2.TabIndex = 40;
			// 
			// TbxFilter
			// 
			this.TbxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TbxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbxFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TbxFilter.Location = new System.Drawing.Point(364, 28);
			this.TbxFilter.Margin = new System.Windows.Forms.Padding(4);
			this.TbxFilter.Name = "TbxFilter";
			this.TbxFilter.Size = new System.Drawing.Size(199, 26);
			this.TbxFilter.TabIndex = 31;
			this.TbxFilter.Tag = "Numeric";
			this.TbxFilter.TextChanged += new System.EventHandler(this.FilterServices);
			// 
			// BtnNewService
			// 
			this.BtnNewService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnNewService.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnNewService.FlatAppearance.BorderSize = 0;
			this.BtnNewService.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BtnNewService.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BtnNewService.ForeColor = System.Drawing.Color.Black;
			this.BtnNewService.Location = new System.Drawing.Point(51, 527);
			this.BtnNewService.Margin = new System.Windows.Forms.Padding(2);
			this.BtnNewService.Name = "BtnNewService";
			this.BtnNewService.Size = new System.Drawing.Size(89, 32);
			this.BtnNewService.TabIndex = 44;
			this.BtnNewService.Tag = "Lockable";
			this.BtnNewService.Text = "Nuevo";
			this.BtnNewService.UseVisualStyleBackColor = false;
			this.BtnNewService.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// BtnModify
			// 
			this.BtnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnModify.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnModify.Enabled = false;
			this.BtnModify.FlatAppearance.BorderSize = 0;
			this.BtnModify.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BtnModify.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BtnModify.ForeColor = System.Drawing.Color.Black;
			this.BtnModify.Location = new System.Drawing.Point(144, 527);
			this.BtnModify.Margin = new System.Windows.Forms.Padding(2);
			this.BtnModify.Name = "BtnModify";
			this.BtnModify.Size = new System.Drawing.Size(89, 32);
			this.BtnModify.TabIndex = 43;
			this.BtnModify.Tag = "Lockable";
			this.BtnModify.Text = "Modificar";
			this.BtnModify.UseVisualStyleBackColor = false;
			this.BtnModify.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// BxStatus
			// 
			this.BxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
			this.BxStatus.Location = new System.Drawing.Point(451, 338);
			this.BxStatus.Margin = new System.Windows.Forms.Padding(4);
			this.BxStatus.Name = "BxStatus";
			this.BxStatus.Size = new System.Drawing.Size(112, 26);
			this.BxStatus.TabIndex = 39;
			this.BxStatus.SelectedIndexChanged += new System.EventHandler(this.SelectStatus);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnCancel.Enabled = false;
			this.BtnCancel.FlatAppearance.BorderSize = 0;
			this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BtnCancel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BtnCancel.ForeColor = System.Drawing.Color.Black;
			this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnCancel.Location = new System.Drawing.Point(473, 527);
			this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(89, 32);
			this.BtnCancel.TabIndex = 36;
			this.BtnCancel.Tag = "Lockable";
			this.BtnCancel.Text = "Cancelar";
			this.BtnCancel.UseVisualStyleBackColor = false;
			this.BtnCancel.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// BtnAcept
			// 
			this.BtnAcept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnAcept.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnAcept.Enabled = false;
			this.BtnAcept.FlatAppearance.BorderSize = 0;
			this.BtnAcept.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BtnAcept.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BtnAcept.ForeColor = System.Drawing.Color.Black;
			this.BtnAcept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnAcept.Location = new System.Drawing.Point(380, 527);
			this.BtnAcept.Margin = new System.Windows.Forms.Padding(2);
			this.BtnAcept.Name = "BtnAcept";
			this.BtnAcept.Size = new System.Drawing.Size(89, 32);
			this.BtnAcept.TabIndex = 35;
			this.BtnAcept.Tag = "Lockable";
			this.BtnAcept.Text = "Aceptar";
			this.BtnAcept.UseVisualStyleBackColor = false;
			this.BtnAcept.Click += new System.EventHandler(this.ButtonClicked);
			// 
			// LblStatus
			// 
			this.LblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LblStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblStatus.Location = new System.Drawing.Point(365, 338);
			this.LblStatus.Margin = new System.Windows.Forms.Padding(4);
			this.LblStatus.Name = "LblStatus";
			this.LblStatus.Size = new System.Drawing.Size(83, 26);
			this.LblStatus.TabIndex = 28;
			this.LblStatus.Text = "Estado:";
			this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BxServicesDetails
			// 
			this.BxServicesDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BxServicesDetails.Controls.Add(this.BxDiagnosticPage);
			this.BxServicesDetails.Controls.Add(this.BxProblemPage);
			this.BxServicesDetails.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BxServicesDetails.HotTrack = true;
			this.BxServicesDetails.ItemSize = new System.Drawing.Size(115, 27);
			this.BxServicesDetails.Location = new System.Drawing.Point(51, 336);
			this.BxServicesDetails.Margin = new System.Windows.Forms.Padding(4);
			this.BxServicesDetails.Multiline = true;
			this.BxServicesDetails.Name = "BxServicesDetails";
			this.BxServicesDetails.SelectedIndex = 0;
			this.BxServicesDetails.Size = new System.Drawing.Size(512, 181);
			this.BxServicesDetails.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.BxServicesDetails.TabIndex = 46;
			this.BxServicesDetails.SelectedIndexChanged += new System.EventHandler(this.BxServicesDetails_SelectedIndexChanged);
			// 
			// BxDiagnosticPage
			// 
			this.BxDiagnosticPage.BackColor = System.Drawing.Color.Transparent;
			this.BxDiagnosticPage.Controls.Add(this.TbxDiagnostic);
			this.BxDiagnosticPage.Location = new System.Drawing.Point(4, 31);
			this.BxDiagnosticPage.Name = "BxDiagnosticPage";
			this.BxDiagnosticPage.Padding = new System.Windows.Forms.Padding(3);
			this.BxDiagnosticPage.Size = new System.Drawing.Size(504, 146);
			this.BxDiagnosticPage.TabIndex = 0;
			this.BxDiagnosticPage.Text = "Diagnóstico";
			// 
			// TbxDiagnostic
			// 
			this.TbxDiagnostic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbxDiagnostic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TbxDiagnostic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TbxDiagnostic.Location = new System.Drawing.Point(3, 3);
			this.TbxDiagnostic.Multiline = true;
			this.TbxDiagnostic.Name = "TbxDiagnostic";
			this.TbxDiagnostic.ReadOnly = true;
			this.TbxDiagnostic.Size = new System.Drawing.Size(498, 140);
			this.TbxDiagnostic.TabIndex = 0;
			// 
			// BxProblemPage
			// 
			this.BxProblemPage.Controls.Add(this.TbxProblem);
			this.BxProblemPage.Location = new System.Drawing.Point(4, 31);
			this.BxProblemPage.Name = "BxProblemPage";
			this.BxProblemPage.Padding = new System.Windows.Forms.Padding(3);
			this.BxProblemPage.Size = new System.Drawing.Size(504, 146);
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
			this.TbxProblem.ReadOnly = true;
			this.TbxProblem.Size = new System.Drawing.Size(498, 140);
			this.TbxProblem.TabIndex = 1;
			// 
			// WindowServices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(624, 624);
			this.Controls.Add(this.PnlBody);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "WindowServices";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.ShowIcon = false;
			this.Text = "Servicios";
			this.Load += new System.EventHandler(this.WindowLoad);
			this.Controls.SetChildIndex(this.PnlBody, 0);
			this.PnlBody.ResumeLayout(false);
			this.PnlBody.PerformLayout();
			this.PnlForm.ResumeLayout(false);
			this.PnlForm.PerformLayout();
			this.BxServicesDetails.ResumeLayout(false);
			this.BxDiagnosticPage.ResumeLayout(false);
			this.BxDiagnosticPage.PerformLayout();
			this.BxProblemPage.ResumeLayout(false);
			this.BxProblemPage.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private ComboBox comboBox1;
		private ImageList ImgStatus;
		private Panel PnlBody;
		private Button BtnDelete;
		private ListView BxServices;
		private ColumnHeader ListViewStatusColumn;
		private ColumnHeader ListViewFolioColumn;
		private ColumnHeader ListViewNameColumn;
		private ColumnHeader ListViewAdmissionColumn;
		private Label LblFilter;
		private Label LblPeriod;
		private ComboBox comboBox2;
		private Label LblFolio;
		private TextBox TbxFilter;
		private TextBox TbxFolio;
		private Label LblCustomer;
		private TextBox TbxCustomerNumber;
		private Label LblName;
		private TextBox TbxCustomerName;
		private Label LblAdmissionDate;
		private TextBox TbxAdmissionDate;
		private Label LblDeliveryDate;
		private TextBox TbxDeliveryDate;
		private Button BtnNewService;
		private Button BtnModify;
		private ComboBox BxStatus;
		private Button BtnCancel;
		private Button BtnAcept;
		private Label LblStatus;
		private TabControl BxServicesDetails;
		private TabPage BxDiagnosticPage;
		private TextBox TbxDiagnostic;
		private TabPage BxProblemPage;
		private TextBox TbxProblem;
		private Panel PnlForm;
	}
}