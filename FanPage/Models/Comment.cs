﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanPage.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string User { get; set; }
        public string CommentText { get; set; }
    }
}
