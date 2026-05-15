namespace practice14_enums
{
    internal class Logs
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public Action LogAction { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public enum Action
        {
            Created,
            Updated,
            Deleted,
            StatusChanged,
            Completed
        }
    }
}
