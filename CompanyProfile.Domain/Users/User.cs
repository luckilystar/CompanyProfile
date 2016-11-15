using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProfile.Domain.Users
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string  Email { get; set; }
        [MaxLength(250)]
        public string  Name { get; set; }


    }
}
