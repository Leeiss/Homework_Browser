using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Markers : Form
    {
        public Markers()
        {
            InitializeComponent();
        }
        string xmlPath = @"C:\Users\farra\source\repos\Browser_Homework\Browser_Homework\Markers.xml";
        private void Markers_Load(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(@"C:\Users\farra\source\repos\Browser_Homework\Browser_Homework\Markers.xml");
                XmlElement xRoot = xDoc.DocumentElement;
                foreach (XmlElement xnode in xRoot)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("address");
                    markers_lb.Items.Add(attr.Value);
                }
            }
            catch
            {
                MessageBox.Show("У вас еще нет страниц в закладках");
            }
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            Browser browser = new Browser()
            { address = markers_lb.SelectedItem.ToString() };
            this.Close();
            browser.Show();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string address = markers_lb.SelectedItem.ToString();
            markers_lb.Items.RemoveAt(markers_lb.SelectedIndex);
            var xmlDoc = XDocument.Load(Path.Combine(Environment.CurrentDirectory, @"C:\\Users\\farra\\source\\repos\\Browser_Homework\\Browser_Homework\\Markers.xml"));
            xmlDoc.Element("markers").Elements("marker").Where(x => x.Attribute("address").Value == address).FirstOrDefault().Remove();
            xmlDoc.Save(Path.Combine(Environment.CurrentDirectory, @"C:\\Users\\farra\\source\\repos\\Browser_Homework\\Browser_Homework\\Markers.xml"));

        }
        private void markers_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_btn.Visible = true;
            delete_btn.Visible = true;
        }
    }
}
