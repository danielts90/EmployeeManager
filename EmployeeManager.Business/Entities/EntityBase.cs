using EmployeeManager.Business.Dto;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Business.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created_At { get; set; }


        public static implicit operator DtoBase(EntityBase entity) => entity.ToDto();
        protected abstract DtoBase ToDto();
    }
}
