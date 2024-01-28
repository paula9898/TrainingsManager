using Microsoft.AspNetCore.Mvc;
using TrainingsManager.Backend.EntityFramework.Data;

namespace TrainingsManager.Backend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly ITrainingsManagerDbContext _trainingsManagerDbContext;

        public ActivityController(ITrainingsManagerDbContext trainingsManagerDbContext)
        {
            _trainingsManagerDbContext = trainingsManagerDbContext;
        }

    }
}

