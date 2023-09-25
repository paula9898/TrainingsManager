using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingsManager.Backend.Model.Activities
{
    public class Squatting : Activity
    {
        public Squatting(Guid userId, DateTime date, int heartFrequencyBPM, TimeSpan time, int calories) : base(userId, date, heartFrequencyBPM, time, calories)
        {
        }
        public Activity Activity;
        public override int CalculateCalories(int weight, int height)
        {
            throw new NotImplementedException();
        }
    }
}
