using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCancelToken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CancellationTokenSource cancelToken = new CancellationTokenSource();

        private async void btnBaslat_Click(object sender, EventArgs e)
        {

            Task<HttpResponseMessage> myTask;
            try
            {
                myTask = new HttpClient().GetAsync("https://localhost:44336/api/Home/GetContent", cancelToken.Token);

                await myTask;

                var content = await myTask.Result.Content.ReadAsStringAsync();

                richTextBox1.Text = content;
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem iptal edildi");
            }
            
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            cancelToken.Cancel();
        }
    }
}
