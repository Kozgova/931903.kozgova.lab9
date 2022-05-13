
namespace Лабораторная_9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ed1 = new System.Windows.Forms.NumericUpDown();
            this.ed2 = new System.Windows.Forms.NumericUpDown();
            this.ed3 = new System.Windows.Forms.NumericUpDown();
            this.ed4 = new System.Windows.Forms.NumericUpDown();
            this.ed5 = new System.Windows.Forms.NumericUpDown();
            this.edAmount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbTMath = new System.Windows.Forms.Label();
            this.lbTDisp = new System.Windows.Forms.Label();
            this.lbSMath = new System.Windows.Forms.Label();
            this.lbSDisp = new System.Windows.Forms.Label();
            this.lbPMath = new System.Windows.Forms.Label();
            this.lbPDisp = new System.Windows.Forms.Label();
            this.lbSquare = new System.Windows.Forms.Label();
            this.lbSign = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbIndicator = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btStart1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btStart1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.edAmount);
            this.panel1.Controls.Add(this.ed5);
            this.panel1.Controls.Add(this.ed4);
            this.panel1.Controls.Add(this.ed3);
            this.panel1.Controls.Add(this.ed2);
            this.panel1.Controls.Add(this.ed1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(7, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 343);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(556, 13);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(487, 308);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вероятность 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вероятность 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вероятность 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вероятность 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Количество испытаний";
            // 
            // ed1
            // 
            this.ed1.DecimalPlaces = 2;
            this.ed1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed1.Location = new System.Drawing.Point(286, 17);
            this.ed1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed1.Name = "ed1";
            this.ed1.Size = new System.Drawing.Size(120, 22);
            this.ed1.TabIndex = 8;
            // 
            // ed2
            // 
            this.ed2.DecimalPlaces = 2;
            this.ed2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed2.Location = new System.Drawing.Point(286, 59);
            this.ed2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed2.Name = "ed2";
            this.ed2.Size = new System.Drawing.Size(120, 22);
            this.ed2.TabIndex = 9;
            // 
            // ed3
            // 
            this.ed3.DecimalPlaces = 2;
            this.ed3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed3.Location = new System.Drawing.Point(286, 101);
            this.ed3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed3.Name = "ed3";
            this.ed3.Size = new System.Drawing.Size(120, 22);
            this.ed3.TabIndex = 10;
            // 
            // ed4
            // 
            this.ed4.DecimalPlaces = 2;
            this.ed4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed4.Location = new System.Drawing.Point(286, 144);
            this.ed4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed4.Name = "ed4";
            this.ed4.Size = new System.Drawing.Size(120, 22);
            this.ed4.TabIndex = 11;
            // 
            // ed5
            // 
            this.ed5.DecimalPlaces = 2;
            this.ed5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed5.Location = new System.Drawing.Point(286, 184);
            this.ed5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed5.Name = "ed5";
            this.ed5.Size = new System.Drawing.Size(120, 22);
            this.ed5.TabIndex = 12;
            this.ed5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edAmount
            // 
            this.edAmount.Location = new System.Drawing.Point(286, 231);
            this.edAmount.Name = "edAmount";
            this.edAmount.Size = new System.Drawing.Size(120, 22);
            this.edAmount.TabIndex = 13;
            this.edAmount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Теоретические значения:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "матем. ожидание";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "дисперсия";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 537);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Статические значения:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 509);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "матем. ожидание";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 558);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "дисперсия";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(572, 413);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Погрешность:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(716, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "матем. ожидание";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(716, 433);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "дисперсия";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(572, 539);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 17);
            this.label16.TabIndex = 10;
            this.label16.Text = "Хи квадрат";
            // 
            // lbTMath
            // 
            this.lbTMath.AutoSize = true;
            this.lbTMath.Location = new System.Drawing.Point(402, 397);
            this.lbTMath.Name = "lbTMath";
            this.lbTMath.Size = new System.Drawing.Size(16, 17);
            this.lbTMath.TabIndex = 11;
            this.lbTMath.Text = "0";
            // 
            // lbTDisp
            // 
            this.lbTDisp.AutoSize = true;
            this.lbTDisp.Location = new System.Drawing.Point(402, 445);
            this.lbTDisp.Name = "lbTDisp";
            this.lbTDisp.Size = new System.Drawing.Size(16, 17);
            this.lbTDisp.TabIndex = 12;
            this.lbTDisp.Text = "0";
            // 
            // lbSMath
            // 
            this.lbSMath.AutoSize = true;
            this.lbSMath.Location = new System.Drawing.Point(402, 509);
            this.lbSMath.Name = "lbSMath";
            this.lbSMath.Size = new System.Drawing.Size(16, 17);
            this.lbSMath.TabIndex = 13;
            this.lbSMath.Text = "0";
            // 
            // lbSDisp
            // 
            this.lbSDisp.AutoSize = true;
            this.lbSDisp.Location = new System.Drawing.Point(402, 558);
            this.lbSDisp.Name = "lbSDisp";
            this.lbSDisp.Size = new System.Drawing.Size(16, 17);
            this.lbSDisp.TabIndex = 14;
            this.lbSDisp.Text = "0";
            // 
            // lbPMath
            // 
            this.lbPMath.AutoSize = true;
            this.lbPMath.Location = new System.Drawing.Point(894, 389);
            this.lbPMath.Name = "lbPMath";
            this.lbPMath.Size = new System.Drawing.Size(16, 17);
            this.lbPMath.TabIndex = 15;
            this.lbPMath.Text = "0";
            // 
            // lbPDisp
            // 
            this.lbPDisp.AutoSize = true;
            this.lbPDisp.Location = new System.Drawing.Point(894, 433);
            this.lbPDisp.Name = "lbPDisp";
            this.lbPDisp.Size = new System.Drawing.Size(16, 17);
            this.lbPDisp.TabIndex = 16;
            this.lbPDisp.Text = "0";
            // 
            // lbSquare
            // 
            this.lbSquare.AutoSize = true;
            this.lbSquare.Location = new System.Drawing.Point(706, 539);
            this.lbSquare.Name = "lbSquare";
            this.lbSquare.Size = new System.Drawing.Size(16, 17);
            this.lbSquare.TabIndex = 17;
            this.lbSquare.Text = "0";
            // 
            // lbSign
            // 
            this.lbSign.AutoSize = true;
            this.lbSign.Location = new System.Drawing.Point(804, 539);
            this.lbSign.Name = "lbSign";
            this.lbSign.Size = new System.Drawing.Size(0, 17);
            this.lbSign.TabIndex = 18;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(910, 539);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 17);
            this.label25.TabIndex = 19;
            this.label25.Text = "9.488";
            // 
            // lbIndicator
            // 
            this.lbIndicator.AutoSize = true;
            this.lbIndicator.Location = new System.Drawing.Point(1015, 539);
            this.lbIndicator.Name = "lbIndicator";
            this.lbIndicator.Size = new System.Drawing.Size(0, 17);
            this.lbIndicator.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Вероятность 5";
            // 
            // btStart1
            // 
            this.btStart1.Location = new System.Drawing.Point(178, 279);
            this.btStart1.Name = "btStart1";
            this.btStart1.Size = new System.Drawing.Size(120, 42);
            this.btStart1.TabIndex = 15;
            this.btStart1.Text = "Узнать";
            this.btStart1.UseVisualStyleBackColor = true;
            this.btStart1.Click += new System.EventHandler(this.btStart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 625);
            this.Controls.Add(this.lbIndicator);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.lbSign);
            this.Controls.Add(this.lbSquare);
            this.Controls.Add(this.lbPDisp);
            this.Controls.Add(this.lbPMath);
            this.Controls.Add(this.lbSDisp);
            this.Controls.Add(this.lbSMath);
            this.Controls.Add(this.lbTDisp);
            this.Controls.Add(this.lbTMath);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown edAmount;
        private System.Windows.Forms.NumericUpDown ed5;
        private System.Windows.Forms.NumericUpDown ed4;
        private System.Windows.Forms.NumericUpDown ed3;
        private System.Windows.Forms.NumericUpDown ed2;
        private System.Windows.Forms.NumericUpDown ed1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbTMath;
        private System.Windows.Forms.Label lbTDisp;
        private System.Windows.Forms.Label lbSMath;
        private System.Windows.Forms.Label lbSDisp;
        private System.Windows.Forms.Label lbPMath;
        private System.Windows.Forms.Label lbPDisp;
        private System.Windows.Forms.Label lbSquare;
        private System.Windows.Forms.Label lbSign;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbIndicator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btStart1;
    }
}

