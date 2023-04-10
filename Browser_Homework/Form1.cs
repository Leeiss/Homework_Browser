using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Browser_Homework
{
    public partial class Browser : Form
    {
        int i = 0;
        public Browser()
        {
            InitializeComponent();
            panel.Visible = true;
            mainpicture.Visible = true;
            mainpanel.Visible = true;
            tabControl.Visible = false;

        }
        private void plus_btn_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
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
                panel.Visible = true;
                mainpicture.Visible = true;
                mainpanel.Visible = true;
                tabControl.Visible = false;
            }
            else if (String.IsNullOrEmpty(search_string_tb.Text) || search_string_tb.Text.Length > search_string_tb.MaxLength)
            {

                MessageBox.Show("Строка пуста");
                panel.Visible = false;
                mainpicture.Visible = false;
                mainpanel.Visible = false;
                tabControl.Visible = true;
            }
            else if (tabControl.SelectedTab == null)
            {

                MessageBox.Show("Перед тем как сделать поиск, создайте вкладку");
                panel.Visible = false;
                mainpicture.Visible = false;
                mainpanel.Visible = false;
                tabControl.Visible = true;
            }
            else
            {
                try
                {
                    panel.Visible = false;
                    mainpicture.Visible = false;
                    mainpanel.Visible = false;
                    tabControl.Visible = true;

                    ((WebBrowser)tabControl.SelectedTab.Controls[0]).Navigate(search_string_tb.Text);
                }
                catch
                {
                    MessageBox.Show("Такой страницы не существует");
                }
            }
        }

        private void activate(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(search_string_tb.Text) || search_string_tb.Text.Length > search_string_tb.MaxLength)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {

                ((WebBrowser)tabControl.SelectedTab.Controls[0]).GoBack();
            }
        }

        private void forward_btn_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).GoForward();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).Refresh();
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
                    panel.Visible = true;
                    mainpicture.Visible = true;
                    mainpanel.Visible = true;
                    tabControl.Visible = false;
                }
                else if (String.IsNullOrEmpty(search_string_tb.Text) || search_string_tb.Text.Length > search_string_tb.MaxLength)
                {

                    MessageBox.Show("Строка пуста");
                    panel.Visible = false;
                    mainpicture.Visible = false;
                    mainpanel.Visible = false;
                    tabControl.Visible = true;
                }
                else if (tabControl.SelectedTab == null)
                {

                    MessageBox.Show("Перед тем как сделать поиск, создайте вкладку");
                    panel.Visible = false;
                    mainpicture.Visible = false;
                    mainpanel.Visible = false;
                    tabControl.Visible = true;
                }
                else
                {
                    try
                    {
                        panel.Visible = false;
                        mainpicture.Visible = false;
                        mainpanel.Visible = false;
                        tabControl.Visible = true;

                        ((WebBrowser)tabControl.SelectedTab.Controls[0]).Navigate(search_string_tb.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Такой страницы не существует");
                    }
                }
            }

        }
    }
}