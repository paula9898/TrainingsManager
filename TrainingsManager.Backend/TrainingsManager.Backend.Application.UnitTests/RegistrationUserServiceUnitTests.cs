using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingsManager.Backend.Application.HashingPasswordService;
using TrainingsManager.Backend.EntityFramework.Data;

namespace TrainingsManager.Backend.Application.UnitTests
{
    public class RegistrationUserServiceUnitTests
    {
        [Fact]
        public void RegisterUser_Should_ValidatePassword()
        {
            //Arrange
            var hashPasswordServiceMock = new Mock<IHashPasswordService>();
            var trainingsManagerDbContextMock = new Mock<ITrainingsManagerDbContext>();

            var registrationUserService = new RegistrationUserService(
                hashPasswordServiceMock.Object,
                trainingsManagerDbContextMock.Object);

            //Act
            Action action = () => registrationUserService.RegisterUser("cos@example.com",
                "Password123!",
                "Password123!",
                "Paulina",
                "Otrebska",
                "Czestochowa",
                Model.Sex.Woman,
                173, 53, 25);

            //Assert
            Assert.Throws<Exception>(action);
        }
    }
}
