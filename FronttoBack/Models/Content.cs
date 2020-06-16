﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FronttoBack.Models
{
    public class Content
    {
        public int Id { get; set; }
        [Required, StringLength(150)]
        public string Title { get; set; }
        [Required, MinLength(50), MaxLength(500)]
        public string Description { get; set; }
        [Required, StringLength(255)]
        public string Img { get; set; }
    }
}