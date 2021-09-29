using Smad.UserControls.Settings;

namespace Smad.Entities {
    
    public class Option {

        public string Name { get; set; }
        public BaseSetting Content { get; set; }

        public Option(string name, BaseSetting content) {
            Name = name;
            Content = content;
        }
    }
}