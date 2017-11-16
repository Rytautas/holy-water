namespace holy_water
{
    class User
    {
        private string username, password;

        public string Username { get; private set; }
        public string Password { get; private set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
