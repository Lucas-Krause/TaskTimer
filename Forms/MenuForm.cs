using System.Text.Json;
using TaskTimer.Models;

namespace TaskTimer
{
    public partial class MenuForm : Form
    {
        #region Fields and Properties

        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SavedTaskTimers.json");
        private List<TaskTimerDto> savedTaskTimers;
        public int numberOfSavedTasks = 0;

        #endregion

        #region Initialization

        public MenuForm()
        {
            savedTaskTimers = new List<TaskTimerDto>();
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            tmrUpdateDgv.Start();
            LoadSavedTasks();
        }

        #endregion

        #region Data Operations

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

        #region UI Operations

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

        #endregion

        #region Event Handlers

        private void btnNewTaskTimer_Click(object sender, EventArgs e)
        {
            TaskTimerForm taskTimerForm = new(savedTaskTimers);
            taskTimerForm.Owner = this;
            taskTimerForm.Show();
            Hide();
        }

        private void tmrUpdateDgv_Tick(object sender, EventArgs e)
        {
            PopulateDataGridView();
            EnableOrDisableDeleteButton();
            EnableOrDisableEditButton();
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
                TaskTimerForm taskTimerForm = new(savedTaskTimers, row.Cells["clmIdGuid"].Value.ToString());
                taskTimerForm.Owner = this;
                taskTimerForm.Show();
                Hide();
            }
        }

        #endregion
    }
}
