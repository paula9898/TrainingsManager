namespace TrainingsManager.Backend.Application.UnitTests
{
    public class HashingPasswordServiceUnitTests
    {
        public const string Password = "nowehaslo123";

        [Fact]
        public void GenerateHash_Return_CorrectHash()
        {
            // Arrange
            var hashingPasswordService = new HashingPasswordService.HashPasswordService();

            // Act
            var hashPassword = hashingPasswordService.GenerateHash(Password);

            // Assert
            Assert.NotNull(hashPassword);
            Assert.NotEmpty(hashPassword);
            Assert.True(hashPassword.Length == 88);
        }

        [Fact]
        public void VerifyPassword_Return_True()
        {
            // Arrange
            var hashingPasswordService = new HashingPasswordService.HashPasswordService();

            // Act
            var isVerified = hashingPasswordService.VerifyPassword(Password, hashingPasswordService.GenerateHash(Password));

            // Assert

            Assert.True(isVerified);
        }

        [Fact]
        public void VerifyPassword_Return_False()
        {
            // Arrange
            var hashingPasswordService = new HashingPasswordService.HashPasswordService();

            // Act
            var isVerified = hashingPasswordService.VerifyPassword(Password, hashingPasswordService.GenerateHash("Paulinka1234!"));

            // Assert

            Assert.False(isVerified);
        }

        [Fact]
        public void GenerateHash_WhenHashedGeneratedTwice_ShouldReturnTrue()
        {
            // Arrange
            var hashingPasswordService = new HashingPasswordService.HashPasswordService();

            // Act
            var expected = hashingPasswordService.GenerateHash(Password);
            var actual = hashingPasswordService.GenerateHash(Password);

            // Assert
            Assert.Equal(expected,actual);
        }
    }
}