using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingsManager.Backend.Model.Activities
{
    public class Cycling : Activity
    {
        public Cycling(Guid userId,int distance, DateTime date, int heartFrequancyBPM, TimeSpan time, TimeSpan pace, int calories) : base(userId,distance, date, heartFrequancyBPM, time, pace, calories)
        {
        }

        public override int CalculateCalories(int weight, int height)
        {
            throw new NotImplementedException();
        }
    }
}
