﻿namespace BLL
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public byte Age { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}