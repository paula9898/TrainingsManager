using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingsManager.Backend.Application.HashingPasswordService;
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

            HashPasswordService hashingPasswordService = new HashPasswordService();

            var passwordHash = hashingPasswordService.GenerateHash(password);

            _trainingsManagerDbContext.Users.Add(new User(name, surname, city, sex, height, weight, age, email, passwordHash)
            {

            });

            _trainingsManagerDbContext.SaveChanges();
        }
    }
}
