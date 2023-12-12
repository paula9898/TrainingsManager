<<<<<<< Updated upstream
﻿using Microsoft.AspNetCore.Http;
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
    }
}
=======
﻿using Microsoft.AspNetCore.Http;
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

