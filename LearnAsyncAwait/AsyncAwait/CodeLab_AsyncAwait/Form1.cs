using CodeLab_AsyncAwait.Service;
using Microsoft.VisualBasic;

namespace CodeLab_AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            lbInfo.Text = "";
        }

        private void btDownload1_Click(object sender, EventArgs e)
        {
            var downloader = new NasaBlueMarbleDownloader();

            lbInfo.Text = "After you started the download, ... try to check/uncheck the checkbox.";
            var dialogResult = MessageBox.Show("Click OK to start.");
            if (dialogResult == DialogResult.OK)
            {

                var s = downloader.Download1();

                lbInfo.Text = s;
            }
            MessageBox.Show("Were you able to check/uncheck the checkbox during the download ?", "Question : ", MessageBoxButtons.YesNo);

        }

        private async void btDownload2_Click(object sender, EventArgs e)
        {
            var downloader = new NasaBlueMarbleDownloader();

            lbInfo.Text = "After you started the download, ... try to check/uncheck the checkbox.";
            var dialogResult = MessageBox.Show("Click OK to start.");
            if (dialogResult == DialogResult.OK)
            {

                var s = await downloader.Download4();

                lbInfo.Text = s;
            }
            MessageBox.Show("Were you able to check/uncheck the checkbox during the download ?", "Question : ", MessageBoxButtons.YesNo);

        }
    }
}