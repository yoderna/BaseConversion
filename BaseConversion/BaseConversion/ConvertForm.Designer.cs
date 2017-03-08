//////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//      Project:    Base Conversion
//
//    File Name:    ConvertForm.Designer.cs
//
//       Author:    Nicholas Yoder
//
//  Description:    ConvertForm is the only form for this application, containing all controls necessary
//                  to convert to decimal and from decimal. This file contains the controls and properties.
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace BaseConversion
{
    /// <summary>
    /// The main form for this application, allowing the user to convert to and from decimal
    /// </summary>
    partial class ConvertForm
    {
        /// <summary>
        /// Required designer variable
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertForm));
            this.labelDecimalVal = new System.Windows.Forms.Label();
            this.textBoxDecimalVal = new System.Windows.Forms.TextBox();
            this.textBoxNewBase = new System.Windows.Forms.TextBox();
            this.labelOtherBase = new System.Windows.Forms.Label();
            this.labelBase = new System.Windows.Forms.Label();
            this.numericUpDownBase = new System.Windows.Forms.NumericUpDown();
            this.labelDigits = new System.Windows.Forms.Label();
            this.numericUpDownDigits = new System.Windows.Forms.NumericUpDown();
            this.buttonFromDecimal = new System.Windows.Forms.Button();
            this.buttonToDecimal = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigits)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDecimalVal
            // 
            this.labelDecimalVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelDecimalVal.AutoSize = true;
            this.labelDecimalVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecimalVal.Location = new System.Drawing.Point(24, 19);
            this.labelDecimalVal.Name = "labelDecimalVal";
            this.labelDecimalVal.Size = new System.Drawing.Size(187, 20);
            this.labelDecimalVal.TabIndex = 0;
            this.labelDecimalVal.Text = "Decimal Integer Value";
            // 
            // textBoxDecimalVal
            // 
            this.textBoxDecimalVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxDecimalVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDecimalVal.ForeColor = System.Drawing.Color.Blue;
            this.textBoxDecimalVal.Location = new System.Drawing.Point(26, 49);
            this.textBoxDecimalVal.Name = "textBoxDecimalVal";
            this.textBoxDecimalVal.Size = new System.Drawing.Size(183, 20);
            this.textBoxDecimalVal.TabIndex = 1;
            this.textBoxDecimalVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDecimalVal_KeyPress);
            // 
            // textBoxNewBase
            // 
            this.textBoxNewBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxNewBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewBase.ForeColor = System.Drawing.Color.Red;
            this.textBoxNewBase.Location = new System.Drawing.Point(301, 49);
            this.textBoxNewBase.Name = "textBoxNewBase";
            this.textBoxNewBase.Size = new System.Drawing.Size(261, 20);
            this.textBoxNewBase.TabIndex = 2;
            this.textBoxNewBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNewBase_KeyPress);
            // 
            // labelOtherBase
            // 
            this.labelOtherBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelOtherBase.AutoSize = true;
            this.labelOtherBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtherBase.Location = new System.Drawing.Point(297, 19);
            this.labelOtherBase.Name = "labelOtherBase";
            this.labelOtherBase.Size = new System.Drawing.Size(198, 20);
            this.labelOtherBase.TabIndex = 3;
            this.labelOtherBase.Text = "Integer Value in Base 2";
            // 
            // labelBase
            // 
            this.labelBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelBase.AutoSize = true;
            this.labelBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBase.Location = new System.Drawing.Point(297, 81);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(46, 20);
            this.labelBase.TabIndex = 4;
            this.labelBase.Text = "Base";
            // 
            // numericUpDownBase
            // 
            this.numericUpDownBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericUpDownBase.Location = new System.Drawing.Point(349, 81);
            this.numericUpDownBase.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownBase.Name = "numericUpDownBase";
            this.numericUpDownBase.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownBase.TabIndex = 5;
            this.numericUpDownBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownBase.ValueChanged += new System.EventHandler(this.numericUpDownBase_ValueChanged);
            // 
            // labelDigits
            // 
            this.labelDigits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelDigits.AutoSize = true;
            this.labelDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDigits.Location = new System.Drawing.Point(395, 81);
            this.labelDigits.Name = "labelDigits";
            this.labelDigits.Size = new System.Drawing.Size(122, 20);
            this.labelDigits.TabIndex = 6;
            this.labelDigits.Text = "Places in Result";
            // 
            // numericUpDownDigits
            // 
            this.numericUpDownDigits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.numericUpDownDigits.Location = new System.Drawing.Point(522, 81);
            this.numericUpDownDigits.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownDigits.Name = "numericUpDownDigits";
            this.numericUpDownDigits.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownDigits.TabIndex = 7;
            this.numericUpDownDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonFromDecimal
            // 
            this.buttonFromDecimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonFromDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFromDecimal.Location = new System.Drawing.Point(28, 140);
            this.buttonFromDecimal.MaximumSize = new System.Drawing.Size(155, 30);
            this.buttonFromDecimal.MinimumSize = new System.Drawing.Size(155, 30);
            this.buttonFromDecimal.Name = "buttonFromDecimal";
            this.buttonFromDecimal.Size = new System.Drawing.Size(155, 30);
            this.buttonFromDecimal.TabIndex = 8;
            this.buttonFromDecimal.Text = "Convert From Decimal";
            this.buttonFromDecimal.UseVisualStyleBackColor = true;
            this.buttonFromDecimal.Click += new System.EventHandler(this.buttonFromDecimal_Click);
            // 
            // buttonToDecimal
            // 
            this.buttonToDecimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonToDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToDecimal.Location = new System.Drawing.Point(235, 140);
            this.buttonToDecimal.MaximumSize = new System.Drawing.Size(143, 30);
            this.buttonToDecimal.MinimumSize = new System.Drawing.Size(143, 30);
            this.buttonToDecimal.Name = "buttonToDecimal";
            this.buttonToDecimal.Size = new System.Drawing.Size(143, 30);
            this.buttonToDecimal.TabIndex = 9;
            this.buttonToDecimal.Text = "Convert To Decimal";
            this.buttonToDecimal.UseVisualStyleBackColor = true;
            this.buttonToDecimal.Click += new System.EventHandler(this.buttonToDecimal_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(442, 140);
            this.buttonExit.MaximumSize = new System.Drawing.Size(75, 30);
            this.buttonExit.MinimumSize = new System.Drawing.Size(75, 30);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 30);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 182);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonToDecimal);
            this.Controls.Add(this.buttonFromDecimal);
            this.Controls.Add(this.numericUpDownDigits);
            this.Controls.Add(this.labelDigits);
            this.Controls.Add(this.numericUpDownBase);
            this.Controls.Add(this.labelBase);
            this.Controls.Add(this.labelOtherBase);
            this.Controls.Add(this.textBoxNewBase);
            this.Controls.Add(this.textBoxDecimalVal);
            this.Controls.Add(this.labelDecimalVal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConvertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The label that identifies which textbox is textBoxDecimalVal
        /// </summary>
        private System.Windows.Forms.Label labelDecimalVal;

        /// <summary>
        /// The textbox in which decimal values are entered and received
        /// </summary>
        private System.Windows.Forms.TextBox textBoxDecimalVal;

        /// <summary>
        /// The textbox in which values of bases 2-16 are entered and received
        /// </summary>
        private System.Windows.Forms.TextBox textBoxNewBase;

        /// <summary>
        /// The label that identifies which textbox is textBoxNewBase
        /// </summary>
        private System.Windows.Forms.Label labelOtherBase;

        /// <summary>
        /// The label that indicates numericUpDownBase sets the number base
        /// </summary>
        private System.Windows.Forms.Label labelBase;

        /// <summary>
        /// The numericUpDown control in which the user may specify the number base
        /// </summary>
        private System.Windows.Forms.NumericUpDown numericUpDownBase;

        /// <summary>
        /// The label which indicates numericUpDownPlaces sets the number of digits in the result
        /// </summary>
        private System.Windows.Forms.Label labelDigits;

        /// <summary>
        /// The numericUpDown control in which the user may specify the minimum digits in the result
        /// </summary>
        private System.Windows.Forms.NumericUpDown numericUpDownDigits;

        /// <summary>
        /// The button that converts from decimal to another base
        /// </summary>
        private System.Windows.Forms.Button buttonFromDecimal;

        /// <summary>
        /// The button that converts from another base to decimal
        /// </summary>
        private System.Windows.Forms.Button buttonToDecimal;

        /// <summary>
        /// The button that closes the application
        /// </summary>
        private System.Windows.Forms.Button buttonExit;
    }
}

