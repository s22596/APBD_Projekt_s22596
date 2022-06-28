﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektAPBD.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<WatchList> WatchLists { get; set; }
    }
}
