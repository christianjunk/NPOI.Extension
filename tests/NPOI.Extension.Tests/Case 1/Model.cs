using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NPOI.Extension.Tests.Case_1
{
    public class Model
    {
        [Column(Index = 0, Title = "A")]
        public string A { get; set; }

        [Column(AutoIndex = true, Title = "F")]
        public string F { get; set; }
    }
}
