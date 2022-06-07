using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{
    public class ClassMod
    {
        public int Id { get; set; }


        [Required]
       
        public string FirstName { get; set; }


        [Required]
       
        public string LastName { get; set; }


        [Required]
        [StringLength(100)]
        //[RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        //ErrorMessage = "email address is invalid")]
        public string Email { get; set; }



        [Required]
       
        public DateTime DOB { get; set; }

        [Required]
        
        public string Department { get; set; }


        [Required]
       
        public string Designation { get; set; }


        [Required]
       
        public string City { get; set; }


        [Required]
        [StringLength(10)]
        public string ContactNo { get; set; }

    }
}
