namespace OnlineBookStore
{
    public class UserInfo
    {
        private string username;
        private string password;

        public UserInfo()
        {
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }
    }
}