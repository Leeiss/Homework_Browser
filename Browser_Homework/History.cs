using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Browser_Homework
{

    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }
        private void lbl_history_Click(object sender, EventArgs e)
        {

        }
        string HistoryDocXml = @".\..\..\..\History.xml";

        private void History_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(HistoryDocXml);
            XmlElement xmlRoot = xmlDoc.DocumentElement;

            if (xmlRoot != null)
            {
                foreach (XmlElement xmlNode in xmlRoot)
                {
                    for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
                    {
                        if (xmlNode.ChildNodes[i].Name == "date")
                        {
                            DateTime dateRecord = DateTime.Parse(xmlNode.ChildNodes[i].InnerText.ToString());

                            TimeSpan sevenDays = new TimeSpan(7, 0, 0, 0);

                            if (dateRecord - DateTime.Now > sevenDays)
                            {
                                xmlRoot.RemoveChild(xmlRoot.ChildNodes[i]);
                            }
                        }
                    }
                }
            }
            xmlDoc.Load(HistoryDocXml);
            XmlNodeList addressNodes = xmlDoc.SelectNodes("//address");
            foreach (XmlNode addressNode in addressNodes)
            {
                string addressValue = addressNode.InnerText;
                addresses_lb.Items.Add(addressValue);
            }
        }
        private void show_btn_Click(object sender, EventArgs e)
        {
            Browser browser = new Browser()
            { address = addresses_lb.SelectedItem.ToString() };
            this.Close();
            browser.Show();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            addresses_lb.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(HistoryDocXml);
            foreach (XmlNode node in doc.ChildNodes)
            {
                node.RemoveAll();
            }
            doc.Save(HistoryDocXml);
        }

        private void addresses_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_btn.Visible = true;
        }
    }
}
