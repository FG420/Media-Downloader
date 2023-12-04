using AngleSharp;
using System.Net.Http;
using System.IO;
using MediaToolkit.Model;
using MediaToolkit;
using VideoLibrary;

namespace MediaDownloaderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnDownload.Click += BtnDownload_Click;
            this.btnBrowse.Click += BtnBrowse_Click;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        private void BtnBrowse_Click(object? sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBoxBrowse.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void BtnDownload_Click(object? sender, EventArgs e)
        {
            String url = this.textBoxUrl.Text;
            String folder = this.textBoxBrowse.Text;
            String filename = this.textBoxFilename.Text;

            DownloadMedia(url, folder, filename);

        }

        private void DownloadMedia(string url, string folder, string filename)
        {
            try
            {
                var source = folder;
                var youtube = YouTube.Default;
                var vid = youtube.GetVideo(url);
                File.WriteAllBytes(source + vid.FullName, vid.GetBytes());

                var inputFile = new MediaFile { Filename = source + vid.FullName };
                var outputFile = new MediaFile { Filename = $"{filename}.mp3" };

                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);

                    // Aggiungi l'evento ConvertProgressEvent per aggiornare la ProgressBar
                    engine.ConvertProgressEvent += (sender, args) =>
                    {
                        // Calcola la percentuale di completamento
                        var progressPercentage = (int)((args.ProcessedDuration.Ticks * 100) / args.TotalDuration.Ticks);

                        // Aggiorna la ProgressBar
                        progressBar1.Value = progressPercentage;
                    };

                    // Esegui la conversione del file
                    engine.Convert(inputFile, outputFile);

                    // Ripristina la ProgressBar al valore massimo quando la conversione è completata
                    progressBar1.Value = progressBar1.Maximum;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}



/* var config = Configuration.Default.WithDefaultLoader();
 var context = BrowsingContext.New(config);

 // Fetch the HTML document from the provided URL
 var document = await context.OpenAsync(url);

 // Extract the direct URL to the mp3 file from the HTML document
 //var mp3Url = document.QuerySelector("source[type='audio/mpeg']").GetAttribute("src");
 if (document != null)
 {
     var mp3Element = document.QuerySelector("source[type='mp3/mp4']");
     if (mp3Element != null)
     {
         var mp3Url = mp3Element.GetAttribute("src");

         // Download the mp3 file using HttpClient
         using (var httpClient = new HttpClient())
         {
             var response = await httpClient.GetAsync(mp3Url);
             response.EnsureSuccessStatusCode();

             // Save the mp3 file to the local disk
             using (var fileStream = File.Create(filename))
             {
                 await response.Content.CopyToAsync(fileStream);
             }
         }
     }
     else
     {
         MessageBox.Show("The media doesn't exixt", "Ops!", MessageBoxButtons.OK);
     }

 } */