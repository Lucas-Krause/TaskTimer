using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.Json;
using TaskTimer.Dtos;
using TaskTimer.Models;

namespace TaskTimer
{
    public partial class TaskTimerForm : Form
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

        private const string TimeFormat = "hh\\:mm";
        private bool isClosing = false;
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SavedTaskTimers.json");
        private List<TaskTimerDto> savedTaskTimers;
        private bool isNewTimer = true;
        private TaskTimerDto? currentTaskTimer;

        #endregion

        #region [ Initialization ]

        public TaskTimerForm(List<TaskTimerDto> _savedTaskTimers)
        {
            isNewTimer = true;
            InitializeComponent();
            tmrCurrentTaskTime.Start();
            savedTaskTimers = _savedTaskTimers;
        }

        public TaskTimerForm(List<TaskTimerDto> _savedTaskTimers, string? idGuid)
        {
            isNewTimer = false;
            InitializeComponent();
            tmrCurrentTaskTime.Start();
            savedTaskTimers = _savedTaskTimers;
            currentTaskTimer = savedTaskTimers.Find(timer => timer.idGuid == idGuid);

            if (currentTaskTimer is not null)
            {
                txtTaskName.Text = currentTaskTimer.Name;
                mktxtStartTime.Text = currentTaskTimer.StartTime;
                mktxtStopTime.Text = currentTaskTimer.StopTime;
                mktxtTotalTaskTime.Text = currentTaskTimer.TotalTime;
                PopulateTaskBreaks(currentTaskTimer.Breaks);
            }
        }

        #endregion

        #region [ Event Handlers ]

        private void TaskTimerForm_Load(object sender, EventArgs e)
        {
            txtTaskName.SelectionStart = 0;
            txtTaskName.SelectionLength = 0;
        }

        private void tmrCurrentTaskTime_Tick(object sender, EventArgs e)
        {
            UpdateTotalTaskTime();
            EnableOrDisableAddBreakButton();
            dgvBreaks.ClearSelection();
        }

        private void txtTaskName_TextChanged(object sender, EventArgs e)
        {
            TextBox txtTaskName = (TextBox)sender;
            txtTaskName.Text = txtTaskName.Text.ToUpper();
            txtTaskName.Select(txtTaskName.Text.Length, 0);
        }

        private void btnRegisterStart_Click(object sender, EventArgs e)
        {
            mktxtStartTime.Text = GetHoursPlusMinutesString(DateTime.Now);
        }

        private void btnRegisterStop_Click(object sender, EventArgs e)
        {
            mktxtStopTime.Text = GetHoursPlusMinutesString(DateTime.Now);
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            ClearAllInputs();
        }

        private void btnAddBreak_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("dd/MM HH:mm");
            TimeSpan startTime = ParseTimeSpanFromMaskedInput(mktxtStartTime.Text);
            TimeSpan stopTime = ParseTimeSpanFromMaskedInput(mktxtStopTime.Text);
            TimeSpan totalCurrentTime = stopTime - startTime;

            dgvBreaks.Rows.Add(
                currentTime,
                mktxtStartTime.Text,
                mktxtStopTime.Text,
                $"{(int)totalCurrentTime.TotalHours:D2}:{totalCurrentTime.Minutes:D2}");

