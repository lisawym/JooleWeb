using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Joole.Data
{
        [MetadataType(typeof( UserMetadata))]
        [Bind(Exclude = "UserId" )] 
        public partial class tblUser
        {
            [NotMapped]
            [Required]
            [Display(Name = "Confirm Password")]
            [System.ComponentModel.DataAnnotations.Compare("UserPassword", ErrorMessage ="Passwords do not match")]
            public string UserConfirmPassword { get; set; }
    }

        
    
    
}
