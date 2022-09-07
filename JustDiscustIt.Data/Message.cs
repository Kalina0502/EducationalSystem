using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustDiscustIt.Data
{
   public class Message
    {
        [Key]
        public int Id { get; set; }

        public string Text { get; set; }

        public int SenderId { get; set; }

        public int ReceiverId { get; set; }
    }
}
