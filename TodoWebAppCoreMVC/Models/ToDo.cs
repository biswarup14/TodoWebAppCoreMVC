using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoWebAppCoreMVC.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Kindly Enter the description")]
        public string Description { get; set; } = string.Empty;
        [Required(ErrorMessage ="Kindly enter DueDate")]
        public DateTime? DueDate { get; set; }
        [Required(ErrorMessage ="Select CategoryID")]
        public string CategoryId { get; set; } = string.Empty;
        [ValidateNever]
        public Category Category { get; set; } = null!;
        [Required(ErrorMessage ="Select StatusId")]
        public string StatusId { get; set; } = string.Empty;
        [ValidateNever]
        public Status Status { get; set; } = null!;
        public bool Overdue => StatusId == "open" && DueDate < DateTime.Today;
    }
}
