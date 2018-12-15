namespace Monty_Hall_problem
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtHit = new System.Windows.Forms.TextBox();
            this.txtMiss = new System.Windows.Forms.TextBox();
            this.txtMissRemove = new System.Windows.Forms.TextBox();
            this.txtHitRemove = new System.Windows.Forms.TextBox();
            this.txtRunCnt = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.chcSelect = new System.Windows.Forms.CheckBox();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHit
            // 
            this.txtHit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtHit.Location = new System.Drawing.Point(6, 36);
            this.txtHit.MaxLength = 5;
            this.txtHit.Name = "txtHit";
            this.txtHit.Size = new System.Drawing.Size(100, 19);
            this.txtHit.TabIndex = 0;
            this.txtHit.Text = "1";
            this.txtHit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHit.WordWrap = false;
            this.txtHit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // txtMiss
            // 
            this.txtMiss.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMiss.Location = new System.Drawing.Point(112, 36);
            this.txtMiss.MaxLength = 5;
            this.txtMiss.Name = "txtMiss";
            this.txtMiss.Size = new System.Drawing.Size(100, 19);
            this.txtMiss.TabIndex = 1;
            this.txtMiss.Text = "2";
            this.txtMiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMiss.WordWrap = false;
            this.txtMiss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // txtMissRemove
            // 
            this.txtMissRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMissRemove.Location = new System.Drawing.Point(114, 40);
            this.txtMissRemove.MaxLength = 5;
            this.txtMissRemove.Name = "txtMissRemove";
            this.txtMissRemove.Size = new System.Drawing.Size(100, 19);
            this.txtMissRemove.TabIndex = 3;
            this.txtMissRemove.Text = "1";
            this.txtMissRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMissRemove.WordWrap = false;
            this.txtMissRemove.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // txtHitRemove
            // 
            this.txtHitRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtHitRemove.Location = new System.Drawing.Point(8, 40);
            this.txtHitRemove.MaxLength = 5;
            this.txtHitRemove.Name = "txtHitRemove";
            this.txtHitRemove.Size = new System.Drawing.Size(100, 19);
            this.txtHitRemove.TabIndex = 2;
            this.txtHitRemove.Text = "0";
            this.txtHitRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHitRemove.WordWrap = false;
            this.txtHitRemove.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // txtRunCnt
            // 
            this.txtRunCnt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtRunCnt.Location = new System.Drawing.Point(12, 184);
            this.txtRunCnt.MaxLength = 9;
            this.txtRunCnt.Name = "txtRunCnt";
            this.txtRunCnt.Size = new System.Drawing.Size(100, 19);
            this.txtRunCnt.TabIndex = 4;
            this.txtRunCnt.Text = "100";
            this.txtRunCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRunCnt.WordWrap = false;
            this.txtRunCnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(126, 184);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(105, 19);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "実行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(221, 19);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "初期化";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "あたりの数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "はずれの数";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txtHit);
            this.gb1.Controls.Add(this.txtMiss);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(221, 69);
            this.gb1.TabIndex = 9;
            this.gb1.TabStop = false;
            this.gb1.Text = "あたり／はずれの数";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.label3);
            this.gb2.Controls.Add(this.label4);
            this.gb2.Controls.Add(this.txtHitRemove);
            this.gb2.Controls.Add(this.txtMissRemove);
            this.gb2.Location = new System.Drawing.Point(12, 87);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(221, 77);
            this.gb2.TabIndex = 10;
            this.gb2.TabStop = false;
            this.gb2.Text = "選択後に取り除く値";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "はずれの数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "あたりの数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "実行回数";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 18);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(261, 15);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 14;
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.progressBar);
            this.gb3.Location = new System.Drawing.Point(243, 12);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(273, 46);
            this.gb3.TabIndex = 15;
            this.gb3.TabStop = false;
            this.gb3.Text = "処理進捗";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(243, 65);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(273, 166);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(247, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "結果表示";
            // 
            // chcSelect
            // 
            this.chcSelect.AutoSize = true;
            this.chcSelect.Location = new System.Drawing.Point(128, 166);
            this.chcSelect.Name = "chcSelect";
            this.chcSelect.Size = new System.Drawing.Size(87, 16);
            this.chcSelect.TabIndex = 17;
            this.chcSelect.Text = "選択を変える";
            this.chcSelect.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 242);
            this.Controls.Add(this.chcSelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtRunCnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monty Hall problem";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHit;
        private System.Windows.Forms.TextBox txtMiss;
        private System.Windows.Forms.TextBox txtMissRemove;
        private System.Windows.Forms.TextBox txtHitRemove;
        private System.Windows.Forms.TextBox txtRunCnt;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chcSelect;
    }
}

