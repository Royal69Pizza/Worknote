namespace Worknote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelLogo = new System.Windows.Forms.Label();
            this.dataOfWorknotes = new System.Windows.Forms.DataGridView();
            this.createBox = new System.Windows.Forms.GroupBox();
            this.ButtonCreateWorknote = new System.Windows.Forms.Button();
            this.buttonCreatePrintColor = new System.Windows.Forms.Button();
            this.dateTimePickerCreateDeadline = new System.Windows.Forms.DateTimePicker();
            this.labelCreateDeadline = new System.Windows.Forms.Label();
            this.labelCreateDescription = new System.Windows.Forms.Label();
            this.ButtonCreateColor = new System.Windows.Forms.Button();
            this.labelCreateColor = new System.Windows.Forms.Label();
            this.labelCreateTitle = new System.Windows.Forms.Label();
            this.inputCreateTitle = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputCreateDescription = new System.Windows.Forms.TextBox();
            this.ButtonDeleteWorknote = new System.Windows.Forms.Button();
            this.textCopy = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataOfWorknotes)).BeginInit();
            this.createBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Praetorian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.Location = new System.Drawing.Point(7, 9);
            this.labelLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(137, 22);
            this.labelLogo.TabIndex = 2;
            this.labelLogo.Text = "Worknote";
            // 
            // dataOfWorknotes
            // 
            this.dataOfWorknotes.AllowUserToAddRows = false;
            this.dataOfWorknotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Omega Flight Title", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOfWorknotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataOfWorknotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOfWorknotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.color,
            this.title,
            this.description,
            this.created,
            this.deadline});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataOfWorknotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataOfWorknotes.Location = new System.Drawing.Point(11, 33);
            this.dataOfWorknotes.Margin = new System.Windows.Forms.Padding(2);
            this.dataOfWorknotes.Name = "dataOfWorknotes";
            this.dataOfWorknotes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Omega Flight Title", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOfWorknotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataOfWorknotes.RowHeadersWidth = 51;
            this.dataOfWorknotes.RowTemplate.Height = 24;
            this.dataOfWorknotes.Size = new System.Drawing.Size(775, 221);
            this.dataOfWorknotes.TabIndex = 23;
            // 
            // createBox
            // 
            this.createBox.Controls.Add(this.inputCreateDescription);
            this.createBox.Controls.Add(this.ButtonCreateWorknote);
            this.createBox.Controls.Add(this.buttonCreatePrintColor);
            this.createBox.Controls.Add(this.dateTimePickerCreateDeadline);
            this.createBox.Controls.Add(this.labelCreateDeadline);
            this.createBox.Controls.Add(this.labelCreateDescription);
            this.createBox.Controls.Add(this.ButtonCreateColor);
            this.createBox.Controls.Add(this.labelCreateColor);
            this.createBox.Controls.Add(this.labelCreateTitle);
            this.createBox.Controls.Add(this.inputCreateTitle);
            this.createBox.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBox.ForeColor = System.Drawing.Color.White;
            this.createBox.Location = new System.Drawing.Point(791, 33);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(290, 182);
            this.createBox.TabIndex = 24;
            this.createBox.TabStop = false;
            this.createBox.Text = "Create";
            // 
            // ButtonCreateWorknote
            // 
            this.ButtonCreateWorknote.BackColor = System.Drawing.Color.Green;
            this.ButtonCreateWorknote.Location = new System.Drawing.Point(204, 150);
            this.ButtonCreateWorknote.Name = "ButtonCreateWorknote";
            this.ButtonCreateWorknote.Size = new System.Drawing.Size(79, 26);
            this.ButtonCreateWorknote.TabIndex = 29;
            this.ButtonCreateWorknote.Text = "Create";
            this.ButtonCreateWorknote.UseVisualStyleBackColor = false;
            this.ButtonCreateWorknote.Click += new System.EventHandler(this.ButtonCreateWorknote_Click);
            // 
            // buttonCreatePrintColor
            // 
            this.buttonCreatePrintColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCreatePrintColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreatePrintColor.Location = new System.Drawing.Point(81, 19);
            this.buttonCreatePrintColor.Name = "buttonCreatePrintColor";
            this.buttonCreatePrintColor.Size = new System.Drawing.Size(26, 27);
            this.buttonCreatePrintColor.TabIndex = 28;
            this.buttonCreatePrintColor.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerCreateDeadline
            // 
            this.dateTimePickerCreateDeadline.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePickerCreateDeadline.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dateTimePickerCreateDeadline.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dateTimePickerCreateDeadline.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePickerCreateDeadline.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCreateDeadline.Location = new System.Drawing.Point(64, 122);
            this.dateTimePickerCreateDeadline.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerCreateDeadline.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerCreateDeadline.Name = "dateTimePickerCreateDeadline";
            this.dateTimePickerCreateDeadline.Size = new System.Drawing.Size(219, 22);
            this.dateTimePickerCreateDeadline.TabIndex = 27;
            this.dateTimePickerCreateDeadline.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // labelCreateDeadline
            // 
            this.labelCreateDeadline.AutoSize = true;
            this.labelCreateDeadline.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateDeadline.Location = new System.Drawing.Point(6, 128);
            this.labelCreateDeadline.Name = "labelCreateDeadline";
            this.labelCreateDeadline.Size = new System.Drawing.Size(52, 14);
            this.labelCreateDeadline.TabIndex = 26;
            this.labelCreateDeadline.Text = "Deadline";
            // 
            // labelCreateDescription
            // 
            this.labelCreateDescription.AutoSize = true;
            this.labelCreateDescription.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateDescription.Location = new System.Drawing.Point(6, 77);
            this.labelCreateDescription.Name = "labelCreateDescription";
            this.labelCreateDescription.Size = new System.Drawing.Size(69, 14);
            this.labelCreateDescription.TabIndex = 18;
            this.labelCreateDescription.Text = "Description";
            // 
            // ButtonCreateColor
            // 
            this.ButtonCreateColor.BackColor = System.Drawing.Color.Teal;
            this.ButtonCreateColor.Location = new System.Drawing.Point(48, 20);
            this.ButtonCreateColor.Name = "ButtonCreateColor";
            this.ButtonCreateColor.Size = new System.Drawing.Size(27, 26);
            this.ButtonCreateColor.TabIndex = 17;
            this.ButtonCreateColor.Text = "◢";
            this.ButtonCreateColor.UseVisualStyleBackColor = false;
            this.ButtonCreateColor.Click += new System.EventHandler(this.ButtonCreateColor_Click);
            // 
            // labelCreateColor
            // 
            this.labelCreateColor.AutoSize = true;
            this.labelCreateColor.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateColor.Location = new System.Drawing.Point(6, 26);
            this.labelCreateColor.Name = "labelCreateColor";
            this.labelCreateColor.Size = new System.Drawing.Size(36, 14);
            this.labelCreateColor.TabIndex = 12;
            this.labelCreateColor.Text = "Color";
            // 
            // labelCreateTitle
            // 
            this.labelCreateTitle.AutoSize = true;
            this.labelCreateTitle.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateTitle.Location = new System.Drawing.Point(6, 55);
            this.labelCreateTitle.Name = "labelCreateTitle";
            this.labelCreateTitle.Size = new System.Drawing.Size(29, 14);
            this.labelCreateTitle.TabIndex = 10;
            this.labelCreateTitle.Text = "Title";
            // 
            // inputCreateTitle
            // 
            this.inputCreateTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.inputCreateTitle.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCreateTitle.ForeColor = System.Drawing.Color.White;
            this.inputCreateTitle.Location = new System.Drawing.Point(41, 52);
            this.inputCreateTitle.Name = "inputCreateTitle";
            this.inputCreateTitle.Size = new System.Drawing.Size(242, 22);
            this.inputCreateTitle.TabIndex = 11;
            // 
            // color
            // 
            this.color.HeaderText = "";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Width = 25;
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 170;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 320;
            // 
            // created
            // 
            this.created.HeaderText = "Created";
            this.created.MinimumWidth = 6;
            this.created.Name = "created";
            this.created.ReadOnly = true;
            // 
            // deadline
            // 
            this.deadline.HeaderText = "Deadline";
            this.deadline.MinimumWidth = 6;
            this.deadline.Name = "deadline";
            this.deadline.ReadOnly = true;
            // 
            // inputCreateDescription
            // 
            this.inputCreateDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.inputCreateDescription.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCreateDescription.ForeColor = System.Drawing.Color.White;
            this.inputCreateDescription.Location = new System.Drawing.Point(9, 94);
            this.inputCreateDescription.Name = "inputCreateDescription";
            this.inputCreateDescription.Size = new System.Drawing.Size(274, 22);
            this.inputCreateDescription.TabIndex = 30;
            // 
            // ButtonDeleteWorknote
            // 
            this.ButtonDeleteWorknote.BackColor = System.Drawing.Color.Maroon;
            this.ButtonDeleteWorknote.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteWorknote.Location = new System.Drawing.Point(997, 221);
            this.ButtonDeleteWorknote.Name = "ButtonDeleteWorknote";
            this.ButtonDeleteWorknote.Size = new System.Drawing.Size(84, 26);
            this.ButtonDeleteWorknote.TabIndex = 26;
            this.ButtonDeleteWorknote.Text = "DELETE";
            this.ButtonDeleteWorknote.UseVisualStyleBackColor = false;
            this.ButtonDeleteWorknote.Click += new System.EventHandler(this.ButtonDeleteWorknote_Click);
            // 
            // textCopy
            // 
            this.textCopy.AutoSize = true;
            this.textCopy.BackColor = System.Drawing.Color.Olive;
            this.textCopy.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCopy.Location = new System.Drawing.Point(836, 227);
            this.textCopy.Name = "textCopy";
            this.textCopy.Size = new System.Drawing.Size(155, 14);
            this.textCopy.TabIndex = 27;
            this.textCopy.Text = "Select a worknote for delete";
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Maroon;
            this.ButtonExit.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(1028, 9);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(53, 26);
            this.ButtonExit.TabIndex = 22;
            this.ButtonExit.Text = "EXIT";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1089, 261);
            this.ControlBox = false;
            this.Controls.Add(this.textCopy);
            this.Controls.Add(this.ButtonDeleteWorknote);
            this.Controls.Add(this.createBox);
            this.Controls.Add(this.dataOfWorknotes);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.labelLogo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataOfWorknotes)).EndInit();
            this.createBox.ResumeLayout(false);
            this.createBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.DataGridView dataOfWorknotes;
        private System.Windows.Forms.GroupBox createBox;
        private System.Windows.Forms.Label labelCreateTitle;
        private System.Windows.Forms.TextBox inputCreateTitle;
        private System.Windows.Forms.Label labelCreateColor;
        private System.Windows.Forms.Button ButtonCreateColor;
        private System.Windows.Forms.Label labelCreateDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreateDeadline;
        private System.Windows.Forms.Label labelCreateDeadline;
        private System.Windows.Forms.Button buttonCreatePrintColor;
        private System.Windows.Forms.Button ButtonCreateWorknote;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn created;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadline;
        private System.Windows.Forms.TextBox inputCreateDescription;
        private System.Windows.Forms.Button ButtonDeleteWorknote;
        private System.Windows.Forms.Label textCopy;
        private System.Windows.Forms.Button ButtonExit;
    }
}

