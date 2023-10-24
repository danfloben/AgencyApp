using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AgencyApp.Data.Models
{
    public class Agency
    {
        public int Id { get; set; }

        public int Code { get; set; }

        public string Description { get; set; } 

        public string Address { get; set; }

        public string Identification { get; set; }    
        public DateTime CreationDate { get; set; }
        public string Currency { get; set; }
    }
}
