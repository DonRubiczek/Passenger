using System;
using System.Text.RegularExpressions;

namespace Passenger.Core.Domain
{
    public class User
    {
        private static readonly Regex NameRegex = new Regex("");
        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public string Username { get; protected set; }
        public string Fullname { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }

        protected User()
        {

        }

        public User(string email, string password,
            string salt, string username)
        {
            Id = Guid.NewGuid();
            Email = email;
            Password = password;
            Salt = salt;
            Username = username;
            CreatedAt = DateTime.UtcNow;
        }

        public void SetEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email cannot be empty");
            }
            if(Email == email)
            {
                return;
            }

            Email = email.ToLowerInvariant();
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetUsername(string username)
        {
            if(!NameRegex.IsMatch(username))
            {
                throw new Exception("Username is valid");
            } 

            Username = username.ToLowerInvariant();
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetPassword(string password)
        {
            if(string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Password cannot be empty");
            }
            if(password.Length < 4)
            {
                throw new Exception("Password should contain atleast 4 characters");
            }
            if(password.Length > 100)
            {
                throw new Exception("Password should contain maximum 100 characters");
            }
            if(Password == password)
            {
                return;
            }
            

            Password = password.ToLowerInvariant();
            UpdatedAt = DateTime.UtcNow;
        }
    }
}