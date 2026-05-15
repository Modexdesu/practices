using System;

namespace practice14_enums
{
    internal class Tasks
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        public enum Status
        {
            ToDo,
            InProgress,
            Done
        }
        
        public Status TaskStatus { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
