using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.WebProject
{
    public abstract class JQEntity : IEntity<Guid>, IHasCreationTime, IHasModificationTime, ICreationAudited, IModificationAudited, ISoftDelete
    {
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public DateTime? LastModificationTime { get; set; } = null;
        public long? CreatorUserId { get; set; } = null;
        public long? LastModifierUserId { get; set; } = null;
        public bool IsDeleted { get; set; } = false;

        public string? OrgCode { get; set; } = null;

        public string OrgName { get; set; } = null;

        public string GroupId { get; set; } = null;

        public string GroupName { get; set; } = null;
        public Guid Id { get; set; } = Guid.NewGuid();

        public bool IsTransient()
        {
            return false;
        }
    }
}
