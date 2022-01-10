using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// Represents of developers Table
    /// </summary>
    public class Developer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Followers { get; set; }
    }
}
