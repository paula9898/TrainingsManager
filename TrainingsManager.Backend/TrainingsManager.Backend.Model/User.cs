using System.Diagnostics;

namespace TrainingsManager.Backend.Model
{
    public class User
    {
        public User(string name, string surname, string city, Sex sex, int height, int weight, int age) // jak najmniej modyfikowac z zewnatrz
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Surname = surname;
            this.City = city;
            this.Sex = sex;
            this.Height = height;
            this.Weight = weight;
            this.Age = age;
        }
        public Guid Id { get; private set; } // setter jest wtedy tylko dostepny w tej klasie
        public string Name { get; private set; } = string.Empty;
        public string Surname { get; private set; } = string.Empty;
        public string City { get; private set; } = string.Empty;
        public Sex Sex { get; private set; }
        public int Height { get; private set; }
        public int Weight { get; private set; }
        public int Age { get; private set; }

        public ICollection<Activity> Activities { get; private set; }
    }
}
