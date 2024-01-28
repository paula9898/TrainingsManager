namespace TrainingsManager.Backend.Model.Activities
{
    public class Running : Activity
    {
        public Running(Guid userId, int distance, DateTime date, int heartFrequencyBPM, TimeSpan time, TimeSpan pace, int calories) : base(userId, date, heartFrequencyBPM, time, calories)
        {
            this.Distance = distance;
            this.Pace = pace;
        }
        public Activity Activity { get; private set; }
        public TimeSpan Pace { get; private set; }
        public int Distance { get; private set; }
        public override int CalculateCalories(int weight, int height)
        {
            throw new NotImplementedException();
        }
    }
}
