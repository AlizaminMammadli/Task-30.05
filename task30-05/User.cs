
namespace task30_05
{
    public class User
    {
        private static int _counter;
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        static User() 
        
        {
            _counter = 0;
        }

        public User ()
        {
            _counter++;
            Id = _counter;
        }

        public bool CheckPassword(string password)
        {
            if (!string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
                if (password.Length <= 8)
                    if (char.IsUpper(password[0]))
                        if (password.Any(char.IsDigit))
                            if (password.Any(char.IsPunctuation))
                                return true;
            return false;
           
        }

        public void ShowInfo()
        {
            Console.WriteLine($"User Id : {Id} \nFullname : {FullName} \nPassword : {Password}");
        }

    }
}
