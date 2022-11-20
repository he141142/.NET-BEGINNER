using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.entity
{
    class Specialized
    {
        private string specializeName;
        private string shortName;

        public string SpecializeName { get => specializeName; set => specializeName = value; }
        public string ShortName { get => shortName; set => shortName = value; }
    }
}
