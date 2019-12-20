using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineApplication.Models
{
    public class Application
    {
        public int Id { get; set; }    
    
        public string Sender { get; set; }
        
        public string ReceiverName { get; set; }
        public string ReceiverComanyName { get; set; }
        public string ReceiverAddress { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public string Body { get; set; }
        public Application()
        {
            Date = DateTime.Now;
        }

    }
  
}

