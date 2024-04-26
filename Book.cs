using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace practice3
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        [JsonIgnore]
        public System.Drawing.Image Cover { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
    }
}
