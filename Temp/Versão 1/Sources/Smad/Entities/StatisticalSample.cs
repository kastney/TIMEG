using Smad.Panels;
using System;
using System.ComponentModel;
using System.Linq;

namespace Smad.Entities {

    [Serializable]
    public sealed class StatisticalSample : Filter {

        private int sampleSize;
        [Category("Amostra estatística")]
        [DisplayName("Tamanho da amostra")]
        [Description("A quantidade total de comentários presentes na amostra")]
        public int SampleSize { get { return sampleSize; } set { sampleSize = value; Changed(); } }

        public StatisticalSample() {
            Name = "Amostra estatística";
            IsEnabled = false;
        }

        public override void Apply(App app) {
            int[] sizes = new int[5];
            float[] pos = new float[5];

            for (int i = 0; i < 5; i++) {
                float posAux = sampleSize * (float)app.Comments.Where(a => a.Rating.Equals(i + 1)).Count() * 100 / app.Comments.Count / 100;
                sizes[i] = (int)posAux;
                pos[i] = posAux - sizes[i];
            }

            var diference = sampleSize - sizes.Sum();
            for (int i = 0; i < diference; i++) {
                var max = pos.Max();
                for (int j = 0; j < pos.Length; j++) {
                    if (max == pos[j]) {
                        sizes[j]++;
                        pos[j] = 0;
                        j = pos.Length;
                    }
                }
            }

            app.ProcessComments = new System.Collections.Generic.List<Comment>();
            foreach (var comment in app.Comments) {
                if (sizes[comment.Rating - 1] != 0) {
                    sizes[comment.Rating - 1]--;
                    app.ProcessComments.Add(comment);
                }
                if (sizes[0] == 0 && sizes[1] == 0 && sizes[2] == 0 && sizes[3] == 0 && sizes[4] == 0) {
                    break;
                }
            }

            //Obtém as informações de comentários.
            app.CommentsCout = app.ProcessComments.Count;
            app.Star1 = app.ProcessComments.Where(a => a.Rating.Equals(1)).Count();
            app.Star2 = app.ProcessComments.Where(a => a.Rating.Equals(2)).Count();
            app.Star3 = app.ProcessComments.Where(a => a.Rating.Equals(3)).Count();
            app.Star4 = app.ProcessComments.Where(a => a.Rating.Equals(4)).Count();
            app.Star5 = app.ProcessComments.Where(a => a.Rating.Equals(5)).Count();
            //Atualiza o painel de propriedades.
            if (Pages.MainPage.LayoutManager.GetPanelByType<PropertiesPanel>() is PropertiesPanel propertiesPanel) {
                propertiesPanel.PropertyGrid.Refresh();
            }
            //Atualiza o painel de comentários.
            if (Pages.MainPage.LayoutManager.GetPanelByType<CommentsPanel>() is CommentsPanel commentsPanel) {
                commentsPanel.UpdateContent();
            }
            //Atualizar nuvem de palavras
            if (Pages.MainPage.LayoutManager.GetPanelByType<WordCloudPanel>() is WordCloudPanel wordCloudPanel) {
                wordCloudPanel.UpdateContent();
            }
        }

        public override void Unapply(App app) {
            //Obtém todos os comentários existentes.
            app.ProcessComments = new System.Collections.Generic.List<Comment>();
            foreach (var comment in app.Comments) {
                app.ProcessComments.Add(comment);
            }
            //Obtém as informações de comentários.
            app.CommentsCout = app.ProcessComments.Count;
            app.Star1 = app.ProcessComments.Where(a => a.Rating.Equals(1)).Count();
            app.Star2 = app.ProcessComments.Where(a => a.Rating.Equals(2)).Count();
            app.Star3 = app.ProcessComments.Where(a => a.Rating.Equals(3)).Count();
            app.Star4 = app.ProcessComments.Where(a => a.Rating.Equals(4)).Count();
            app.Star5 = app.ProcessComments.Where(a => a.Rating.Equals(5)).Count();
            //Atualiza o painel de propriedades.
            if (Pages.MainPage.LayoutManager.GetPanelByType<PropertiesPanel>() is PropertiesPanel propertiesPanel) {
                propertiesPanel.PropertyGrid.Refresh();
            }
            //Atualiza o painel de comentários.
            if (Pages.MainPage.LayoutManager.GetPanelByType<CommentsPanel>() is CommentsPanel commentsPanel) {
                commentsPanel.UpdateContent();
            }
            //Atualizar nuvem de palavras
            if (Pages.MainPage.LayoutManager.GetPanelByType<WordCloudPanel>() is WordCloudPanel wordCloudPanel) {
                wordCloudPanel.UpdateContent();
            }
        }

        private void Changed() {
            //Informa falso para que aplique novamente o filtro.
            IsEnabled = false;
            //Registra uma mudança de propriedade.
            Pages.MainPage.ObjectSerializeManager.RegisterChanged();

            if (Pages.MainPage.LayoutManager.GetPanelByType<FilterPanel>() is FilterPanel filterPanel) {
                //Atualiza a lista de filtros.
                var a = filterPanel.ListView.Objects;
                filterPanel.ListView.Objects = null;
                filterPanel.ListView.Objects = a;
            }
        }
    }
}