using NUnit.Framework;

namespace CodingSchoolFinalProject
{
    public class User
    {
        public string UserName;
        public string UserPassword;

        public User(string username, string password)
        {
            UserName = username;
            UserPassword = password;
        }

        public static User TestUser = new User("ugne.puskunigyte@gmail.com", "Test123");
    }
}