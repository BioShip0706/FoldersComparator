using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace FoldersComparer
{
    public partial class Form1 : Form
    {
        private NumericUpDown numericUpDown;
        private CheckBox checkBoxLog;
        private string patternFilterOne = "*.*";
        private string patternFilterTwo = "*.*";



        public Form1()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //maxFilesSizeToolStripMenuItem.DropDownItems.Add(new ToolStripControlHost(new NumericUpDown()));
            sizeTypes.SelectedIndex = 1;
            filterOne.SelectedIndex = 2;
            filterTwo.SelectedIndex = 2;

            numericUpDown = new NumericUpDown();
            numericUpDown.Minimum = 0;
            numericUpDown.Maximum = ushort.MaxValue;
            numericUpDown.Value = 0;

            ToolStripControlHost numericUpDownHost = new ToolStripControlHost(numericUpDown);
            numericUpDownHost.Width = 100;
            numericUpDownHost.AutoSize = false;

            maxFilesSizeToolStripMenuItem.DropDownItems.Insert(1, numericUpDownHost);


            //checkbox

            checkBoxLog = new CheckBox();
            checkBoxLog.Text = "Print full directories on log";
            checkBoxLog.Checked = false;


            ToolStripControlHost checkBoxHost = new ToolStripControlHost(checkBoxLog);
            checkBoxHost.AutoSize = false;
            checkBoxHost.Width = 170;

            maxFilesSizeToolStripMenuItem.DropDownItems.Insert(2, checkBoxHost);


            numericUpDown.ValueChanged += new EventHandler(OnNumUpDownValueChanged);

        }

        private void OnNumUpDownValueChanged(object sender, EventArgs e)
        {
            //if (numericUpDown.Value > 21000)
            //{
            //    MessageBox.Show("Program isn't tested for files bigger than 10 gigabytes, program may take a long time or crash");
            //}

            if (numericUpDown.Value == 0)
            {
                rememberSize.Visible = true;
            }
            else
            {
                rememberSize.Visible = false;
            }
        }


        private void browseOne_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog finestraBrowse = new FolderBrowserDialog();
            finestraBrowse.Description = "Select a folder";
            finestraBrowse.ShowNewFolderButton = true;
            finestraBrowse.RootFolder = Environment.SpecialFolder.MyComputer; //starting folder

            if (finestraBrowse.ShowDialog() == DialogResult.OK)
            {
                folderOne.Text = finestraBrowse.SelectedPath; //set the value to 
            }

            if (folderOne.Text != String.Empty && folderTwo.Text != String.Empty && logDest.Text != String.Empty)
            {
                buttonAnalyze.Enabled = true;
                buttonSwap.Enabled = true;
            }
        }

        private void browseTwo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog finestraBrowse = new FolderBrowserDialog();
            finestraBrowse.Description = "Select a folder";
            finestraBrowse.ShowNewFolderButton = true;
            finestraBrowse.RootFolder = Environment.SpecialFolder.MyComputer; //starting folder

            if (finestraBrowse.ShowDialog() == DialogResult.OK)
            {
                folderTwo.Text = finestraBrowse.SelectedPath; //set the value to 
            }

            if (folderOne.Text != String.Empty && folderTwo.Text != String.Empty && logDest.Text != String.Empty)
            {
                buttonAnalyze.Enabled = true;
                buttonSwap.Enabled = true;
            }
        }

        private void browseLog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog finestraBrowse = new FolderBrowserDialog();
            finestraBrowse.Description = "Select a folder";
            finestraBrowse.ShowNewFolderButton = true;
            finestraBrowse.RootFolder = Environment.SpecialFolder.MyComputer; //starting folder

            if (finestraBrowse.ShowDialog() == DialogResult.OK)
            {
                logDest.Text = finestraBrowse.SelectedPath; //set the value to 
            }

            if (folderOne.Text != String.Empty && folderTwo.Text != String.Empty && logDest.Text != String.Empty)
            {
                buttonAnalyze.Enabled = true;
                buttonSwap.Enabled = true;
            }


        }

        private async void buttonAnalyze_Click(object sender, EventArgs e) //avoiding crashes and softlocks
        {
            buttonAnalyze.Enabled = false;
            buttonAnalyze.Text = "PLEASE WAIT";
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            folderOneCount.Visible = true;
            folderTwoCount.Visible = true;

            try
            {
                await Task.Run(() => CompareFolders());
            }
            finally
            {
                buttonAnalyze.Enabled = true;
                buttonAnalyze.Text = "COMPARE";
                //folderOneCount.Text = String.Empty;
                //folderTwoCount.Text = String.Empty;
                // progressBar1.Visible = false;
                progressBar1.Visible = false;

                folderOneCount.Visible = false;
                folderTwoCount.Visible = false;
            }


        }

        private void CompareFolders()
        {
            if (numericUpDown.Value == 0)
            {
                MessageBox.Show("Set the Max file size to consider first (In Options)");
                return;
            }
            folderFilter();

            string folderOnePath = folderOne.Text;
            string folderTwoPath = folderTwo.Text;
            string folderLogPath = logDest.Text;

            string logFileContent = String.Empty;

            

            if (Directory.Exists(folderOnePath) && Directory.Exists(folderTwoPath) && Directory.Exists(folderLogPath))
            {
                MessageBox.Show("Starting comparation between folders....\nIt may take few minutes, check the progress bar");

                string[] filesFolderOne = Directory.GetFiles(folderOnePath, patternFilterOne, SearchOption.AllDirectories); //search all files in that path, with all extensions, in all directories
                string[] filesFolderTwo = Directory.GetFiles(folderTwoPath, patternFilterTwo, SearchOption.AllDirectories); //search all files in that path, with all extensions, in all directories

                //folderOneCount.Text = "Folder one files count: " + Convert.ToString(filesFolderOne.Length);
                //folderTwoCount.Text = "Folder two files count: " + Convert.ToString(filesFolderTwo.Length);


                this.Invoke((Action)(() =>
                {
                    folderOneCount.Text = "Folder one files count: " + filesFolderOne.Length;
                    folderTwoCount.Text = "Folder two files count: " + filesFolderTwo.Length;
                }));

                int totalComparisons = filesFolderOne.Length * filesFolderTwo.Length;
                this.Invoke((Action)(() => progressBar1.Maximum = totalComparisons));
                int barProgress = 0;

                int barUpdateInterval = totalComparisons / 30 ;

                HashSet<string> checkedFilesPaths = new HashSet<string>(); //store the files paths that were already matched

                for (int i = 0; i < filesFolderOne.Length; i++)
                {
                    barProgress++;

                    if (barProgress % barUpdateInterval == 0)
                    {
                        this.Invoke((Action)(() => progressBar1.Value = barProgress));
                    }

                    FileInfo fileInfoOne = new FileInfo(filesFolderOne[i]);
                    if (fileInfoOne.Length > numericUpDown.Value * 1024 * 1024) //  in bytes
                    {
                        continue; // Skip the file if larger than 10 MB
                    }

                    //byte[] fileDataOne = File.ReadAllBytes(filesFolderOne[i]);
                    //byte[] fileDataOne = ReadLargeFile(filesFolderOne[i]);
                    string fileOneHash = CalculateSHA256(filesFolderOne[i]);

                    for (int j = 0; j < filesFolderTwo.Length; j++)
                    {

                        barProgress++;

                        if (barProgress % barUpdateInterval == 0)
                        {
                            this.Invoke((Action)(() => progressBar1.Value = barProgress));
                        }


                        FileInfo fileInfoTwo = new FileInfo(filesFolderTwo[j]);
                        if (fileInfoTwo.Length > numericUpDown.Value * 1024 * 1024) //  in bytes
                        {
                            continue; // Skip the file if larger than 10 MB
                        }

                        if (checkedFilesPaths.Contains(filesFolderTwo[j]))
                        {
                            continue; //skip the file if it was already matched
                        }

                        if (fileInfoOne.Length != fileInfoTwo.Length)
                        {
                            continue; // skip if file sizes are different
                        }

                        if (fileInfoOne.Length == 0 || fileInfoTwo.Length == 0)
                        {
                            // Gestisci i file vuoti come necessario
                            continue; // Salta o gestisci i file vuoti
                        }

                        //byte[] fileDataTwo = File.ReadAllBytes(filesFolderTwo[j]);
                        //byte[] fileDataTwo = ReadLargeFile(filesFolderTwo[j]);

                        

                        string fileTwoHash = CalculateSHA256(filesFolderTwo[j]);


                        if (fileOneHash == fileTwoHash)
                        {
                            if (!checkBoxLog.Checked)
                            {
                                logFileContent += Path.GetFileName(filesFolderOne[i]) + " is the same as: " + Path.GetFileName(filesFolderTwo[j]) + "\n";
                            }
                            else
                            {
                                logFileContent += filesFolderOne[i] + " is the same as: " + filesFolderTwo[j] + "\n";
                            }
                            checkedFilesPaths.Add(filesFolderTwo[j]);
                            break;
                        }

                    }
                }

                //string logFileName = DateTime.Now.ToString("dd-MM-yy") + "-" + Path.GetDirectoryName(folderOnePath) + "-" + Path.GetDirectoryName(folderTwoPath);

                string folderOneName = Path.GetFileName(folderOnePath);
                string folderTwoName = Path.GetFileName(folderTwoPath);

                string logFileName = DateTime.Now.ToString("MM-dd-yy-HH--mm--ss") + "-" + folderOneName + "-" + folderTwoName + ".txt";

                string logFilePath = Path.Combine(folderLogPath, logFileName);

                //logFileContent = "Folder One filters: " + filterOne.Text + ": " + extensionOne.Text + "\n" +
                //                 "Folder Two filters: " + filterTwo.Text + ": " + extensionTwo.Text +
                //                 "\n------------------------------\n" +logFileContent;

                //logFileContent = "Folder One directory: " + folderOnePath + "\n" +
                //                 "Folder Two directory: " + folderTwoPath + "\n" +
                //                 "Folder One filters| " +
                //                 (enableFilterOne.Checked ? filterOne.Text + ": " + extensionOne.Text : "NO FILTERS") +
                //                 "\nFolder Two filters| " +
                //                 (enableFilterTwo.Checked ? filterTwo.Text + ": " + extensionTwo.Text : "NO FILTERS") +
                //                 "\n------------------------------\n" + logFileContent;


                try
                {
                    if (!string.IsNullOrEmpty(logFileContent))
                    {
                        logFileContent = "Folder One directory: " + folderOnePath + "\n" +
                                 "Folder Two directory: " + folderTwoPath + "\n" +
                                 "Folder One filters| " +
                                 (enableFilterOne.Checked ? filterOne.Text + " " + extensionOne.Text : "NO FILTERS") +
                                 "\nFolder Two filters| " +
                                 (enableFilterTwo.Checked ? filterTwo.Text + " " + extensionTwo.Text : "NO FILTERS") +
                                 "\n------------------------------\n" + logFileContent;

                        File.WriteAllText(logFilePath, logFileContent);
                        MessageBox.Show("Log correctly created at: " + logFilePath);
                    }
                    else
                    {
                        MessageBox.Show("No file created, no correlations found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during the log creation: " + ex.Message);
                }

            }
        }

        private string CalculateSHA256(string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read)) //file path, open file to acess content, read style
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashBytes = sha256.ComputeHash(fileStream); //example: contains 0x5A,0x3B etc etc
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant(); //convert to byte (readable chars)
                }
            }
        }



        private void buttonSwap_Click(object sender, EventArgs e)
        {
            string text = folderOne.Text;
            folderOne.Text = folderTwo.Text;
            folderTwo.Text = text;
        }

        private void whatDoesItDoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("This program compares all the files in two user specified folders.\n" +
                "You need to set the max size of the files to consider. (In options)\n" +
                "The comparison is between files hashes, and the matches are written to a log file in a user specified path.\n", "How the program works");
        }

        private void kbToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void insertSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void folderFilter()
        {
            if (enableFilterOne.Checked)
            {
                if (filterOne.SelectedIndex == 0) //starts with
                {
                    patternFilterOne = extensionOne.Text + "*";
                }
                if (filterOne.SelectedIndex == 1) //contains
                {
                    patternFilterOne = "*" + extensionOne.Text + "*";
                }
                if (filterOne.SelectedIndex == 2) //ends with
                {
                    patternFilterOne = "*" + extensionOne.Text;
                }
            }
            else
            {
                patternFilterOne = "*.*";
            }

            if (enableFilterTwo.Checked)
            {
                if (filterTwo.SelectedIndex == 0) //starts with
                {
                    patternFilterTwo = extensionTwo.Text + "*";
                }
                if (filterTwo.SelectedIndex == 1) //contains
                {
                    patternFilterTwo = "*" + extensionTwo.Text + "*";
                }
                if (filterTwo.SelectedIndex == 2) //ends with
                {
                    patternFilterTwo = "*" + extensionTwo.Text;
                }
            }
            else
            {
                patternFilterTwo = "*.*";
            }
        }

        private void enableFilterOne_CheckedChanged(object sender, EventArgs e)
        {
            filterOne.Enabled = !filterOne.Enabled;
            extensionOne.Enabled = !extensionOne.Enabled;


        }

        private void enableFilterTwo_CheckedChanged(object sender, EventArgs e)
        {
            filterTwo.Enabled = !filterTwo.Enabled;
            extensionTwo.Enabled = !extensionTwo.Enabled;
        }

        private void filterOne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterTwo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void maxFilesSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (numericUpDown.Value == 0)
            {
                rememberSize.Visible = true;
            }
            else
            {
                rememberSize.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
