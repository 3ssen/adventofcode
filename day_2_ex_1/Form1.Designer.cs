﻿namespace day_2_ex_1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbRibbonResult = new System.Windows.Forms.TextBox();
            this.btnCalculateRibbonsize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(46, 26);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(198, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "calculate papersize";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(46, 55);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(198, 22);
            this.tbResult.TabIndex = 1;
            // 
            // tbRibbonResult
            // 
            this.tbRibbonResult.Location = new System.Drawing.Point(46, 112);
            this.tbRibbonResult.Name = "tbRibbonResult";
            this.tbRibbonResult.ReadOnly = true;
            this.tbRibbonResult.Size = new System.Drawing.Size(198, 22);
            this.tbRibbonResult.TabIndex = 3;
            // 
            // btnCalculateRibbonsize
            // 
            this.btnCalculateRibbonsize.Location = new System.Drawing.Point(46, 83);
            this.btnCalculateRibbonsize.Name = "btnCalculateRibbonsize";
            this.btnCalculateRibbonsize.Size = new System.Drawing.Size(198, 23);
            this.btnCalculateRibbonsize.TabIndex = 2;
            this.btnCalculateRibbonsize.Text = "calculate ribbonlength";
            this.btnCalculateRibbonsize.UseVisualStyleBackColor = true;
            this.btnCalculateRibbonsize.Click += new System.EventHandler(this.btnCalculateRibbonsize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.tbRibbonResult);
            this.Controls.Add(this.btnCalculateRibbonsize);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbRibbonResult;
        private System.Windows.Forms.Button btnCalculateRibbonsize;
    }
}

