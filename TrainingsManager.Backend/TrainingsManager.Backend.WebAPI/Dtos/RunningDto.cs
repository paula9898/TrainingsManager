using TrainingsManager.Backend.Model;

namespace TrainingsManager.Backend.WebAPI.Dtos
{
    public class RunningDto
    {
        public DateTime Date { get; private set; }
        public int HeartFrequencyBPM { get; private set; }
        public TimeSpan Time { get; private set; }
        public int Calories { get; private set; }
        public TimeSpan Pace { get; private set; }
        public int Distance { get; private set; }
    }
}
