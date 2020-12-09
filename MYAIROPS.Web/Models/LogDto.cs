using System;
using System.ComponentModel.DataAnnotations;

namespace MYAIROPS.Web.Models
{
    public class LogDto
    {
        [Required(ErrorMessage = "Id is required.")]
        public int? Id { get; set; }       

        [Required(ErrorMessage = "Date is required.")]
        public DateTime? Date { get; set; }

        [StringLength(255, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        [Required(ErrorMessage = "Text is required.")]
        public string Text { get; set; }
    }
}
