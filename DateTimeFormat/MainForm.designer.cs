namespace DateTimeFormat
{
	partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCultures = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.formatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new System.Data.DataSet();
            this.dataTableFormats = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.textBoxFormatString = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxToStringResult = new System.Windows.Forms.TextBox();
            this.linkLabelFormatSpecifier = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDateString = new System.Windows.Forms.TextBox();
            this.textBoxTryParseResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTryParseExactResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxExpectedFormats = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonTryParse = new System.Windows.Forms.Button();
            this.checkBoxInvariantCulture = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.columnFormatSpecifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnExampleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFormats)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(15, 25);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(171, 20);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(192, 25);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(90, 20);
            this.dtpTime.TabIndex = 1;
            this.dtpTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Culture";
            // 
            // comboBoxCultures
            // 
            this.comboBoxCultures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCultures.FormattingEnabled = true;
            this.comboBoxCultures.Location = new System.Drawing.Point(307, 26);
            this.comboBoxCultures.Name = "comboBoxCultures";
            this.comboBoxCultures.Size = new System.Drawing.Size(191, 21);
            this.comboBoxCultures.TabIndex = 2;
            this.comboBoxCultures.SelectedIndexChanged += new System.EventHandler(this.comboBoxCultures_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFormatSpecifierDataGridViewTextBoxColumn,
            this.columnNameDataGridViewTextBoxColumn,
            this.columnExampleDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.formatsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(15, 51);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(745, 362);
            this.dataGridView.TabIndex = 3;
            // 
            // formatsBindingSource
            // 
            this.formatsBindingSource.DataMember = "Formats";
            this.formatsBindingSource.DataSource = this.bindingSource;
            // 
            // bindingSource
            // 
            this.bindingSource.AllowNew = false;
            this.bindingSource.DataSource = this.dataSet;
            this.bindingSource.Position = 0;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableFormats});
            // 
            // dataTableFormats
            // 
            this.dataTableFormats.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.dataTableFormats.TableName = "Formats";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Format specifier";
            this.dataColumn1.ColumnName = "ColumnFormatSpecifier";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Name";
            this.dataColumn2.ColumnName = "ColumnName";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Example value";
            this.dataColumn3.ColumnName = "ColumnExample";
            // 
            // textBoxFormatString
            // 
            this.textBoxFormatString.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxFormatString.Location = new System.Drawing.Point(15, 42);
            this.textBoxFormatString.Name = "textBoxFormatString";
            this.textBoxFormatString.Size = new System.Drawing.Size(267, 20);
            this.textBoxFormatString.TabIndex = 5;
            this.textBoxFormatString.TextChanged += new System.EventHandler(this.textBoxFormatString_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ToString result";
            // 
            // textBoxToStringResult
            // 
            this.textBoxToStringResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxToStringResult.Location = new System.Drawing.Point(307, 42);
            this.textBoxToStringResult.Name = "textBoxToStringResult";
            this.textBoxToStringResult.ReadOnly = true;
            this.textBoxToStringResult.Size = new System.Drawing.Size(267, 20);
            this.textBoxToStringResult.TabIndex = 6;
            // 
            // linkLabelFormatSpecifier
            // 
            this.linkLabelFormatSpecifier.AutoSize = true;
            this.linkLabelFormatSpecifier.Location = new System.Drawing.Point(12, 26);
            this.linkLabelFormatSpecifier.Name = "linkLabelFormatSpecifier";
            this.linkLabelFormatSpecifier.Size = new System.Drawing.Size(81, 13);
            this.linkLabelFormatSpecifier.TabIndex = 4;
            this.linkLabelFormatSpecifier.TabStop = true;
            this.linkLabelFormatSpecifier.Text = "Format specifier";
            this.linkLabelFormatSpecifier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFormatSpecifier_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date string";
            // 
            // textBoxDateString
            // 
            this.textBoxDateString.Location = new System.Drawing.Point(19, 41);
            this.textBoxDateString.Name = "textBoxDateString";
            this.textBoxDateString.Size = new System.Drawing.Size(187, 20);
            this.textBoxDateString.TabIndex = 7;
            // 
            // textBoxTryParseResult
            // 
            this.textBoxTryParseResult.Location = new System.Drawing.Point(469, 41);
            this.textBoxTryParseResult.Name = "textBoxTryParseResult";
            this.textBoxTryParseResult.ReadOnly = true;
            this.textBoxTryParseResult.Size = new System.Drawing.Size(126, 20);
            this.textBoxTryParseResult.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "TryParse result";
            // 
            // textBoxTryParseExactResult
            // 
            this.textBoxTryParseExactResult.Location = new System.Drawing.Point(601, 41);
            this.textBoxTryParseExactResult.Name = "textBoxTryParseExactResult";
            this.textBoxTryParseExactResult.ReadOnly = true;
            this.textBoxTryParseExactResult.Size = new System.Drawing.Size(126, 20);
            this.textBoxTryParseExactResult.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "TryParseExact result";
            // 
            // textBoxExpectedFormats
            // 
            this.textBoxExpectedFormats.Location = new System.Drawing.Point(212, 41);
            this.textBoxExpectedFormats.Name = "textBoxExpectedFormats";
            this.textBoxExpectedFormats.Size = new System.Drawing.Size(217, 20);
            this.textBoxExpectedFormats.TabIndex = 8;
            this.textBoxExpectedFormats.Text = "d;D;g;G";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Expected formats (for TryParseExact only)";
            // 
            // buttonTryParse
            // 
            this.buttonTryParse.Location = new System.Drawing.Point(435, 39);
            this.buttonTryParse.Name = "buttonTryParse";
            this.buttonTryParse.Size = new System.Drawing.Size(28, 23);
            this.buttonTryParse.TabIndex = 9;
            this.buttonTryParse.Text = ">>";
            this.buttonTryParse.UseVisualStyleBackColor = true;
            this.buttonTryParse.Click += new System.EventHandler(this.buttonTryParse_Click);
            // 
            // checkBoxInvariantCulture
            // 
            this.checkBoxInvariantCulture.AutoSize = true;
            this.checkBoxInvariantCulture.Location = new System.Drawing.Point(511, 28);
            this.checkBoxInvariantCulture.Name = "checkBoxInvariantCulture";
            this.checkBoxInvariantCulture.Size = new System.Drawing.Size(123, 17);
            this.checkBoxInvariantCulture.TabIndex = 15;
            this.checkBoxInvariantCulture.Text = "Use &invariant culture";
            this.checkBoxInvariantCulture.UseVisualStyleBackColor = true;
            this.checkBoxInvariantCulture.CheckedChanged += new System.EventHandler(this.checkBoxInvariantCulture_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxFormatString);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxToStringResult);
            this.groupBox1.Controls.Add(this.linkLabelFormatSpecifier);
            this.groupBox1.Location = new System.Drawing.Point(15, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 80);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DateTime.ToString";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxExpectedFormats);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxDateString);
            this.groupBox2.Controls.Add(this.buttonTryParse);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxTryParseResult);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxTryParseExactResult);
            this.groupBox2.Location = new System.Drawing.Point(15, 505);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 85);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DateTime.TryParse";
            // 
            // columnFormatSpecifierDataGridViewTextBoxColumn
            // 
            this.columnFormatSpecifierDataGridViewTextBoxColumn.DataPropertyName = "ColumnFormatSpecifier";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.columnFormatSpecifierDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.columnFormatSpecifierDataGridViewTextBoxColumn.HeaderText = "Format specifier";
            this.columnFormatSpecifierDataGridViewTextBoxColumn.Name = "columnFormatSpecifierDataGridViewTextBoxColumn";
            this.columnFormatSpecifierDataGridViewTextBoxColumn.ReadOnly = true;
            this.columnFormatSpecifierDataGridViewTextBoxColumn.Width = 160;
            // 
            // columnNameDataGridViewTextBoxColumn
            // 
            this.columnNameDataGridViewTextBoxColumn.DataPropertyName = "ColumnName";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.columnNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnNameDataGridViewTextBoxColumn.FillWeight = 300F;
            this.columnNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.columnNameDataGridViewTextBoxColumn.Name = "columnNameDataGridViewTextBoxColumn";
            this.columnNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.columnNameDataGridViewTextBoxColumn.Width = 330;
            // 
            // columnExampleDataGridViewTextBoxColumn
            // 
            this.columnExampleDataGridViewTextBoxColumn.DataPropertyName = "ColumnExample";
            this.columnExampleDataGridViewTextBoxColumn.FillWeight = 200F;
            this.columnExampleDataGridViewTextBoxColumn.HeaderText = "Example";
            this.columnExampleDataGridViewTextBoxColumn.Name = "columnExampleDataGridViewTextBoxColumn";
            this.columnExampleDataGridViewTextBoxColumn.ReadOnly = true;
            this.columnExampleDataGridViewTextBoxColumn.Width = 240;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxInvariantCulture);
            this.Controls.Add(this.comboBoxCultures);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.dtpDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DateTimeFormat";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFormats)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpTime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxCultures;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Data.DataSet dataSet;
		private System.Data.DataTable dataTableFormats;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
		private System.Windows.Forms.BindingSource formatsBindingSource;
		private System.Windows.Forms.BindingSource bindingSource;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxFormatString;
		private System.Windows.Forms.TextBox textBoxToStringResult;
		private System.Windows.Forms.LinkLabel linkLabelFormatSpecifier;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxDateString;
		private System.Windows.Forms.TextBox textBoxTryParseResult;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxTryParseExactResult;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxExpectedFormats;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button buttonTryParse;
		private System.Windows.Forms.CheckBox checkBoxInvariantCulture;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnExampleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFormatSpecifierDataGridViewTextBoxColumn;
    }
}

