using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int id;
        [Display(Name="First Name")]
        public string firstName;
        public string lastName;
        public int cityID;
    }
}