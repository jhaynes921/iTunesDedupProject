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

namespace iTunesDeDuplicationProject
{
	//iTunesDeDuplicationProject

	public partial class frmMain : Form
	{

		#region Setup Stuff

		internal string testLocation = "J:\\Toshiba_Backup\\iTunes_Backup\\iTunes Media\\Music\\Journey\\_backups";

		string[] AudioFileTypes = new string[] { ".mp3", ".m4a", ".m4b", ".m4p", ".m4r", ".wav", ".flac", ".aac", ".wma", ".wav" };
		string[] VideoFileTypes = new string[] { ".mp4", ".m4v", ".mov", ".avi", ".wmv", ".flv", ".mkv", ".mpg", ".asf", ".webm" };
		string[] PictureFileTypes = new string[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".svg" };

		public frmMain()
		{
			InitializeComponent();
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

#endregion


		public void MainProcess(string DirName) 
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


			string[] allFiles = Directory.GetFiles(DirName,"*.*", option);

			int fileCount = allFiles.Length;
			WriteToDisplay("Files found in directory: " + fileCount.ToString(), false, false);
			WriteToDisplay("Getting list of extensions...", false, false);

			List<string>extensionList = new List<string>();
			
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
			foreach(string ext in extensionList)
			{
				sb.AppendLine(ext);
			}

			if(sb.Length > 0)
			{
				WriteToDisplay("File extensions found in directory:\r\n" + sb.ToString(), false, false);
			}
			else
			{
				WriteToDisplay("No files found in directory.", false, false);
			}


		}

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
	}
}
