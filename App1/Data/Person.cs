using System.ComponentModel.DataAnnotations;

namespace App1.Data
{
    public class Person
    {
        public Person()
        {

            FirstName = "";
            LastName = "";
            DateOfBirth = DateTime.Now;
            Email = "";
            Name = "";
            Age = 0;
        }



        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The First Name field is required.")]
        [StringLength(50, ErrorMessage = "The First Name field must be less than 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The Last Name field is required.")]
        [StringLength(50, ErrorMessage = "The Last Name field must be less than 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The Date of Birth field is required.")]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid date.")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        [StringLength(50, ErrorMessage = "The Name field must be less than 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Age field is required.")]
        [Range(18, 99, ErrorMessage = "The Age must be between 18 and 99.")]
        public int Age { get; set; }


    }
}
