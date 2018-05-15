using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

/// <summary>
/// Main's namespace.
/// </summary>
namespace Main
{
    /// <summary>
    /// Form to process the file.
    /// </summary>
    public partial class Main : Form
    {
        /// <summary>
        /// Constructor to initialize the form.
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event on button Select File.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofdSelectFile = new OpenFileDialog();

                ofdSelectFile.InitialDirectory = Application.StartupPath;
                ofdSelectFile.Title = "Please select a file";
                ofdSelectFile.CheckFileExists = true;
                ofdSelectFile.CheckPathExists = true;
                ofdSelectFile.DefaultExt = "in";
                ofdSelectFile.Filter = "in files (*.in)|*.in";
                ofdSelectFile.FilterIndex = 1;
                ofdSelectFile.RestoreDirectory = true;
                ofdSelectFile.ReadOnlyChecked = true;
                ofdSelectFile.ShowReadOnly = true;

                if (ofdSelectFile.ShowDialog() == DialogResult.OK)
                {
                    FileInfo finFileSelected = new FileInfo(ofdSelectFile.FileName);

                    TxtFileSelected.Tag = ofdSelectFile.FileName;
                    TxtFileSelected.Text = finFileSelected.Name;
                    BtnProcessFile.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Click event on button Process File.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnProcessFile_Click(object sender, EventArgs e)
        {
            try
            {
                List<People.People> lstPeople = new List<People.People>();

                using (StreamReader sr = new StreamReader(TxtFileSelected.Tag.ToString()))
                {
                    string strLine;

                    while ((strLine = sr.ReadLine()) != null) 
                    {
                        string[] strPerson = strLine.Split('|');

                        lstPeople.Add(new People.People()
                        {
                            PersonId = strPerson[0] == String.Empty ? 0 : Int32.Parse(strPerson[0]),
                            Name = strPerson[1],
                            LastName = strPerson[2],
                            CurrentRole = strPerson[3],
                            Country = strPerson[4],
                            Industry = strPerson[5],
                            NumberOfRecommendations = strPerson[6] == String.Empty ? 0 : Int32.Parse(strPerson[6]),
                            NumberOfConnections = strPerson[7] == String.Empty ? 0 : Int32.Parse(strPerson[7])
                        });
                    }
                }

                var lstPersonIds = lstPeople.OrderByDescending(x => x.NumberOfRecommendations)
                                            .ThenByDescending(x => x.NumberOfConnections)
                                            .Select(x => x.PersonId).Take(100).ToList();

                using (StreamWriter sw = new StreamWriter("people.out"))
                {
                    foreach (int i in lstPersonIds)
                    {
                        sw.WriteLine(i.ToString());
                    }
                }

                if (File.Exists(Application.StartupPath + "\\people.out"))
                {                    
                    BtnProcessFile.Enabled = false;
                    MessageBox.Show("The file " + TxtFileSelected.Text + " was succesfully processed at the people.out file.", "File Processed");
                    TxtFileSelected.Text = String.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
