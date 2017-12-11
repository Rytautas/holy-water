namespace holy_water
{
    public class User
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool dark;

        public User(string username, string password, bool dark = false)
        {
            Username = username;
            Password = password;
            this.dark = dark;
        }
    }
}
