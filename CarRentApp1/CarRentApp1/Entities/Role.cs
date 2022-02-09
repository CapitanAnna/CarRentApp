﻿using System.Collections;
using System.Collections.Generic;

namespace CarRentApp1.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public virtual ICollection<UserRole>UserRoles { get; set; }
    }
}