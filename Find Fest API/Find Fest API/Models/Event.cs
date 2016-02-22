using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Fest_API.Models {
    [Table("Events")]
    public class Event {
        [Key]
        public int EventID { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

    }
}
