using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineApplication.Models
{
    public class Profile
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public string ProfilePicture { get; set; }
    }
}
