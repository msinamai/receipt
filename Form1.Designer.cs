namespace receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            firstnametxt = new TextBox();
            leveltxt = new TextBox();
            regnotxt = new TextBox();
            progrmtxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            amnttxt = new TextBox();
            label6 = new Label();
            generate = new Button();
            printbtn = new Button();
            resetbtn = new Button();
            resulttxtbx = new RichTextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            SuspendLayout();
            // 
            // firstnametxt
            // 
            firstnametxt.Location = new Point(141, 141);
            firstnametxt.Name = "firstnametxt";
            firstnametxt.Size = new Size(168, 27);
            firstnametxt.TabIndex = 0;
            // 
            // leveltxt
            // 
            leveltxt.Location = new Point(141, 325);
            leveltxt.Name = "leveltxt";
            leveltxt.Size = new Size(168, 27);
            leveltxt.TabIndex = 1;
            // 
            // regnotxt
            // 
            regnotxt.Location = new Point(141, 236);
            regnotxt.Name = "regnotxt";
            regnotxt.Size = new Size(168, 27);
            regnotxt.TabIndex = 2;
            // 
            // progrmtxt
            // 
            progrmtxt.Location = new Point(141, 406);
            progrmtxt.Name = "progrmtxt";
            progrmtxt.Size = new Size(168, 27);
            progrmtxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 141);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 5;
            label1.Text = "FIRSTNAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 240);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 6;
            label2.Text = "REG NO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 329);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 7;
            label3.Text = "LEVEL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 410);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 8;
            label4.Text = "PROGRAM:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(25, 468);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 9;
            label5.Text = "AMOUNT:";
            // 
            // amnttxt
            // 
            amnttxt.Location = new Point(141, 467);
            amnttxt.Name = "amnttxt";
            amnttxt.Size = new Size(168, 27);
            amnttxt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(258, 33);
            label6.Name = "label6";
            label6.Size = new Size(302, 38);
            label6.TabIndex = 11;
            label6.Text = "RECEIPT GENERATOR:";
            // 
            // generate
            // 
            generate.BackColor = SystemColors.ActiveCaption;
            generate.FlatStyle = FlatStyle.Flat;
            generate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            generate.Location = new Point(25, 558);
            generate.Name = "generate";
            generate.Size = new Size(116, 29);
            generate.TabIndex = 12;
            generate.Text = "GENERATE";
            generate.UseVisualStyleBackColor = false;
            generate.Click += generate_Click;
            // 
            // printbtn
            // 
            printbtn.BackColor = SystemColors.ActiveCaption;
            printbtn.FlatStyle = FlatStyle.Flat;
            printbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            printbtn.Location = new Point(395, 558);
            printbtn.Name = "printbtn";
            printbtn.Size = new Size(116, 29);
            printbtn.TabIndex = 13;
            printbtn.Text = "PRINT";
            printbtn.UseVisualStyleBackColor = false;
            printbtn.Click += printbtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = SystemColors.ActiveCaption;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.Location = new Point(193, 558);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(116, 29);
            resetbtn.TabIndex = 14;
            resetbtn.Text = "RESET";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // resulttxtbx
            // 
            resulttxtbx.AcceptsTab = true;
            resulttxtbx.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            resulttxtbx.Location = new Point(395, 95);
            resulttxtbx.Name = "resulttxtbx";
            resulttxtbx.ReadOnly = true;
            resulttxtbx.ShowSelectionMargin = true;
            resulttxtbx.Size = new Size(376, 415);
            resulttxtbx.TabIndex = 15;
            resulttxtbx.Text = "";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 631);
            Controls.Add(resulttxtbx);
            Controls.Add(resetbtn);
            Controls.Add(printbtn);
            Controls.Add(generate);
            Controls.Add(label6);
            Controls.Add(amnttxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progrmtxt);
            Controls.Add(regnotxt);
            Controls.Add(leveltxt);
            Controls.Add(firstnametxt);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstnametxt;
        private TextBox leveltxt;
        private TextBox regnotxt;
        private TextBox progrmtxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox amnttxt;
        private Label label6;
        private Button generate;
        private Button printbtn;
        private Button resetbtn;
        private RichTextBox resulttxtbx;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
