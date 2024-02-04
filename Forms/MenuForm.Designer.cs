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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
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
            ((System.ComponentModel.ISupportInitialize)dgvSavedTaskTimers).BeginInit();
            SuspendLayout();
            // 
            // btnNewTaskTimer
            // 
            btnNewTaskTimer.Location = new Point(12, 12);
            btnNewTaskTimer.Name = "btnNewTaskTimer";
            btnNewTaskTimer.Size = new Size(120, 23);
            btnNewTaskTimer.TabIndex = 0;
            btnNewTaskTimer.Text = "Novo Timer";
            btnNewTaskTimer.UseVisualStyleBackColor = true;
            btnNewTaskTimer.Click += btnNewTaskTimer_Click;
            // 
            // dgvSavedTaskTimers
            // 
            dgvSavedTaskTimers.AllowUserToAddRows = false;
            dgvSavedTaskTimers.AllowUserToDeleteRows = false;
            dgvSavedTaskTimers.AllowUserToResizeColumns = false;
            dgvSavedTaskTimers.AllowUserToResizeRows = false;
            dgvSavedTaskTimers.BackgroundColor = SystemColors.Control;
            dgvSavedTaskTimers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSavedTaskTimers.Columns.AddRange(new DataGridViewColumn[] { clmIdGuid, clmName, clmStart, clmStop, clmNumberOfBreaks, clmTotal });
            dgvSavedTaskTimers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSavedTaskTimers.Location = new Point(143, 12);
            dgvSavedTaskTimers.MultiSelect = false;
            dgvSavedTaskTimers.Name = "dgvSavedTaskTimers";
            dgvSavedTaskTimers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvSavedTaskTimers.ScrollBars = ScrollBars.Vertical;
            dgvSavedTaskTimers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSavedTaskTimers.Size = new Size(692, 211);
            dgvSavedTaskTimers.TabIndex = 17;
            // 
            // clmIdGuid
            // 
            clmIdGuid.HeaderText = "idGuid";
            clmIdGuid.Name = "clmIdGuid";
            clmIdGuid.Visible = false;
            // 
            // clmName
            // 
            clmName.HeaderText = "Task";
            clmName.Name = "clmName";
            clmName.Width = 250;
            // 
            // clmStart
            // 
            clmStart.HeaderText = "Início";
            clmStart.Name = "clmStart";
            // 
            // clmStop
            // 
            clmStop.HeaderText = "Parada";
            clmStop.Name = "clmStop";
            // 
            // clmNumberOfBreaks
            // 
            clmNumberOfBreaks.HeaderText = "Pausas";
            clmNumberOfBreaks.Name = "clmNumberOfBreaks";
            // 
            // clmTotal
            // 
            clmTotal.HeaderText = "Total";
            clmTotal.Name = "clmTotal";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 41);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 23);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 70);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 23);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tmrUpdateDgv
            // 
            tmrUpdateDgv.Tick += tmrUpdateDgv_Tick;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 234);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgvSavedTaskTimers);
            Controls.Add(btnNewTaskTimer);
            Name = "MenuForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Timer Menu";
            ((System.ComponentModel.ISupportInitialize)dgvSavedTaskTimers).EndInit();
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
    }
}
