using Microsoft.EntityFrameworkCore;
using AStandupApi.Data.Models;

namespace AStandupApi.Data.Contexts
{
    internal class LoggingContext : DbContext
    {
        internal static string AppFolder
        {
            get
            {
                var appDataFolder = Environment.SpecialFolder.LocalApplicationData;
                var path = Environment.GetFolderPath(appDataFolder);
                return System.IO.Path.Join(path, "AStandupApi");
            }
        }

        internal static string DbPath =>
            System.IO.Path.Join(AppFolder, "a_standup_api.db");

        public DbSet<MeetingNote> MeetingNotes { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }

        public LoggingContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

    }
}
