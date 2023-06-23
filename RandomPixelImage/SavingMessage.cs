using System.Windows.Forms;

namespace RandomPixelImage
{
    public partial class SavingMessage : Form
    {
        public int Value;
        public SavingMessage()
        {
            InitializeComponent();
            Progress(0);
        }
        public void Progress(int Progress)
        {
            Value += Progress;
            double ProgressPercentage = Progress / 100;
            ProgressPanel.Width = (int)(ProgressPercentage * ProgressBarContainer.Width);
        }
        //public void Start() => Value = 0;
        private void SavingMessage_Load(object sender, System.EventArgs e)
        {

        }
    }
}
