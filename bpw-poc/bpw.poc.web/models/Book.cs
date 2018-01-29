using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bpw.poc.web.models
{
    public class book
    {
        
        [Key]
        public int book_id { get; set; }

        public string book_name { get; set; }
    }
}
