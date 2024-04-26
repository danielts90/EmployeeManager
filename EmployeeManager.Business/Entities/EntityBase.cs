using Dapper.Contrib.Extensions;
using EmployeeManager.Business.Dto;

namespace EmployeeManager.Business.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public long Id { get; set; }
        [Write(false)]
        public DateTime created_at { get; set; }


        public static implicit operator DtoBase(EntityBase entity) => entity.ToDto();
        protected abstract DtoBase ToDto();
    }
}
