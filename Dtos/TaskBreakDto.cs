namespace TaskTimer.Dtos
{
    public class TaskBreakDto
    {
        public string DateTimeOfBreak { get; set; } = string.Empty;
        public string StartTime { get; set; } = "00:00";
        public string StopTime { get; set; } = "00:00";
        public string TotalTime { get; set; } = "00:00";
    }
}
