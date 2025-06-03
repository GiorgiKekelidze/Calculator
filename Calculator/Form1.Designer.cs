using System.Drawing;
using System.Windows.Forms;

namespace Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.EqlBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SubsBtn = new System.Windows.Forms.Button();
            this.MultBtn = new System.Windows.Forms.Button();
            this.DivBtn = new System.Windows.Forms.Button();
            this.PointBtn = new System.Windows.Forms.Button();
            this.OneBtn = new System.Windows.Forms.Button();
            this.FourBtn = new System.Windows.Forms.Button();
            this.NineBtn = new System.Windows.Forms.Button();
            this.SqrtBtn = new System.Windows.Forms.Button();
            this.SqrBtn = new System.Windows.Forms.Button();
            this.OneDivBtn = new System.Windows.Forms.Button();
            this.EightBtn = new System.Windows.Forms.Button();
            this.SevenBtn = new System.Windows.Forms.Button();
            this.FiveBtn = new System.Windows.Forms.Button();
            this.SixBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.ThreeBtn = new System.Windows.Forms.Button();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.ModulusBtn = new System.Windows.Forms.Button();
            this.DltBtn = new System.Windows.Forms.Button();
            this.CBtn = new System.Windows.Forms.Button();
            this.CEBtn = new System.Windows.Forms.Button();
            this.PerCentage = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EqlBtn
            // 
            this.EqlBtn.Location = new System.Drawing.Point(298, 546);
            this.EqlBtn.Name = "EqlBtn";
            this.EqlBtn.Size = new System.Drawing.Size(92, 56);
            this.EqlBtn.TabIndex = 1;
            this.EqlBtn.Text = "=";
            this.EqlBtn.UseVisualStyleBackColor = true;
            this.EqlBtn.Click += new System.EventHandler(this.EqlBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(298, 484);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(92, 56);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SubsBtn
            // 
            this.SubsBtn.Location = new System.Drawing.Point(298, 422);
            this.SubsBtn.Name = "SubsBtn";
            this.SubsBtn.Size = new System.Drawing.Size(92, 56);
            this.SubsBtn.TabIndex = 3;
            this.SubsBtn.Text = "-";
            this.SubsBtn.UseVisualStyleBackColor = true;
            this.SubsBtn.Click += new System.EventHandler(this.SubsBtn_Click);
            // 
            // MultBtn
            // 
            this.MultBtn.Location = new System.Drawing.Point(298, 360);
            this.MultBtn.Name = "MultBtn";
            this.MultBtn.Size = new System.Drawing.Size(92, 56);
            this.MultBtn.TabIndex = 4;
            this.MultBtn.Text = "X";
            this.MultBtn.UseVisualStyleBackColor = true;
            this.MultBtn.Click += new System.EventHandler(this.MultBtn_Click);
            // 
            // DivBtn
            // 
            this.DivBtn.Location = new System.Drawing.Point(298, 298);
            this.DivBtn.Name = "DivBtn";
            this.DivBtn.Size = new System.Drawing.Size(92, 56);
            this.DivBtn.TabIndex = 5;
            this.DivBtn.Text = "/";
            this.DivBtn.UseVisualStyleBackColor = true;
            this.DivBtn.Click += new System.EventHandler(this.DivBtn_Click);
            // 
            // PointBtn
            // 
            this.PointBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointBtn.Location = new System.Drawing.Point(200, 546);
            this.PointBtn.Name = "PointBtn";
            this.PointBtn.Size = new System.Drawing.Size(92, 56);
            this.PointBtn.TabIndex = 6;
            this.PointBtn.Text = ",";
            this.PointBtn.UseVisualStyleBackColor = true;
            this.PointBtn.Click += new System.EventHandler(this.PointBtn_Click);
            // 
            // OneBtn
            // 
            this.OneBtn.Location = new System.Drawing.Point(4, 484);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(92, 56);
            this.OneBtn.TabIndex = 7;
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = true;
            this.OneBtn.Click += new System.EventHandler(this.OneBtn_Click);
            // 
            // FourBtn
            // 
            this.FourBtn.Location = new System.Drawing.Point(4, 422);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(92, 56);
            this.FourBtn.TabIndex = 8;
            this.FourBtn.Text = "4";
            this.FourBtn.UseVisualStyleBackColor = true;
            this.FourBtn.Click += new System.EventHandler(this.FourBtn_Click);
            // 
            // NineBtn
            // 
            this.NineBtn.Location = new System.Drawing.Point(200, 360);
            this.NineBtn.Name = "NineBtn";
            this.NineBtn.Size = new System.Drawing.Size(92, 56);
            this.NineBtn.TabIndex = 9;
            this.NineBtn.Text = "9";
            this.NineBtn.UseVisualStyleBackColor = true;
            this.NineBtn.Click += new System.EventHandler(this.NineBtn_Click);
            // 
            // SqrtBtn
            // 
            this.SqrtBtn.Location = new System.Drawing.Point(200, 298);
            this.SqrtBtn.Name = "SqrtBtn";
            this.SqrtBtn.Size = new System.Drawing.Size(92, 56);
            this.SqrtBtn.TabIndex = 10;
            this.SqrtBtn.Text = "Sqrt";
            this.SqrtBtn.UseVisualStyleBackColor = true;
            this.SqrtBtn.Click += new System.EventHandler(this.SqrtBtn_Click);
            // 
            // SqrBtn
            // 
            this.SqrBtn.Location = new System.Drawing.Point(102, 298);
            this.SqrBtn.Name = "SqrBtn";
            this.SqrBtn.Size = new System.Drawing.Size(92, 56);
            this.SqrBtn.TabIndex = 11;
            this.SqrBtn.Text = "X^2";
            this.SqrBtn.UseVisualStyleBackColor = true;
            this.SqrBtn.Click += new System.EventHandler(this.SqrBtn_Click);
            // 
            // OneDivBtn
            // 
            this.OneDivBtn.Location = new System.Drawing.Point(4, 298);
            this.OneDivBtn.Name = "OneDivBtn";
            this.OneDivBtn.Size = new System.Drawing.Size(92, 56);
            this.OneDivBtn.TabIndex = 12;
            this.OneDivBtn.Text = "1/X";
            this.OneDivBtn.UseVisualStyleBackColor = true;
            this.OneDivBtn.Click += new System.EventHandler(this.OneDivBtn_Click);
            // 
            // EightBtn
            // 
            this.EightBtn.Location = new System.Drawing.Point(102, 360);
            this.EightBtn.Name = "EightBtn";
            this.EightBtn.Size = new System.Drawing.Size(92, 56);
            this.EightBtn.TabIndex = 13;
            this.EightBtn.Text = "8";
            this.EightBtn.UseVisualStyleBackColor = true;
            this.EightBtn.Click += new System.EventHandler(this.EightBtn_Click);
            // 
            // SevenBtn
            // 
            this.SevenBtn.Location = new System.Drawing.Point(4, 360);
            this.SevenBtn.Name = "SevenBtn";
            this.SevenBtn.Size = new System.Drawing.Size(92, 56);
            this.SevenBtn.TabIndex = 14;
            this.SevenBtn.Text = "7";
            this.SevenBtn.UseVisualStyleBackColor = true;
            this.SevenBtn.Click += new System.EventHandler(this.SevenBtn_Click);
            // 
            // FiveBtn
            // 
            this.FiveBtn.Location = new System.Drawing.Point(102, 422);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(92, 56);
            this.FiveBtn.TabIndex = 15;
            this.FiveBtn.Text = "5";
            this.FiveBtn.UseVisualStyleBackColor = true;
            this.FiveBtn.Click += new System.EventHandler(this.FiveBtn_Click);
            // 
            // SixBtn
            // 
            this.SixBtn.Location = new System.Drawing.Point(200, 422);
            this.SixBtn.Name = "SixBtn";
            this.SixBtn.Size = new System.Drawing.Size(92, 56);
            this.SixBtn.TabIndex = 16;
            this.SixBtn.Text = "6";
            this.SixBtn.UseVisualStyleBackColor = true;
            this.SixBtn.Click += new System.EventHandler(this.SixBtn_Click);
            // 
            // TwoBtn
            // 
            this.TwoBtn.Location = new System.Drawing.Point(102, 484);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(92, 56);
            this.TwoBtn.TabIndex = 17;
            this.TwoBtn.Text = "2";
            this.TwoBtn.UseVisualStyleBackColor = true;
            this.TwoBtn.Click += new System.EventHandler(this.TwoBtn_Click);
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.Location = new System.Drawing.Point(200, 484);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(92, 56);
            this.ThreeBtn.TabIndex = 18;
            this.ThreeBtn.Text = "3";
            this.ThreeBtn.UseVisualStyleBackColor = true;
            this.ThreeBtn.Click += new System.EventHandler(this.ThreeBtn_Click);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroBtn.Location = new System.Drawing.Point(102, 546);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(92, 56);
            this.ZeroBtn.TabIndex = 19;
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = true;
            this.ZeroBtn.Click += new System.EventHandler(this.ZeroBtn_Click);
            // 
            // ModulusBtn
            // 
            this.ModulusBtn.Location = new System.Drawing.Point(4, 546);
            this.ModulusBtn.Name = "ModulusBtn";
            this.ModulusBtn.Size = new System.Drawing.Size(92, 56);
            this.ModulusBtn.TabIndex = 20;
            this.ModulusBtn.Text = "+/-";
            this.ModulusBtn.UseVisualStyleBackColor = true;
            this.ModulusBtn.Click += new System.EventHandler(this.ModulusBtn_Click);
            // 
            // DltBtn
            // 
            this.DltBtn.Location = new System.Drawing.Point(298, 236);
            this.DltBtn.Name = "DltBtn";
            this.DltBtn.Size = new System.Drawing.Size(92, 56);
            this.DltBtn.TabIndex = 21;
            this.DltBtn.Text = "Delete";
            this.DltBtn.UseVisualStyleBackColor = true;
            this.DltBtn.Click += new System.EventHandler(this.DltBtn_Click);
            // 
            // CBtn
            // 
            this.CBtn.Location = new System.Drawing.Point(200, 236);
            this.CBtn.Name = "CBtn";
            this.CBtn.Size = new System.Drawing.Size(92, 56);
            this.CBtn.TabIndex = 22;
            this.CBtn.Text = "C";
            this.CBtn.UseVisualStyleBackColor = true;
            this.CBtn.Click += new System.EventHandler(this.CBtn_Click);
            // 
            // CEBtn
            // 
            this.CEBtn.Location = new System.Drawing.Point(102, 236);
            this.CEBtn.Name = "CEBtn";
            this.CEBtn.Size = new System.Drawing.Size(92, 56);
            this.CEBtn.TabIndex = 23;
            this.CEBtn.Text = "CE";
            this.CEBtn.UseVisualStyleBackColor = true;
            this.CEBtn.Click += new System.EventHandler(this.CEBtn_Click);
            // 
            // PerCentage
            // 
            this.PerCentage.Location = new System.Drawing.Point(4, 236);
            this.PerCentage.Name = "PerCentage";
            this.PerCentage.Size = new System.Drawing.Size(92, 56);
            this.PerCentage.TabIndex = 24;
            this.PerCentage.Text = "%";
            this.PerCentage.UseVisualStyleBackColor = true;
            this.PerCentage.Click += new System.EventHandler(this.PerCentage_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(4, 135);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(386, 56);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "0";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 603);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.PerCentage);
            this.Controls.Add(this.CEBtn);
            this.Controls.Add(this.CBtn);
            this.Controls.Add(this.DltBtn);
            this.Controls.Add(this.ModulusBtn);
            this.Controls.Add(this.ZeroBtn);
            this.Controls.Add(this.ThreeBtn);
            this.Controls.Add(this.TwoBtn);
            this.Controls.Add(this.SixBtn);
            this.Controls.Add(this.FiveBtn);
            this.Controls.Add(this.SevenBtn);
            this.Controls.Add(this.EightBtn);
            this.Controls.Add(this.OneDivBtn);
            this.Controls.Add(this.SqrBtn);
            this.Controls.Add(this.SqrtBtn);
            this.Controls.Add(this.NineBtn);
            this.Controls.Add(this.FourBtn);
            this.Controls.Add(this.OneBtn);
            this.Controls.Add(this.PointBtn);
            this.Controls.Add(this.DivBtn);
            this.Controls.Add(this.MultBtn);
            this.Controls.Add(this.SubsBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EqlBtn);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EqlBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SubsBtn;
        private System.Windows.Forms.Button MultBtn;
        private System.Windows.Forms.Button DivBtn;
        private System.Windows.Forms.Button PointBtn;
        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button FourBtn;
        private System.Windows.Forms.Button NineBtn;
        private System.Windows.Forms.Button SqrtBtn;
        private System.Windows.Forms.Button SqrBtn;
        private System.Windows.Forms.Button OneDivBtn;
        private System.Windows.Forms.Button EightBtn;
        private System.Windows.Forms.Button SevenBtn;
        private System.Windows.Forms.Button FiveBtn;
        private System.Windows.Forms.Button SixBtn;
        private System.Windows.Forms.Button TwoBtn;
        private System.Windows.Forms.Button ThreeBtn;
        private System.Windows.Forms.Button ZeroBtn;
        private System.Windows.Forms.Button ModulusBtn;
        private System.Windows.Forms.Button DltBtn;
        private System.Windows.Forms.Button CBtn;
        private System.Windows.Forms.Button CEBtn;
        private System.Windows.Forms.Button PerCentage;
        private RichTextBox richTextBox1;
    }
}

