using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections.Generic;
using LiveCharts.Wpf;
using LiveCharts;
using System.Drawing;
using System.Drawing.Imaging;
using Xceed.Words.NET;
using System.Linq;
using MetroFramework.Forms;
using GemBox.Document;

namespace JovenSystems
{
    public partial class MainApp : MetroForm
    {
        WebClient wc;
        StreamReader sr;
        List<string[]> dataset;
        List<string> countries;
        Dictionary<string, Dictionary<DateTime, int>> confirmed;
        Dictionary<string, Dictionary<DateTime, int>> recoveries;
        Dictionary<string, Dictionary<DateTime, int>> deaths;
        Dictionary<string, Dictionary<DateTime, int>> incConfirmed;
        Dictionary<string, Dictionary<DateTime, int>> incRecoveries;
        Dictionary<string, Dictionary<DateTime, int>> incDeaths;
        HashSet<DateTime> dates;
        int numConfirmed = 0;
        int numRecoveries = 0;
        int deathCount = 0;
        int numRows = 0;
        string username;
        string password;
        string reportsPath;
        string filePath;
        string picturePath;

        public MainApp(string username, string password)
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            InitDirectories();
            InitCred();
            LoadData();
            LoadCountries();
            LoadConfirmed();
            LoadRecoveries();
            LoadDeaths();
            LoadIncConfirmed();
            LoadIncRecovs();
            LoadIncDeaths();
            InitDates();
            countryBox.SelectedIndex = 0;
            startDateBox.SelectedIndex = 0;
            endDateBox.SelectedIndex = endDateBox.Items.Count - 1;
            this.ActiveControl = processBtn;
        }



        private void InitDirectories()
        {
            reportsPath = $"{Application.StartupPath}\\Reports";
            filePath = $"{Application.StartupPath}\\DataMiningFile";
            picturePath = $"{Application.StartupPath}\\Pictures\\";
            Directory.CreateDirectory(reportsPath);
            Directory.CreateDirectory(filePath);
            Directory.CreateDirectory(picturePath);
        }

        private void LoadIncDeaths()
        {
            incDeaths = new Dictionary<string, Dictionary<DateTime, int>>();
            foreach (var country in countries)
            {
                Dictionary<DateTime, int> d = new Dictionary<DateTime, int>();
                foreach (var data in dataset)
                {
                    if (data[0] == country)
                    {
                        d.Add(DateTime.Parse(data[2]), int.Parse(data[7]));
                    }
                }
                incDeaths.Add(country, d);
            }
        }

        private void LoadIncConfirmed()
        {
            incConfirmed = new Dictionary<string, Dictionary<DateTime, int>>();
            foreach (var country in countries)
            {
                Dictionary<DateTime, int> d = new Dictionary<DateTime, int>();
                foreach (var data in dataset)
                {
                    if (data[0] == country)
                    {
                        d.Add(DateTime.Parse(data[2]), int.Parse(data[6]));
                    }
                }
                incConfirmed.Add(country, d);
            }
        }

        private void LoadIncRecovs()
        {
            incRecoveries = new Dictionary<string, Dictionary<DateTime, int>>();
            foreach (var country in countries)
            {
                Dictionary<DateTime, int> d = new Dictionary<DateTime, int>();
                foreach (var data in dataset)
                {
                    if (data[0] == country)
                    {
                        d.Add(DateTime.Parse(data[2]), int.Parse(data[8]));
                    }
                }
                incRecoveries.Add(country, d);
            }
        }

