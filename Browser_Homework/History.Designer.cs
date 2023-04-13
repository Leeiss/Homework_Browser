namespace Browser_Homework
{
    partial class History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            show_btn = new Button();
            addresses_lb = new ListBox();
            lbl_history = new Label();
            panel = new FlowLayoutPanel();
            clear_btn = new Button();
            SuspendLayout();
            // 
            // show_btn
            // 
            show_btn.BackColor = Color.FromArgb(226, 232, 223);
            show_btn.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            show_btn.Location = new Point(742, 226);
            show_btn.Name = "show_btn";
            show_btn.Size = new Size(150, 46);
            show_btn.TabIndex = 13;
            show_btn.Text = "Открыть";
            show_btn.UseVisualStyleBackColor = false;
            show_btn.Visible = false;
            show_btn.Click += show_btn_Click;
            // 
            // addresses_lb
            // 
            addresses_lb.Font = new Font("XO Courser", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            addresses_lb.FormattingEnabled = true;
            addresses_lb.ItemHeight = 31;
            addresses_lb.Location = new Point(19, 226);
            addresses_lb.Name = "addresses_lb";
            addresses_lb.Size = new Size(717, 779);
            addresses_lb.TabIndex = 12;
            addresses_lb.SelectedIndexChanged += addresses_lb_SelectedIndexChanged;
            // 
            // lbl_history
            // 
            lbl_history.AutoSize = true;
            lbl_history.Font = new Font("XO Courser", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_history.ForeColor = SystemColors.ControlDark;
            lbl_history.Location = new Point(19, 63);
            lbl_history.Name = "lbl_history";
            lbl_history.Size = new Size(634, 82);
            lbl_history.TabIndex = 11;
            lbl_history.Text = "История просмотра страниц за\r\nпоследнюю неделю";
            lbl_history.Click += lbl_history_Click;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(226, 232, 223);
            panel.Location = new Point(-32, 17);
            panel.Name = "panel";
            panel.Size = new Size(1134, 32);
            panel.TabIndex = 10;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.FromArgb(226, 232, 223);
            clear_btn.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            clear_btn.Location = new Point(19, 175);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(428, 45);
            clear_btn.TabIndex = 15;
            clear_btn.Text = " Очистить историю ";
            clear_btn.TextAlign = ContentAlignment.MiddleLeft;
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(932, 1060);
            Controls.Add(clear_btn);
            Controls.Add(show_btn);
            Controls.Add(addresses_lb);
            Controls.Add(lbl_history);
            Controls.Add(panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(958, 1131);
            Name = "History";
            Text = "История посещенных страниц";
            Load += History_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button show_btn;
        private ListBox addresses_lb;
        private Label lbl_history;
        private FlowLayoutPanel panel;
        private Button clear_btn;
    }
}