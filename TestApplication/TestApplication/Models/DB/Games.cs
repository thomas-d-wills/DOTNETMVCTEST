using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestApplication
{
    public partial class Games
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; } = null!;
        [DataType(DataType.Date)]
        public DateTime? Release { get; set; }
        public string? Publisher { get; set; }
    }
}
