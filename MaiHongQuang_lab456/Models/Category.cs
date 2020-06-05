using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MaiHongQuang_lab456.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)] 
        public string Name { get; set; }
    }
}