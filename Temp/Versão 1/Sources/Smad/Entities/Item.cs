using System;

namespace Smad.Entities {

    [Serializable]
    public class Item {

        public string Code { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Problem { get; set; }
        public string Location { get; set; }
        public int SeverityLevel { get; set; } = 0;
        public byte[] Print { get; set; }
        public string Group { get; set; }

        public string Severity {
            get {
                switch (SeverityLevel) {
                    case 0: {
                        return "Baixa";
                    }
                    case 1: {
                        return "Média";
                    }
                    case 2: {
                        return "Alta";
                    }
                    default: {
                        return "";
                    }
                }
            }
        }

        public int IsError { get; set; } = -1;
    }
}