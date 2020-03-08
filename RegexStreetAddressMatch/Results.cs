using System;
using System.Windows.Forms;

namespace RegexStreetAddressMatch
{
    public partial class Results : Form
    {
        private int count;
        private string result;
        public Results(int count, string result)
        {
            InitializeComponent();
            this.count = count;
            this.result = result;
        }

        private void Results_Load(object sender, EventArgs e)
        {
            CountLabel.Text = Convert.ToString(this.count);
            ResultTextBox.Text = this.result;
        }
    }
}
