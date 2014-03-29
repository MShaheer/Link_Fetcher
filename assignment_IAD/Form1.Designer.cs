namespace assignment_IAD
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.GO = new System.Windows.Forms.Button();
            this.Find_Links = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(314, 373);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(343, 174);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(233, 277);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // GO
            // 
            this.GO.Location = new System.Drawing.Point(414, 25);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(75, 23);
            this.GO.TabIndex = 2;
            this.GO.Text = "GO";
            this.GO.UseVisualStyleBackColor = true;
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // Find_Links
            // 
            this.Find_Links.Location = new System.Drawing.Point(414, 115);
            this.Find_Links.Name = "Find_Links";
            this.Find_Links.Size = new System.Drawing.Size(75, 23);
            this.Find_Links.TabIndex = 3;
            this.Find_Links.Text = "Links";
            this.Find_Links.UseVisualStyleBackColor = true;
            this.Find_Links.Click += new System.EventHandler(this.Find_Links_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 4;
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(12, 30);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(18, 13);
            this.url.TabIndex = 5;
            this.url.Text = "url";
            this.url.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 497);
            this.Controls.Add(this.url);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Find_Links);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button GO;
        private System.Windows.Forms.Button Find_Links;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label url;
    }
}

