using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace practice14_enums
{
    internal class FileService
    {
        private const string tasksFile = "Tasks.txt";
        private const string logsFile = "Logs.txt";

        // Task operations
        public void CreateTask(Tasks task)
        {
            var allTasks = ReadAllTasks();
            allTasks.Add(task);
            var json =JsonSerializer.Serialize(allTasks);
            File.WriteAllText(tasksFile, json);
          var log = new Logs
            {
                Id = Guid.NewGuid(),
                LogAction = Logs.Action.Created,
              TaskId = task.Id,
              Message = $"Task '{task.Title}' created with status '{task.TaskStatus}'.",
              Timestamp = DateTime.Now
            };
            LogAction(log);
            PrintToConsole($"Task '{task.Title}' created with status '{task.TaskStatus}'.");
        }

        public void UpdateTask(Guid taskId, Tasks updatedTask)
        {
            var allTasks = ReadAllTasks();
            var existingTask = allTasks.FirstOrDefault(t => t.Id == taskId);
            if (existingTask != null)
            {
                PrintToConsole($"Task with id {taskId} not found");
            }
        }

        public void DeleteTask(Guid taskId)
        {
            // Make change → Save → Create log → Print
        }

        public List<Tasks> ReadAllTasks()
        {
            // Load from file
        }

        // Log operations (internal helper)
        private void LogAction(Logs log)
        {
            // Append log to Logs.txt → Print to console
        }

        // Utility helper for the 4-step pattern
        private void PrintToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
