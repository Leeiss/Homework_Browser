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
        string xmlPath = @"C:\\Users\\farra\\source\\repos\\Browser_Homework\\Browser_Homework\\History.xml";
        private void History_Load(object sender, EventArgs e)
        {
            try
            {
                XDocument doc = XDocument.Load(xmlPath);
                foreach (XElement item in doc.Descendants("urls").Elements("address"))
                {
                    var val = item.Value;
                    addresses_lb.Items.Add(val);
                }
            }
            catch
            {
                MessageBox.Show("Ваша история просмотра страниц пуста");
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
            doc.Load(@"C:\\Users\\farra\\source\\repos\\Browser_Homework\\Browser_Homework\\History.xml");
            foreach (XmlNode node in doc.ChildNodes)
            {
                node.RemoveAll();
            }
            doc.Save(@"C:\\Users\\farra\\source\\repos\\Browser_Homework\\Browser_Homework\\History.xml");
        }
    }
}
