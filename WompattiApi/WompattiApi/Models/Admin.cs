﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WompattiApi.Models
{
    public partial class Admin
    {
        [Key]
        public long Id { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        [StringLength(50)]
        public string Hash { get; set; }
    }
}