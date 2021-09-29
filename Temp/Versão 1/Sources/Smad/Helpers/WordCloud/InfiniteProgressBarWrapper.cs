using System.Windows.Forms;

namespace Smad.Helpers.WordCloud {

    internal class InfiniteProgressBarWrapper : ProgressBarWrapper {

        public InfiniteProgressBarWrapper(ToolStripProgressBar toolStripProgressBar) : base(toolStripProgressBar) { }
        public InfiniteProgressBarWrapper(ProgressBar toolStripProgressBar) : base(toolStripProgressBar) { }

        public override int Maximum {
            get { return 10000; }
            set {
                //base.Maximum = value;
            }
        }

        public override void Increment(int increment) {
            if (Value + increment > Maximum) {
                Value = 0;
            }
            base.Increment(increment);
        }
    }
}