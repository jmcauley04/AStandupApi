using AStandupApi.Data.Contexts;
using AStandupApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStandupApi.Controllers
{
    internal class LogController
    {
        public async Task SaveNotes(string notes, int minutes)
        {
            var logTime = DateTime.Now;

            var meetingNote = new MeetingNote()
            {
                Notes = notes,
                MeetingDate = logTime
            };

            var context = new LoggingContext();

            await context.MeetingNotes.AddAsync(meetingNote);
            await SaveActivity($"Daily Standup Meeting ({minutes} mins)", context, logTime);

            await context.SaveChangesAsync();
        }

        public async Task SaveActivity(string activityNote, LoggingContext? context = null, DateTime? logTime = null)
        {
            var activity = new ActivityLog()
            {
                Note = activityNote,
                LogTime = logTime ?? DateTime.Now
            };

            if(context != null)
            {
                await context.ActivityLogs.AddAsync(activity);
                return;
            }

            context = new LoggingContext();

            await context.ActivityLogs.AddAsync(activity);

            await context.SaveChangesAsync();
        }

        internal async Task<IEnumerable<ActivityLog>> GetLogYesterday()
        {
            var context = new LoggingContext();

            return await context.ActivityLogs
                .OrderByDescending(x => x.LogTime)
                .Take(30)
                .ToListAsync();
        }

        internal async Task<IEnumerable<MeetingNote>> GetLastNotes(DateTime datetime, int previousQty = 4)
        {
            var context = new LoggingContext();

            var laterNotes = await context.MeetingNotes
                .Where(x => x.MeetingDate >= datetime)
                .ToListAsync();

            var previousNotes = await context.MeetingNotes
                .Where(x => x.MeetingDate < datetime)
                .OrderByDescending(x => x.MeetingDate)
                .Take(previousQty)
                .ToListAsync();

            var debugInfo = new StringBuilder(string.Empty);
            debugInfo.AppendLine("later:");
            foreach (var note in laterNotes)
                debugInfo.AppendLine(note.MeetingDate.ToString());

            debugInfo.AppendLine("prev:");
            foreach (var note in previousNotes)
                debugInfo.AppendLine(note.MeetingDate.ToString());

            var allNotes = await context.MeetingNotes.ToListAsync();

            debugInfo.AppendLine("all:");
            foreach (var note in allNotes)
                debugInfo.AppendLine(note.MeetingDate.ToString());

            var result = debugInfo.ToString();


            // get all meeting notes before the selected and get x meeting notes prior to the selected
            return laterNotes
                .Union(previousNotes)
                .OrderByDescending(x => x.MeetingDate);
        }
    }
}
