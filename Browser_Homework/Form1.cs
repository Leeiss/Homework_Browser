using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;

namespace Browser_Homework
{
    public partial class Browser : Form
    {
        int i = 0;
        public Browser()

        {
            InitializeComponent();
            mainpicture.Visible = true;
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
        private void plus_btn_Click(object sender, EventArgs e)
        {
            mainpicture.Visible = false;
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
        void webDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = ((WebBrowser)tabControl.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void search_string_click(object sender, EventArgs e)
        {
            search_string_tb.Text = string.Empty;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (search_string_tb.Text.Equals("https://www.Frogoogle.ru/"))
            {
                mainpicture.Visible = true;
                mainpanel.Visible = true;
                tabControl.Visible = false;
            }
            else if (String.IsNullOrEmpty(search_string_tb.Text) || search_string_tb.Text.Length > search_string_tb.MaxLength)
            {

                MessageBox.Show("������ �����");
                mainpicture.Visible = false;
                mainpanel.Visible = false;
                tabControl.Visible = true;
            }
            else if (tabControl.SelectedTab == null)
            {

                MessageBox.Show("����� ��� ��� ������� �����, �������� �������");
                mainpicture.Visible = false;
                mainpanel.Visible = false;
                tabControl.Visible = true;
            }
            else
            {
                mainpicture.Visible = false;
                mainpanel.Visible = false;
                tabControl.Visible = true;
                ((WebBrowser)tabControl.SelectedTab.Controls[0]).Navigate(search_string_tb.Text); 
                var xmlDoc = XDocument.Load(Path.Combine(Environment.CurrentDirectory, HistoryDocXml));
                xmlDoc.Element("urls").Add(new XElement("url"), new XElement("address", search_string_tb.Text), new XElement("date", DateTime.Now));
                xmlDoc.Save(Path.Combine(Environment.CurrentDirectory, HistoryDocXml));
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == null)
            {
                MessageBox.Show("�� �� ������ �������� ��������,��� ��� ����� �� ��������� ��������");
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
                MessageBox.Show("�� �� ������ ��������� �����, ��� ��� ����� �� ��������� ��������");
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
                MessageBox.Show("��� ���������� ������� �������� ��������");
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
                if (search_string_tb.Text.Equals("https://www.Frogoogle.ru/"))
                {
                    mainpicture.Visible = true;
                    mainpanel.Visible = true;
                    tabControl.Visible = false;
                }
                else if (String.IsNullOrEmpty(search_string_tb.Text) || search_string_tb.Text.Length > search_string_tb.MaxLength)
                {

                    MessageBox.Show("������ �����");

                    mainpicture.Visible = false;
                    mainpanel.Visible = false;
                    tabControl.Visible = true;
                }
                else if (tabControl.SelectedTab == null)
                {

                    MessageBox.Show("����� ��� ��� ������� �����, �������� �������");

                    mainpicture.Visible = false;
                    mainpanel.Visible = false;
                    tabControl.Visible = true;
                }
                else
                {
                    try
                    {

                        mainpicture.Visible = false;
                        mainpanel.Visible = false;
                        tabControl.Visible = true;

                        ((WebBrowser)tabControl.SelectedTab.Controls[0]).Navigate(search_string_tb.Text);
                    }
                    catch
                    {
                        MessageBox.Show("����� �������� �� ����������");
                    }
                }
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
                MessageBox.Show("��� ��������� �������� �������� ������� �������� ��");
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
                MessageBox.Show("������� �������� �����-������ ��������");
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
                MessageBox.Show("��� ���� ����� ��������� �������� �� ����, ��� ����� �� ��� �����");
            }
        }

    }
}