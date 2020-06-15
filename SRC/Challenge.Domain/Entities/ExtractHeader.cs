
using System;

namespace Challenge.Domain.Entities
{
    public class ExtractHeader
    {
        public int Id { get; set; }
        public int StatusCode { get; set; }
        public string Language { get; set; }
        public DateTime DateServer { get; set; }
        public string StatusSeverity { get; set; }
    }
}
