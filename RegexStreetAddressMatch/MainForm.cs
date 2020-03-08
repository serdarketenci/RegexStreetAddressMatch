using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexStreetAddressMatch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FindStreetAddressButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SourceTextBox.Text) == true)
            {
                MessageBox.Show("Data is empty");
                return;
            }

            var addresses = RegexUtilities.FindStreetAddress(SourceTextBox.Text);
            //var messageBoxValue = string.Format("Count: {0} {1} {2}", Convert.ToString(addresses.Count), Environment.NewLine, String.Join(Environment.NewLine, addresses.ToArray()));
            //MessageBox.Show(messageBoxValue);
            Results resultForm = new Results(addresses.Count, String.Join(Environment.NewLine, addresses.ToArray()));
            resultForm.Show();
        }

        private void GetHTMLButton_Click(object sender, EventArgs e)
        {
            string urlAddress = URLTextBox.Text;

            if (RegexUtilities.IsValidURL(urlAddress) == false)
            {
                MessageBox.Show("Invalid URL Format");
                return;
            }

            try
            {
                // using System.Net;
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                // Use SecurityProtocolType.Ssl3 if needed for compatibility reasons

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (String.IsNullOrWhiteSpace(response.CharacterSet))
                        readStream = new StreamReader(receiveStream);
                    else
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

                    string data = readStream.ReadToEnd();

                    response.Close();
                    readStream.Close();

                    SourceTextBox.Text = RegexUtilities.FindTextFromHTML(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void ClearSourceButton_Click(object sender, EventArgs e)
        {
            SourceTextBox.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
