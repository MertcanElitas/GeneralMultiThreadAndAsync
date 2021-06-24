using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLinqCancelTokenForm
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cts;
        public Form1()
        {
            InitializeComponent();
            cts = new CancellationTokenSource();
        }

        private static bool Hesapla(int item)
        {
            Thread.SpinWait(500000);
            return item % 12 == default(int);
        }

        private void btn_Baslat_Click(object sender, EventArgs e)
        {
            var data = Enumerable.Range(1, 10000);

            Task.Run(() =>
            {
                try
                {
                    data.AsParallel().Where(Hesapla)
                .WithCancellation(cts.Token)
               .ToList()
               .ForEach(x =>
               {
                   Thread.Sleep(100);
                   cts.Token.ThrowIfCancellationRequested();
                   listBox1.Invoke((MethodInvoker)delegate { listBox1.Items.Add(x); });
                   Console.WriteLine(x);
               });
                }
                catch (OperationCanceledException ex)
                {
                    MessageBox.Show("İşlem İptal Edildi");
                }
                catch (Exception ex1)
                {

                    throw;
                }

            });

        }

        private void bnt_Bitir_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
