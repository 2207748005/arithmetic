using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class T_user
    {
        public int id { get; set; }
        public string name { get; set; }
        public string trueName { get; set; }
        public string cardId { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string qqId { get; set; }
        public string pwd { get; set; }
        public DateTime regTime { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public int state { get; set; }
    }
}
