﻿namespace FirstApi.Models.Requests
{
    public class AddContactRequest
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
