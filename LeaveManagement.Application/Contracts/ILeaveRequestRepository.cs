using LeaveManagement.Data;
using LeaveManagement.Common.Models;

namespace LeaveManagement.Application.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM model);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
        Task<LeaveRequestVM?>? GetLeaveRequestAsync(int? id);
        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
    }
}
