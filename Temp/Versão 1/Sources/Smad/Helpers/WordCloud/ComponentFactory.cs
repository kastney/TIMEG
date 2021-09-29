using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses;
using Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Blacklist;
using Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Blacklist.En;
using Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Extractors;
using Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Stemmers;
using Nulo.WinForms.Control.WordCloudGenerator.TextAnalyses.Stemmers.En;
using Smad.Entities;

namespace Smad.Helpers.WordCloud {

    internal static class ComponentFactory {
        public static IWordStemmer CreateWordStemmer(bool groupSameStemWords) {
            return groupSameStemWords
                       ? (IWordStemmer)new PorterStemmer()
                       : new NullStemmer();
        }

        public static IBlacklist CreateBlacklist(bool excludeEnglishCommonWords) {
            return excludeEnglishCommonWords
                       ? (IBlacklist)new CommonWords()
                       : new NullBlacklist();
        }

        public static IEnumerable<string> CreateExtractor(InputType inputType, string input, IProgressIndicator progress) {
            switch (inputType) {
                case InputType.File:
                FileInfo fileInfo = new FileInfo(input);
                return new FileExtractor(fileInfo, progress);

                case InputType.Uri:
                Uri uri = new Uri(input);
                return new UriExtractor(uri, progress);

                default:
                return new StringExtractor(input, progress);
            }
        }
        public static IEnumerable<string> CreateExtractor(List<Comment> comments, IProgressIndicator progress) {
            return new CommentsExtractor(comments, progress);
        }

        public static IProgressIndicator CreateProgressBar(InputType inputType, ToolStripProgressBar progressBar) {
            return inputType == InputType.String ? new ProgressBarWrapper(progressBar) : new InfiniteProgressBarWrapper(progressBar);
        }
        public static IProgressIndicator CreateProgressBar(InputType inputType, ProgressBar progressBar) {
            return inputType == InputType.String ? new ProgressBarWrapper(progressBar) : new InfiniteProgressBarWrapper(progressBar);
        }

        public static InputType DetectInputType(string input) {
            if (input.Length < 0x200) {
                if (input.StartsWith("http", true, CultureInfo.InvariantCulture)) {
                    return InputType.Uri;
                }
                if (File.Exists(input)) {
                    return InputType.File;
                }
            }
            return InputType.String;
        }
    }
}