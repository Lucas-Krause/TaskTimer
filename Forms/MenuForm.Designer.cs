namespace TaskTimer
{
    partial class MenuForm
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

        #region Windows Form Designer generated code ChatGPT

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnNewTaskTimer = new Button();
            dgvSavedTaskTimers = new DataGridView();
            clmIdGuid = new DataGridViewTextBoxColumn();
            clmName = new DataGridViewTextBoxColumn();
            clmStart = new DataGridViewTextBoxColumn();
            clmStop = new DataGridViewTextBoxColumn();
            clmNumberOfBreaks = new DataGridViewTextBoxColumn();
            clmTotal = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btnDelete = new Button();
            tmrUpdateDgv = new System.Windows.Forms.Timer(components);
            pnlTitleBar = new Panel();
            lblTitle = new Label();
            picAppIcon = new PictureBox();
            btnMinimize = new Button();
            btnClose = new Button();
            ntiTimerIcon = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)dgvSavedTaskTimers).BeginInit();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAppIcon).BeginInit();
            SuspendLayout();
            // 
            // btnNewTaskTimer
            // 
            btnNewTaskTimer.BackColor = Color.FromArgb(250, 221, 240);
            resources.ApplyResources(btnNewTaskTimer, "btnNewTaskTimer");
            btnNewTaskTimer.Name = "btnNewTaskTimer";
            btnNewTaskTimer.UseVisualStyleBackColor = false;
            btnNewTaskTimer.Click += btnNewTaskTimer_Click;
            // 
            // dgvSavedTaskTimers
            // 
            dgvSavedTaskTimers.AllowUserToAddRows = false;
            dgvSavedTaskTimers.AllowUserToDeleteRows = false;
            dgvSavedTaskTimers.AllowUserToResizeColumns = false;
            dgvSavedTaskTimers.AllowUserToResizeRows = false;
            dgvSavedTaskTimers.BackgroundColor = Color.FromArgb(211, 175, 229);
            dgvSavedTaskTimers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(186, 164, 197);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(186, 164, 197);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSavedTaskTimers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSavedTaskTimers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSavedTaskTimers.Columns.AddRange(new DataGridViewColumn[] { clmIdGuid, clmName, clmStart, clmStop, clmNumberOfBreaks, clmTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSavedTaskTimers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSavedTaskTimers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSavedTaskTimers.EnableHeadersVisualStyles = false;
            dgvSavedTaskTimers.GridColor = Color.Black;
            resources.ApplyResources(dgvSavedTaskTimers, "dgvSavedTaskTimers");
            dgvSavedTaskTimers.MultiSelect = false;
            dgvSavedTaskTimers.Name = "dgvSavedTaskTimers";
            dgvSavedTaskTimers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(186, 164, 197);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LavenderBlush;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSavedTaskTimers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSavedTaskTimers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(211, 175, 229);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(211, 175, 229);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dgvSavedTaskTimers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvSavedTaskTimers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSavedTaskTimers.CellMouseDoubleClick += dgvSavedTaskTimers_CellMouseDoubleClick;
            // 
            // clmIdGuid
            // 
            resources.ApplyResources(clmIdGuid, "clmIdGuid");
            clmIdGuid.Name = "clmIdGuid";
            // 
            // clmName
            // 
            resources.ApplyResources(clmName, "clmName");
            clmName.Name = "clmName";
            // 
            // clmStart
            // 
            resources.ApplyResources(clmStart, "clmStart");
            clmStart.Name = "clmStart";
            // 
            // clmStop
            // 
            resources.ApplyResources(clmStop, "clmStop");
            clmStop.Name = "clmStop";
            // 
            // clmNumberOfBreaks
            // 
            resources.ApplyResources(clmNumberOfBreaks, "clmNumberOfBreaks");
            clmNumberOfBreaks.Name = "clmNumberOfBreaks";
            // 
            // clmTotal
            // 
            resources.ApplyResources(clmTotal, "clmTotal");
            clmTotal.Name = "clmTotal";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(250, 221, 240);
            resources.ApplyResources(btnEdit, "btnEdit");
            btnEdit.Name = "btnEdit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.EnabledChanged += btnEdit_EnabledChanged;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(253, 143, 182);
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.Name = "btnDelete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.EnabledChanged += btnDelete_EnabledChanged;
            btnDelete.Click += btnDelete_Click;
            // 
            // tmrUpdateDgv
            // 
            tmrUpdateDgv.Tick += tmrUpdateDgv_Tick;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.Pink;
            pnlTitleBar.Controls.Add(lblTitle);
            pnlTitleBar.Controls.Add(picAppIcon);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnClose);
            resources.ApplyResources(pnlTitleBar, "pnlTitleBar");
            pnlTitleBar.ForeColor = Color.LawnGreen;
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.ForeColor = SystemColors.WindowText;
            lblTitle.Name = "lblTitle";
            // 
            // picAppIcon
            // 
            picAppIcon.BackgroundImage = Properties.Resources.icons8_timer_50;
            resources.ApplyResources(picAppIcon, "picAppIcon");
            picAppIcon.InitialImage = Properties.Resources.icons8_timer_50;
            picAppIcon.Name = "picAppIcon";
            picAppIcon.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Pink;
            btnMinimize.BackgroundImage = Properties.Resources.icons8_minimize_48;
            resources.ApplyResources(btnMinimize, "btnMinimize");
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnMinimize.ForeColor = Color.Pink;
            btnMinimize.Name = "btnMinimize";
            btnMinimize.TabStop = false;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Pink;
            btnClose.BackgroundImage = Properties.Resources.icons8_close_48;
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnClose.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnClose.ForeColor = Color.Pink;
            btnClose.Name = "btnClose";
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ntiTimerIcon
            // 
            resources.ApplyResources(ntiTimerIcon, "ntiTimerIcon");
            // 
            // MenuForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 203, 226);
            Controls.Add(pnlTitleBar);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvSavedTaskTimers);
            Controls.Add(btnNewTaskTimer);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "MenuForm";
            ShowIcon = false;
            Paint += MenuForm_Paint;
            ((System.ComponentModel.ISupportInitialize)dgvSavedTaskTimers).EndInit();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAppIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewTaskTimer;
        private DataGridView dgvSavedTaskTimers;
        private Button btnEdit;
        private Button btnDelete;
        private System.Windows.Forms.Timer tmrUpdateDgv;
        private DataGridViewTextBoxColumn clmIdGuid;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmStart;
        private DataGridViewTextBoxColumn clmStop;
        private DataGridViewTextBoxColumn clmNumberOfBreaks;
        private DataGridViewTextBoxColumn clmTotal;
        private Panel pnlTitleBar;
        private Button btnMinimize;
        private Button btnClose;
        private PictureBox picAppIcon;
        private NotifyIcon ntiTimerIcon;
        private Label lblTitle;
    }
}
