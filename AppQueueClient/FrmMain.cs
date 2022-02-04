using AppQueueClient.Models;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQueueClient
{
    public partial class FrmMain : Form
    {
        private readonly string _baseUri = "https://localhost:44329/api/";
        private BackgroundWorker _backgroundWorker;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            _backgroundWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

            _backgroundWorker.DoWork += backgroundWorker_DoWorkImportacao;
            _backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompletedImportacao;
            _backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWorkImportacao(object sender, DoWorkEventArgs e)
        {
            var sales = SalesFake.ListSalesFake(50000);
            foreach (var item in sales)
            {
                if (_backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                Invoke((MethodInvoker)delegate
                {
                    dgvMain.Rows.Insert(0,
                    item.Cardnumber,
                    item.Cvv,
                    item.Name,
                    item.Amount,
                    item.Transaction,
                    false);

                    ConsumeApi(item, dgvMain.Rows.Count - 1);
                    dgvMain.Refresh();
                });
            }
        }

        private void backgroundWorker_RunWorkerCompletedImportacao(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show("Vendas paradas...");
        }

        private void ConsumeApi(Sales sales, int index)
        {
            var salesReq = JsonConvert.SerializeObject(sales, Formatting.Indented);
            HttpContent content = new StringContent(salesReq, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            Task taskUpload = httpClient.PostAsync(_baseUri + "payments", content).ContinueWith(task =>
            {
                if (task.Status == TaskStatus.RanToCompletion)
                {
                    var response = task.Result;

                    if (!_backgroundWorker.CancellationPending && response.IsSuccessStatusCode)
                        dgvMain["PROCESSED", index].Value = true;
                }
            });
        }

        private void btnPararVendas_Click(object sender, EventArgs e)
        {
            _backgroundWorker.CancelAsync();
        }
    }
}
