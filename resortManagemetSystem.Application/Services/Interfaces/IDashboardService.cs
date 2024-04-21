using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resortManagemetSystem.Web.ViewModels;

namespace resortManagemetSystem.Application.Services.Interfaces
{
    public interface IDashboardService
    {
        Task<RadialBarChartDto> GetTotalBookingRadialChartData();
        Task<RadialBarChartDto> GetRegisteredUserChartData();
        Task<RadialBarChartDto> GetRevenueChartData();
        Task<PieChartDto> GetBookingPieChartData();
        Task<LineChartDto> GetMemberAndBookingLineChartData();
    }
}
