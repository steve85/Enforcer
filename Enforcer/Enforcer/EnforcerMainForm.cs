/*
 * Enforcer
 * 10/05/2010 - Steve Ryan
 * Provides a checklist of items to be done before deployment of hardware.
 * 
 * To Do:
 * Figure out a way to validate install item ids when reading in xml (no duplicates)
 * See if xml can be compressed or encrypted so that users cannot tamper with the contents
 * Add extra attributes to the xml file to include the following:
 *  - Username - On initial startup keep prompting for username
 *  - Initial Open timestamp
 *  - Finish button click timestamp 
 */ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace Enforcer
{
    public partial class EnforcerMainForm : Form
    {
        // ### Only temporary
        private string _xmlFileName = "../../InstallCheckList.xml";
        private string _installType;
        private string _userName;
        private string _startTime;
        private string _finishTime;
        private List<InstallItem> _lstInstallItems = new List<InstallItem>();

        public EnforcerMainForm()
        {
            InitializeComponent();
            this._installType = string.Empty;
            this.ReadData();
            this.AddControls();
        }

        // Read data from xml file
        private void ReadData()
        {
            string strId = string.Empty;
            string strName = string.Empty;
            string strDescription = string.Empty;
            string strIsInstalled = string.Empty;
            string strIsNotRequired = string.Empty;
            int Id = 0;
            bool IsInstalled = false;
            bool IsNotRequired = false;

            try
            {
                // Attempt to read in the installation checklist xml document
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(this._xmlFileName);                

                // Get the install type from the xml
                if (!string.IsNullOrEmpty(xmlDocument.DocumentElement.GetAttributeNode("InstallType").Value))
                {
                    this._installType = xmlDocument.DocumentElement.GetAttributeNode("InstallType").Value;
                    this.lblInstallItems.Text = string.Format("Installation Items for {0}",  this._installType);
                }

                this.GetUserName(xmlDocument);
                this.InsertInitialTimeStamp(xmlDocument);

                XmlNodeList xmlNodeList = xmlDocument.SelectNodes("//Enforcer/InstallItems/Item");
                 
                // Loop through each installation item
                foreach (XmlNode xmlInstallNodes in xmlNodeList)
                {
                    XmlNodeList xmlPropertyNodes = xmlInstallNodes.ChildNodes;

                    // Reset values
                    strId = string.Empty;
                    strName = string.Empty;
                    strDescription = string.Empty;
                    strIsInstalled = string.Empty;
                    strIsNotRequired = string.Empty;
                    Id = 0;
                    IsInstalled = false;
                    IsNotRequired = false;


                    // Loop through the properties for the installation item, get the
                    // values and create an object. If the object is not yet present in the 
                    // list add it
                    foreach (XmlNode xmlProperty in xmlPropertyNodes)
                    {                        
                        if (xmlProperty.Name.Equals("Id"))
                        {
                            strId = xmlProperty.InnerText;
                            if (int.TryParse(strId, out Id))
                            {
                                // ### throw an error
                            }
                        }
                        else if (xmlProperty.Name.Equals("Name"))
                        {
                            strName = xmlProperty.InnerText;
                            if (string.IsNullOrEmpty(strName))
                            {
                                // ### throw an error
                            }
                        }
                        else if (xmlProperty.Name.Equals("Description"))
                        {
                            strDescription = xmlProperty.InnerText;
                            if (string.IsNullOrEmpty(strDescription))
                            {
                                // ### throw an error
                            }
                        }
                        else if (xmlProperty.Name.Equals("Installed"))
                        {
                            strIsInstalled = xmlProperty.InnerText;
                            if (!bool.TryParse(strIsInstalled, out IsInstalled))
                            {
                                // ### throw an error
                            }
                        }
                        else if (xmlProperty.Name.Equals("NotRequired"))
                        {
                            strIsNotRequired = xmlProperty.InnerText;
                            if (bool.TryParse(strIsNotRequired, out IsNotRequired))
                            {
                                // ### throw an error
                            }
                        }
                        else
                        {
                            // ### Not expected
                        }
                    }

                    InstallItem installItem = new InstallItem();
                    installItem.Id = Id;
                    installItem.Name = strName;
                    installItem.Description = strDescription;
                    installItem.IsInstalled = IsInstalled;
                    installItem.IsNotRequired = IsNotRequired;

                    if (!this._lstInstallItems.Contains(installItem))
                    {
                        this._lstInstallItems.Add(installItem);
                    }
                }
                //xmlDocument.Save(this._xmlFileName);
            }
            catch (Exception e)
            {
                // ### Fix this
                MessageBox.Show(e.Message);
            }
        }

        // Update the data in the xml file
        private void WriteData()
        {
            // ### Do this each an item is changed, this way if the app closes
            // unexpectedly the config will be remembered
        }

        private void GetUserName(XmlDocument xmlDocument)
        {
            // Get or set the user name
            if (!string.IsNullOrEmpty(xmlDocument.DocumentElement.GetAttributeNode("UserName").Value))
            {
                this._userName = xmlDocument.DocumentElement.GetAttributeNode("UserName").Value;
            }
            else
            {
                // ### set the user name
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("USERNAME").ToString()))
                {
                    this._userName = Environment.GetEnvironmentVariable("USERNAME").ToString();
                    xmlDocument.DocumentElement.SetAttribute("UserName",
                        Environment.GetEnvironmentVariable("USERNAME").ToString());
                }
            }
        }

        private void InsertInitialTimeStamp(XmlDocument xmlDocument)
        {
            // Get or set the start time
            if (!string.IsNullOrEmpty(xmlDocument.DocumentElement.GetAttributeNode("StartTime").Value))
            {
                this._startTime = xmlDocument.DocumentElement.GetAttributeNode("StartTime").Value;
            }
            else
            {
                this._startTime = string.Format("{0}", DateTime.Now);
                xmlDocument.DocumentElement.SetAttribute("StartTime", this._startTime);
            }
        }

        private void InsertFinishTimeStamp()
        {

        }

        // Dynamically adds controls to the panel depending on xml file
        private void AddControls()
        {
            ArrayList lstLabels = new ArrayList();
            ArrayList lstDone = new ArrayList();
            ArrayList lstNotRequired = new ArrayList();
            for (int i = 0; i < this._lstInstallItems.Count; i++)
            {
                // ### Add image placeholders

 
                // Add labels                
                lstLabels.Add(new Label());
                ((Label)lstLabels[i]).Location = new System.Drawing.Point(40, 25 + i * 40);
                ((Label)lstLabels[i]).Name = "Label" + i.ToString();
                ((Label)lstLabels[i]).Size = new System.Drawing.Size(440, 40);
                ((Label)lstLabels[i]).Text = this._lstInstallItems[i].Name;
                ((Label)lstLabels[i]).Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
                this.PanelInstallItems.Controls.Add(((Label)lstLabels[i]));


                // Add is done checkbox
                lstDone.Add(new CheckBox());
                ((CheckBox)lstDone[i]).Location = new System.Drawing.Point(480, 25 + i * 40);
                ((CheckBox)lstDone[i]).Name = "Done" + i.ToString();
                ((CheckBox)lstDone[i]).Size = new Size(100, 40);
                ((CheckBox)lstDone[i]).Text = "Done";                
                ((CheckBox)lstDone[i]).Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
                ((CheckBox)lstDone[i]).CheckedChanged += new EventHandler(EnforcerMainForm_CheckedChanged);
                this.PanelInstallItems.Controls.Add(((CheckBox)lstDone[i]));

                // ### Check is mandatory
                // Add is not required checkbox
                lstNotRequired.Add(new CheckBox());
                ((CheckBox)lstNotRequired[i]).Location = new System.Drawing.Point(580, 25 + i * 40);
                ((CheckBox)lstNotRequired[i]).Name = "NotRequired" + i.ToString();
                ((CheckBox)lstNotRequired[i]).Size = new Size(150, 40);
                ((CheckBox)lstNotRequired[i]).Text = "Not Required";
                ((CheckBox)lstNotRequired[i]).Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
                ((CheckBox)lstNotRequired[i]).CheckedChanged += new EventHandler(EnforcerMainForm_CheckedChanged);
                this.PanelInstallItems.Controls.Add(((CheckBox)lstNotRequired[i]));

                this.txtItemDesc.Text = this._lstInstallItems[i].Description;

                // Break loop
                if (!this._lstInstallItems[i].IsInstalled && !this._lstInstallItems[i].IsNotRequired)
                    break;
              
            }
        }

        private void EnforcerMainForm_CheckedChanged(object sender, EventArgs e)
        {
            // ### Determine the box that is checked and go from here
            CheckBox chkBox = (CheckBox)sender;
            MessageBox.Show(chkBox.Name);
        }

    }
}
