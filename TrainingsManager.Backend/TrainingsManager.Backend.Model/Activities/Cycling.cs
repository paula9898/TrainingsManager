using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingsManager.Backend.Model.Activities
{
    public class Cycling : Activity
    {
        public Cycling(Guid userId,Guid activityId, int distance, DateTime date, int heartFrequancyBPM, TimeSpan time, TimeSpan pace, int calories) : base(userId, date, heartFrequancyBPM, time, calories)
        {
            this.Distance = distance;
            this.Pace = pace;
            this.ActivityId = activityId;
        }
        public Guid ActivityId { get; private set; }
        public TimeSpan Pace { get; private set; }
        public int Distance { get; private set; }
        public override int CalculateCalories(int weight, int height)
        {
            throw new NotImplementedException();
        }
    }
}
