namespace TrainingsManager.Backend.Model.Activities
{
    public class Running : Activity
    {
        public Running(Guid userId, int distance, DateTime date, int heartFrequancyBPM, TimeSpan time, TimeSpan pace, int calories) : base(userId, distance, date, heartFrequancyBPM, time, pace, calories)
        {
        }

        public override int CalculateCalories(int weight, int height)
        {
            throw new NotImplementedException();
        }
    }
}