        private static Bitmap DrawControlToBitMap(Control control)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Rectangle rect = control.RectangleToScreen(control.ClientRectangle);
            graphics.CopyFromScreen(rect.Location, Point.Empty, control.Size);
            return bitmap;
        }

        private void LoadDeaths()
        {
            deaths = new Dictionary<string, Dictionary<DateTime, int>>();
            foreach (var country in countries)
            {
                Dictionary<DateTime, int> d = new Dictionary<DateTime, int>();
                foreach (var data in dataset)
                {
                    if (data[0] == country)
                    {
                        d.Add(DateTime.Parse(data[2]), int.Parse(data[4]));
                    }
                }
                deaths.Add(country, d);
            }
        }

        private void LoadRecoveries()
        {
            recoveries = new Dictionary<string, Dictionary<DateTime, int>>();
            foreach(var country in countries)
            {
                Dictionary<DateTime, int> d = new Dictionary<DateTime, int>();
                foreach (var data in dataset)
                {
                    if(data[0] == country)
                    {
                        d.Add(DateTime.Parse(data[2]), int.Parse(data[5]));
                    }
                }
                recoveries.Add(country, d);
            }
        }

        private void InitDates()
        {
            dates = new HashSet<DateTime>();
            foreach(var data in confirmed)
            {
                foreach(var day in data.Value)
                {
                    dates.Add(day.Key);
                }
            }

            foreach(var date in dates)
            {
                startDateBox.Items.Add(date);
                endDateBox.Items.Add(date);
            }    
        }

        private void LoadConfirmed()
        {
            confirmed = new Dictionary<string, Dictionary<DateTime, int>>();
            foreach(var country in countries)
            {
                Dictionary<DateTime, int> d = new Dictionary<DateTime, int>();
                foreach(var data in dataset)
                {
                    if(data[0] == country)
                    {
                        d.Add(DateTime.Parse(data[2]), int.Parse(data[3]));
                    }
                }
                confirmed.Add(country, d);
            }
        }

        private void LoadCountries()
        {
            HashSet<string> cHash = new HashSet<string>();
            countries = new List<string>();

            foreach(var data in dataset)
            {
                cHash.Add(data[0]);
            }

            foreach(var c in cHash)
            {
                countries.Add(c);
            }

            countries.Sort();

            foreach(var country in countries)
            {
                countryBox.Items.Add(country);
            }
        }

        private void LoadData()
        {
            sr = new StreamReader($"{filePath}\\CovidFiles.csv");
            dataset = new List<string[]>();

            sr.ReadLine();

            while(sr.Peek() != -1)
            {
                dataset.Add(sr.ReadLine().Split(','));
            }

            sr.Close();
        }

        private void InitCred()
        {
            wc = new WebClient();
            wc.Credentials = new NetworkCredential(username, password);
            wc.DownloadFile("ftp://66.220.9.50/Data Mining File/CovidFiles.csv", $"{filePath}\\CovidFiles.csv");
        }

        private void ProcessData(object sender, EventArgs e)
        {
            numConfirmed = 0;
            deathCount = 0;
            numRecoveries = 0;
            numRows = 0;
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart2.Series.Clear();
            cartesianChart2.AxisX.Clear();
            foreach(var data in confirmed)
            {
                if(countryBox.Text == data.Key)
                {
                    ChartValues<int> confirmedCases = new ChartValues<int>();
                    List<string> dates = new List<string>();
                    foreach(var day in data.Value)
                    {
                        if(DateTime.Parse(startDateBox.Text) <= day.Key && DateTime.Parse(endDateBox.Text) >= day.Key)
                        {
                            confirmedCases.Add(day.Value);
                            numConfirmed = day.Value;
                            dates.Add(day.Key.ToString());
                            numRows++;
                        }
                    }
                    numRows++;
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Title = "Confirmed",
                        Values = confirmedCases,
                    });
                    cartesianChart1.AxisX.Add(new Axis
                    {
                        Title = "Days",
                        Labels = dates
                    });
                }
            }
            foreach(var data in recoveries)
            {
                if(countryBox.Text == data.Key)
                {
                    ChartValues<int> numRecovs = new ChartValues<int>();
                    foreach(var day in data.Value)
                    {
                        if(DateTime.Parse(startDateBox.Text) <= day.Key && DateTime.Parse(endDateBox.Text) >= day.Key)
                        {
                            numRecovs.Add(day.Value);
                            numRecoveries = day.Value;
                        }
                    }
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Title = "Recoveries",
                        Values = numRecovs
                    });
                }
            }
            foreach (var data in deaths)
            {
                if (countryBox.Text == data.Key)
                {
                    ChartValues<int> numDeaths = new ChartValues<int>();
                    foreach (var day in data.Value)
                    {
                        if (DateTime.Parse(startDateBox.Text) <= day.Key && DateTime.Parse(endDateBox.Text) >= day.Key)
                        {
                            numDeaths.Add(day.Value);
                            deathCount = day.Value;
                        }
                    }
                    cartesianChart1.Series.Add(new LineSeries
                    {
                        Title = "Deaths",
                        Values = numDeaths
                    });
                }
            }
            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = "Confirmed",
                Values = new ChartValues<int> {numConfirmed }
            });
            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = "Recoveries",
                Values = new ChartValues<int> { numRecoveries }
            });
            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = "Deaths",
                Values = new ChartValues<int> { deathCount }
            });
            cartesianChart2.AxisX.Add(new Axis
            {
                Title = "Cases of Covid-19",
                Labels = new[] {$"{countryBox.Text} Cases"}
            });
            cartesianChart1.LegendLocation = LegendLocation.Right;
            cartesianChart2.LegendLocation = LegendLocation.Bottom;
            saveBtn.Enabled = true;
        }
        private void SaveReport(object sender, EventArgs e)
        {
            Bitmap bmpStats = DrawControlToBitMap(cartesianChart1);
            Bitmap bmpBar = DrawControlToBitMap(cartesianChart2);
            cartesianChart1.DrawToBitmap(bmpStats, new Rectangle(0, 0, bmpStats.Width, bmpStats.Height));
            cartesianChart2.DrawToBitmap(bmpBar, new Rectangle(0, 0, bmpBar.Width, bmpBar.Height));
            foreach(var country in countries)
            {
                if(countryBox.Text == country)
                {
                    int fontSize = 12;
                    int fontTitleSize = 16;
                    string font = "Calibri";
                    bmpStats.Save($"{picturePath}{country}_stats.png", ImageFormat.Png);
                    bmpBar.Save($"{picturePath}{country}_bar.png", ImageFormat.Png);
                    var doc = DocX.Create($"{reportsPath}\\{country} Report.docx");
                    string title = $"{country} Covid-19 Report from {startDateBox.Text} to {endDateBox.Text}";

                    Xceed.Document.NET.Formatting titleFormat = new Xceed.Document.NET.Formatting();
                    titleFormat.FontFamily = new Xceed.Document.NET.Font(font);
                    titleFormat.Size = fontTitleSize;

                    Xceed.Document.NET.Paragraph repTitle = doc.InsertParagraph(title, false, titleFormat);
                    repTitle.Alignment = Xceed.Document.NET.Alignment.center;

                    Xceed.Document.NET.Image imgStats = doc.AddImage($"{picturePath}{country}_stats.png");
                    Xceed.Document.NET.Picture statsPic = imgStats.CreatePicture();
                    statsPic.Width = 500;
                    statsPic.Height = 200;

                    Xceed.Document.NET.Paragraph statsPar = doc.InsertParagraph();
                    statsPar.AppendPicture(statsPic);

                    Xceed.Document.NET.Table table1 = doc.AddTable(3, 2);
                    table1.Alignment = Xceed.Document.NET.Alignment.center;

                    Xceed.Document.NET.Formatting table1Format = new Xceed.Document.NET.Formatting();
                    table1Format.FontFamily = new Xceed.Document.NET.Font(font);
                    table1Format.Size = fontTitleSize;
                    doc.InsertParagraph("General Stats ", false, table1Format).Alignment = Xceed.Document.NET.Alignment.center;

                    Xceed.Document.NET.Image imgBar = doc.AddImage($"{picturePath}{country}_bar.png");
                    Xceed.Document.NET.Picture barPic = imgBar.CreatePicture();
                    barPic.Width = 200;
                    barPic.Height = 200;

                    Xceed.Document.NET.Paragraph barPar = doc.InsertParagraph();
                    barPar.AppendPicture(barPic).Alignment = Xceed.Document.NET.Alignment.center;

                    table1.Rows[0].Cells[0].Paragraphs.First().Append("Confirmed Cases: ").Font(font).FontSize(fontSize);
                    table1.Rows[1].Cells[0].Paragraphs.First().Append("Number of Recoveries: ").Font(font).FontSize(fontSize);
                    table1.Rows[2].Cells[0].Paragraphs.First().Append("Number of Deaths: ").Font(font).FontSize(fontSize);
                    table1.Rows[0].Cells[1].Paragraphs.First().Append(numConfirmed.ToString()).Font(font).FontSize(fontSize);
                    table1.Rows[1].Cells[1].Paragraphs.First().Append(numRecoveries.ToString()).Font(font).FontSize(fontSize);
                    table1.Rows[2].Cells[1].Paragraphs.First().Append(deathCount.ToString()).Font(font).FontSize(fontSize);
                    doc.InsertTable(table1);
                    doc.InsertParagraph(" ");

                    Xceed.Document.NET.Formatting table2Format = new Xceed.Document.NET.Formatting();
                    table2Format.FontFamily = new Xceed.Document.NET.Font(font);
                    table2Format.Size = fontTitleSize;
                    doc.InsertParagraph($"Complete Stats of Covid-19 in {country}", false, table2Format).Alignment = Xceed.Document.NET.Alignment.left;
                    doc.InsertParagraph(" ");

                    Xceed.Document.NET.Table table2 = doc.AddTable(numRows, 7);
                    table2.Alignment = Xceed.Document.NET.Alignment.left;
                    table2.Rows[0].Cells[0].Paragraphs.First().Append("Dates").Font(font).FontSize(fontSize);
                    table2.Rows[0].Cells[1].Paragraphs.First().Append("Confirmed Cases").Font(font).FontSize(fontSize);
                    table2.Rows[0].Cells[2].Paragraphs.First().Append("Recoveries").Font(font).FontSize(fontSize);
                    table2.Rows[0].Cells[3].Paragraphs.First().Append("Deaths").Font(font).FontSize(fontSize);
                    table2.Rows[0].Cells[4].Paragraphs.First().Append("Number of Increase in Confirmed Cases").Font(font).FontSize(fontSize);
                    table2.Rows[0].Cells[5].Paragraphs.First().Append("Number of Increase in Recoveries").Font(font).FontSize(fontSize);
                    table2.Rows[0].Cells[6].Paragraphs.First().Append("Number of Increase in Deaths").Font(font).FontSize(fontSize);

                    foreach(var data in confirmed)
                    {
                        if(country == data.Key)
                        {
                            int i = 1;
                            foreach(var day in data.Value)
                            {
                                if(DateTime.Parse(startDateBox.Text) <= day.Key && DateTime.Parse(endDateBox.Text) >= day.Key)
                                {
                                    table2.Rows[i].Cells[0].Paragraphs.First().Append(day.Key.ToShortDateString()).Font(font).FontSize(fontSize);
                                    table2.Rows[i].Cells[1].Paragraphs.First().Append(day.Value.ToString()).Font(font).FontSize(fontSize);
                                    i++;
                                }
                            }
                        }
                    }

                    foreach (var data in recoveries)
                    {
                        if (country == data.Key)
                        {
                            int i = 1;
                            foreach (var day in data.Value)
                            {
                                if (DateTime.Parse(startDateBox.Text) <= day.Key && DateTime.Parse(endDateBox.Text) >= day.Key)
                                {
                                    table2.Rows[i].Cells[2].Paragraphs.First().Append(day.Value.ToString()).Font(font).FontSize(fontSize);
                                    i++;
                                }
                            }
                        }
                    }

                    foreach (var data in deaths)
                    {
                        if (country == data.Key)
                        {
                            int i = 1;
                            foreach (var day in data.Value)
                            {
                                if (DateTime.Parse(startDateBox.Text) <= day.Key && DateTime.Parse(endDateBox.Text) >= day.Key)
                                {
                                    table2.Rows[i].Cells[3].Paragraphs.First().Append(day.Value.ToString()).Font(font).FontSize(fontSize);
                                    i++;
                                }
                            }
                        }
                    }

                    foreach (var data in incConfirmed)
                    {
                        if (country == data.Key)
                        {
                            int i = 1;
                            foreach (var day in data.Value)
                            {
                                if (DateTime.Parse(startDateBox.Text) <= day.Key && DateTime.Parse(endDateBox.Text) >= day.Key)
                                {
                                    table2.Rows[i].Cells[4].Paragraphs.First().Append(day.Value.ToString()).Font(font).FontSize(fontSize);
                                    i++;
                                } 
                            }
                        }
                    }

                    foreach (var data in incRecoveries)
                    {
                        if (country == data.Key)
                        {
                            int i = 1;
                            foreach (var day in data.Value)
                            {
                                if (DateTime.Parse(startDateBox.Text) <= day.Key && DateTime.Parse(endDateBox.Text) >= day.Key)
                                {
                                    table2.Rows[i].Cells[5].Paragraphs.First().Append(day.Value.ToString()).Font(font).FontSize(fontSize);
                                    i++;
                                }
                            }
                        }
                    }

                    foreach (var data in incDeaths)
                    {
                        if (country == data.Key)
                        {
                            int i = 1;
                            foreach (var day in data.Value)
                            {
                                if (DateTime.Parse(startDateBox.Text) <= day.Key && DateTime.Parse(endDateBox.Text) >= day.Key)
                                {
                                    table2.Rows[i].Cells[6].Paragraphs.First().Append(day.Value.ToString()).Font(font).FontSize(fontSize);
                                    i++;
                                }
                            }
                        }
                    }
                    table2.Alignment = Xceed.Document.NET.Alignment.left;
                    doc.InsertTable(table2);

                    doc.Save();
                    MessageBox.Show($"File saved at {reportsPath}\\{country} Report.docx.\nChoose either to Upload or Reset the Report", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            processBtn.Enabled = false;
            saveBtn.Enabled = false;
            uploadBtn.Enabled = true;
            resetBtn.Enabled = true;
            countryBox.Enabled = false;
            startDateBox.Enabled = false;
            endDateBox.Enabled = false;
        }

        private void UploadToCloud(object sender, EventArgs e)
        {
            try
            {
                foreach (var country in countries)
                {
                    if (country == countryBox.Text)
                    {
                        wc.UploadFile($"ftp://66.220.9.50/Reports/ {country} Report.docx", $"{reportsPath}\\{country} Report.docx");
                        MessageBox.Show("Report Uploaded Successfully in the Cloud Server", "Upload Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error while sending.\n Please close first word document before sending to the server.", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void Reset(object sender, EventArgs e)
        {
            numRows = 0;
            processBtn.Enabled = true;
            uploadBtn.Enabled = false;
            resetBtn.Enabled = false;
            countryBox.Enabled = true;
            startDateBox.Enabled = true;
            endDateBox.Enabled = true;
            MessageBox.Show("App Restarted", "App Reset Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void PrintReport(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document document = app.Documents.Open($"{reportsPath}\\{countryBox.Text} Report.docx");
            document.Activate();
            document.PrintOut();
        }
    }
}
