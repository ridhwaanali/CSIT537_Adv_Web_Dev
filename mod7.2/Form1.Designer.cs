namespace mod7._2
{
    partial class ConversionCalculator
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
            this.convert = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // convert
            // 
            this.convert.FormattingEnabled = true;
            this.convert.Items.AddRange(new object[] {
            "Miles To Kilometers",
            "Kilometers to Miles",
            "Feet to Meters",
            "Meters to Feet",
            "Inches to Centimeters",
            "Centimeters to Inches"});
            this.convert.Location = new System.Drawing.Point(115, 87);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(121, 28);
            this.convert.TabIndex = 1;
            this.convert.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Conversion";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(115, 164);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 26);
            this.input.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input";
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(23, 237);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(55, 20);
            this.equal.TabIndex = 5;
            this.equal.Text = "Result";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(115, 231);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 26);
            this.result.TabIndex = 6;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(16, 316);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(102, 47);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(142, 318);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(108, 42);
            this.close.TabIndex = 8;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            // 
            // ConversionCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 433);
            this.Controls.Add(this.close);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.result);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convert);
            this.Name = "ConversionCalculator";
            this.Text = "Conversion Calculator";
            this.Load += new System.EventHandler(this.ConversionCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox convert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button close;
    }
}

