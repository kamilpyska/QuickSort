namespace QuickSortBubbleSort
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTBox = new System.Windows.Forms.TextBox();
            this.outputTBox = new System.Windows.Forms.TextBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.quicksortCheckBox = new System.Windows.Forms.CheckBox();
            this.bubbleSortCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.randomNumbersBtn = new System.Windows.Forms.Button();
            this.nUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj liczby do posortowania (oddzielone znakiem spacji):\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wynik sortowania:";
            // 
            // inputTBox
            // 
            this.inputTBox.Location = new System.Drawing.Point(28, 54);
            this.inputTBox.Name = "inputTBox";
            this.inputTBox.Size = new System.Drawing.Size(519, 20);
            this.inputTBox.TabIndex = 2;
            this.inputTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTBox_KeyPress);
            // 
            // outputTBox
            // 
            this.outputTBox.Location = new System.Drawing.Point(35, 192);
            this.outputTBox.Name = "outputTBox";
            this.outputTBox.Size = new System.Drawing.Size(512, 20);
            this.outputTBox.TabIndex = 3;
            this.outputTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.outputTBox_KeyPress);
            // 
            // sortBtn
            // 
            this.sortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sortBtn.Location = new System.Drawing.Point(212, 99);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(149, 51);
            this.sortBtn.TabIndex = 4;
            this.sortBtn.Text = "Sortuj";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // quicksortCheckBox
            // 
            this.quicksortCheckBox.AutoSize = true;
            this.quicksortCheckBox.Location = new System.Drawing.Point(41, 108);
            this.quicksortCheckBox.Name = "quicksortCheckBox";
            this.quicksortCheckBox.Size = new System.Drawing.Size(71, 17);
            this.quicksortCheckBox.TabIndex = 5;
            this.quicksortCheckBox.Text = "Quicksort";
            this.quicksortCheckBox.UseVisualStyleBackColor = true;
            this.quicksortCheckBox.CheckedChanged += new System.EventHandler(this.quicksortCheckBox_CheckedChanged);
            // 
            // bubbleSortCheckBox
            // 
            this.bubbleSortCheckBox.AutoSize = true;
            this.bubbleSortCheckBox.Location = new System.Drawing.Point(41, 131);
            this.bubbleSortCheckBox.Name = "bubbleSortCheckBox";
            this.bubbleSortCheckBox.Size = new System.Drawing.Size(79, 17);
            this.bubbleSortCheckBox.TabIndex = 6;
            this.bubbleSortCheckBox.Text = "Bubble sort";
            this.bubbleSortCheckBox.UseVisualStyleBackColor = true;
            this.bubbleSortCheckBox.CheckedChanged += new System.EventHandler(this.bubbleSortCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Algorytm sortowania:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Czas:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(71, 225);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(13, 13);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "0";
            // 
            // randomNumbersBtn
            // 
            this.randomNumbersBtn.Location = new System.Drawing.Point(393, 24);
            this.randomNumbersBtn.Name = "randomNumbersBtn";
            this.randomNumbersBtn.Size = new System.Drawing.Size(101, 23);
            this.randomNumbersBtn.TabIndex = 10;
            this.randomNumbersBtn.Text = "Losowy ciąg cyfr";
            this.randomNumbersBtn.UseVisualStyleBackColor = true;
            this.randomNumbersBtn.Click += new System.EventHandler(this.randomNumbersBtn_Click);
            // 
            // nUpDown
            // 
            this.nUpDown.Location = new System.Drawing.Point(500, 27);
            this.nUpDown.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDown.Name = "nUpDown";
            this.nUpDown.Size = new System.Drawing.Size(47, 20);
            this.nUpDown.TabIndex = 11;
            this.nUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 262);
            this.Controls.Add(this.nUpDown);
            this.Controls.Add(this.randomNumbersBtn);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bubbleSortCheckBox);
            this.Controls.Add(this.quicksortCheckBox);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.outputTBox);
            this.Controls.Add(this.inputTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quicksort i Bubble sort";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputTBox;
        private System.Windows.Forms.TextBox outputTBox;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.CheckBox quicksortCheckBox;
        private System.Windows.Forms.CheckBox bubbleSortCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button randomNumbersBtn;
        private System.Windows.Forms.NumericUpDown nUpDown;
    }
}

