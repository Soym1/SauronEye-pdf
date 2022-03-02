using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;
using PdfExtract;


namespace SauronEYE
{
   
    public partial class Form1 : Form
    {
        public class PdfFileInfo
        {
            public string Path { get; set; }
            public string FileName { get; set; }
            public string IndexedCharacters { get; set; }
            public string Size { get; set; }
            public string Content { get; set; }
            public string SoureFile2 { get; set; }

        }

        FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
        List<PdfFileInfo> Files = new List<PdfFileInfo>();
        CancellationTokenSource cancelFilter;

        ulong countFilePDF = 0;
        ulong countFileFound;
        int total = 0;
        public Form1()
        {
            InitializeComponent();

            listView.Scrollable = true;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Columns.Add("FileName", 100);
            listView.Columns.Add("Size", 100);
            listView.Columns.Add("Path", 200);
            listView.Columns.Add("Amout", 100);
            listView.Columns.Add("TotalWorld", 100);
            listView.View = View.Details;

            Time.Visible = false;
            FileFound.Visible = false;
            Total.Visible = false;


        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            textPath.Text = folderBrowser.SelectedPath;
        }
        // Search word
        Regex patternParser = new Regex("(\\\"[^\\\"]+\\\"|[\\S]+)");

        private void Filter_Work(string pattern)
        {

            List<Regex> filters = new List<Regex>();

            foreach (Match filter in patternParser.Matches(pattern))
            {
                filters.Add(new Regex(Regex.Escape(filter.Value.Trim('"')).Replace("\\?", ".?").Replace("\\*", ".*")));
            }
          
            listView.Items.Clear();

            foreach (PdfFileInfo info in Files)
            {
                total = 0;
                if (cancelFilter.Token.IsCancellationRequested)
                    return;

                if (!filters.Any())
                {
                    continue;
                }

                bool ok = true;

                foreach (Regex filter in filters)
                {
                    if (cancelFilter.Token.IsCancellationRequested)
                        return;

                    if (!filter.IsMatch(info.Content))
                    {
                        ok = false;
                        break;
                    }
                    else
                    {
                        total = Math.Max(filter.Matches(info.Content).Count, filter.Matches(info.SoureFile2).Count);
                    }
                }
                
                if (ok)
                {
                    countFileFound += 1;
                    string[] arr = new string[5];
                    ListViewItem itm;

                    arr[0] = info.FileName;
                    arr[1] = info.Size;
                    arr[2] = info.Path;
                    arr[3] = total.ToString();
                    arr[4] = info.IndexedCharacters;

                    itm = new ListViewItem(arr);
                    listView.Items.Add(itm);
                    
                }
            }
        }

        private void CreateIndex(string path)
        {


            string[] files = Directory.GetFiles(path, "*.pdf", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                
                countFilePDF += 1;
                FileInfo fi = new FileInfo(file);

                PdfFileInfo info = new PdfFileInfo();

                info.Path = file;
                info.FileName = fi.Name;
                info.Size = $"{fi.Length / 1024}k";

                try
                {
                    using (var pdfStream = File.OpenRead(file))
                    using (var extractor = new Extractor())
                    {
                        info.SoureFile2 = extractor.ExtractToString(pdfStream).ToLower();
                    }
                        /*info.Content = extractor.ExtractToString(pdfStream).ToLower();
                        //Files.Add(info);
                    }
                }
                catch { }*/
           
                    using (var extractor = new Extractor())
                    {
                        // Choose languages
                        var Ocr = new IronTesseract();
                        Ocr.Language = OcrLanguage.English;
                        Ocr.Language = OcrLanguage.Russian;
             

                        using (var Input = new OcrInput(file))
                        {
                            // Input.DeNoise(); // fixes digital noise and poor scanning
                            // Input.Deskew();  // fixes rotation and perspective
                            var Result = Ocr.Read(Input);
                            info.Content = Result.Text.ToLower();
                        }
                        char[] delimiters = new char[] { ' ', '\r', '\n' };
                        info.IndexedCharacters = info.Content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length.ToString();
                        Files.Add(info);
                    }
                }
                catch { }
                   


            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FileBox.Visible = false;
            TotalBox.Visible = false;
            TimeBox.Visible = false;
            Time.Visible = false;
            FileFound.Visible = false;
            Total.Visible = false;

            listView.Clear();

            listView.Scrollable = true;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Columns.Add("FileName", 100);
            listView.Columns.Add("Size", 100);
            listView.Columns.Add("Path", 200);
            listView.Columns.Add("Amout", 100);
            listView.Columns.Add("TotalWorld", 100);
            listView.View = View.Details;
            Stopwatch sw = new Stopwatch();
            Files.Clear();

            sw.Start();
            countFilePDF = 0;
            countFileFound = 0;
            string path = textPath.Text;

            if (path == "")
            {
                MessageBox.Show("Please choose your path!");
                return;
            }

            if (textFW.Text == "")
            {
                MessageBox.Show("Please write something!");
                return;
            }

            if (!Directory.Exists(path))
            {
                MessageBox.Show("Selected Directory does not exist!");
                return;
            }


            CreateIndex(path);

            string pattern = textFW.Text.ToLower();
            cancelFilter = new CancellationTokenSource();
            Filter_Work(pattern);

           

            TimeSpan ts = sw.Elapsed;
            sw.Stop();
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            TimeBox.Text = elapsedTime.ToString();
            Time.Visible = true;
            FileFound.Visible = true;
            Total.Visible = true;
            FileBox.Visible = true;
            TotalBox.Visible = true;
            TimeBox.Visible = true;
            FileBox.Text = countFilePDF.ToString();
            TotalBox.Text = countFileFound.ToString();
        }

      
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                System.Diagnostics.Process.Start(listView.SelectedItems[0].SubItems[2].Text);
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                System.Diagnostics.Process.Start(listView.SelectedItems[0].SubItems[2].Text);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            
            listView.Items.Clear();
            FileBox.Visible = false;
            TotalBox.Visible = false;
            TimeBox.Visible = false;
            Time.Visible = false;
            FileFound.Visible = false;
            Total.Visible = false;
        }
    }
}
