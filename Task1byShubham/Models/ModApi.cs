using System.ComponentModel.DataAnnotations;


namespace ApiTask1.Models
{
    public class ModApi
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

       
        public string LastName { get; set; }

       
        public string Email { get; set; }

      
        public DateTime DOB { get; set; }

        public string Department { get; set; }

      
        public string Designation { get; set; }

       
        public string City { get; set; }

        public string ContactNo { get; set; }

    }
}
