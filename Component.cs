using System.Collections.Generic;

namespace dependency_management
{
    public class Component
    {
        public string Name { get; set; }
        public IEnumerable<string> RequiredComponents { get; set; }
        public bool? Entry { get; set; }
    }
}