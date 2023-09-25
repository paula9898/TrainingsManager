using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingsManager.Backend.Model.Base;

namespace TrainingsManager.Backend.Model.Activities
{
    public class Activity : Entity
    {
        public Activity(Guid userId, DateTime date, int heartFrequencyBPM, TimeSpan time, int calories)
        {
            this.UserId = userId;
            this.Date = date;
            this.HeartFrequencyBPM = heartFrequencyBPM;
            this.Time = time;
            this.Calories = calories;
            
        }
        public Guid UserId { get; private set; }
        public DateTime Date { get; private set; }
        public int HeartFrequencyBPM { get; private set; }
        public TimeSpan Time { get; private set; }
        public int Calories { get; private set; }
        public User User { get; private set; }
        public virtual int CalculateCalories(int weight, int height)
        {
            throw new NotImplementedException();
        }

        public Running Running { get; private set; }
        public Cycling Cycling { get; private set; }
        public Squatting Squatting { get; private set; }

    }
}
