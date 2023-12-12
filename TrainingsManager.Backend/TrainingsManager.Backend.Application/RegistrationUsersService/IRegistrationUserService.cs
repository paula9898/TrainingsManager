using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingsManager.Backend.Model;

namespace TrainingsManager.Backend.Application.RegistrationUsersService
{
    public interface IRegistrationUserService
    {
        void RegisterUser(string email, string password, string confirmPassword, string name, string surname, string city, Sex sex, int height, int weight, int age)
    }
}
