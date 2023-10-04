using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MauiApp2.Services
{
    public class MockApiService
    {
        private const int DEFAULT_DAYS = 5;
        private const int DEFAULT_ENTRY_HOUR = 7;
        private const int DEFAULT_EXIT_HOUR = 12;

        private readonly Dictionary<string, UserInfo> _userInfos;

        public MockApiService()
        {
            _userInfos = new Dictionary<string, UserInfo>
            {
                { "token1", new UserInfo { Name = "User 1", Responsible = "Responsável1", Attendance = GenerateFictitiousAttendance(DateTime.Now.AddDays(-DEFAULT_DAYS), DEFAULT_DAYS) } },
                { "token2", new UserInfo { Name = "User 2", Responsible = "Responsável2", Attendance = GenerateFictitiousAttendance(DateTime.Now.AddDays(-DEFAULT_DAYS), DEFAULT_DAYS) } }
            };
        }

        private List<AttendanceRecord> GenerateFictitiousAttendance(DateTime startDate, int days)
        {
            var attendance = new List<AttendanceRecord>();
            for (int i = 0; i < days; i++)
            {
                attendance.Add(new AttendanceRecord
                {
                    Date = startDate.AddDays(i),
                    EntryTime = startDate.AddDays(i).AddHours(DEFAULT_ENTRY_HOUR),
                    ExitTime = startDate.AddDays(i).AddHours(DEFAULT_EXIT_HOUR)
                });
            }
            return attendance;
        }

        public Task<bool> LoginAsync(string loginToken)
        {
            return Task.FromResult(_userInfos.ContainsKey(loginToken));
        }

        public UserInfo GetUserInfo(string loginToken)
        {
            if (_userInfos.TryGetValue(loginToken, out var userInfo))
            {
                return userInfo;
            }
            throw new ArgumentException("Token inválido ou usuário não autenticado.");
        }
    }

    public class AttendanceRecord
    {
        public DateTime Date { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
    }

    public class UserInfo
    {
        public string Name { get; set; }
        public string Responsible { get; set; }
        public List<AttendanceRecord> Attendance { get; set; }
    }
}
