using System;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;

namespace Smad.Entities {

    [Serializable]
    public class App {

        #region Comments Information
        [ReadOnly(true)]
        [Category("Comentários")]
        [DisplayName("Total")]
        [Description("A quantidade total de comentários baixados nesse aplicativo")]
        public int CommentsCout { get; set; }

        [ReadOnly(true)]
        [Category("Comentários")]
        [DisplayName("1 estrela")]
        [Description("A quantidade total de comentários baixados que foram classificados com 1 estrela")]
        public int Star1 { get; set; }

        [ReadOnly(true)]
        [Category("Comentários")]
        [DisplayName("2 estrelas")]
        [Description("A quantidade total de comentários baixados que foram classificados com 2 estrelas")]
        public int Star2 { get; set; }

        [ReadOnly(true)]
        [Category("Comentários")]
        [DisplayName("3 estrelas")]
        [Description("A quantidade total de comentários baixados que foram classificados com 3 estrelas")]
        public int Star3 { get; set; }

        [ReadOnly(true)]
        [Category("Comentários")]
        [DisplayName("4 estrelas")]
        [Description("A quantidade total de comentários baixados que foram classificados com 4 estrelas")]
        public int Star4 { get; set; }

        [ReadOnly(true)]
        [Category("Comentários")]
        [DisplayName("5 estrelas")]
        [Description("A quantidade total de comentários baixados que foram classificados com 5 estrelas")]
        public int Star5 { get; set; }
        #endregion

        [Browsable(false)]
        public string Id { get; set; }

        [Browsable(false)]
        public string Name { get; set; }

        [Browsable(false)]
        public List<Comment> Comments { get; set; }

        [Browsable(false)]
        public List<Comment> ProcessComments { get; set; }

        [Browsable(false)]
        public List<Filter> Filters { get; set; }

        private readonly byte[] icon;
        [Browsable(false)]
        public Image Icon {
            get {
                return Image.FromStream(new MemoryStream(icon));
            }
        }

        public float StarRating { get; set; }

        public App(byte[] icon) {
            CommentsCout = 0;
            Star1 = 0;
            Star2 = 0;
            Star3 = 0;
            Star4 = 0;
            Star5 = 0;

            Comments = new List<Comment>();
            ProcessComments = new List<Comment>();
            Filters = new List<Filter>();
            this.icon = icon;
        }

        public byte[] GetIcon() {
            return icon;
        }
    }
}