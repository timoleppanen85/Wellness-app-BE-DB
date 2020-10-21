﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WompattiApi.Models
{
    public partial class Question
    {
        public Question()
        {
            Answer = new HashSet<Answer>();
        }

        [Key]
        public long Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Header1 { get; set; }
        public string Header2 { get; set; }
        [Required]
        public string Image { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public long SubjectId { get; set; }
        public bool Hidden { get; set; }

        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("Question")]
        public virtual Subject Subject { get; set; }
        [InverseProperty("Question")]
        public virtual ICollection<Answer> Answer { get; set; }
    }
}