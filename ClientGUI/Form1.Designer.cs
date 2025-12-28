namespace ClientGUI;

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
        panel1 = new Panel();
        panel2 = new Panel();
        panel3 = new Panel();
        label2 = new Label();
        panel6 = new Panel();
        panel5 = new Panel();
        label1 = new Label();
        panel7 = new Panel();
        panel4 = new Panel();
        button1 = new Button();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        panel5.SuspendLayout();
        panel4.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.LightGray;
        panel1.Controls.Add(panel2);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Padding = new Padding(20);
        panel1.Size = new Size(800, 450);
        panel1.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.BackColor = Color.Gainsboro;
        panel2.Controls.Add(panel3);
        panel2.Controls.Add(panel6);
        panel2.Controls.Add(panel5);
        panel2.Controls.Add(panel7);
        panel2.Controls.Add(panel4);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(20, 20);
        panel2.Name = "panel2";
        panel2.Padding = new Padding(50);
        panel2.Size = new Size(760, 410);
        panel2.TabIndex = 0;
        // 
        // panel3
        // 
        panel3.BackColor = Color.WhiteSmoke;
        panel3.Controls.Add(label2);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(50, 125);
        panel3.Name = "panel3";
        panel3.Padding = new Padding(5);
        panel3.Size = new Size(660, 170);
        panel3.TabIndex = 2;
        // 
        // label2
        // 
        label2.BackColor = Color.White;
        label2.Dock = DockStyle.Fill;
        label2.FlatStyle = FlatStyle.Popup;
        label2.Location = new Point(5, 5);
        label2.Name = "label2";
        label2.Size = new Size(650, 160);
        label2.TabIndex = 5;
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panel6
        // 
        panel6.BackColor = Color.Gainsboro;
        panel6.Dock = DockStyle.Top;
        panel6.Location = new Point(50, 115);
        panel6.MaximumSize = new Size(0, 10);
        panel6.Name = "panel6";
        panel6.Size = new Size(660, 10);
        panel6.TabIndex = 5;
        // 
        // panel5
        // 
        panel5.BackColor = Color.WhiteSmoke;
        panel5.Controls.Add(label1);
        panel5.Dock = DockStyle.Top;
        panel5.Location = new Point(50, 50);
        panel5.MinimumSize = new Size(0, 50);
        panel5.Name = "panel5";
        panel5.Padding = new Padding(5);
        panel5.Size = new Size(660, 65);
        panel5.TabIndex = 4;
        // 
        // label1
        // 
        label1.BackColor = Color.White;
        label1.Dock = DockStyle.Fill;
        label1.FlatStyle = FlatStyle.Popup;
        label1.Location = new Point(5, 5);
        label1.Name = "label1";
        label1.Size = new Size(650, 55);
        label1.TabIndex = 1;
        label1.Text = "ReadME Forge";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // panel7
        // 
        panel7.BackColor = Color.Gainsboro;
        panel7.Dock = DockStyle.Bottom;
        panel7.Location = new Point(50, 295);
        panel7.MaximumSize = new Size(0, 10);
        panel7.Name = "panel7";
        panel7.Size = new Size(660, 10);
        panel7.TabIndex = 6;
        // 
        // panel4
        // 
        panel4.BackColor = Color.WhiteSmoke;
        panel4.Controls.Add(button1);
        panel4.Dock = DockStyle.Bottom;
        panel4.Location = new Point(50, 305);
        panel4.Name = "panel4";
        panel4.Padding = new Padding(10);
        panel4.Size = new Size(660, 55);
        panel4.TabIndex = 3;
        // 
        // button1
        // 
        button1.Dock = DockStyle.Fill;
        button1.FlatStyle = FlatStyle.Popup;
        button1.Location = new Point(10, 10);
        button1.Name = "button1";
        button1.Size = new Size(640, 35);
        button1.TabIndex = 0;
        button1.Text = "Start";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(panel1);
        Name = "Form1";
        Text = "Form1";
        FormClosing += Form1_FormClosing;
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel5.ResumeLayout(false);
        panel4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Panel panel4;
    private Button button1;
    private Panel panel3;
    private Label label2;
    private Panel panel5;
    private Label label1;
    private Panel panel6;
    private Panel panel7;
}
