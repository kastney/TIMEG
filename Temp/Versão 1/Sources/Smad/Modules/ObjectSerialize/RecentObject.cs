using System;
using LiveShowStudio.Modules.ObjectSerializeManager;

namespace Smad.Modules.ObjectSerialize {

    public class RecentObject : IRecentObject {

        public string Directory { get; set; }
        public string Name { get; set; }
        public byte[] Icon { get; set; }
        public DateTime LastAcess { get; set; }

        public string Button { get; set; } = "X";
        public string ProjectType { get; set; }
    }
}