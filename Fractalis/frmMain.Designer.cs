namespace Fractalis
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pcbFractal = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbFractalList = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.nudMultiFractalValue = new System.Windows.Forms.NumericUpDown();
            this.lblMultiFractalValue = new System.Windows.Forms.Label();
            this.nudCRealPart = new System.Windows.Forms.NumericUpDown();
            this.nudCImaginaryPart = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chkInverted = new System.Windows.Forms.CheckBox();
            this.nudZoom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tmrImage = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFractal)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiFractalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCRealPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCImaginaryPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.09313F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.90687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.pcbFractal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 426);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pcbFractal
            // 
            this.pcbFractal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbFractal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbFractal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbFractal.Location = new System.Drawing.Point(18, 23);
            this.pcbFractal.Name = "pcbFractal";
            this.pcbFractal.Size = new System.Drawing.Size(733, 380);
            this.pcbFractal.TabIndex = 0;
            this.pcbFractal.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cmbFractalList, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnGenerate, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(777, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(166, 380);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cmbFractalList
            // 
            this.cmbFractalList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFractalList.FormattingEnabled = true;
            this.cmbFractalList.Location = new System.Drawing.Point(3, 3);
            this.cmbFractalList.Name = "cmbFractalList";
            this.cmbFractalList.Size = new System.Drawing.Size(160, 23);
            this.cmbFractalList.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.nudMultiFractalValue, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblMultiFractalValue, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.nudCRealPart, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.nudCImaginaryPart, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkInverted, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.nudZoom, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(160, 148);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // nudMultiFractalValue
            // 
            this.nudMultiFractalValue.Location = new System.Drawing.Point(3, 113);
            this.nudMultiFractalValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMultiFractalValue.Name = "nudMultiFractalValue";
            this.nudMultiFractalValue.Size = new System.Drawing.Size(74, 23);
            this.nudMultiFractalValue.TabIndex = 12;
            this.nudMultiFractalValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMultiFractalValue
            // 
            this.lblMultiFractalValue.AutoSize = true;
            this.lblMultiFractalValue.Location = new System.Drawing.Point(3, 90);
            this.lblMultiFractalValue.Name = "lblMultiFractalValue";
            this.lblMultiFractalValue.Size = new System.Drawing.Size(16, 15);
            this.lblMultiFractalValue.TabIndex = 11;
            this.lblMultiFractalValue.Text = "N";
            // 
            // nudCRealPart
            // 
            this.nudCRealPart.DecimalPlaces = 5;
            this.nudCRealPart.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudCRealPart.Location = new System.Drawing.Point(3, 63);
            this.nudCRealPart.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            327680});
            this.nudCRealPart.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147221504});
            this.nudCRealPart.Name = "nudCRealPart";
            this.nudCRealPart.Size = new System.Drawing.Size(74, 23);
            this.nudCRealPart.TabIndex = 10;
            this.nudCRealPart.Value = new decimal(new int[] {
            7,
            0,
            0,
            -2147418112});
            // 
            // nudCImaginaryPart
            // 
            this.nudCImaginaryPart.DecimalPlaces = 5;
            this.nudCImaginaryPart.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.nudCImaginaryPart.Location = new System.Drawing.Point(83, 63);
            this.nudCImaginaryPart.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            327680});
            this.nudCImaginaryPart.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147221504});
            this.nudCImaginaryPart.Name = "nudCImaginaryPart";
            this.nudCImaginaryPart.Size = new System.Drawing.Size(74, 23);
            this.nudCImaginaryPart.TabIndex = 9;
            this.nudCImaginaryPart.Value = new decimal(new int[] {
            27015,
            0,
            0,
            327680});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inverted";
            // 
            // chkInverted
            // 
            this.chkInverted.AutoSize = true;
            this.chkInverted.Location = new System.Drawing.Point(83, 18);
            this.chkInverted.Name = "chkInverted";
            this.chkInverted.Size = new System.Drawing.Size(43, 19);
            this.chkInverted.TabIndex = 6;
            this.chkInverted.Text = "Yes";
            this.chkInverted.UseVisualStyleBackColor = true;
            // 
            // nudZoom
            // 
            this.nudZoom.Location = new System.Drawing.Point(3, 18);
            this.nudZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudZoom.Name = "nudZoom";
            this.nudZoom.Size = new System.Drawing.Size(74, 23);
            this.nudZoom.TabIndex = 3;
            this.nudZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zoom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Re(c)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Im(c)";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(3, 233);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(160, 43);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(3, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 26);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tmrImage
            // 
            this.tmrImage.Enabled = true;
            this.tmrImage.Interval = 1000;
            this.tmrImage.Tick += new System.EventHandler(this.tmrImage_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "Fractalis";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFractal)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiFractalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCRealPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCImaginaryPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pcbFractal;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cmbFractalList;
        private Button btnGenerate;
        private System.Windows.Forms.Timer tmrImage;
        private Button btnSave;
        private NumericUpDown nudZoom;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private CheckBox chkInverted;
        private NumericUpDown nudCImaginaryPart;
        private Label label3;
        private Label label4;
        private NumericUpDown nudCRealPart;
        private Label lblMultiFractalValue;
        private NumericUpDown nudMultiFractalValue;
    }
}