namespace _260FinalProject_CardManager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cardFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.theDatabaseSetYourLookingFor = new _260FinalProject_CardManager.TheDatabaseSetYourLookingFor();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tableTableAdapter1 = new _260FinalProject_CardManager.TheDatabaseSetYourLookingForTableAdapters.TableTableAdapter();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.rowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardFlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theDatabaseSetYourLookingFor)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardFlowPanel
            // 
            this.cardFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cardFlowPanel.AutoScroll = true;
            this.cardFlowPanel.BackColor = System.Drawing.Color.Blue;
            this.cardFlowPanel.Controls.Add(this.dataGridView1);
            this.cardFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.cardFlowPanel.Location = new System.Drawing.Point(4, 513);
            this.cardFlowPanel.Name = "cardFlowPanel";
            this.cardFlowPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.cardFlowPanel.Size = new System.Drawing.Size(571, 221);
            this.cardFlowPanel.TabIndex = 0;
            this.cardFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CardFlowPanel);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.NullValue = null;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNumber,
            this.logo,
            this.company,
            this.cardNumber,
            this.expDate,
            this.secNum});
            this.dataGridView1.DataSource = this.tableBindingSource4;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.RowHeadersWidth = 31;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(563, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tableBindingSource4
            // 
            this.tableBindingSource4.DataMember = "Table";
            this.tableBindingSource4.DataSource = this.theDatabaseSetYourLookingFor;
            // 
            // theDatabaseSetYourLookingFor
            // 
            this.theDatabaseSetYourLookingFor.DataSetName = "TheDatabaseSetYourLookingFor";
            this.theDatabaseSetYourLookingFor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Calculate Payments";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(581, 682);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete a Card";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(581, 526);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(194, 43);
            this.button10.TabIndex = 10;
            this.button10.Text = "Add A Card";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.AddCard);
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(548, 135);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Blue;
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(7, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 35);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Card Manager Beta";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 10F;
            this.dataGridViewImageColumn1.HeaderText = "Card Type";
            this.dataGridViewImageColumn1.Image = global::_260FinalProject_CardManager.Properties.Resources.unknown;
            this.dataGridViewImageColumn1.MinimumWidth = 90;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 90;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel1.Controls.Add(this.textBox8);
            this.flowLayoutPanel1.Controls.Add(this.textBox6);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Controls.Add(this.maskedTextBox1);
            this.flowLayoutPanel1.Controls.Add(this.maskedTextBox2);
            this.flowLayoutPanel1.Controls.Add(this.maskedTextBox3);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.textBox4);
            this.flowLayoutPanel1.Controls.Add(this.textBox5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(307, 162);
            this.flowLayoutPanel1.TabIndex = 13;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(3, 13);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(123, 20);
            this.textBox8.TabIndex = 8;
            this.textBox8.Text = "Total Payment Ammount";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(132, 13);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(71, 20);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "Interest Rate";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(209, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Monthly Payment";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(3, 39);
            this.maskedTextBox1.Mask = "00000.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = '0';
            this.maskedTextBox1.Size = new System.Drawing.Size(123, 20);
            this.maskedTextBox1.TabIndex = 9;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(132, 39);
            this.maskedTextBox2.Mask = "00.00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.PromptChar = '0';
            this.maskedTextBox2.Size = new System.Drawing.Size(71, 20);
            this.maskedTextBox2.TabIndex = 10;
            this.maskedTextBox2.Tag = "";
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedTextBox2.ValidatingType = typeof(int);
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(209, 39);
            this.maskedTextBox3.Mask = "00000.00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.PromptChar = '0';
            this.maskedTextBox3.Size = new System.Drawing.Size(92, 20);
            this.maskedTextBox3.TabIndex = 11;
            this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox3.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedTextBox3.ValidatingType = typeof(int);
            this.maskedTextBox3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox4.Location = new System.Drawing.Point(3, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(163, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Number of Monthly Payments =";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(172, 114);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 20);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "0";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Blue;
            this.textBox7.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Yellow;
            this.textBox7.Location = new System.Drawing.Point(4, 94);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(249, 35);
            this.textBox7.TabIndex = 14;
            this.textBox7.Text = "Payment Calculator";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // rowNumber
            // 
            this.rowNumber.HeaderText = "#";
            this.rowNumber.MinimumWidth = 20;
            this.rowNumber.Name = "rowNumber";
            this.rowNumber.ReadOnly = true;
            this.rowNumber.Width = 20;
            // 
            // logo
            // 
            this.logo.FillWeight = 10F;
            this.logo.HeaderText = "Card Type";
            this.logo.Image = global::_260FinalProject_CardManager.Properties.Resources.unknown;
            this.logo.MinimumWidth = 70;
            this.logo.Name = "logo";
            this.logo.ReadOnly = true;
            this.logo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.logo.Width = 70;
            // 
            // company
            // 
            this.company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.company.DataPropertyName = "Card Company";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company.DefaultCellStyle = dataGridViewCellStyle17;
            this.company.HeaderText = "Card Company";
            this.company.MinimumWidth = 130;
            this.company.Name = "company";
            this.company.ReadOnly = true;
            this.company.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cardNumber
            // 
            this.cardNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cardNumber.DataPropertyName = "Card Number";
            this.cardNumber.HeaderText = "Card Number";
            this.cardNumber.MinimumWidth = 170;
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.ReadOnly = true;
            this.cardNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // expDate
            // 
            this.expDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expDate.DataPropertyName = "Card Exp";
            this.expDate.HeaderText = "Card Exp";
            this.expDate.MinimumWidth = 80;
            this.expDate.Name = "expDate";
            this.expDate.ReadOnly = true;
            this.expDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // secNum
            // 
            this.secNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.secNum.DataPropertyName = "Card Security Number";
            this.secNum.HeaderText = "CVV";
            this.secNum.MinimumWidth = 30;
            this.secNum.Name = "secNum";
            this.secNum.ReadOnly = true;
            this.secNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(787, 738);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cardFlowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Card Manager Beta V .5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cardFlowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theDatabaseSetYourLookingFor)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel cardFlowPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dataGridView1;
        public TheDatabaseSetYourLookingFor theDatabaseSetYourLookingFor;
        public System.Windows.Forms.BindingSource tableBindingSource4;
        public TheDatabaseSetYourLookingForTableAdapters.TableTableAdapter tableTableAdapter1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNumber;
        private System.Windows.Forms.DataGridViewImageColumn logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn secNum;
    }
}

