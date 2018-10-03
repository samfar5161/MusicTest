namespace MusicTestGUI
{
    partial class Fretboard
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
            this.WbDisplay = new System.Windows.Forms.WebBrowser();
            this.OptionsPanel0 = new System.Windows.Forms.Panel();
            this.RbMinor = new System.Windows.Forms.RadioButton();
            this.RbMajor = new System.Windows.Forms.RadioButton();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnGo = new System.Windows.Forms.Button();
            this.CbKey = new System.Windows.Forms.ComboBox();
            this.LblKey = new System.Windows.Forms.Label();
            this.CbInstruments = new System.Windows.Forms.ComboBox();
            this.LblInstrument = new System.Windows.Forms.Label();
            this.GbScale = new System.Windows.Forms.GroupBox();
            this.LblSeventh = new System.Windows.Forms.Label();
            this.LblSixth = new System.Windows.Forms.Label();
            this.LblFifth = new System.Windows.Forms.Label();
            this.LblFourth = new System.Windows.Forms.Label();
            this.LblThird = new System.Windows.Forms.Label();
            this.LblSecond = new System.Windows.Forms.Label();
            this.LblFirst = new System.Windows.Forms.Label();
            this.OptionsPanel0.SuspendLayout();
            this.GbScale.SuspendLayout();
            this.SuspendLayout();
            // 
            // WbDisplay
            // 
            this.WbDisplay.Location = new System.Drawing.Point(12, 377);
            this.WbDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.WbDisplay.Name = "WbDisplay";
            this.WbDisplay.ScrollBarsEnabled = false;
            this.WbDisplay.Size = new System.Drawing.Size(1534, 265);
            this.WbDisplay.TabIndex = 1;
            this.WbDisplay.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // OptionsPanel0
            // 
            this.OptionsPanel0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionsPanel0.Controls.Add(this.RbMinor);
            this.OptionsPanel0.Controls.Add(this.RbMajor);
            this.OptionsPanel0.Controls.Add(this.BtnClear);
            this.OptionsPanel0.Controls.Add(this.BtnGo);
            this.OptionsPanel0.Controls.Add(this.CbKey);
            this.OptionsPanel0.Controls.Add(this.LblKey);
            this.OptionsPanel0.Controls.Add(this.CbInstruments);
            this.OptionsPanel0.Controls.Add(this.LblInstrument);
            this.OptionsPanel0.Location = new System.Drawing.Point(12, 13);
            this.OptionsPanel0.Name = "OptionsPanel0";
            this.OptionsPanel0.Size = new System.Drawing.Size(489, 135);
            this.OptionsPanel0.TabIndex = 2;
            // 
            // RbMinor
            // 
            this.RbMinor.AutoSize = true;
            this.RbMinor.Location = new System.Drawing.Point(19, 96);
            this.RbMinor.Name = "RbMinor";
            this.RbMinor.Size = new System.Drawing.Size(64, 21);
            this.RbMinor.TabIndex = 8;
            this.RbMinor.TabStop = true;
            this.RbMinor.Text = "Minor";
            this.RbMinor.UseVisualStyleBackColor = true;
            // 
            // RbMajor
            // 
            this.RbMajor.AutoSize = true;
            this.RbMajor.Checked = true;
            this.RbMajor.Location = new System.Drawing.Point(19, 68);
            this.RbMajor.Name = "RbMajor";
            this.RbMajor.Size = new System.Drawing.Size(64, 21);
            this.RbMajor.TabIndex = 7;
            this.RbMajor.TabStop = true;
            this.RbMajor.Text = "Major";
            this.RbMajor.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(396, 80);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 31);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnGo
            // 
            this.BtnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGo.Location = new System.Drawing.Point(315, 80);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(75, 31);
            this.BtnGo.TabIndex = 4;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // CbKey
            // 
            this.CbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbKey.FormattingEnabled = true;
            this.CbKey.Location = new System.Drawing.Point(337, 10);
            this.CbKey.Name = "CbKey";
            this.CbKey.Size = new System.Drawing.Size(131, 26);
            this.CbKey.TabIndex = 3;
            this.CbKey.Text = "Select Key";
            // 
            // LblKey
            // 
            this.LblKey.AutoSize = true;
            this.LblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKey.Location = new System.Drawing.Point(294, 12);
            this.LblKey.Name = "LblKey";
            this.LblKey.Size = new System.Drawing.Size(37, 20);
            this.LblKey.TabIndex = 2;
            this.LblKey.Text = "Key";
            // 
            // CbInstruments
            // 
            this.CbInstruments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbInstruments.FormattingEnabled = true;
            this.CbInstruments.Location = new System.Drawing.Point(109, 10);
            this.CbInstruments.Name = "CbInstruments";
            this.CbInstruments.Size = new System.Drawing.Size(166, 26);
            this.CbInstruments.TabIndex = 1;
            this.CbInstruments.Text = "Select Instrument";
            // 
            // LblInstrument
            // 
            this.LblInstrument.AutoSize = true;
            this.LblInstrument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInstrument.Location = new System.Drawing.Point(15, 12);
            this.LblInstrument.Name = "LblInstrument";
            this.LblInstrument.Size = new System.Drawing.Size(88, 20);
            this.LblInstrument.TabIndex = 0;
            this.LblInstrument.Text = "Instrument";
            // 
            // GbScale
            // 
            this.GbScale.Controls.Add(this.LblSeventh);
            this.GbScale.Controls.Add(this.LblSixth);
            this.GbScale.Controls.Add(this.LblFifth);
            this.GbScale.Controls.Add(this.LblFourth);
            this.GbScale.Controls.Add(this.LblThird);
            this.GbScale.Controls.Add(this.LblSecond);
            this.GbScale.Controls.Add(this.LblFirst);
            this.GbScale.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GbScale.Location = new System.Drawing.Point(529, 12);
            this.GbScale.Name = "GbScale";
            this.GbScale.Size = new System.Drawing.Size(444, 91);
            this.GbScale.TabIndex = 3;
            this.GbScale.TabStop = false;
            this.GbScale.Text = "Scale";
            // 
            // LblSeventh
            // 
            this.LblSeventh.AutoSize = true;
            this.LblSeventh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeventh.Location = new System.Drawing.Point(367, 38);
            this.LblSeventh.Name = "LblSeventh";
            this.LblSeventh.Size = new System.Drawing.Size(23, 25);
            this.LblSeventh.TabIndex = 6;
            this.LblSeventh.Text = "1";
            // 
            // LblSixth
            // 
            this.LblSixth.AutoSize = true;
            this.LblSixth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSixth.Location = new System.Drawing.Point(315, 38);
            this.LblSixth.Name = "LblSixth";
            this.LblSixth.Size = new System.Drawing.Size(23, 25);
            this.LblSixth.TabIndex = 5;
            this.LblSixth.Text = "1";
            // 
            // LblFifth
            // 
            this.LblFifth.AutoSize = true;
            this.LblFifth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFifth.Location = new System.Drawing.Point(263, 38);
            this.LblFifth.Name = "LblFifth";
            this.LblFifth.Size = new System.Drawing.Size(23, 25);
            this.LblFifth.TabIndex = 4;
            this.LblFifth.Text = "1";
            // 
            // LblFourth
            // 
            this.LblFourth.AutoSize = true;
            this.LblFourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFourth.Location = new System.Drawing.Point(211, 38);
            this.LblFourth.Name = "LblFourth";
            this.LblFourth.Size = new System.Drawing.Size(23, 25);
            this.LblFourth.TabIndex = 3;
            this.LblFourth.Text = "1";
            // 
            // LblThird
            // 
            this.LblThird.AutoSize = true;
            this.LblThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblThird.Location = new System.Drawing.Point(159, 38);
            this.LblThird.Name = "LblThird";
            this.LblThird.Size = new System.Drawing.Size(23, 25);
            this.LblThird.TabIndex = 2;
            this.LblThird.Text = "1";
            // 
            // LblSecond
            // 
            this.LblSecond.AutoSize = true;
            this.LblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSecond.Location = new System.Drawing.Point(107, 38);
            this.LblSecond.Name = "LblSecond";
            this.LblSecond.Size = new System.Drawing.Size(23, 25);
            this.LblSecond.TabIndex = 1;
            this.LblSecond.Text = "1";
            // 
            // LblFirst
            // 
            this.LblFirst.AutoSize = true;
            this.LblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirst.Location = new System.Drawing.Point(55, 38);
            this.LblFirst.Name = "LblFirst";
            this.LblFirst.Size = new System.Drawing.Size(23, 25);
            this.LblFirst.TabIndex = 0;
            this.LblFirst.Text = "1";
            // 
            // Fretboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 693);
            this.Controls.Add(this.GbScale);
            this.Controls.Add(this.OptionsPanel0);
            this.Controls.Add(this.WbDisplay);
            this.Name = "Fretboard";
            this.Text = "Fretboard";
            this.Load += new System.EventHandler(this.Fretboard_Load);
            this.OptionsPanel0.ResumeLayout(false);
            this.OptionsPanel0.PerformLayout();
            this.GbScale.ResumeLayout(false);
            this.GbScale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WbDisplay;
        private System.Windows.Forms.Panel OptionsPanel0;
        private System.Windows.Forms.ComboBox CbInstruments;
        private System.Windows.Forms.Label LblInstrument;
        private System.Windows.Forms.ComboBox CbKey;
        private System.Windows.Forms.Label LblKey;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.RadioButton RbMinor;
        private System.Windows.Forms.RadioButton RbMajor;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.GroupBox GbScale;
        private System.Windows.Forms.Label LblFirst;
        private System.Windows.Forms.Label LblSeventh;
        private System.Windows.Forms.Label LblSixth;
        private System.Windows.Forms.Label LblFifth;
        private System.Windows.Forms.Label LblFourth;
        private System.Windows.Forms.Label LblThird;
        private System.Windows.Forms.Label LblSecond;
    }
}

