using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enforcer
{
    class InstallItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsInstalled { get; set; }
        public bool IsNotRequired { get; set; }
    }
}
