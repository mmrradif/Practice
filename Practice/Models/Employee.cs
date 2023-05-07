namespace Practice.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Employee
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        private int id;

        private string firstName;
        private string lastName;


        [Required]
        [EmailAddress]
        private string email;

        private string? phoneNumber;



        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        } 

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string? PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }


        public Employee(string firstName, string lastName, string email, string? phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }


}
