namespace BioMetrixCore
{
    partial class Master
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            this.tbxDeviceIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnPingDevice = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMachineNumber = new System.Windows.Forms.TextBox();
            this.btnBeep = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.btnGetAllLogData = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnDeviceTime = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnView = new System.Windows.Forms.Button();
            this.btnGetAllUserID = new System.Windows.Forms.Button();
            this.btnUploadUserInfo = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnSaveToText = new System.Windows.Forms.Button();
            this.btnGetLastData = new System.Windows.Forms.Button();
            this.btnSaveTodayLog = new System.Windows.Forms.Button();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.btnGetLast = new System.Windows.Forms.Button();
            this.btnCountRecords = new System.Windows.Forms.Button();
            this.send_json_data = new System.Windows.Forms.Button();
            this.tmrReload = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblDeviceInfo = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxDeviceIP
            // 
            this.tbxDeviceIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDeviceIP.Location = new System.Drawing.Point(311, 9);
            this.tbxDeviceIP.Name = "tbxDeviceIP";
            this.tbxDeviceIP.Size = new System.Drawing.Size(99, 22);
            this.tbxDeviceIP.TabIndex = 0;
            this.tbxDeviceIP.Text = "192.168.1.201";
            this.tbxDeviceIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(251, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Device IP";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(415, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port No.";
            // 
            // tbxPort
            // 
            this.tbxPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPort.Location = new System.Drawing.Point(466, 9);
            this.tbxPort.MaxLength = 6;
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(56, 22);
            this.tbxPort.TabIndex = 2;
            this.tbxPort.Text = "4370";
            this.tbxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPort.TextChanged += new System.EventHandler(this.tbxPort_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(185)))));
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(672, 6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(95, 28);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnPingDevice
            // 
            this.btnPingDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPingDevice.BackColor = System.Drawing.Color.Transparent;
            this.btnPingDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPingDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPingDevice.FlatAppearance.BorderSize = 0;
            this.btnPingDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(185)))));
            this.btnPingDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnPingDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPingDevice.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPingDevice.ForeColor = System.Drawing.Color.White;
            this.btnPingDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnPingDevice.Image")));
            this.btnPingDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPingDevice.Location = new System.Drawing.Point(773, 6);
            this.btnPingDevice.Name = "btnPingDevice";
            this.btnPingDevice.Size = new System.Drawing.Size(75, 29);
            this.btnPingDevice.TabIndex = 5;
            this.btnPingDevice.Text = "Ping";
            this.btnPingDevice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPingDevice.UseVisualStyleBackColor = false;
            this.btnPingDevice.Click += new System.EventHandler(this.btnPingDevice_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(0, 625);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblStatus.Size = new System.Drawing.Size(862, 25);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "label3";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(528, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Machine Number";
            // 
            // tbxMachineNumber
            // 
            this.tbxMachineNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMachineNumber.Location = new System.Drawing.Point(629, 9);
            this.tbxMachineNumber.MaxLength = 3;
            this.tbxMachineNumber.Name = "tbxMachineNumber";
            this.tbxMachineNumber.Size = new System.Drawing.Size(37, 22);
            this.tbxMachineNumber.TabIndex = 8;
            this.tbxMachineNumber.Text = "1";
            this.tbxMachineNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxMachineNumber.TextChanged += new System.EventHandler(this.tbxMachineNumber_TextChanged);
            // 
            // btnBeep
            // 
            this.btnBeep.BackColor = System.Drawing.SystemColors.Control;
            this.btnBeep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeep.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBeep.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBeep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBeep.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeep.Location = new System.Drawing.Point(602, 64);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(59, 48);
            this.btnBeep.TabIndex = 5;
            this.btnBeep.Text = "Beep";
            this.btnBeep.UseVisualStyleBackColor = false;
            this.btnBeep.Visible = false;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.tbxDeviceIP);
            this.pnlHeader.Controls.Add(this.tbxPort);
            this.pnlHeader.Controls.Add(this.btnPingDevice);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.btnConnect);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.tbxMachineNumber);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(862, 42);
            this.pnlHeader.TabIndex = 712;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(75, 19);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "ZKTECO";
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToDeleteRows = false;
            this.dgvRecords.AllowUserToOrderColumns = true;
            this.dgvRecords.AllowUserToResizeColumns = false;
            this.dgvRecords.AllowUserToResizeRows = false;
            this.dgvRecords.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecords.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvRecords.Location = new System.Drawing.Point(0, 176);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.Size = new System.Drawing.Size(837, 380);
            this.dgvRecords.TabIndex = 883;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dgvRecords);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 556);
            this.panel1.TabIndex = 891;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.btnGetAllUserID);
            this.flowLayoutPanel1.Controls.Add(this.btnUploadUserInfo);
            this.flowLayoutPanel1.Controls.Add(this.btnBeep);
            this.flowLayoutPanel1.Controls.Add(this.btnPost);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveToText);
            this.flowLayoutPanel1.Controls.Add(this.btnGetLastData);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveTodayLog);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveToDB);
            this.flowLayoutPanel1.Controls.Add(this.btnGetLast);
            this.flowLayoutPanel1.Controls.Add(this.btnCountRecords);
            this.flowLayoutPanel1.Controls.Add(this.send_json_data);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(837, 176);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Controls.Add(this.btnUserInfo);
            this.flowLayoutPanel3.Controls.Add(this.btnGetAllLogData);
            this.flowLayoutPanel3.Controls.Add(this.btnToday);
            this.flowLayoutPanel3.Controls.Add(this.btnDeviceTime);
            this.flowLayoutPanel3.Controls.Add(this.btnExport);
            this.flowLayoutPanel3.Controls.Add(this.btnRestart);
            this.flowLayoutPanel3.Controls.Add(this.btnOff);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 8);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(831, 50);
            this.flowLayoutPanel3.TabIndex = 921;
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnUserInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUserInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUserInfo.FlatAppearance.BorderSize = 0;
            this.btnUserInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnUserInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(185)))));
            this.btnUserInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnUserInfo.Image")));
            this.btnUserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserInfo.Location = new System.Drawing.Point(10, 5);
            this.btnUserInfo.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(137, 37);
            this.btnUserInfo.TabIndex = 918;
            this.btnUserInfo.Text = "USER INFO   ";
            this.btnUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserInfo.UseVisualStyleBackColor = false;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // btnGetAllLogData
            // 
            this.btnGetAllLogData.BackColor = System.Drawing.Color.Transparent;
            this.btnGetAllLogData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGetAllLogData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetAllLogData.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGetAllLogData.FlatAppearance.BorderSize = 0;
            this.btnGetAllLogData.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnGetAllLogData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(185)))));
            this.btnGetAllLogData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnGetAllLogData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAllLogData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAllLogData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGetAllLogData.Image = ((System.Drawing.Image)(resources.GetObject("btnGetAllLogData.Image")));
            this.btnGetAllLogData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetAllLogData.Location = new System.Drawing.Point(153, 5);
            this.btnGetAllLogData.Name = "btnGetAllLogData";
            this.btnGetAllLogData.Size = new System.Drawing.Size(84, 37);
            this.btnGetAllLogData.TabIndex = 917;
            this.btnGetAllLogData.Text = "ALL   ";
            this.btnGetAllLogData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetAllLogData.UseVisualStyleBackColor = false;
            this.btnGetAllLogData.Click += new System.EventHandler(this.btnGetAllLogData_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.Transparent;
            this.btnToday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnToday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(185)))));
            this.btnToday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnToday.Image = ((System.Drawing.Image)(resources.GetObject("btnToday.Image")));
            this.btnToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToday.Location = new System.Drawing.Point(243, 5);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(103, 37);
            this.btnToday.TabIndex = 916;
            this.btnToday.Text = "TODAY   ";
            this.btnToday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click_1);
            // 
            // btnDeviceTime
            // 
            this.btnDeviceTime.BackColor = System.Drawing.Color.Transparent;
            this.btnDeviceTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeviceTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeviceTime.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeviceTime.FlatAppearance.BorderSize = 0;
            this.btnDeviceTime.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDeviceTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(185)))));
            this.btnDeviceTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnDeviceTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeviceTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeviceTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeviceTime.Image = ((System.Drawing.Image)(resources.GetObject("btnDeviceTime.Image")));
            this.btnDeviceTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeviceTime.Location = new System.Drawing.Point(352, 5);
            this.btnDeviceTime.Name = "btnDeviceTime";
            this.btnDeviceTime.Size = new System.Drawing.Size(143, 37);
            this.btnDeviceTime.TabIndex = 915;
            this.btnDeviceTime.Text = "DEVICE TIME   ";
            this.btnDeviceTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeviceTime.UseVisualStyleBackColor = false;
            this.btnDeviceTime.Click += new System.EventHandler(this.btnDeviceTime_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(185)))));
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(501, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(109, 37);
            this.btnExport.TabIndex = 912;
            this.btnExport.Text = "EXPORT   ";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(185)))));
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRestart.Image = ((System.Drawing.Image)(resources.GetObject("btnRestart.Image")));
            this.btnRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestart.Location = new System.Drawing.Point(616, 5);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(113, 37);
            this.btnRestart.TabIndex = 913;
            this.btnRestart.Text = "RESTART   ";
            this.btnRestart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.Transparent;
            this.btnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOff.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOff.FlatAppearance.BorderSize = 0;
            this.btnOff.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(185)))));
            this.btnOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOff.Image = ((System.Drawing.Image)(resources.GetObject("btnOff.Image")));
            this.btnOff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOff.Location = new System.Drawing.Point(735, 5);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(71, 37);
            this.btnOff.TabIndex = 914;
            this.btnOff.Text = "OFF";
            this.btnOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Controls.Add(this.lblFrom);
            this.flowLayoutPanel2.Controls.Add(this.dtpFrom);
            this.flowLayoutPanel2.Controls.Add(this.lblTo);
            this.flowLayoutPanel2.Controls.Add(this.dtpTo);
            this.flowLayoutPanel2.Controls.Add(this.btnView);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 64);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(444, 50);
            this.flowLayoutPanel2.TabIndex = 920;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(3, 5);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblFrom.Size = new System.Drawing.Size(48, 42);
            this.lblFrom.TabIndex = 884;
            this.lblFrom.Text = "FROM";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(57, 8);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(124, 29);
            this.dtpFrom.TabIndex = 899;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(187, 5);
            this.lblTo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblTo.Size = new System.Drawing.Size(26, 42);
            this.lblTo.TabIndex = 901;
            this.lblTo.Text = "TO";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(219, 8);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(124, 29);
            this.dtpTo.TabIndex = 900;
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(185)))));
            this.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(349, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(88, 41);
            this.btnView.TabIndex = 919;
            this.btnView.Text = "SHOW";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetAllUserID
            // 
            this.btnGetAllUserID.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetAllUserID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetAllUserID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGetAllUserID.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnGetAllUserID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGetAllUserID.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGetAllUserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAllUserID.Location = new System.Drawing.Point(453, 64);
            this.btnGetAllUserID.Name = "btnGetAllUserID";
            this.btnGetAllUserID.Size = new System.Drawing.Size(72, 48);
            this.btnGetAllUserID.TabIndex = 892;
            this.btnGetAllUserID.Text = "Get All User ID";
            this.btnGetAllUserID.UseVisualStyleBackColor = false;
            this.btnGetAllUserID.Visible = false;
            this.btnGetAllUserID.Click += new System.EventHandler(this.btnGetAllUserID_Click);
            // 
            // btnUploadUserInfo
            // 
            this.btnUploadUserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnUploadUserInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadUserInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUploadUserInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnUploadUserInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUploadUserInfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUploadUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadUserInfo.Location = new System.Drawing.Point(531, 64);
            this.btnUploadUserInfo.Name = "btnUploadUserInfo";
            this.btnUploadUserInfo.Size = new System.Drawing.Size(65, 48);
            this.btnUploadUserInfo.TabIndex = 893;
            this.btnUploadUserInfo.Text = "Upload Userinfo";
            this.btnUploadUserInfo.UseVisualStyleBackColor = false;
            this.btnUploadUserInfo.Visible = false;
            this.btnUploadUserInfo.Click += new System.EventHandler(this.btnUploadUserInfo_Click);
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.SystemColors.Control;
            this.btnPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPost.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPost.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPost.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(667, 64);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(71, 48);
            this.btnPost.TabIndex = 898;
            this.btnPost.Text = "Upload";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Visible = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnSaveToText
            // 
            this.btnSaveToText.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveToText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveToText.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveToText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveToText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSaveToText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveToText.Location = new System.Drawing.Point(744, 64);
            this.btnSaveToText.Name = "btnSaveToText";
            this.btnSaveToText.Size = new System.Drawing.Size(89, 48);
            this.btnSaveToText.TabIndex = 902;
            this.btnSaveToText.Text = "Export Last In/Out";
            this.btnSaveToText.UseVisualStyleBackColor = false;
            this.btnSaveToText.Visible = false;
            this.btnSaveToText.Click += new System.EventHandler(this.btnSaveToText_Click);
            // 
            // btnGetLastData
            // 
            this.btnGetLastData.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetLastData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetLastData.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGetLastData.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnGetLastData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGetLastData.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGetLastData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetLastData.Location = new System.Drawing.Point(3, 120);
            this.btnGetLastData.Name = "btnGetLastData";
            this.btnGetLastData.Size = new System.Drawing.Size(65, 48);
            this.btnGetLastData.TabIndex = 922;
            this.btnGetLastData.Text = "Get Last In/Out";
            this.btnGetLastData.UseVisualStyleBackColor = false;
            this.btnGetLastData.Visible = false;
            this.btnGetLastData.Click += new System.EventHandler(this.btnGetLastData_Click);
            // 
            // btnSaveTodayLog
            // 
            this.btnSaveTodayLog.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveTodayLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveTodayLog.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveTodayLog.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSaveTodayLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSaveTodayLog.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveTodayLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTodayLog.Location = new System.Drawing.Point(74, 120);
            this.btnSaveTodayLog.Name = "btnSaveTodayLog";
            this.btnSaveTodayLog.Size = new System.Drawing.Size(105, 48);
            this.btnSaveTodayLog.TabIndex = 924;
            this.btnSaveTodayLog.Text = "Save Today\'s Log to Database";
            this.btnSaveTodayLog.UseVisualStyleBackColor = false;
            this.btnSaveTodayLog.Visible = false;
            this.btnSaveTodayLog.Click += new System.EventHandler(this.btnSaveTodayLog_Click);
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveToDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveToDB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveToDB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSaveToDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSaveToDB.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveToDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveToDB.Location = new System.Drawing.Point(185, 120);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(66, 48);
            this.btnSaveToDB.TabIndex = 923;
            this.btnSaveToDB.Text = "Sync";
            this.btnSaveToDB.UseVisualStyleBackColor = false;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // btnGetLast
            // 
            this.btnGetLast.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetLast.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGetLast.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnGetLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGetLast.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGetLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetLast.Location = new System.Drawing.Point(257, 120);
            this.btnGetLast.Name = "btnGetLast";
            this.btnGetLast.Size = new System.Drawing.Size(91, 48);
            this.btnGetLast.TabIndex = 925;
            this.btnGetLast.Text = "Get Last Synced";
            this.btnGetLast.UseVisualStyleBackColor = false;
            this.btnGetLast.Click += new System.EventHandler(this.btnGetLast_Click);
            // 
            // btnCountRecords
            // 
            this.btnCountRecords.BackColor = System.Drawing.SystemColors.Control;
            this.btnCountRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCountRecords.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCountRecords.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCountRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCountRecords.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCountRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountRecords.Location = new System.Drawing.Point(354, 120);
            this.btnCountRecords.Name = "btnCountRecords";
            this.btnCountRecords.Size = new System.Drawing.Size(98, 48);
            this.btnCountRecords.TabIndex = 926;
            this.btnCountRecords.Text = "Show Logs to be Synced";
            this.btnCountRecords.UseVisualStyleBackColor = false;
            this.btnCountRecords.Click += new System.EventHandler(this.btnCountRecords_Click);
            // 
            // send_json_data
            // 
            this.send_json_data.BackColor = System.Drawing.SystemColors.Control;
            this.send_json_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_json_data.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.send_json_data.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.send_json_data.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.send_json_data.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.send_json_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_json_data.Location = new System.Drawing.Point(458, 120);
            this.send_json_data.Name = "send_json_data";
            this.send_json_data.Size = new System.Drawing.Size(92, 48);
            this.send_json_data.TabIndex = 927;
            this.send_json_data.Text = "Send Data";
            this.send_json_data.UseVisualStyleBackColor = false;
            this.send_json_data.Click += new System.EventHandler(this.send_json_data_Click);
            // 
            // tmrReload
            // 
            this.tmrReload.Tick += new System.EventHandler(this.tmrReload_Tick);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // lblDeviceInfo
            // 
            this.lblDeviceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeviceInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviceInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeviceInfo.Location = new System.Drawing.Point(11, 47);
            this.lblDeviceInfo.Name = "lblDeviceInfo";
            this.lblDeviceInfo.Size = new System.Drawing.Size(839, 19);
            this.lblDeviceInfo.TabIndex = 892;
            this.lblDeviceInfo.Text = "Device Info : --";
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 650);
            this.Controls.Add(this.lblDeviceInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblStatus);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(615, 425);
            this.Name = "Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biometric System";
            this.Load += new System.EventHandler(this.Master_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDeviceIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnPingDevice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.Panel pnlHeader;
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGetAllUserID;
        private System.Windows.Forms.Button btnUploadUserInfo;
        private System.Windows.Forms.Timer tmrReload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnSaveToText;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnDeviceTime;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnGetAllLogData;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblDeviceInfo;
        private System.Windows.Forms.Button btnGetLastData;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.Button btnSaveTodayLog;
        public System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Button btnGetLast;
        private System.Windows.Forms.Button btnCountRecords;
        private System.Windows.Forms.Button send_json_data;
        public System.Windows.Forms.TextBox tbxMachineNumber;
    }
}

