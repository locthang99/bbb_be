using Application.DTOs.Dashboard;
using Application.Interfaces.Repo;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories.Repo
{
    public class DashboardRepository: IDashboardRepository
    {
        private readonly BigBlueBirdsDbContext _context;
        public DashboardRepository(BigBlueBirdsDbContext context)
        {
            _context = context;

        }
        public async Task<List<DashboardDTO>> GetNumberSong(string type)
        {
            // var data = await _context.Songs.GroupBy(x => x.DateCreate.Year).ToListAsync();
            if (type == "month")
            {
                var data = from song in _context.Songs
                           group song by new { song.DateCreate.Month, song.DateCreate.Year } into g
                           select new
                           {
                               M = g.Key.Month,
                               Y = g.Key.Year,
                               Title = g.Key.Month.ToString() + "/" + g.Key.Year.ToString(),
                               Total = g.Count()
                           };
                return await data.Select(x => new DashboardDTO
                {
                    M = x.M,
                    Y = x.Y,
                    Title = x.Title,
                    Value = x.Total
                }).OrderBy(x => x.Y).ThenBy(x => x.M).ToListAsync();
            }
            else
            {
                var data = from song in _context.Songs
                           group song by new { song.DateCreate.Year } into g
                           select new
                           {
                               Y = g.Key.Year,
                               Title = g.Key.Year.ToString(),
                               Total = g.Count()
                           };
                return await data.Select(x => new DashboardDTO
                {
                    Y = x.Y,
                    Title = x.Title,
                    Value = x.Total
                }).OrderBy(x => x.Y).ToListAsync();
            }
        }
        public async Task<List<DashboardDTO>> GetNumberPlaylist(string type)
        {
            // var data = await _context.Songs.GroupBy(x => x.DateCreate.Year).ToListAsync();
            if (type == "month")
            {
                var data = from pl in _context.Playlists
                           group pl by new { pl.DateCreate.Month, pl.DateCreate.Year } into g
                           select new
                           {
                               M = g.Key.Month,
                               Y = g.Key.Year,
                               Title = g.Key.Month.ToString() + "/" + g.Key.Year.ToString(),
                               Total = g.Count()
                           };
                return await data.Select(x => new DashboardDTO
                {
                    M = x.M,
                    Y = x.Y,
                    Title = x.Title,
                    Value = x.Total
                }).OrderBy(x => x.Y).ThenBy(x => x.M).ToListAsync();
            }
            else
            {
                var data = from pl in _context.Playlists
                           group pl by new { pl.DateCreate.Year } into g
                           select new
                           {
                               Y = g.Key.Year,
                               Title = g.Key.Year.ToString(),
                               Total = g.Count()
                           };
                return await data.Select(x => new DashboardDTO
                {
                    Y = x.Y,
                    Title = x.Title,
                    Value = x.Total
                }).OrderBy(x => x.Y).ToListAsync();
            }
        }
        public async Task<List<DashboardDTO>> GetTotalPlaylist()
        {
            // var data = await _context.Songs.GroupBy(x => x.DateCreate.Year).ToListAsync();
            var now = DateTime.Now;
            var week = await _context.Playlists.CountAsync(x => DateTime.Now.AddDays(-7).CompareTo(x.DateCreate) == -1);
            var month = await _context.Playlists.CountAsync(x => DateTime.Now.AddDays(-30).CompareTo(x.DateCreate) == -1);
            var year = await _context.Playlists.CountAsync(x => DateTime.Now.AddDays(-365).CompareTo(x.DateCreate) == -1);
            var total = await _context.Playlists.CountAsync();

            var data = new List<DashboardDTO>();
            data.Add(new DashboardDTO() { Title = "Tuần qua", Value = week });
            data.Add(new DashboardDTO() { Title = "Tháng qua", Value = month });
            data.Add(new DashboardDTO() { Title = "Năm qua", Value = year });
            data.Add(new DashboardDTO() { Title = "Tổng số playlist", Value = total});
            return data;

        }
        public async Task<List<DashboardDTO>> GetTotalType()
        {
            var data = from st in _context.Song_Types
                       group st by new { st.Type.Name } into g
                       select new
                       {
                           M = 0,
                           Y = 0,
                           Title = g.Key.Name,
                           Total = g.Count()
                       };
            return await data.Select(x => new DashboardDTO
            {
                M = x.M,
                Y = x.Y,
                Title = x.Title,
                Value = x.Total
            }).OrderBy(x => x.Y).ThenBy(x => x.M).ToListAsync();
        }
        public async Task<List<DashboardDTO>> GetTotalRole()
        {
            var data = from st in _context.Users
                       group st by new { st.RoleBase } into g
                       select new
                       {
                           M = 0,
                           Y = 0,
                           Title = g.Key.RoleBase,
                           Total = g.Count()
                       };
            return await data.Select(x => new DashboardDTO
            {
                M = x.M,
                Y = x.Y,
                Title = x.Title,
                Value = x.Total
            }).OrderBy(x => x.Y).ThenBy(x => x.M).ToListAsync();
        }
        public async Task<List<DashboardDTOVIP>> GetAll(string type)
        {
            if (type == "month")
            {
                var data = from song in _context.Songs
                           group song by new { song.DateCreate.Month, song.DateCreate.Year } into g
                           select new
                           {
                               M = g.Key.Month,
                               Y = g.Key.Year,
                               Title = g.Key.Month.ToString() + "/" + g.Key.Year.ToString(),
                               Like = g.Sum(x => Convert.ToInt64(x.TotalLike)),
                               Cmt = g.Sum(x => Convert.ToInt64(x.TotalCmt)),
                               Listen = g.Sum(x => Convert.ToInt64(x.TotalListen)),
                               Download = g.Sum(x => Convert.ToInt64(x.TotalDownload)),

                           };
                return await data.Select(x => new DashboardDTOVIP
                {
                    M = x.M,
                    Y = x.Y,
                    Title = x.Title,
                    Like = x.Like,
                    Cmt = x.Cmt,
                    Listen = x.Listen,
                    Download = x.Download
                }).OrderBy(x => x.Y).ThenBy(x => x.M).ToListAsync();
            }
            else
            {
                var data = from song in _context.Songs
                           group song by new { song.DateCreate.Year } into g
                           select new
                           {

                               Y = g.Key.Year,
                               Title = g.Key.Year.ToString(),
                               Like = g.Sum(x => Convert.ToInt64(x.TotalLike)),
                               Cmt = g.Sum(x => Convert.ToInt64(x.TotalCmt)),
                               Listen = g.Sum(x => Convert.ToInt64(x.TotalListen)),
                               Download = g.Sum(x => Convert.ToInt64(x.TotalDownload)),

                           };
                return await data.Select(x => new DashboardDTOVIP
                {

                    Y = x.Y,
                    Title = x.Title,
                    Like = x.Like,
                    Cmt = x.Cmt,
                    Listen = x.Listen,
                    Download = x.Download
                }).OrderBy(x => x.Y).ToListAsync();
            }
        }
        public async Task<List<DashboardDTO>> GetAge(string type)
        {
            var data = from u in _context.Users
                       group u by new { u.Dob.Year } into g
                       select new
                       {

                           Y = g.Key.Year,
                           Title = g.Key.Year.ToString(),
                           Total = g.Count()
                       };
            return await data.Select(x => new DashboardDTO
            {
                Y = x.Y,
                Title = x.Title,
                Value = x.Total
            }).OrderBy(x => x.Y).ToListAsync();
        }
        public async Task<List<DashboardDTO>> GetCreateUser(string type)
        {

            if (type == "month")
            {
                var data = from u in _context.Users
                           group u by new { u.DateCreate.Month, u.DateCreate.Year } into g
                           select new
                           {
                               M = g.Key.Year,
                               Y = g.Key.Year,
                               Title = g.Key.Month.ToString() + "/" + g.Key.Year.ToString(),
                               Total = g.Count()
                           };
                return await data.Select(x => new DashboardDTO
                {
                    M = x.M,
                    Y = x.Y,
                    Title = x.Title,
                    Value = x.Total
                }).OrderBy(x => x.Y).ThenBy(x => x.M).ToListAsync();
            }
            else
            {
                var data = from u in _context.Users
                           group u by new { u.DateCreate.Year } into g
                           select new
                           {
                               Y = g.Key.Year,
                               Title = g.Key.Year.ToString(),
                               Total = g.Count()
                           };
                return await data.Select(x => new DashboardDTO
                {
                    Y = x.Y,
                    Title = x.Title,
                    Value = x.Total
                }).OrderBy(x => x.Y).ToListAsync();
            }
        }
        public async Task<List<DashboardDTOVIP>> GetAllReactionMySong(string type,int userId)
        {
            if (type == "month")
            {
                var data = from song in _context.Songs
                           where song.CreatedBy == userId
                           group song by new { song.DateCreate.Month, song.DateCreate.Year } into g
                           select new
                           {
                               M = g.Key.Month,
                               Y = g.Key.Year,
                               Title = g.Key.Month.ToString() + "/" + g.Key.Year.ToString(),
                               Like = g.Sum(x => Convert.ToInt64(x.TotalLike)),
                               Cmt = g.Sum(x => Convert.ToInt64(x.TotalCmt)),
                               Listen = g.Sum(x => Convert.ToInt64(x.TotalListen)),
                               Download = g.Sum(x => Convert.ToInt64(x.TotalDownload)),

                           };
                return await data.Select(x => new DashboardDTOVIP
                {
                    M = x.M,
                    Y = x.Y,
                    Title = x.Title,
                    Like = x.Like,
                    Cmt = x.Cmt,
                    Listen = x.Listen,
                    Download = x.Download
                }).OrderBy(x => x.Y).ThenBy(x => x.M).ToListAsync();
            }
            else
            {
                var data = from song in _context.Songs
                           where song.CreatedBy == userId
                           group song by new { song.DateCreate.Year } into g
                           select new
                           {

                               Y = g.Key.Year,
                               Title = g.Key.Year.ToString(),
                               Like = g.Sum(x => Convert.ToInt64(x.TotalLike)),
                               Cmt = g.Sum(x => Convert.ToInt64(x.TotalCmt)),
                               Listen = g.Sum(x => Convert.ToInt64(x.TotalListen)),
                               Download = g.Sum(x => Convert.ToInt64(x.TotalDownload)),

                           };
                return await data.Select(x => new DashboardDTOVIP
                {

                    Y = x.Y,
                    Title = x.Title,
                    Like = x.Like,
                    Cmt = x.Cmt,
                    Listen = x.Listen,
                    Download = x.Download
                }).OrderBy(x => x.Y).ToListAsync();
            }
        }
        public List<DashboardDTO> GetAllInfoMySong( int userId)
        {
            var dataTotalSong = from song in _context.Songs
                       where song.CreatedBy == userId
                       group song by new { song.CreatedBy } into g
                       select new
                       {
                           Title = "Số bài",
                           Total = g.Count()
                       };
            var dataPlaylist = from pl in _context.Playlists
                                where pl.CreatedBy == userId
                                group pl by new { pl.CreatedBy } into g
                                select new
                                {
                                    Title = "Số playlist",
                                    Total = g.Count()
                                };
            var dataListen = from song in _context.Songs
                                where song.CreatedBy == userId
                                group song.TotalListen by new { song.CreatedBy } into g
                                select new
                                {
                                    Title = "Lượt nghe",
                                    Total = g.Sum()
                                };
            var dataLike = from song in _context.Songs
                             where song.CreatedBy == userId
                             group song.TotalLike by new { song.CreatedBy } into g
                             select new
                             {
                                 Title = "Lượt thích",
                                 Total = g.Sum()
                             };
            var dataCmt = from song in _context.Songs
                             where song.CreatedBy == userId
                             group song.TotalCmt by new { song.CreatedBy } into g
                             select new
                             {
                                 Title = "Lượt bình luận",
                                 Total = g.Sum()
                             };
            var dataDownload = from song in _context.Songs
                             where song.CreatedBy == userId
                             group song.TotalDownload by new { song.CreatedBy } into g
                             select new
                             {
                                 Title = "Lượt tải",
                                 Total = g.Sum()
                             };
            List<DashboardDTO> rs = new List<DashboardDTO>();
            rs.Add(dataTotalSong.Select(x => new DashboardDTO
            {
                Title = x.Title,
                Value = x.Total
            }).FirstOrDefault());

            var p = dataPlaylist.Select(x => new DashboardDTO
            {
                Title = x.Title,
                Value = x.Total
            }).FirstOrDefault();
            if(p==null)
            {
                rs.Add(new DashboardDTO() { 
                    Title = "Số playlist",
                    Value = 0
                });
            }
            else
            {
                rs.Add(p);
            }    


            rs.Add(dataListen.Select(x => new DashboardDTO
            {
                Title = x.Title,
                Value = x.Total
            }).FirstOrDefault());

            rs.Add(dataLike.Select(x => new DashboardDTO
            {
                Title = x.Title,
                Value = x.Total
            }).FirstOrDefault());

            rs.Add(dataCmt.Select(x => new DashboardDTO
            {
                Title = x.Title,
                Value = x.Total
            }).FirstOrDefault());

            rs.Add(dataDownload.Select(x => new DashboardDTO
            {
                Title = x.Title,
                Value = x.Total
            }).FirstOrDefault());

            return rs.ToList();
        }
        public async Task<List<DashboardDTO>> GetChartAllUser()
        {
            var data = from u in _context.Users
                       group u by new { u.UserVip } into g
                       select new
                       {
                           Y = "",
                           Title = g.Key.UserVip? "User Vip":"User bình thường",
                           Total = g.Count()
                       };
            return await data.Select(x => new DashboardDTO
            {
                Y = 0,
                Title = x.Title,
                Value = x.Total
            }).OrderBy(x => x.Y).ToListAsync();
        }
    }
}
