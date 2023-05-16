using System.ComponentModel.DataAnnotations;

namespace MyUni.Models
{
    public class Student
    {
        public int StudentId { get; set; }
       
        public string LastName { get; set; }
        [Display(Name = "Last Name")]
        public string FirstName { get; set; }
        [Display(Name = "First Name")]
        public DateTime EnrollmentDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",  ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime DOB { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}" , ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Birth")]

        public ICollection <Enrollment> Enrollements { get; set; }
        
    }
}
