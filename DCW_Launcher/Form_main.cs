using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Checksums;
using IWshRuntimeLibrary;

namespace DCW_Launcher
{
    public partial class Form_main : Form
    {
        private string server = null;
        private string nowVersion = null;
        private string lastVersion = null;
        private string path = null;
        public Form_main()
        {
            InitializeComponent();

            this.numericUpDown1.Value = DateTime.Now.Year;
            this.numericUpDown2.Value = DateTime.Now.Month;
            this.numericUpDown3.Value = DateTime.Now.Day;

            XmlDocument doc = new XmlDocument();
            doc.Load("launcher_config.xml");
            if (doc != null)
            {
                //分析文件  
                XmlNode node = doc.SelectSingleNode("//DCW/configuration");
                if (node != null)
                {
                    this.server = node.Attributes["server"].InnerText.Trim();
                    this.tb_server.Text = this.server;
                    this.path = node.Attributes["path"].InnerText.Trim();
                    this.tb_path.Text = this.path;
                }
                else
                {
                    MessageBox.Show("Local laucher_config.xml is defect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Can't get local laucher_config.xml", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string configURL = string.Format("{0}\\DCW\\config.xml", Application.StartupPath);
            
            if (System.IO.File.Exists(configURL))
            {
                doc.Load(configURL);
                //分析文件
                XmlNode node = doc.SelectSingleNode("//DCW/configuration");
                if (node != null)
                {
                    this.nowVersion = node.Attributes["version"].InnerText.Trim();
                    this.tb_nowVersion.Text = this.nowVersion;
                    
                }
                else
                {
                    MessageBox.Show("Local config.xml is defect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                nowVersion= "0000.00.00.00";
                this.tb_nowVersion.Text = nowVersion;
            }


        }


        private void btn_check_Click(object sender, EventArgs e)
        {
            this.lastVersion = this.GetLastVersion(this.server);
            if(string.IsNullOrEmpty(lastVersion))
            {
                MessageBox.Show("Can't fetch last version from server", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.tb_lastVersion.Text = this.lastVersion;           
            if (string.IsNullOrEmpty(nowVersion))
            {
                MessageBox.Show("Can't fetch version from local", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //this.lb_info.Items.Add("Local version: " + nowVersion);
                int last = Convert.ToInt32(lastVersion.Replace(".", "").Trim());
                int now = Convert.ToInt32(nowVersion.Replace(".", "").Trim());
                if (last > now)
                {
                    if (MessageBox.Show("New version is available! Do you want to update?", "New version", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        //下载
                        this.lb_info.Items.Add("【1】Downloading the new software from server...");
                        string filePath = this.Download(this.server,string.Format("DCW({0}).zip", this.lastVersion));
                        //更新
                        this.lb_info.Items.Add("【2】Installing the new software...");
                        this.UnZipFile(filePath);
                        this.CreateDesktopLnk();
                        this.lb_info.Items.Add("【3】Update is finished!");
                        this.lb_info.Items.Add("【================================================】");


                        


                        MessageBox.Show("Update is finished!", "Online Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Current version is the last.", "No new version", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("launcher_config.xml");
            if (doc != null)
            {
                //分析文件  
                XmlNode node = doc.SelectSingleNode("//DCW/configuration");
                if (node != null)
                {
                    this.server = this.tb_server.Text.Trim();
                    node.Attributes["server"].InnerText = this.server;                    
                    doc.Save("launcher_config.xml");
                }
                else
                {
                    MessageBox.Show("Local config.xml is defect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Can't get local config.xml", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetLastVersion(string server)
        {
            string version = null;
            Uri uri = new Uri(server);
            string[] temp = this.GetFtpFileName(uri);
            for(int i=0;i<temp.Length;i++)
            {
                try
                {
                    string item = temp[i];
                    if (item.Contains("DCW(") && item.Contains(").zip"))
                    {
                        string verString = item.Substring(4, 13);
                        int verTemp = Convert.ToInt32(verString.Replace(".", ""));
                        if (string.IsNullOrEmpty(version))
                            version = verString;
                        else if (verTemp > Convert.ToInt32(version.Replace(".", "")))
                        {
                            version = verString;
                        }
                    }
                }
                catch { }
            }
            
            return version;
        }

        /// <summary>
        /// 直接传文件名获取信息
        /// </summary>
        /// <param name="userId">ftp userid</param>
        /// <param name="pwd">ftp password</param>
        /// <param name="ftpIP">ftp ip</param>
        /// <returns></returns>
        public string[] GetFtpFileName(Uri uri)
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            try
            {
                FtpWebRequest ftpRequest = null;
                FtpWebResponse ftpResponse = null;
                Stream ftpStream = null;
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(uri);
                ftpRequest.Credentials = new NetworkCredential("anonymous", "");
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpStream = ftpResponse.GetResponseStream();
                StreamReader ftpReader = new StreamReader(ftpStream);
                string line = ftpReader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = ftpReader.ReadLine();
                }
                result.Remove(result.ToString().LastIndexOf('\n'), 1);

                ftpReader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
                return result.ToString().Split('\n');

            }
            catch (Exception ex)
            {
                downloadFiles = null;
                return downloadFiles;
            }
        }

        private string GetZipURL(string server)
        {
            string url = null;
            //获取服务器信息  
            using (WebClient client = new WebClient())
            {
                XmlDocument doc = new XmlDocument();
                try
                {
                    doc.Load(client.OpenRead(server + "config.xml"));
                    if (doc != null)
                    {
                        //分析文件  
                        XmlNode node = doc.SelectSingleNode("//DCW/configuration");
                        if (node != null)
                        {
                            url = node.Attributes["url"].InnerText.Trim();

                            //获取信息成功，退出函数
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Can't connect to update server", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return url;
        }

        private string Download(string server,string fileName)
        {
            //string zipURL = this.GetZipURL(server);
            if (!Directory.Exists(Application.StartupPath + "\\temp\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\temp\\");
            }

            string fileURL = string.Format("{0}\\temp\\DCW({1}).zip", Application.StartupPath, this.lastVersion); 
            FileStream fs = new FileStream(fileURL, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);

            FtpWebRequest objWebRequest = (FtpWebRequest)WebRequest.Create(string.Format("{0}{1}",server,fileName));
            //objWebRequest.AllowAutoRedirect = true;
            //              int nOffset = 0;  
            long nCount = 0;
            byte[] buffer = new byte[40960];   //40KB  
            int nRecv = 0;  //接收到的字节数  

            FtpWebResponse objWebResponse = (FtpWebResponse)objWebRequest.GetResponse();
            Stream recvStream = objWebResponse.GetResponseStream();

            /*
            if( this.bCheckFileSize && nMaxLength != this.nFileSize )  
            {  
                throw new Exception( string.Format( "文件\"{0}\"被损坏,无法下载!",Path.GetFileName( this.strFile ) ) );  
            }  
            if( this.DownloadFileStart != null )  
                this.DownloadFileStart( new DownloadFileStartEventArgs( (int)nMaxLength ) ); 
            */
            try
            {
                while (true)
                {
                    nRecv = recvStream.Read(buffer, 0, buffer.Length);
                    if (nRecv == 0)
                        break;
                    fs.Write(buffer, 0, nRecv);
                    nCount += nRecv;
                }
            }
            catch
            {
                fileURL = null;
            }
            finally
            {
                recvStream.Close();
                fs.Close();
            }
            return fileURL;
        }

        private void UnZipFile(string zipFilePath)
        {

            if (!System.IO.File.Exists(zipFilePath))
            {
                Console.WriteLine("Cannot find file '{0}'", zipFilePath);
                return;
            }

            using (ZipInputStream s = new ZipInputStream(System.IO.File.OpenRead(zipFilePath)))
            {
                if (!Directory.Exists(Application.StartupPath + "\\DCW\\"))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\DCW\\");
                }
                ZipEntry theEntry;
                while ((theEntry = s.GetNextEntry()) != null)
                {

                    //Console.WriteLine(theEntry.Name);
                    string directoryName = Path.GetDirectoryName(Application.StartupPath + "\\DCW\\"+theEntry.Name);
                    string fileName = Path.GetFileName(theEntry.Name);

                    // create directory
                    if (directoryName.Length > 0)
                    {
                        Directory.CreateDirectory(directoryName);
                    }

                    if (fileName != String.Empty)
                    {
                        using (FileStream streamWriter = System.IO.File.Create(Application.StartupPath + "\\DCW\\" + fileName))
                        {

                            int size = 2048;
                            byte[] data = new byte[2048];
                            while (true)
                            {
                                size = s.Read(data, 0, data.Length);
                                if (size > 0)
                                {
                                    streamWriter.Write(data, 0, size);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void CreateDesktopLnk()
        {
            string DesktopPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);//得到桌面文件夹
            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();

            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(DesktopPath + "\\DCW Datenbank.lnk");
            shortcut.TargetPath =Application.StartupPath +"\\DCW\\DCW.exe";
            shortcut.Arguments = "";// 参数
            shortcut.Description = "DCW Datenbank";
            shortcut.WorkingDirectory = Application.StartupPath+"\\DCW";//程序所在文件夹，在快捷方式图标点击右键可以看到此属性
            shortcut.IconLocation =Application.StartupPath + "\\DCW\\DCW.exe,0";//图标
            //shortcut.Hotkey = "CTRL+SHIFT+Z";//热键
            shortcut.WindowStyle = 1;
            shortcut.Save();


        }

        private void btn_path_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.path = this.folderBrowserDialog.SelectedPath;
                this.tb_path.Text = path;
                //XmlDocument doc = new XmlDocument();
                //doc.Load("config.xml");
                //XmlNode xmlNode = doc.SelectSingleNode("//DCW/configuration");

                //xmlNode.Attributes["path"].InnerText = this.path;
                
                //doc.Save("config.xml");
                
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string version = Convert.ToUInt16(this.numericUpDown1.Value).ToString("d4") + "." + Convert.ToUInt16(this.numericUpDown2.Value).ToString("d2") + "." + Convert.ToUInt16(this.numericUpDown3.Value).ToString("d2") + "." + Convert.ToUInt16(this.numericUpDown4.Value).ToString("d2");
            string filename = "DCW(" + version + ").zip";
            //string URL = this.tb_url.Text.Trim() + filename;

            //生成升级包之前，将界面上的参数存储到Launcher的xml文件
            //XmlDocument doc = new XmlDocument();
            //doc.Load("config.xml");
            //XmlNode xmlNode = doc.SelectSingleNode("//DCW/configuration");
            //xmlNode.Attributes["server"].InnerText = this.tb_server.Text.Trim();
            //xmlNode.Attributes["path"].InnerText = this.tb_path.Text.Trim();
            //xmlNode.Attributes["version"].InnerText = version;
            //xmlNode.Attributes["url"].InnerText = URL;
            //doc.Save("config.xml");
            //生成升级包之前，将界面上的参数存储到DCW的xml文件
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(this.tb_path.Text.Trim() + "\\config.xml");
            XmlNode xmlNode1 = doc1.SelectSingleNode("//DCW/configuration");
            //xmlNode1.Attributes["server"].InnerText = this.tb_server.Text.Trim();
            
            xmlNode1.Attributes["version"].InnerText = version;//修改DCW程序中的版本信息
            //xmlNode1.Attributes["version"].InnerText = version;
            //xmlNode1.Attributes["url"].InnerText = URL;
            doc1.Save(this.tb_path.Text.Trim() + "\\config.xml");


            if (!string.IsNullOrEmpty(this.path))
            {
                //string targetPath = Path.Combine(this.folderBrowserDialog.SelectedPath, "testtt.zip");
                //生成用于压缩的文件列表
                List<string> fileList = new List<string>();
                DirectoryInfo theFolder = new DirectoryInfo(this.path);
                FileInfo[] files = theFolder.GetFiles();
                foreach (FileInfo file in files)
                {
                    fileList.Add(file.FullName);
                }
                /*
                DirectoryInfo[] dirInfo = theFolder.GetDirectories();
                //遍历文件夹
                foreach (DirectoryInfo NextFolder in dirInfo)
                {
                    // this.listBox1.Items.Add(NextFolder.Name);
                    FileInfo[] fileInfo = NextFolder.GetFiles();
                    foreach (FileInfo NextFile in fileInfo)  //遍历文件
                        this.listBox2.Items.Add(NextFile.Name);
                }
                */
                if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string copyTargetPath = this.folderBrowserDialog.SelectedPath;//最终放置文件的位置
                    //压缩升级文件到指定位置
                    int x = this.Zip(Path.Combine(copyTargetPath, filename), fileList.ToArray(), "Document", null);
                    //复制config.xml到指定位置
                    //string copySourcePath = System.Windows.Forms.Application.StartupPath;
                    //string ConFileName = "launcher_config.xml";
                    //string sourceFile = System.IO.Path.Combine(copySourcePath, ConFileName);
                    //string destFile = System.IO.Path.Combine(copyTargetPath, ConFileName);
                    //System.IO.File.Copy(sourceFile, destFile, true);
                }
                
            }
            
        }

        public int Zip(string destFolder, string[] srcFiles, string srcFolder, string password)
        {
            ICSharpCode.SharpZipLib.Zip.ZipConstants.DefaultCodePage = 850;
            ZipOutputStream zipStream = null;
            FileStream streamWriter = null;
            int count = 0;

            try
            {
                //Use Crc32
                Crc32 crc32 = new Crc32();

                //Create Zip File
                zipStream = new ZipOutputStream(System.IO.File.Create(destFolder));

                //Specify Level
                zipStream.SetLevel(Convert.ToInt32(6));

                //Specify Password
                if (password != null && password.Trim().Length > 0)
                {
                    zipStream.Password = password;
                }

                //Foreach File
                foreach (string file in srcFiles)
                {
                    //Check Whether the file exists
                    if (!System.IO.File.Exists(file))
                    {
                        throw new FileNotFoundException(file);
                    }

                    //Read the file to stream
                    streamWriter = System.IO.File.OpenRead(file);
                    byte[] buffer = new byte[streamWriter.Length];
                    streamWriter.Read(buffer, 0, buffer.Length);
                    streamWriter.Close();

                    //Specify ZipEntry
                    crc32.Reset();
                    crc32.Update(buffer);
                    ZipEntry zipEntry = new ZipEntry(Path.GetFileName(file));
                    zipEntry.DateTime = DateTime.Now;
                    zipEntry.Size = buffer.Length;
                    zipEntry.Crc = crc32.Value;

                    //Put file info into zip stream
                    zipStream.PutNextEntry(zipEntry);

                    //Put file data into zip stream
                    zipStream.Write(buffer, 0, buffer.Length);

                    count++;
                }

                //count += PutDirectoryToZipStream(srcFolder, null, zipStream, crc32, streamWriter);
            }
            catch
            {
                throw;
            }
            finally
            {
                //Clear Resource
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
                if (zipStream != null)
                {
                    zipStream.Finish();
                    zipStream.Close();
                }
            }

            return count;
        }
        private static int PutDirectoryToZipStream(string directory, string logicBaseDir, ZipOutputStream zipStream, Crc32 crc32, FileStream streamWriter)
        {
            int count = 0;

            //Get the logic directory
            string logicDir = null;
            if (logicBaseDir == null || logicBaseDir.Length == 0)
            {
                logicDir = GetDirectoryName(directory);
            }
            else
            {
                logicDir = logicBaseDir + @"" + GetDirectoryName(directory);
            }
            logicDir = logicDir.Replace("/", @"").Replace(@"\", @"");

            //Get Directories Name
            string[] dirs = Directory.GetDirectories(directory);

            //Get Files Name
            string[] files = Directory.GetFiles(directory);

            //Foreach Directories
            foreach (string dir in dirs)
            {
                count = count + PutDirectoryToZipStream(dir, logicDir, zipStream, crc32, streamWriter);
            }

            //Foreach Files
            foreach (string file in files)
            {
                //Read the file to stream
                streamWriter = System.IO.File.OpenRead(file);
                byte[] buffer = new byte[streamWriter.Length];
                streamWriter.Read(buffer, 0, buffer.Length);
                streamWriter.Close();

                //Specify ZipEntry
                crc32.Reset();
                crc32.Update(buffer);
                ZipEntry zipEntry = new ZipEntry(Path.Combine(logicDir, Path.GetFileName(file)));
                zipEntry.DateTime = DateTime.Now;
                zipEntry.Size = buffer.Length;
                zipEntry.Crc = crc32.Value;

                //Put file info into zip stream
                zipStream.PutNextEntry(zipEntry);

                //Put file data into zip stream
                zipStream.Write(buffer, 0, buffer.Length);

                count++;
            }

            return count;
        }
        private static string GetDirectoryName(string directory)
        {
            directory = directory.Replace("/", @"").Replace(@"\", @"");
            if (directory[directory.Length - 1].ToString() == @"")
            {
                directory = directory.Substring(0, directory.Length - 1);
            }

            int lastRoot = directory.LastIndexOfAny(@"".ToCharArray());

            return directory.Substring(lastRoot + 1, directory.Length - lastRoot - 1);
        }





        private void lb_info_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.End)
            {
                if (groupBox2.Visible == true)
                {
                    groupBox2.Visible = false;
                }
                else
                {
                    groupBox2.Visible = true;
                }
            }
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\DCW\\DCW.exe", "");
            //System.Diagnostics.Process.Start(@"C:\Users\Administrator\Documents\GitHub\DCW\DCW_Launcher\bin\Debug\DCW\DCW.exe");

            
            //this.Close();
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(this.tb_path.Text.Trim() + "\\config.xml");
            XmlNode node = doc1.SelectSingleNode("//DCW/configuration");
            if (node != null)
            {
                string version = node.Attributes["version"].InnerText.Trim();
                string[] ver=version.Split('.');
                numericUpDown1.Value = Convert.ToDecimal(ver[0]);
                numericUpDown2.Value = Convert.ToDecimal(ver[1]);
                numericUpDown3.Value = Convert.ToDecimal(ver[2]);
                numericUpDown4.Value = Convert.ToDecimal(ver[3]);
            }
        }
    }

}
