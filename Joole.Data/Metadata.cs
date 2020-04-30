using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joole.Data
{

    public class UserMetadata
    {
        [Key]
        public int UserId;

        [Required]
        [StringLength(20)]
        public string UserName;

        [Required]
        [StringLength(50)]
        [Display(Name = "Password")]
        public string UserPassword;

        [Required]
        [StringLength(320)]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string UserEmail;

        public byte[] UserImage;
    }
}
