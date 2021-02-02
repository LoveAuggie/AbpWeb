using Abp.AutoMapper;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABP.WebProject.DB;
using Abp.Authorization.Users;
using Abp.Auditing;

namespace ABP.WebProject.DTO
{
    /// <summary>
    /// 创建用户用实体
    /// </summary>
    [AutoMapTo(typeof(User))]
    public class CreateUserDto : IShouldNormalize
    {
        [Required]
        [StringLength(10)]
        public string UserName { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
        public string NickName { get; set; }

        [Required]
        [DisableAuditing]
        [StringLength(AbpUserBase.MaxPasswordLength)]
        public string PassWord { get; set; }

        [Required]
        [Phone]
        [StringLength(AbpUserBase.MaxPhoneNumberLength)]
        public string Phone { get; set; }

        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string Email { get; set; }

        public string[] Roles { get; set; }

        public void Normalize()
        {
            if (Roles == null)
            {
                Roles = new string[0];
            }
        }
    }
}
/* Study Note - Dto
 * Dto 主要用于定义面向于接口的信息，和数据库实体类似，但是又有少数的区别
 * Required、Phone、EmailAddress 等属性，由系统类提供，用于验证数据的格式
 * AbpUserBase： 为Abp对于User信息的一些默认属性配置，可以直接使用
 * IShouldNormalize： 用于初始值的初始化，在该实体实例化之后调用，可以再Normalize方法中，对于实体信息进行初始化
 *    - 该方法在属性的验证之前，既可以再这里对于一些需要验证的信息，进行一定的调整
 */
