using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.WebProject.DB
{
    [Table("Sys_User")]
    public class User : JQEntity
    {
        public string UserName { get; set; }

        public string PassWord { get; set; }

        public string NickName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public bool IsActive { get; set; }
    }
}
