using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop_System.Models
{
    [MetadataType(typeof(LoginMetadata))]
    public  class LoginModel
    {
        public string USER_NAME { get; set; }
        public string U_PASSWORD { get; set; }
    }

    public class LoginMetadata
    {
        [DisplayName("USER_NAME")]
        public string USER_NAME { get; set; }

        // [PasswordPropertyText]
        [DisplayName("PASSWORD")]
        public string U_PASSWORD { get; set; }

    }
}
