using System;
using System.ComponentModel;

namespace Smad.Entities {

    [Serializable]
    public abstract class Filter {

        [Browsable(false)]
        public bool IsEnabled { get; set; }

        [Browsable(false)]
        public string Name { get; set; }

        public virtual void Apply(App app) { }
        public virtual void Unapply(App app) { }
    }
}