using Smad.Entities;
using Supremes;
using System;
using System.Linq;
using System.Net;

namespace Smad.Helpers.Scrapers {

    public static class GooglePlayScraper {

        public static App BasicInfor(string packageId) {
            try {
                var inforLink = new Uri($"https://play.google.com/store/apps/details?id={packageId}&hl=pt_BR");
                var htmlDocument = Dcsoup.Parse(inforLink, int.MaxValue);

                var inforData = htmlDocument.GetElementsByClass("IQ1z0d");
                if (string.IsNullOrEmpty(inforData.OuterHtml))
                    throw new Exception();

                var imageData = htmlDocument.GetElementsByClass("xSyT2c");
                var wc = new WebClient();
                var icon = wc.DownloadData(imageData[0].Children[0].Attributes["src"]);

                return new App(icon) {
                    Id = packageId,
                    Name = htmlDocument.GetElementsByClass("AHFaub").Text,
                    StarRating = float.Parse(htmlDocument.GetElementsByClass("BHMmbe").Text),
                    //Developer = inforData[13].Text,
                    //DownloadNumber = inforData[4].Text,
                    //ReviewsNumber = int.Parse(htmlDocument.GetElementsByClass("EymY4b").First.Children[1].Text.Replace(",", "").Replace(".", "")),
                    //Version = inforData[5].Text,
                    //UpdateDate = DateTime.Parse(inforData[2].Text),
                    //Link = inforLink.AbsoluteUri
                };
            } catch {
                return null;
            }
        }

        public static Comment CommentInfor(string html) {
            try {
                var htmlDocument = Dcsoup.Parse(html);

                var ratingCharacters = htmlDocument.GetElementsByAttributeValue("role", "img")[0].Attributes.FirstOrDefault(a => a.Key.Equals("aria-label")).Value.Where(char.IsDigit).ToArray();
                var ratingNumbers = new int[ratingCharacters.Length];
                for (int i = 0; i < ratingNumbers.Length; i++)
                    ratingNumbers[i] = int.Parse(ratingCharacters[i].ToString());

                return new Comment {
                    UserName = htmlDocument.GetElementsByClass("X43Kjb").Text,
                    Message = htmlDocument.GetElementsByAttributeValue("jsname", "bN97Pc").Text,
                    Like = int.Parse(htmlDocument.GetElementsByClass("jUL89d").Text),
                    PublishDate = htmlDocument.GetElementsByClass("p2TkOb")[0].Text,
                    Rating = ratingNumbers.Min()
                };
            } catch {
                return null;
            }
        }
    }
}