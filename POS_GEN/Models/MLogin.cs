using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_GEN.Models
{
    [Table("User_Info")]
    internal class MLogin
    {
        [Key]
        public int User_ID { get; set; }

        [Required(ErrorMessage = "Field required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Field required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Field required")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Field required")]
        public int userstatus { get; set; }

    }


    //public void 

}