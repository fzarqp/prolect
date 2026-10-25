using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cправочник_формул
{
    internal class Class1
    {
        [Serializable] 
        public class Formula
        {
            public string Name { get; set; } 
            public string Category { get; set; }
            public string Expression { get; set; }
            public string Description { get; set; }
        }
    }
}
}
