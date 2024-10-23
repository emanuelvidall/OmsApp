using System.ComponentModel.DataAnnotations;

namespace OmsApp.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [MaxLength(255)] 
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(500)] 
        public string Address { get; set; }
    }
}