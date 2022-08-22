using System;

namespace APIProject.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public bool is_read { get; set; }
        public DateTime? date_read { get; set; }
        public int? rate { get; set; }
        public string genre { get; set; }
        public string author { get; set; }
        public string cover_url { get; set; }
        public DateTime date_added { get; set; }

    }
}
