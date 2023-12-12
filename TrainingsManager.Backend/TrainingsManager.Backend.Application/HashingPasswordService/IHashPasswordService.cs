namespace TrainingsManager.Backend.Application.HashingPasswordService
{
    public interface IHashPasswordService
    {
        public bool VerifyPassword(string password, string hash);
        public string GenerateHash(string password);
    }
}
