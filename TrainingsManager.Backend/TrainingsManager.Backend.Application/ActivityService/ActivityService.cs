using Azure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingsManager.Backend.Model.Activities;

namespace TrainingsManager.Backend.Application.ActivityService
{
    public class ActivityService
    {
        private readonly DbContext _dbContext;

        public ActivityService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> CreateRunningActivity(Guid userId, int distance, DateTime date, int heartFrequencyBPM, TimeSpan time, TimeSpan pace, int calories)
        {
            var runningActivity = new Running(userId, distance, date, heartFrequencyBPM, time,pace, calories);

            _dbContext.Set<Running>().Add(runningActivity);
            await _dbContext.SaveChangesAsync();

            return runningActivity.Id;//async po to zeby kod się wywol asychronicznie, nie musimy się martwic watkami, async awiat definiuje nowy task,
            //hej biblioteko zaapiekuj się tym taskiem, watkami, ile rdzeni jest na komputerze, biblioteka wie ile mam rdzeni
        }

        public async Task<Guid> CreateCyclingActivity(Guid userId, int distance, DateTime date, int heartFrequencyBPM, TimeSpan time, TimeSpan pace, int calories)
        {
            var cyclingActivity = new Cycling(userId, distance, date, heartFrequencyBPM, time, pace, calories);

            _dbContext.Set<Cycling>().Add(cyclingActivity);
            await _dbContext.SaveChangesAsync();

            return cyclingActivity.Id;
        }
    }
}
