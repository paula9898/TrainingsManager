using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingsManager.Backend.Model.Base;

namespace TrainingsManager.Backend.Model.Activities
{
    public abstract class Activity : Entity
    {
        public Activity(Guid userId, int distance, DateTime date, int heartFrequancyBPM, TimeSpan time, TimeSpan pace, int calories)
        {
            this.UserId = userId;
            this.Distance = distance;
            this.Date = date;
            this.HeartFrequencyBPM = heartFrequancyBPM;
            this.Time = time;
            this.Pace = pace;
            this.Calories = calories;
        }
        public Guid UserId { get; private set; }
        public int Distance { get; private set; }
        public DateTime Date { get; private set; }
        public int HeartFrequencyBPM { get; private set; }
        public TimeSpan Time { get; private set; }
        public TimeSpan Pace { get; private set; }
        public int Calories { get; private set; }

        public abstract int CalculateCalories(int weight, int height);

    }
}
