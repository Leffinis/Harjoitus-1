namespace Harjoitus_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer? components = null;

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
            this.subjectLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentBox = new System.Windows.Forms.RichTextBox();
            this.quizOptionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.quizResultLabel = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.counterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectLabel.Location = new System.Drawing.Point(32, 32);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(77, 21);
            this.subjectLabel.TabIndex = 0;
            this.subjectLabel.Text = "Предмет";
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(28, 72);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(744, 74);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Название урока";
            // 
            // contentBox
            // 
            this.contentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentBox.BackColor = System.Drawing.SystemColors.Control;
            this.contentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contentBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contentBox.Location = new System.Drawing.Point(32, 160);
            this.contentBox.Name = "contentBox";
            this.contentBox.ReadOnly = true;
            this.contentBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.contentBox.Size = new System.Drawing.Size(740, 200);
            this.contentBox.TabIndex = 2;
            this.contentBox.Text = "";
            // 
            // quizOptionsPanel
            // 
            this.quizOptionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quizOptionsPanel.AutoScroll = true;
            this.quizOptionsPanel.AutoSize = false;
            this.quizOptionsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.quizOptionsPanel.Location = new System.Drawing.Point(32, 380);
            this.quizOptionsPanel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.quizOptionsPanel.Name = "quizOptionsPanel";
            this.quizOptionsPanel.Size = new System.Drawing.Size(740, 140);
            this.quizOptionsPanel.TabIndex = 3;
            this.quizOptionsPanel.Visible = false;
            this.quizOptionsPanel.WrapContents = false;
            this.quizOptionsPanel.SizeChanged += new System.EventHandler(this.quizOptionsPanel_SizeChanged);
            // 
            // quizResultLabel
            // 
            this.quizResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quizResultLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.quizResultLabel.Location = new System.Drawing.Point(32, 532);
            this.quizResultLabel.Name = "quizResultLabel";
            this.quizResultLabel.Size = new System.Drawing.Size(740, 40);
            this.quizResultLabel.TabIndex = 4;
            this.quizResultLabel.Text = "Результат квиза";
            this.quizResultLabel.Visible = false;
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previousButton.Location = new System.Drawing.Point(32, 600);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(160, 44);
            this.previousButton.TabIndex = 5;
            this.previousButton.Text = "Назад";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Location = new System.Drawing.Point(612, 600);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(160, 44);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Вперёд";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // counterLabel
            // 
            this.counterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counterLabel.AutoSize = true;
            this.counterLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.counterLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.counterLabel.Location = new System.Drawing.Point(712, 36);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(47, 19);
            this.counterLabel.TabIndex = 7;
            this.counterLabel.Text = "1/1";
            this.counterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 681);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.quizResultLabel);
            this.Controls.Add(this.quizOptionsPanel);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.subjectLabel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Учебная лента";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subjectLabel = null!;
        private System.Windows.Forms.Label titleLabel = null!;
        private System.Windows.Forms.RichTextBox contentBox = null!;
        private System.Windows.Forms.FlowLayoutPanel quizOptionsPanel = null!;
        private System.Windows.Forms.Label quizResultLabel = null!;
        private System.Windows.Forms.Button previousButton = null!;
        private System.Windows.Forms.Button nextButton = null!;
        private System.Windows.Forms.Label counterLabel = null!;
    }
}
