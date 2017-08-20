using System;

namespace ECommerce.Frontend.ViewModels
{
    public class UserViewModel
    {
        public bool IsFound { get; set; }
        public int Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }        
    }
}
