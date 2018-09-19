using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop_System.Models
{
    public class EmailAttribute : RegularExpressionAttribute
    {
        public EmailAttribute()
            : base(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")
        {
        }
    }
    [MetadataType(typeof(UserMetadata))]
    public partial class USERS
    {
        public string RePwd { get; set; }
    }
   
    public class UserMetadata
    {
        [DisplayName("Name")]
        public string NAME { get; set; }

        [DisplayName("SURNAME")]
        public string SURNAME { get; set; }

        [DisplayName("USER_NAME")]
        public string USER_NAME { get; set; }

       // [PasswordPropertyText]
        [DisplayName("PASSWORD")]
        public string U_PASSWORD { get; set; }

        //[PasswordPropertyText]
        [DisplayName("confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("U_PASSWORD")]
        public string RePwd { get; set; }
    
        [DisplayName("ADDRESS")]
        public string ADDRESS { get; set; }

        [Email]
        public string EMAIL { get; set; }
    }
}
