using EmployeeManager.Business.Dto;

namespace EmployeeManager.Business.Composite
{
    public class EmployeeWithAddress
    {
        public EmployeeDto Employee { get; set; }
        public AddressDto Address { get; set; }
    }
}
