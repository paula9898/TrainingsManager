using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingsManager.Backend.Application.UnitTests.HashingPasswordService;
using TrainingsManager.Backend.EntityFramework.Data;
using TrainingsManager.Backend.Model;
using TrainingsManager.Backend.Model.Activities;


namespace TrainingsManager.Backend.Application
{
    public class RegistrationUserService 
    {
        private readonly TrainingsManagerDbContext _trainingsManagerDbContext;
        public RegistrationUserService(TrainingsManagerDbContext trainingsManagerDbContext)
        {
            _trainingsManagerDbContext = trainingsManagerDbContext;
        }

        public void RegisterUser(string email, string password, string confirmPassword, string name, string surname, string city, Sex sex, int height, int weight, int age)
        {
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Incorrect Login or password");
            }

            if(password != confirmPassword)
            {
                throw new ArgumentException("Password and confirm password does not match");
            }

            HashingPasswordService hashingPasswordService = new HashingPasswordService();

            var hashpassword = hashingPasswordService.GenerateHash(password);

            if(hashingPasswordService.VerifyPassword(password, hashpassword))
            {
                _trainingsManagerDbContext.Users.Add(new User(name, surname, city, sex, height, weight, age, email,hashpassword)
                {

                });

                _trainingsManagerDbContext.SaveChanges();
            }
        }

    }
}
