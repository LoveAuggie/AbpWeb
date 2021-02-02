using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.WebProject.DTO
{
    public class UpdateUserDto : CreateUserDto
    {   
        [Required]
        [StringLength(50)]
        public string UpdateReason { get; set; }
    }
}
