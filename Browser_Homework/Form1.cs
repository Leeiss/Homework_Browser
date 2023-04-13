using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using static System.Windows.Forms.LinkLabel;

namespace Browser_Homework
{
    public partial class Browser : Form
    {
        int i = 0;
        
        public Browser()

        {
            InitializeComponent();
            logo_pixture.Visible = true;
            lowpanel.Visible = true;
            mainpanel.Visible = true;
            tabControl.Visible = false;

        }
        public new string address
        {

            get { return search_string_tb.Text; }
            set
            { search_string_tb.Text = value; }
        }
        string HistoryDocXml = @".\..\..\..\History.xml";
        string MarkersDocXml = @".\..\..\..\Markers.xml";
        private void Browser_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int pictureBoxWidth = logo_pixture.Width;
            int pictureBoxHeight = logo_pixture.Height;
            int pictureBoxX = (formWidth - pictureBoxWidth) / 2;
            int pictureBoxY = (formHeight - pictureBoxHeight) / 2;
            logo_pixture.Location = new Point(pictureBoxX, pictureBoxY);
            lowpanel.Location = new Point(formHeight + 5, formWidth - 5);
        }
        private void plus_btn_Click(object sender, EventArgs e)
        {
            logo_pixture.Visible = false;
            lowpanel.Visible = false;
            mainpanel.Visible = false;
            tabControl.Visible = true;
            WebBrowser web = new WebBrowser();
            web.Visible = true;
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += webDocumentCompleted;
            tabControl.TabPages.Add("New page");
            tabControl.SelectTab(i);
            tabControl.SelectedTab.Controls.Add(web);
            i += 1;
        }
        private void Historyxml(string address, DateTime date)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(HistoryDocXml);
            XmlElement xmlRoot = xmlDoc.DocumentElement;

            XmlElement recordElem = xmlDoc.CreateElement("url");

            XmlElement linkElem = xmlDoc.CreateElement("address");
            XmlElement dateElem = xmlDoc.CreateElement("date");

            XmlText linkText = xmlDoc.CreateTextNode(address);
            XmlText dateText = xmlDoc.CreateTextNode(date.ToString());

            linkElem.AppendChild(linkText);
            dateElem.AppendChild(dateText);

            recordElem.AppendChild(linkElem);
            recordElem.AppendChild(dateElem);

            xmlRoot.AppendChild(recordElem);

            xmlDoc.Save(HistoryDocXml);

        }

           
        void webDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = ((WebBrowser)tabControl.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void search_string_click(object sender, EventArgs e)
        {
            search_string_tb.Text = string.Empty;
        }
        private void Searching()
        {
            if (search_string_tb.Text.Equals("https://www.Frogoogle.ru/"))
            {
                logo_pixture.Visible = true;
                lowpanel.Visible = true;
                mainpanel.Visible = true;
                tabControl.Visible = false;
            }
            else if (String.IsNullOrEmpty(search_string_tb.Text) || search_string_tb.Text.Length > search_string_tb.MaxLength)
            {

                MessageBox.Show("—трока пуста");
                logo_pixture.Visible = false;
                lowpanel.Visible = false;
                mainpanel.Visible = false;
                tabControl.Visible = true;
            }
            else if (tabControl.SelectedTab == null)
            {

                MessageBox.Show("ѕеред тем как сделать поиск, создайте вкладку");
                logo_pixture.Visible = false;
                lowpanel.Visible = false;
                mainpanel.Visible = false;
                tabControl.Visible = true;
            }
            else
            {
                logo_pixture.Visible = false;
                lowpanel.Visible = false;
                mainpanel.Visible = false;
                tabControl.Visible = true;
                ((WebBrowser)tabControl.SelectedTab.Controls[0]).Navigate(search_string_tb.Text);
                Historyxml(search_string_tb.Text, DateTime.Now);
            }
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            Searching();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == null)
            {
                MessageBox.Show("¬ы не можете отменить действие,так как ранее не совершали действий");
            }
            else
            {
                ((WebBrowser)tabControl.SelectedTab.Controls[0]).GoBack();

            }
        }

        private void forward_btn_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == null)
            {
                MessageBox.Show("¬ы не можете вернутьс€ назад, так как ранее не совершали действий");
            }
            else
            {
                ((WebBrowser)tabControl.SelectedTab.Controls[0]).GoForward();

            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == null)
            {
                MessageBox.Show("ƒл€ обновлени€ сначала откройте страницу");
            }
            else
            {
                ((WebBrowser)tabControl.SelectedTab.Controls[0]).Refresh();
            }
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count > 1)
            {
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
                tabControl.SelectTab(tabControl.TabPages.Count - 1);
                i -= 1;
            }
            else
                Application.Exit();
        }

        private void searching2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Searching();
            }

        }
        private void markers_menuitem_Click(object sender, EventArgs e)
        {
            Markers markers = new Markers();
            markers.Show();
        }

        private void history_menuitem_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void cansel_btn_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == null)
            {
                MessageBox.Show("ƒл€ остановки загрузки страницы сначала откройте ее");
            }
            else
            {
                ((WebBrowser)tabControl.SelectedTab.Controls[0]).Stop();
            }
        }

        private void markers_btn_Click(object sender, EventArgs e)
        {
            if (search_string_tb.Text != "")
            {
                var xmlDoc = XDocument.Load(Path.Combine(Environment.CurrentDirectory, MarkersDocXml));
                xmlDoc.Element("markers").Add(new XElement("marker", new XAttribute("address", search_string_tb)));
                xmlDoc.Save(Path.Combine(Environment.CurrentDirectory, MarkersDocXml));
            }
            else
            {
                MessageBox.Show("—начала откройте какую-нибудь страницу");
            }



        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab != null)
            {
                ((WebBrowser)tabControl.SelectedTab.Controls[0]).ShowSaveAsDialog();
            }
            else
            {
                MessageBox.Show("ƒл€ того чтобы сохранить страницу на диск, вам нужно на нее зайти");
            }
        }

        private void Browser_Load(object sender, EventArgs e)
        {
           
        }
        
    }
}
