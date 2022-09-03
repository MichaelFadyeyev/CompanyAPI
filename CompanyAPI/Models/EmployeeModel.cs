using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace CompanyAPI.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string EmployeeName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Occupation { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string ImageName { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [NotMapped]
        public string ImageSrc  { get; set; }

    }
}
