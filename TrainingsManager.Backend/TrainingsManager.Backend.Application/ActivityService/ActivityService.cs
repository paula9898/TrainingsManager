using Azure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingsManager.Backend.EntityFramework.Data;
using TrainingsManager.Backend.Model.Activities;

namespace TrainingsManager.Backend.Application.ActivityService
{
    public class ActivityService
    {
        private readonly TrainingsManagerDbContext _trainingsManagerDbContext;

        public ActivityService(TrainingsManagerDbContext trainingsManagerDbContext)
        {
            _trainingsManagerDbContext = trainingsManagerDbContext;
        }

        public async Task<Guid> CreateRunningActivity(int distance, DateTime date, int heartFrequencyBPM, TimeSpan time, TimeSpan pace, int calories)
        {
            var runningActivity = new Running(Guid.NewGuid(), distance, date, heartFrequencyBPM, time,pace, calories);

            _trainingsManagerDbContext.Add(runningActivity);
            await _trainingsManagerDbContext.SaveChangesAsync();

            return runningActivity.Id;//async po to zeby kod się wywol asychronicznie, nie musimy się martwic watkami, async awiat definiuje nowy task,
            //hej biblioteko zaapiekuj się tym taskiem, watkami, ile rdzeni jest na komputerze, biblioteka wie ile mam rdzeni
        }

        public async Task<Guid> CreateCyclingActivity(int distance, DateTime date, int heartFrequencyBPM, TimeSpan time, TimeSpan pace, int calories)
        {
            var cyclingActivity = new Cycling(Guid.NewGuid(), distance, date, heartFrequencyBPM, time, pace, calories);

            _trainingsManagerDbContext.Set<Cycling>().Add(cyclingActivity);
            await _trainingsManagerDbContext.SaveChangesAsync();

            return cyclingActivity.Id;
        }
    }
}
