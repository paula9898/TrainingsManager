using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingsManager.Backend.Model.Base;

namespace TrainingsManager.Backend.Model.Activities
{
    public abstract class Activity
    {
        private Activity()
        {

        }
        public Activity(Guid userId, DateTime date, int heartFrequancyBPM, TimeSpan time, int calories)
        {
            this.Id = Guid.NewGuid();
            this.UserId = userId;
            this.Date = date;
            this.HeartFrequencyBPM = heartFrequancyBPM;
            this.Time = time;
            this.Calories = calories;
            
        }
        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public DateTime Date { get; private set; }
        public int HeartFrequencyBPM { get; private set; }
        public TimeSpan Time { get; private set; }
        public int Calories { get; private set; }
        public User User { get; private set; }
        public abstract int CalculateCalories(int weight, int height);

        public ICollection<Running> Runnings { get; private set; }
        public ICollection<Cycling> Cyclings { get; private set; }
        public ICollection<Squatting> Squattings { get; private set; }

    }
}
