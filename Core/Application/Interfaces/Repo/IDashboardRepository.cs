using Application.DTOs.Dashboard;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repo
{
    public interface IDashboardRepository
    {
        Task<List<DashboardDTO>> GetNumberSong(string type);
        Task<List<DashboardDTO>> GetNumberPlaylist(string type);
        Task<List<DashboardDTO>> GetTotalPlaylist();
        Task<List<DashboardDTO>> GetTotalType();
        Task<List<DashboardDTO>> GetTotalRole();
        Task<List<DashboardDTOVIP>> GetAll(string type);
        Task<List<DashboardDTO>> GetAge(string type);
        Task<List<DashboardDTO>> GetCreateUser(string type);
    }
}
