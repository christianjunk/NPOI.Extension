using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NPOI.Extension.Tests.Case_1
{
    public class Model
    {
        [Column(AutoIndex = true, Title = "F")]
        public string BuildingName { get; set; }
    }
}
