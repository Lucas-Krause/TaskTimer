using TaskTimer.Dtos;

namespace TaskTimer.Models
{
    public class TaskTimerDto
    {
        public string idGuid { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = string.Empty;
        public string StartTime { get; set; } = "00:00";
        public string StopTime { get; set; } = "00:00";
        public string TotalTime { get; set; } = "00:00";

        public List<TaskBreakDto> Breaks { get; set; }

        public TaskTimerDto()
        {
            Breaks = new List<TaskBreakDto>();
        }
    }
}
