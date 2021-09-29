using System.Windows.Forms;

namespace Smad.Pages.Panels.Automatic {

    public partial class DefaultInforPanel : UserControl {

        public DefaultInforPanel() {
            InitializeComponent();

            var palette = MasterPage.LayoutManager.GetTheme().DockContentColorPalette;
            AppNameLabel.ForeColor = palette.TextColor;
            RatingLabel.ForeColor = palette.TextColor;
            EvaluationCountLabel.ForeColor = palette.TextColor;
            CategoryLabel.ForeColor = palette.TextColor;
        }

        private void DefaultInforPanel_Load(object sender, System.EventArgs e) {
            var experiment = MasterPage.ObjectSerializeManager.Object;

            IconImage.Image = experiment.Apps[0].Icon;
            AppNameLabel.Text = experiment.Apps[0].Name;
            RatingLabel.Text = $"Classificação de estrela: {experiment.Apps[0].StarRating}";
            EvaluationCountLabel.Text = $"Quantidade de comentários: {experiment.Apps[0].Comments.Count}";
            CategoryLabel.Text = "Categoria: Jogo educacional";

            Microsoft.Scripting.Hosting.ScriptEngine pythonEngine = IronPython.Hosting.Python.CreateEngine();
            Microsoft.Scripting.Hosting.ScriptSource pythonScript = pythonEngine.CreateScriptSourceFromString(Properties.Resources.hello);
            pythonScript.Execute();
        }
    }
}