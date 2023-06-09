﻿using System.Collections.Generic;

namespace DressApp.WebUi.Data.Models
{
    public class UserDetailModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public IEnumerable<string> SelectedRoles { get; set; }


    }
}
