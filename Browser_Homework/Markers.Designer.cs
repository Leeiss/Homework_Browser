namespace Browser_Homework
{
    partial class Markers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Markers));
            panel = new FlowLayoutPanel();
            lbl_markers = new Label();
            markers_lb = new ListBox();
            show_btn = new Button();
            delete_btn = new Button();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(226, 232, 223);
            panel.Location = new Point(-27, 12);
            panel.Name = "panel";
            panel.Size = new Size(1134, 32);
            panel.TabIndex = 4;
            // 
            // lbl_markers
            // 
            lbl_markers.AutoSize = true;
            lbl_markers.Font = new Font("XO Courser", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_markers.ForeColor = SystemColors.ControlDark;
            lbl_markers.Location = new Point(15, 61);
            lbl_markers.Name = "lbl_markers";
            lbl_markers.Size = new Size(281, 60);
            lbl_markers.TabIndex = 5;
            lbl_markers.Text = "Закладки";
            // 
            // markers_lb
            // 
            markers_lb.Font = new Font("XO Courser", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            markers_lb.FormattingEnabled = true;
            markers_lb.ItemHeight = 31;
            markers_lb.Location = new Point(29, 156);
            markers_lb.Name = "markers_lb";
            markers_lb.Size = new Size(717, 779);
            markers_lb.TabIndex = 6;
            markers_lb.SelectedIndexChanged += markers_lb_SelectedIndexChanged;
            // 
            // show_btn
            // 
            show_btn.BackColor = Color.FromArgb(226, 232, 223);
            show_btn.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            show_btn.Location = new Point(752, 156);
            show_btn.Name = "show_btn";
            show_btn.Size = new Size(150, 46);
            show_btn.TabIndex = 14;
            show_btn.Text = "Открыть";
            show_btn.UseVisualStyleBackColor = false;
            show_btn.Visible = false;
            show_btn.Click += show_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.FromArgb(226, 232, 223);
            delete_btn.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point);
            delete_btn.Location = new Point(752, 223);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(150, 46);
            delete_btn.TabIndex = 15;
            delete_btn.Text = "Удалить";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Visible = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // Markers
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(923, 981);
            Controls.Add(delete_btn);
            Controls.Add(show_btn);
            Controls.Add(markers_lb);
            Controls.Add(lbl_markers);
            Controls.Add(panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(949, 1052);
            Name = "Markers";
            Text = "Мои закладки";
            Load += Markers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panel;
        private Label lbl_markers;
        private ListBox markers_lb;
        private Button show_btn;
        private Button delete_btn;
    }
}