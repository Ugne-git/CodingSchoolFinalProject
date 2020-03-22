using NUnit.Framework;

namespace CodingSchoolFinalProject
{
    public class User
    {
        public string UserEmail;
        public string UserPassword;

        public User(string useremail, string password)
        {
            UserEmail = useremail;
            UserPassword = password;
        }

        public static User DummyUser = new User("ugne.puskunigyte@gmail.com", "Test123");
    }
}