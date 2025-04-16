using System.ComponentModel.DataAnnotations;

namespace CRUDAppUsingASPCoreWebAPI.Models
{
    public class Student
    {
        
            public int id { get; set; }
      
        [Required]
            public string studentname { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public string Class { get; set; }
        [Required]
        public int rollno { get; set; }
        }

    
}
