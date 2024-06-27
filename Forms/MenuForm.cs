using System.Runtime.InteropServices;
using System.Text.Json;
using TaskTimer.Models;

namespace TaskTimer
{
    public partial class MenuForm : Form
    {
        #region [ Properties and Methods to move the window ] 

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region [ Fields and Properties ]

        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SavedTaskTimers.json");
        private List<TaskTimerDto> savedTaskTimers;
        public int numberOfSavedTasks = 0;

        #endregion

        #region [ Initialization ]

        public MenuForm()
        {
            savedTaskTimers = new List<TaskTimerDto>();
            Icon = new Icon(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/TimerIcon.ico"));
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            tmrUpdateDgv.Start();
            LoadSavedTasks();
            ActiveControl = null;
        }

        #endregion

        #region [ Data Operations ] 

        public void LoadSavedTasks()
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);

                savedTaskTimers = JsonSerializer.Deserialize<List<TaskTimerDto>>(jsonData) ?? new List<TaskTimerDto>();
            }
        }

        private void SaveDataToFile()
        {
            var taskTimerJson = JsonSerializer.Serialize(savedTaskTimers);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(taskTimerJson);
            }
        }

        #endregion

        #region [ UI Operations ] 

        public void PopulateDataGridView()
        {
            if (savedTaskTimers.Count > 0 && (numberOfSavedTasks != savedTaskTimers.Count))
            {
                numberOfSavedTasks = savedTaskTimers.Count;

                dgvSavedTaskTimers.Rows.Clear();

                foreach (var taskTimer in savedTaskTimers)
                {
                    dgvSavedTaskTimers.Rows.Add(taskTimer.idGuid, taskTimer.Name, taskTimer.StartTime, taskTimer.StopTime, taskTimer.Breaks.Count, taskTimer.TotalTime);
                }

                dgvSavedTaskTimers.ClearSelection();
            }
        }

        private void RemoveSelectedRowsFromDataGrid()
        {
            foreach (DataGridViewRow row in dgvSavedTaskTimers.SelectedRows)
            {
                if (row.Cells["clmIdGuid"].Value != null)
                {
                    savedTaskTimers.RemoveAll(timer => timer.idGuid == row.Cells["clmIdGuid"].Value.ToString());
                    dgvSavedTaskTimers.Rows.Remove(row);
                }
            }
        }

        private void EnableOrDisableDeleteButton()
        {
            btnDelete.Enabled = dgvSavedTaskTimers != null && dgvSavedTaskTimers.SelectedRows.Count > 0;
        }

        private void EnableOrDisableEditButton()
        {
            btnEdit.Enabled = dgvSavedTaskTimers != null && dgvSavedTaskTimers.SelectedRows.Count > 0;
        }

        private void EditRow(DataGridViewRow row)
        {
            TaskTimerForm taskTimerForm = new(savedTaskTimers, row.Cells["clmIdGuid"].Value.ToString());
            taskTimerForm.Owner = this;
            taskTimerForm.Show();
            Hide();
        }

        #endregion

        #region [ Event Handlers ] 

        private void tmrUpdateDgv_Tick(object sender, EventArgs e)
        {
            PopulateDataGridView();
            EnableOrDisableDeleteButton();
            EnableOrDisableEditButton();
        }

        private void btnNewTaskTimer_Click(object sender, EventArgs e)
        {
            TaskTimerForm taskTimerForm = new(savedTaskTimers);
            taskTimerForm.Owner = this;
            taskTimerForm.Show();
            Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RemoveSelectedRowsFromDataGrid();
            SaveDataToFile();

            MessageBox.Show("Task deletada com sucesso!", "Task deletada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSavedTaskTimers.SelectedRows)
            {
                EditRow(row);
            }
        }

        private void dgvSavedTaskTimers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = dgvSavedTaskTimers.Rows[e.RowIndex];

            EditRow(row);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnEdit_EnabledChanged(object sender, EventArgs e)
        {
            btnEdit.BackColor = btnEdit.Enabled ? Color.FromArgb(250, 221, 240) : Color.Pink;
        }

        private void btnDelete_EnabledChanged(object sender, EventArgs e)
        {
            btnDelete.BackColor = btnDelete.Enabled ? Color.FromArgb(253, 143, 182) : Color.Pink;
        }

        private void MenuForm_Paint(object sender, PaintEventArgs e)
        {
            // Draw a custom border outside the Panel boundaries
            int borderWidth = 3;  // Adjust the width of the border
            using (Pen borderPen = new Pen(Color.Pink, borderWidth))
            {
                // Draw the rectangle just outside the Panel boundaries
                e.Graphics.DrawRectangle(borderPen, new Rectangle(
                    pnlTitleBar.Location.X - borderWidth,
                    pnlTitleBar.Location.Y - borderWidth - 2,
                    pnlTitleBar.Width + borderWidth * 2,
                    pnlTitleBar.Height + borderWidth * 2));
            }
        }

        //Event to make it able to move the window when clicking the title bar
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion
    }
}
