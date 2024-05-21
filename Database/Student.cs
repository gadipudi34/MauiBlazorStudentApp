using SQLite;

namespace StudentAppHybrid.Database
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
