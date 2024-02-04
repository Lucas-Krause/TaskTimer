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
            ((System.ComponentModel.ISupportInitialize)dgvBreaks).BeginInit();
            SuspendLayout();
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Location = new Point(12, 9);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(86, 15);
            lblTaskName.TabIndex = 3;
            lblTaskName.Text = "Nome da Task*";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(12, 27);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(343, 23);
            txtTaskName.TabIndex = 2;
            txtTaskName.TextChanged += txtTaskName_TextChanged;
            // 
            // btnRegisterStart
            // 
            btnRegisterStart.Location = new Point(12, 65);
            btnRegisterStart.Name = "btnRegisterStart";
            btnRegisterStart.Size = new Size(120, 23);
            btnRegisterStart.TabIndex = 4;
            btnRegisterStart.Text = "Registrar início";
            btnRegisterStart.UseVisualStyleBackColor = true;
            btnRegisterStart.Click += btnRegisterStart_Click;
            // 
            // btnRegisterStop
            // 
            btnRegisterStop.Location = new Point(12, 94);
            btnRegisterStop.Name = "btnRegisterStop";
            btnRegisterStop.Size = new Size(120, 23);
            btnRegisterStop.TabIndex = 6;
            btnRegisterStop.Text = "Registrar parada";
            btnRegisterStop.UseVisualStyleBackColor = true;
            btnRegisterStop.Click += btnRegisterStop_Click;
            // 
            // tmrCurrentTaskTime
            // 
            tmrCurrentTaskTime.Tick += tmrCurrentTaskTime_Tick;
            // 
            // mktxtStartTime
            // 
            mktxtStartTime.Location = new Point(138, 65);
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
            mktxtStopTime.Location = new Point(138, 94);
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
            mktxtTotalTaskTime.Location = new Point(253, 95);
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
            label2.Location = new Point(208, 65);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 13;
            label2.Text = "Tempo total gasto na task";
            // 
            // btnAddBreak
            // 
            btnAddBreak.Location = new Point(93, 215);
            btnAddBreak.Name = "btnAddBreak";
            btnAddBreak.Size = new Size(120, 23);
            btnAddBreak.TabIndex = 14;
            btnAddBreak.Text = "Adicionar pausa";
            btnAddBreak.UseVisualStyleBackColor = true;
            btnAddBreak.Click += btnAddBreak_Click;
            // 
            // dgvBreaks
            // 
            dgvBreaks.AllowUserToAddRows = false;
            dgvBreaks.AllowUserToDeleteRows = false;
            dgvBreaks.AllowUserToResizeColumns = false;
            dgvBreaks.BackgroundColor = SystemColors.Control;
            dgvBreaks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBreaks.Columns.AddRange(new DataGridViewColumn[] { clmTime, clmStart, clmStop, clmTotal });
            dgvBreaks.Enabled = false;
            dgvBreaks.Location = new Point(361, 27);
            dgvBreaks.MultiSelect = false;
            dgvBreaks.Name = "dgvBreaks";
            dgvBreaks.ReadOnly = true;
            dgvBreaks.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
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
            lblBreaks.Location = new Point(361, 9);
            lblBreaks.Name = "lblBreaks";
            lblBreaks.Size = new Size(43, 15);
            lblBreaks.TabIndex = 17;
            lblBreaks.Text = "Pausas";
            // 
            // btnSaveTask
            // 
            btnSaveTask.Location = new Point(253, 215);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(75, 23);
            btnSaveTask.TabIndex = 19;
            btnSaveTask.Text = "Salvar task";
            btnSaveTask.UseVisualStyleBackColor = true;
            btnSaveTask.Click += btnSaveTask_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(12, 215);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 20;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // TaskTimerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 252);
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
            Name = "TaskTimerForm";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Timer";
            FormClosing += TaskTimerForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvBreaks).EndInit();
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
    }
}