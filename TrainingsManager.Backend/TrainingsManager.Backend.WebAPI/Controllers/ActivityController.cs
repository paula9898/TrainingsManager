using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingsManager.Backend.Application.ActivityService;
using TrainingsManager.Backend.EntityFramework.Data;
using TrainingsManager.Backend.Model.Activities;
using TrainingsManager.Backend.WebAPI.Dtos;

namespace TrainingsManager.Backend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly TrainingsManagerDbContext _trainingsManagerDbContext;

        public ActivityController(TrainingsManagerDbContext trainingsManagerDbContext)
        {
            _trainingsManagerDbContext = trainingsManagerDbContext;
        }
        //POST: 
        [HttpPost]

        public async Task PostRunning(RunningDto running)
        {
            ActivityService activityService = new ActivityService();
        }

    }
}
