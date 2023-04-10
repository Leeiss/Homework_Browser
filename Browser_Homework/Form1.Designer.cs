namespace Browser_Homework
{
    partial class Browser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            search_engine_toolStrip = new ToolStrip();
            back_btn = new ToolStripButton();
            forward_btn = new ToolStripButton();
            update_btn = new ToolStripButton();
            search_string_tb = new ToolStripTextBox();
            search_btn = new ToolStripButton();
            plus_btn = new ToolStripButton();
            minus_btn = new ToolStripButton();
            tabControl = new TabControl();
            mainpanel = new Panel();
            toolStrip1 = new ToolStrip();
            panel = new FlowLayoutPanel();
            mainpicture = new PictureBox();
            search_engine_toolStrip.SuspendLayout();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainpicture).BeginInit();
            SuspendLayout();
            // 
            // search_engine_toolStrip
            // 
            search_engine_toolStrip.BackColor = Color.FromArgb(226, 232, 223);
            search_engine_toolStrip.ImageScalingSize = new Size(32, 32);
            search_engine_toolStrip.Items.AddRange(new ToolStripItem[] { back_btn, forward_btn, update_btn, search_string_tb, search_btn, plus_btn, minus_btn });
            search_engine_toolStrip.Location = new Point(0, 0);
            search_engine_toolStrip.Name = "search_engine_toolStrip";
            search_engine_toolStrip.Padding = new Padding(0, 0, 4, 0);
            search_engine_toolStrip.Size = new Size(1378, 42);
            search_engine_toolStrip.TabIndex = 0;
            search_engine_toolStrip.Text = "toolStrip1";
            // 
            // back_btn
            // 
            back_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            back_btn.Image = (Image)resources.GetObject("back_btn.Image");
            back_btn.ImageTransparentColor = Color.Magenta;
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(46, 36);
            back_btn.Text = "toolStripButton1";
            back_btn.Click += back_btn_Click;
            // 
            // forward_btn
            // 
            forward_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            forward_btn.Image = (Image)resources.GetObject("forward_btn.Image");
            forward_btn.ImageTransparentColor = Color.Magenta;
            forward_btn.Name = "forward_btn";
            forward_btn.Size = new Size(46, 36);
            forward_btn.Text = "toolStripButton2";
            forward_btn.Click += forward_btn_Click;
            // 
            // update_btn
            // 
            update_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            update_btn.Image = (Image)resources.GetObject("update_btn.Image");
            update_btn.ImageTransparentColor = Color.Magenta;
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(46, 36);
            update_btn.Text = "toolStripButton3";
            update_btn.Click += update_btn_Click;
            // 
            // search_string_tb
            // 
            search_string_tb.BackColor = Color.FromArgb(226, 232, 223);
            search_string_tb.BorderStyle = BorderStyle.FixedSingle;
            search_string_tb.Name = "search_string_tb";
            search_string_tb.Size = new Size(900, 42);
            search_string_tb.Text = "https://www.Frogoogle.ru/";
            search_string_tb.KeyUp += searching2;
            search_string_tb.Click += search_string_click;
            // 
            // search_btn
            // 
            search_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            search_btn.Image = (Image)resources.GetObject("search_btn.Image");
            search_btn.ImageTransparentColor = Color.Magenta;
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(46, 36);
            search_btn.Text = "toolStripButton5";
            search_btn.Click += search_btn_Click;
            // 
            // plus_btn
            // 
            plus_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            plus_btn.Image = (Image)resources.GetObject("plus_btn.Image");
            plus_btn.ImageTransparentColor = Color.Magenta;
            plus_btn.Name = "plus_btn";
            plus_btn.Size = new Size(46, 36);
            plus_btn.Text = "toolStripButton6";
            plus_btn.Click += plus_btn_Click;
            // 
            // minus_btn
            // 
            minus_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            minus_btn.Image = (Image)resources.GetObject("minus_btn.Image");
            minus_btn.ImageTransparentColor = Color.Magenta;
            minus_btn.Name = "minus_btn";
            minus_btn.Size = new Size(46, 36);
            minus_btn.Text = "toolStripButton7";
            minus_btn.Click += minus_btn_Click;
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Location = new Point(0, 45);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1378, 884);
            tabControl.TabIndex = 1;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.ButtonHighlight;
            mainpanel.Controls.Add(toolStrip1);
            mainpanel.Controls.Add(panel);
            mainpanel.Controls.Add(mainpicture);
            mainpanel.Location = new Point(0, 45);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1378, 884);
            mainpanel.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1378, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(226, 232, 223);
            panel.Location = new Point(0, 831);
            panel.Name = "panel";
            panel.Size = new Size(1452, 28);
            panel.TabIndex = 3;
            // 
            // mainpicture
            // 
            mainpicture.Image = (Image)resources.GetObject("mainpicture.Image");
            mainpicture.Location = new Point(203, 191);
            mainpicture.Name = "mainpicture";
            mainpicture.Size = new Size(890, 336);
            mainpicture.TabIndex = 2;
            mainpicture.TabStop = false;
            // 
            // Browser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 929);
            Controls.Add(search_engine_toolStrip);
            Controls.Add(tabControl);
            Controls.Add(mainpanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            Name = "Browser";
            Text = "Web-браузер";
            Activated += activate;
            search_engine_toolStrip.ResumeLayout(false);
            search_engine_toolStrip.PerformLayout();
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainpicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip search_engine_toolStrip;
        private ToolStripButton back_btn;
        private ToolStripButton forward_btn;
        private ToolStripButton update_btn;
        private ToolStripTextBox search_string_tb;
        private ToolStripButton search_btn;
        private ToolStripButton plus_btn;
        private ToolStripButton minus_btn;
        private TabControl tabControl;
        private Panel mainpanel;
        private PictureBox mainpicture;
        private FlowLayoutPanel panel;
        private ToolStrip toolStrip1;
    }
}