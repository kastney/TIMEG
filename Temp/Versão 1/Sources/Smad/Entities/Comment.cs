using System;

namespace Smad.Entities {

    [Serializable]
    public class Comment {

        public string UserName { get; set; }
        public string Message { get; set; }
        public int Rating { get; set; }
        public int Like { get; set; }
        public string PublishDate { get; set; }
    }
}