namespace PowerSupplyControl
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbOutputState1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMeasuredCurrent1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudVoltage1 = new System.Windows.Forms.NumericUpDown();
            this.buttonInitialize1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOutputState2 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonInitialize2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nudVoltage2 = new System.Windows.Forms.NumericUpDown();
            this.tbMeasuredCurrent2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timerCurrentMeasurement = new System.Windows.Forms.Timer(this.components);
            this.buttonReset1 = new System.Windows.Forms.Button();
            this.buttonReset2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoltage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoltage2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonReset1);
            this.splitContainer1.Panel1.Controls.Add(this.cbOutputState1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.tbMeasuredCurrent1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.nudVoltage1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonInitialize1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonReset2);
            this.splitContainer1.Panel2.Controls.Add(this.cbOutputState2);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.buttonInitialize2);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.nudVoltage2);
            this.splitContainer1.Panel2.Controls.Add(this.tbMeasuredCurrent2);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Size = new System.Drawing.Size(505, 261);
            this.splitContainer1.SplitterDistance = 114;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbOutputState1
            // 
            this.cbOutputState1.AutoSize = true;
            this.cbOutputState1.Enabled = false;
            this.cbOutputState1.Location = new System.Drawing.Point(125, 58);
            this.cbOutputState1.Name = "cbOutputState1";
            this.cbOutputState1.Size = new System.Drawing.Size(86, 17);
            this.cbOutputState1.TabIndex = 8;
            this.cbOutputState1.Text = "Output State";
            this.cbOutputState1.UseVisualStyleBackColor = true;
            this.cbOutputState1.CheckedChanged += new System.EventHandler(this.cbOutputState1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "(V)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "(A)";
            // 
            // tbMeasuredCurrent1
            // 
            this.tbMeasuredCurrent1.Location = new System.Drawing.Point(376, 57);
            this.tbMeasuredCurrent1.Name = "tbMeasuredCurrent1";
            this.tbMeasuredCurrent1.ReadOnly = true;
            this.tbMeasuredCurrent1.Size = new System.Drawing.Size(64, 20);
            this.tbMeasuredCurrent1.TabIndex = 5;
            this.tbMeasuredCurrent1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Measured Current";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Voltage Level";
            // 
            // nudVoltage1
            // 
            this.nudVoltage1.DecimalPlaces = 1;
            this.nudVoltage1.Enabled = false;
            this.nudVoltage1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudVoltage1.Location = new System.Drawing.Point(249, 57);
            this.nudVoltage1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudVoltage1.Name = "nudVoltage1";
            this.nudVoltage1.Size = new System.Drawing.Size(52, 20);
            this.nudVoltage1.TabIndex = 2;
            this.nudVoltage1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudVoltage1.ValueChanged += new System.EventHandler(this.nudVoltage1_ValueChanged);
            // 
            // buttonInitialize1
            // 
            this.buttonInitialize1.Location = new System.Drawing.Point(25, 41);
            this.buttonInitialize1.Name = "buttonInitialize1";
            this.buttonInitialize1.Size = new System.Drawing.Size(75, 23);
            this.buttonInitialize1.TabIndex = 1;
            this.buttonInitialize1.Text = "Initialize";
            this.buttonInitialize1.UseVisualStyleBackColor = true;
            this.buttonInitialize1.Click += new System.EventHandler(this.buttonInitialize1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Power Supply 1";
            // 
            // cbOutputState2
            // 
            this.cbOutputState2.AutoSize = true;
            this.cbOutputState2.Enabled = false;
            this.cbOutputState2.Location = new System.Drawing.Point(125, 64);
            this.cbOutputState2.Name = "cbOutputState2";
            this.cbOutputState2.Size = new System.Drawing.Size(86, 17);
            this.cbOutputState2.TabIndex = 17;
            this.cbOutputState2.Text = "Output State";
            this.cbOutputState2.UseVisualStyleBackColor = true;
            this.cbOutputState2.CheckedChanged += new System.EventHandler(this.cbOutputState2_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(12, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Power Supply 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "(V)";
            // 
            // buttonInitialize2
            // 
            this.buttonInitialize2.Location = new System.Drawing.Point(25, 47);
            this.buttonInitialize2.Name = "buttonInitialize2";
            this.buttonInitialize2.Size = new System.Drawing.Size(75, 23);
            this.buttonInitialize2.TabIndex = 10;
            this.buttonInitialize2.Text = "Initialize";
            this.buttonInitialize2.UseVisualStyleBackColor = true;
            this.buttonInitialize2.Click += new System.EventHandler(this.buttonInitialize2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "(A)";
            // 
            // nudVoltage2
            // 
            this.nudVoltage2.DecimalPlaces = 1;
            this.nudVoltage2.Enabled = false;
            this.nudVoltage2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudVoltage2.Location = new System.Drawing.Point(249, 63);
            this.nudVoltage2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudVoltage2.Name = "nudVoltage2";
            this.nudVoltage2.Size = new System.Drawing.Size(52, 20);
            this.nudVoltage2.TabIndex = 11;
            this.nudVoltage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudVoltage2.ValueChanged += new System.EventHandler(this.nudVoltage2_ValueChanged);
            // 
            // tbMeasuredCurrent2
            // 
            this.tbMeasuredCurrent2.Location = new System.Drawing.Point(376, 63);
            this.tbMeasuredCurrent2.Name = "tbMeasuredCurrent2";
            this.tbMeasuredCurrent2.ReadOnly = true;
            this.tbMeasuredCurrent2.Size = new System.Drawing.Size(64, 20);
            this.tbMeasuredCurrent2.TabIndex = 14;
            this.tbMeasuredCurrent2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Voltage Level";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Measured Current";
            // 
            // timerCurrentMeasurement
            // 
            this.timerCurrentMeasurement.Tick += new System.EventHandler(this.timerCurrentMeasurement_Tick);
            // 
            // buttonReset1
            // 
            this.buttonReset1.Location = new System.Drawing.Point(25, 70);
            this.buttonReset1.Name = "buttonReset1";
            this.buttonReset1.Size = new System.Drawing.Size(75, 23);
            this.buttonReset1.TabIndex = 9;
            this.buttonReset1.Text = "Reset";
            this.buttonReset1.UseVisualStyleBackColor = true;
            this.buttonReset1.Click += new System.EventHandler(this.buttonReset1_Click);
            // 
            // buttonReset2
            // 
            this.buttonReset2.Location = new System.Drawing.Point(25, 76);
            this.buttonReset2.Name = "buttonReset2";
            this.buttonReset2.Size = new System.Drawing.Size(75, 23);
            this.buttonReset2.TabIndex = 18;
            this.buttonReset2.Text = "Reset";
            this.buttonReset2.UseVisualStyleBackColor = true;
            this.buttonReset2.Click += new System.EventHandler(this.buttonReset2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 261);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Supply Controller";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudVoltage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVoltage2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMeasuredCurrent1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudVoltage1;
        private System.Windows.Forms.Button buttonInitialize1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbOutputState1;
        private System.Windows.Forms.Timer timerCurrentMeasurement;
        private System.Windows.Forms.CheckBox cbOutputState2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonInitialize2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudVoltage2;
        private System.Windows.Forms.TextBox tbMeasuredCurrent2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonReset1;
        private System.Windows.Forms.Button buttonReset2;
    }
}

