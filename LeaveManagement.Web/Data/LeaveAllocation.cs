using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        [ForeignKey("LeaveTypeId")]
        public LeaveType leaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public string EmployeeId { get; set; }
        
    }
}

