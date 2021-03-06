﻿using System;
using System.Collections.Generic;

namespace LionUp.Models
{
    public partial class Major
    {
        public Major()
        {
            Course = new HashSet<Course>();
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string MajorCategory { get; set; }

        public virtual ICollection<Course> Course { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