            mktxtStartTime.Clear();
            mktxtStopTime.Clear();
            dgvBreaks.ClearSelection();
        }

        private void btnAddBreak_EnabledChanged(object sender, EventArgs e)
        {
            btnAddBreak.BackColor = btnAddBreak.Enabled ? Color.FromArgb(253, 143, 182) : Color.Pink;
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            if (!SaveValidation()) return;

            var taskTimerDto = new TaskTimerDto
            {
                Name = txtTaskName.Text,
                StartTime = IsValidTimeSpanString(mktxtStartTime.Text) ? mktxtStartTime.Text : "00:00",
                StopTime = IsValidTimeSpanString(mktxtStopTime.Text) ? mktxtStopTime.Text : "00:00",
                TotalTime = mktxtTotalTaskTime.Text,
            };

            taskTimerDto.Breaks.AddRange(dgvBreaks.Rows
            .Cast<DataGridViewRow>()
            .Select(row => new TaskBreakDto
            {
                DateTimeOfBreak = row.Cells[0].Value?.ToString() ?? "00/00 00:00",
                StartTime = row.Cells[1].Value?.ToString() ?? "00:00",
                StopTime = row.Cells[2].Value?.ToString() ?? "00:00",
                TotalTime = row.Cells[3].Value?.ToString() ?? "00:00"
            }));

            if (isNewTimer)
            {
                savedTaskTimers.Add(taskTimerDto);
            }
            else if (currentTaskTimer is not null)
            {
                int indexToRemove = savedTaskTimers.FindIndex(timer => timer.idGuid == currentTaskTimer.idGuid);
                savedTaskTimers.RemoveAt(indexToRemove);
                savedTaskTimers.Insert(indexToRemove, taskTimerDto);
            }

            var taskTimerJson = JsonSerializer.Serialize(savedTaskTimers);

            File.WriteAllText(filePath, taskTimerJson);

            MessageBox.Show("Task salva com sucesso!", "Task salva!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnMenu.PerformClick();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Hide();

            if (Owner is MenuForm menuForm)
            {
                menuForm.numberOfSavedTasks = 0;
                menuForm.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void mktxtStartTime_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            ValidateTimeFormatForMaskedInput(e, mktxtStartTime.Text);
        }

        private void mktxtStopTime_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            ValidateTimeFormatForMaskedInput(e, mktxtStopTime.Text);
        }

        private void TaskTimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner is MenuForm menuForm && !isClosing)
            {
                isClosing = true;

                try
                {
                    menuForm.Close();
                }
                finally
                {
                    isClosing = false;
                }
            }
        }

        private void TaskTimerForm_Paint(object sender, PaintEventArgs e)
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

        #region [ Validation and Utility Methods ]

        private void PopulateTaskBreaks(List<TaskBreakDto> taskBreaks)
        {
            dgvBreaks.Rows.Clear();

            foreach (var taskBreak in taskBreaks)
            {
                dgvBreaks.Rows.Add(
                    taskBreak.DateTimeOfBreak,
                    taskBreak.StartTime,
                    taskBreak.StopTime,
                    taskBreak.TotalTime);
            }
        }

        private void ClearAllInputs()
        {
            mktxtStartTime.Clear();
            mktxtStopTime.Clear();
            txtTaskName.Clear();
            dgvBreaks.Rows.Clear();
            txtTaskName.Focus();
        }

        private void EnableOrDisableAddBreakButton()
        {
            btnAddBreak.Enabled = TryParseTimeSpanFromMaskedInput(mktxtStartTime.Text, out var startTime) &&
                                  TryParseTimeSpanFromMaskedInput(mktxtStopTime.Text, out var stopTime) &&
                                  stopTime > startTime;
        }

        private bool SaveValidation()
        {
            if (string.IsNullOrEmpty(txtTaskName.Text))
            {
                ShowWarningMessageBox("Por favor digite o nome da Task para salvar!");
                return false;
            }

            var isValidStartTime = IsValidTimeSpanString(mktxtStartTime.Text);
            var isValidStopTime = IsValidTimeSpanString(mktxtStopTime.Text);

            if ((dgvBreaks.Rows.Count == 0 && (!isValidStartTime || !isValidStopTime)) || (isValidStartTime ^ isValidStopTime))
            {
                ShowWarningMessageBox("Por favor informe um intervalo de tempo válido para salvar!");
                return false;
            }

            return true;
        }

        private static void ShowWarningMessageBox(string message)
        {
            MessageBox.Show(message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void ValidateTimeFormatForMaskedInput(TypeValidationEventArgs e, string text)
        {
            if (text.Trim() != ":" && !e.IsValidInput)
            {
                MessageBox.Show("Formato de tempo inválido, por favor digite um formato válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private static bool IsValidTimeSpanString(string timeString)
        {
            return TimeSpan.TryParseExact(timeString, TimeFormat, CultureInfo.InvariantCulture, out _);
        }

        private static bool TryParseTimeSpanFromMaskedInput(string input, out TimeSpan result)
        {
            result = TimeSpan.Zero;

            if (string.IsNullOrWhiteSpace(input) || input.Trim() == ":") return false;

            var timeComponents = input.Split(':');

            if (timeComponents.Length != 2 ||
                !int.TryParse(timeComponents[0], out var hours) ||
                !int.TryParse(timeComponents[1], out var minutes)) return false;

            result = TimeSpan.FromHours(hours) + TimeSpan.FromMinutes(minutes);
            return true;
        }

        private static TimeSpan ParseTimeSpanFromMaskedInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || input.Trim() == ":")
                return TimeSpan.Zero;

            var timeComponents = input.Split(':');

            if (timeComponents.Length != 2 ||
                !int.TryParse(timeComponents[0], out var hours) ||
                !int.TryParse(timeComponents[1], out var minutes))
                return TimeSpan.Zero;

            return TimeSpan.FromHours(hours) + TimeSpan.FromMinutes(minutes);
        }

        private static string GetHoursPlusMinutesString(DateTime dateTime)
        {
            return $"{dateTime.Hour.ToString("00")}{dateTime.Minute.ToString("00")}";
        }

        private static string GetHoursPlusMinutesString(TimeSpan timeSpan)
        {
            return $"{timeSpan.Hours.ToString("00")}{timeSpan.Minutes.ToString("00")}";
        }

        #endregion

        #region [ Update and Calculation Methods ]

        private void UpdateTotalTaskTime()
        {
            var totalTime = CalculateCurrentTotalTaskTime();
            var totalBreaksTime = CalculateTotalBreaksTime();

            mktxtTotalTaskTime.Text = GetHoursPlusMinutesString(totalTime + totalBreaksTime);
        }

        private TimeSpan CalculateCurrentTotalTaskTime()
        {
            if (TryParseTimeSpanFromMaskedInput(mktxtStartTime.Text, out var startTime) &&
                (TryParseTimeSpanFromMaskedInput(mktxtStopTime.Text, out var stopTime) && stopTime > startTime ||
                DateTime.Now.TimeOfDay > startTime) &&
                TimeSpan.Zero != startTime)
            {
                return stopTime > startTime ? stopTime - startTime : DateTime.Now.TimeOfDay - startTime;
            }

            return TimeSpan.Zero;
        }

        private TimeSpan CalculateTotalBreaksTime()
        {
            if (dgvBreaks.Rows.Count > 0)
            {
                return dgvBreaks.Rows
                    .Cast<DataGridViewRow>()
                    .Select(row => row.Cells["clmTotal"].Value.ToString())
                    .Where(timeString => IsValidTimeSpanString(timeString!))
                    .Select(timeString => ParseTimeSpanFromMaskedInput(timeString!))
                    .Aggregate(TimeSpan.Zero, (acc, time) => acc + time);
            }

            return TimeSpan.Zero;
        }

        #endregion
    }
}
