using Smad.Entities;
using System.Collections.Generic;
using Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Extractors;

namespace Smad.Helpers.WordCloud {

    public class CommentsExtractor : BaseExtractor {

        private readonly List<Comment> comments;

        public CommentsExtractor(List<Comment> comments, IProgressIndicator progressIndicator) : base(progressIndicator) {
            this.comments = comments;
            ProgressIndicator = progressIndicator;
            ProgressIndicator.Maximum = comments.Count;
        }

        public override IEnumerable<string> GetWords() {
            var words = new List<string>();
            foreach (var comment in comments) {
                foreach (var word in GetWords(comment.Message)) {
                    if (!words.Contains(word)) {
                        words.Add(word);
                    }
                }
                ProgressIndicator.Increment(1);
            }
            return words;
        }
    }
}