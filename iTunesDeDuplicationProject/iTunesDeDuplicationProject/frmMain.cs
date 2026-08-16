using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents.Serialization;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

using Shell32;


namespace iTunesDeDuplicationProject
{
	//iTunesDeDuplicationProject

	public partial class frmMain : Form
	{

        #region Setup Stuff

        internal string testLocation;

		/*
		string[] AudioFileTypes = new string[] { ".mp3", ".m4a", ".m4b", ".m4p", ".m4r", ".wav", ".flac", ".aac", ".wma", ".wav" };
		string[] VideoFileTypes = new string[] { ".mp4", ".m4v", ".mov", ".avi", ".wmv", ".flv", ".mkv", ".mpg", ".asf", ".webm" };
		string[] PictureFileTypes = new string[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".svg" };
        */

		HashSet<string> AudioFileTypes = new HashSet<string>( new[] { ".mp3", ".m4a", ".m4b", ".m4p", ".m4r", ".wav", ".flac", ".aac", ".wma", ".wav" }, StringComparer.OrdinalIgnoreCase);

		public frmMain()
		{
			InitializeComponent();
            string thisComputer = Environment.MachineName.ToUpper();
            switch (thisComputer) 
            {
                case "ERIADOR":
					testLocation = "J:\\Toshiba_Backup\\iTunes_Backup\\iTunes Media\\Music\\Journey\\_backups";
					break;
                case "MITHLOND":
					testLocation = "C:\\Users\\henry\\Dropbox\\MP3";
					break;
                default:
                    break;
            }
			tbDirPath.Text = testLocation;
		}


		public void WriteToDisplay(string MessageText, bool ClearFirst = false, bool SuppressTimeStamps = false)
		{
			if(tbDisplay.InvokeRequired)
			{
				tbDisplay.Invoke(new Action(() => WriteToDisplay(MessageText, ClearFirst, SuppressTimeStamps)));
				return;
			}

			if (ClearFirst) { tbDisplay.Clear(); }
			string dispText;
			if (SuppressTimeStamps) { dispText = "•\t" + MessageText + "\r\n"; }
			else { dispText = DateTime.Now.ToString("HH:mm:ss") + " -\t" + MessageText + "\r\n"; }
			tbDisplay.AppendText(dispText);
			tbDisplay.ScrollToCaret();
			Application.DoEvents();
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			MainProcess(tbDirPath.Text);
		}

		#endregion Setup Stuff


        public void MainProcess(string DirName) 
		{
			if (!Directory.Exists(DirName))
			{
				WriteToDisplay("Directory \"" + DirName + "\" is invalid or does not exist.", true, false);
				return;
			}

			List<string> fileList = GetFileList(DirName);
            foreach (string file in fileList) 
            {
                //get basic details
                //get extended details
            }


		}

        public void GetFileDetails(string FileName)
		{
			FileInfo fi = new FileInfo(FileName);
			string filePath = fi.FullName;
			string fileName = fi.Name;
			string fileExt = fi.Extension;
			long fileSize = fi.Length;
			DateTime fileCreated = fi.CreationTime;
			DateTime fileModified = fi.LastWriteTime;
			WriteToDisplay("File: " + fileName + " | Size: " + fileSize.ToString("N0") + " bytes | Created: " + fileCreated.ToString() + " | Modified: " + fileModified.ToString(), false, false);
		}

		public void GetExtendedDetails(string FileName)
		{ 
		}

		public List<string>GetFileList(string DirName)
        {
			WriteToDisplay("Now processing directory \"" + DirName + "\"", true, false);
			if (tglDirOption.Checked)
			{
				WriteToDisplay("Searching all subdirectories.", false, false);
			}
			else
			{
				WriteToDisplay("Searching this directory only.", false, false);
			}

			List<string>fileList = new List<string>();

            SearchOption srchOption = SearchOption.TopDirectoryOnly;
            if (tglDirOption.Checked) { srchOption = SearchOption.AllDirectories; }
			fileList = Directory.EnumerateFiles(DirName, "*.*", srchOption).Where(s => AudioFileTypes.Contains(Path.GetExtension(s).ToLower())).ToList<string>();

			int fileCount = fileList.Count;
			WriteToDisplay("Total files found: " + fileCount.ToString("N0"));
			return fileList;
           
        }






        #region Control Interactions

        private void tglDirOption_CheckedChanged(object sender, EventArgs e)
		{
			if(tglDirOption.Checked)				{
				lbDirOption.Text = "This directory and all subdirectories.";
			}
			else
			{
				lbDirOption.Text = "This directory only";
			}
		}

        #endregion Control Interactions

        #region Holding Bin

        public void MainProcess_HOLDING(string DirName)
        {
            SearchOption option = SearchOption.TopDirectoryOnly;
            if (!Directory.Exists(DirName))
            {
                WriteToDisplay("Directory \"" + DirName + "\" is invalid or does not exist.", true, false);
                return;
            }
            else
            {
                WriteToDisplay("Now processing directory \"" + DirName + "\"", true, false);
                if (tglDirOption.Checked)
                {
                    option = SearchOption.AllDirectories;
                    WriteToDisplay("Searching all subdirectories.", false, false);
                }
                else
                {
                    option = SearchOption.TopDirectoryOnly;
                    WriteToDisplay("Searching this directory only.", false, false);
                }
            }


            string[] allFiles = Directory.GetFiles(DirName, "*.*", option);

            int fileCount = allFiles.Length;
            WriteToDisplay("Files found in directory: " + fileCount.ToString(), false, false);
            WriteToDisplay("Getting list of extensions...", false, false);

            List<string> extensionList = new List<string>();

            foreach (string file in allFiles)
            {
                FileInfo fi = new FileInfo(file);
                string ext = fi.Extension.ToLower();

                if (!extensionList.Contains(ext))
                {
                    extensionList.Add(ext);
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (string ext in extensionList)
            {
                sb.AppendLine(ext);
            }

            if (sb.Length > 0)
            {
                WriteToDisplay("File extensions found in directory:\r\n" + sb.ToString(), false, false);
            }
            else
            {
                WriteToDisplay("No files found in directory.", false, false);
            }

        }

        #endregion Holding Bin

    }
}
