namespace ApexBrowser
{
    partial class Form1
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
            buttonBack = new Button();
            buttonForward = new Button();
            buttonReload = new Button();
            buttonSearch = new Button();
            textBoxUrl = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button5 = new Button();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(49, 29);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "<";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonForward
            // 
            buttonForward.Location = new Point(67, 12);
            buttonForward.Name = "buttonForward";
            buttonForward.Size = new Size(49, 29);
            buttonForward.TabIndex = 1;
            buttonForward.Text = ">";
            buttonForward.UseVisualStyleBackColor = true;
            buttonForward.Click += buttonForward_Click;
            // 
            // buttonReload
            // 
            buttonReload.Location = new Point(122, 12);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(49, 29);
            buttonReload.TabIndex = 2;
            buttonReload.Text = "R";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(799, 12);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(177, 13);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(616, 27);
            textBoxUrl.TabIndex = 4;
            textBoxUrl.KeyDown += textBoxUrl_KeyDown;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 63);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(991, 441);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // button5
            // 
            button5.Location = new Point(909, 13);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 6;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 516);
            Controls.Add(button5);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBoxUrl);
            Controls.Add(buttonSearch);
            Controls.Add(buttonReload);
            Controls.Add(buttonForward);
            Controls.Add(buttonBack);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Button buttonForward;
        private Button buttonReload;
        private Button buttonSearch;
        private TextBox textBoxUrl;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button5;
    }
}
