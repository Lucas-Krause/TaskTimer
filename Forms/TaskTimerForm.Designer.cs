namespace TaskTimer
{
    partial class TaskTimerForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskTimerForm));
            lblTaskName = new Label();
            txtTaskName = new TextBox();
            btnRegisterStart = new Button();
            btnRegisterStop = new Button();
            tmrCurrentTaskTime = new System.Windows.Forms.Timer(components);
            mktxtStartTime = new MaskedTextBox();
            mktxtStopTime = new MaskedTextBox();
            mktxtTotalTaskTime = new MaskedTextBox();
            label2 = new Label();
            btnAddBreak = new Button();
            dgvBreaks = new DataGridView();
            clmTime = new DataGridViewTextBoxColumn();
            clmStart = new DataGridViewTextBoxColumn();
            clmStop = new DataGridViewTextBoxColumn();
            clmTotal = new DataGridViewTextBoxColumn();
            lblBreaks = new Label();
            btnSaveTask = new Button();
            btnMenu = new Button();
            pnlTitleBar = new Panel();
            lblTitle = new Label();
            picAppIcon = new PictureBox();
            btnMinimize = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBreaks).BeginInit();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAppIcon).BeginInit();
            SuspendLayout();
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Location = new Point(11, 35);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(86, 15);
            lblTaskName.TabIndex = 3;
            lblTaskName.Text = "Nome da Task*";
            // 
            // txtTaskName
            // 
            txtTaskName.BackColor = Color.Pink;
            txtTaskName.BorderStyle = BorderStyle.FixedSingle;
            txtTaskName.Location = new Point(11, 53);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(343, 23);
            txtTaskName.TabIndex = 2;
            txtTaskName.TextChanged += txtTaskName_TextChanged;
            // 
            // btnRegisterStart
            // 
            btnRegisterStart.BackColor = Color.FromArgb(250, 221, 240);
            btnRegisterStart.FlatStyle = FlatStyle.Flat;
            btnRegisterStart.Location = new Point(11, 82);
            btnRegisterStart.Name = "btnRegisterStart";
            btnRegisterStart.Size = new Size(120, 25);
            btnRegisterStart.TabIndex = 4;
            btnRegisterStart.Text = "Registrar início";
            btnRegisterStart.UseVisualStyleBackColor = false;
            btnRegisterStart.Click += btnRegisterStart_Click;
            // 
            // btnRegisterStop
            // 
            btnRegisterStop.BackColor = Color.FromArgb(250, 221, 240);
            btnRegisterStop.FlatStyle = FlatStyle.Flat;
            btnRegisterStop.Location = new Point(11, 113);
            btnRegisterStop.Name = "btnRegisterStop";
            btnRegisterStop.Size = new Size(120, 25);
            btnRegisterStop.TabIndex = 6;
            btnRegisterStop.Text = "Registrar parada";
            btnRegisterStop.UseVisualStyleBackColor = false;
            btnRegisterStop.Click += btnRegisterStop_Click;
            // 
            // tmrCurrentTaskTime
            // 
            tmrCurrentTaskTime.Tick += tmrCurrentTaskTime_Tick;
            // 
            // mktxtStartTime
            // 
            mktxtStartTime.BackColor = Color.Pink;
            mktxtStartTime.BorderStyle = BorderStyle.FixedSingle;
            mktxtStartTime.Location = new Point(137, 83);
            mktxtStartTime.Mask = "00:00";
            mktxtStartTime.Name = "mktxtStartTime";
            mktxtStartTime.Size = new Size(53, 23);
            mktxtStartTime.TabIndex = 9;
            mktxtStartTime.TextAlign = HorizontalAlignment.Center;
            mktxtStartTime.ValidatingType = typeof(DateTime);
            mktxtStartTime.TypeValidationCompleted += mktxtStartTime_TypeValidationCompleted;
            // 
            // mktxtStopTime
            // 
            mktxtStopTime.BackColor = Color.Pink;
            mktxtStopTime.BorderStyle = BorderStyle.FixedSingle;
            mktxtStopTime.Location = new Point(137, 115);
            mktxtStopTime.Mask = "00:00";
            mktxtStopTime.Name = "mktxtStopTime";
            mktxtStopTime.Size = new Size(53, 23);
            mktxtStopTime.TabIndex = 10;
            mktxtStopTime.TextAlign = HorizontalAlignment.Center;
            mktxtStopTime.ValidatingType = typeof(DateTime);
            mktxtStopTime.TypeValidationCompleted += mktxtStopTime_TypeValidationCompleted;
            // 
            // mktxtTotalTaskTime
            // 
            mktxtTotalTaskTime.BackColor = Color.Pink;
            mktxtTotalTaskTime.BorderStyle = BorderStyle.FixedSingle;
            mktxtTotalTaskTime.Location = new Point(252, 115);
            mktxtTotalTaskTime.Mask = "00:00";
            mktxtTotalTaskTime.Name = "mktxtTotalTaskTime";
            mktxtTotalTaskTime.ReadOnly = true;
            mktxtTotalTaskTime.Size = new Size(53, 23);
            mktxtTotalTaskTime.TabIndex = 11;
            mktxtTotalTaskTime.TextAlign = HorizontalAlignment.Center;
            mktxtTotalTaskTime.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 91);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 13;
            label2.Text = "Tempo total gasto na task";
            // 
            // btnAddBreak
            // 
            btnAddBreak.BackColor = Color.FromArgb(250, 221, 240);
            btnAddBreak.FlatStyle = FlatStyle.Flat;
            btnAddBreak.Location = new Point(92, 241);
            btnAddBreak.Name = "btnAddBreak";
            btnAddBreak.Size = new Size(120, 25);
            btnAddBreak.TabIndex = 14;
            btnAddBreak.Text = "Adicionar pausa";
            btnAddBreak.UseVisualStyleBackColor = false;
            btnAddBreak.EnabledChanged += btnAddBreak_EnabledChanged;
            btnAddBreak.Click += btnAddBreak_Click;
            // 
            // dgvBreaks
            // 
            dgvBreaks.AllowUserToAddRows = false;
            dgvBreaks.AllowUserToDeleteRows = false;
            dgvBreaks.AllowUserToResizeColumns = false;
            dgvBreaks.BackgroundColor = Color.FromArgb(211, 175, 229);
            dgvBreaks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(186, 164, 197);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(186, 164, 197);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBreaks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBreaks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBreaks.Columns.AddRange(new DataGridViewColumn[] { clmTime, clmStart, clmStop, clmTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBreaks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBreaks.EnableHeadersVisualStyles = false;
            dgvBreaks.GridColor = Color.Black;
            dgvBreaks.Location = new Point(360, 53);
            dgvBreaks.MultiSelect = false;
            dgvBreaks.Name = "dgvBreaks";
            dgvBreaks.ReadOnly = true;
            dgvBreaks.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(186, 164, 197);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBreaks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBreaks.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(211, 175, 229);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(211, 175, 229);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dgvBreaks.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvBreaks.ScrollBars = ScrollBars.Vertical;
            dgvBreaks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBreaks.Size = new Size(443, 211);
            dgvBreaks.TabIndex = 16;
            // 
            // clmTime
            // 
            clmTime.HeaderText = "Horário ";
            clmTime.Name = "clmTime";
            clmTime.ReadOnly = true;
            clmTime.Resizable = DataGridViewTriState.False;
            // 
            // clmStart
            // 
            clmStart.HeaderText = "Início";
            clmStart.Name = "clmStart";
            clmStart.ReadOnly = true;
            // 
            // clmStop
            // 
            clmStop.HeaderText = "Parada";
            clmStop.Name = "clmStop";
            clmStop.ReadOnly = true;
            // 
            // clmTotal
            // 
            clmTotal.HeaderText = "Total";
            clmTotal.Name = "clmTotal";
            clmTotal.ReadOnly = true;
            // 
            // lblBreaks
            // 
            lblBreaks.AutoSize = true;
            lblBreaks.Location = new Point(360, 35);
            lblBreaks.Name = "lblBreaks";
            lblBreaks.Size = new Size(43, 15);
            lblBreaks.TabIndex = 17;
            lblBreaks.Text = "Pausas";
            // 
            // btnSaveTask
            // 
            btnSaveTask.BackColor = Color.FromArgb(250, 221, 240);
            btnSaveTask.FlatStyle = FlatStyle.Flat;
            btnSaveTask.Location = new Point(243, 241);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(75, 25);
            btnSaveTask.TabIndex = 19;
            btnSaveTask.Text = "Salvar task";
            btnSaveTask.UseVisualStyleBackColor = false;
            btnSaveTask.Click += btnSaveTask_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(250, 221, 240);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Location = new Point(11, 241);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 25);
            btnMenu.TabIndex = 20;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.Pink;
            pnlTitleBar.Controls.Add(lblTitle);
            pnlTitleBar.Controls.Add(picAppIcon);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.ForeColor = Color.LawnGreen;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Margin = new Padding(10, 10, 100, 10);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(815, 26);
            pnlTitleBar.TabIndex = 21;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = SystemColors.WindowText;
            lblTitle.ImeMode = ImeMode.NoControl;
            lblTitle.Location = new Point(52, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(62, 15);
            lblTitle.TabIndex = 22;
            lblTitle.Text = "Task Timer";
            // 
            // picAppIcon
            // 
            picAppIcon.BackgroundImage = Properties.Resources.icons8_timer_50;
            picAppIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picAppIcon.Dock = DockStyle.Left;
            picAppIcon.ImeMode = ImeMode.NoControl;
            picAppIcon.InitialImage = Properties.Resources.icons8_timer_50;
            picAppIcon.Location = new Point(0, 0);
            picAppIcon.Name = "picAppIcon";
            picAppIcon.Size = new Size(46, 26);
            picAppIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picAppIcon.TabIndex = 21;
            picAppIcon.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Pink;
            btnMinimize.BackgroundImage = Properties.Resources.icons8_minimize_48;
            btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.Pink;
            btnMinimize.ImeMode = ImeMode.NoControl;
            btnMinimize.Location = new Point(735, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 26);
            btnMinimize.TabIndex = 21;
            btnMinimize.TabStop = false;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Pink;
            btnClose.BackgroundImage = Properties.Resources.icons8_close_48;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnClose.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Pink;
            btnClose.ImeMode = ImeMode.NoControl;
            btnClose.Location = new Point(775, 0);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(100);
            btnClose.Size = new Size(40, 26);
            btnClose.TabIndex = 21;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // TaskTimerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 203, 226);
            ClientSize = new Size(815, 278);
            Controls.Add(pnlTitleBar);
            Controls.Add(btnMenu);
            Controls.Add(btnSaveTask);
            Controls.Add(lblBreaks);
            Controls.Add(dgvBreaks);
            Controls.Add(btnAddBreak);
            Controls.Add(label2);
            Controls.Add(mktxtTotalTaskTime);
            Controls.Add(mktxtStopTime);
            Controls.Add(mktxtStartTime);
            Controls.Add(btnRegisterStop);
            Controls.Add(btnRegisterStart);
            Controls.Add(lblTaskName);
            Controls.Add(txtTaskName);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TaskTimerForm";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Timer";
            FormClosing += TaskTimerForm_FormClosing;
            Load += TaskTimerForm_Load;
            Paint += TaskTimerForm_Paint;
            ((System.ComponentModel.ISupportInitialize)dgvBreaks).EndInit();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAppIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTaskName;
        private TextBox txtTaskName;
        private Button btnRegisterStart;
        private Button btnRegisterStop;
        private System.Windows.Forms.Timer tmrCurrentTaskTime;
        private MaskedTextBox mktxtStartTime;
        private MaskedTextBox mktxtStopTime;
        private MaskedTextBox mktxtTotalTaskTime;
        private Label label2;
        private Button btnAddBreak;
        private DataGridView dgvBreaks;
        private DataGridViewTextBoxColumn clmTime;
        private DataGridViewTextBoxColumn clmStart;
        private DataGridViewTextBoxColumn clmStop;
        private DataGridViewTextBoxColumn clmTotal;
        private Label lblBreaks;
        private Button btnSaveTask;
        private Button btnMenu;
        private Panel pnlTitleBar;
        private Label lblTitle;
        private PictureBox picAppIcon;
        private Button btnMinimize;
        private Button btnClose;
    }
}