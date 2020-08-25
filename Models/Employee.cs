using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDCORE.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        [Column(TypeName="nvarchar(50)")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName ="Varchar(10)")]
        public string EmpCode { get; set; }
        [Column (TypeName ="Varchar(20)")]
        public string Position { get; set; }
        [Column(TypeName = "Varchar(20)")]
        public string OfficeLocation { get; set; }
    }
}
