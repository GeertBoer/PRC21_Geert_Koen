namespace AnimalShelter
{
    partial class AdministrationForm
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
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBadHabits = new System.Windows.Forms.Label();
            this.lblWalkDate = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBadHabits = new System.Windows.Forms.TextBox();
            this.nudDayBirthday = new System.Windows.Forms.NumericUpDown();
            this.nudMonthBirthday = new System.Windows.Forms.NumericUpDown();
            this.nudYearBirthday = new System.Windows.Forms.NumericUpDown();
            this.nudWalkYear = new System.Windows.Forms.NumericUpDown();
            this.nudWalkDay = new System.Windows.Forms.NumericUpDown();
            this.nudWalkMonth = new System.Windows.Forms.NumericUpDown();
            this.nudFindAnimal = new System.Windows.Forms.NumericUpDown();
            this.rbIsReserved = new System.Windows.Forms.CheckBox();
            this.lbNotReserved = new System.Windows.Forms.ListBox();
            this.lbIsReserved = new System.Windows.Forms.ListBox();
            this.gbCreation = new System.Windows.Forms.GroupBox();
            this.nudChipNumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnDeleteAnimal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteSelectedAnimal = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWalkYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWalkDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWalkMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFindAnimal)).BeginInit();
            this.gbCreation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(6, 19);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.animalTypeComboBox.TabIndex = 0;
            this.animalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.animalTypeComboBox_SelectedIndexChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(177, 17);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(64, 23);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(67, 18);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(63, 23);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Birthday:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chip number:";
            // 
            // lblBadHabits
            // 
            this.lblBadHabits.AutoSize = true;
            this.lblBadHabits.Location = new System.Drawing.Point(6, 127);
            this.lblBadHabits.Name = "lblBadHabits";
            this.lblBadHabits.Size = new System.Drawing.Size(60, 13);
            this.lblBadHabits.TabIndex = 6;
            this.lblBadHabits.Text = "Bad habits:";
            this.lblBadHabits.Visible = false;
            // 
            // lblWalkDate
            // 
            this.lblWalkDate.AutoSize = true;
            this.lblWalkDate.Location = new System.Drawing.Point(6, 127);
            this.lblWalkDate.Name = "lblWalkDate";
            this.lblWalkDate.Size = new System.Drawing.Size(79, 13);
            this.lblWalkDate.TabIndex = 7;
            this.lblWalkDate.Text = "Last walk date:";
            this.lblWalkDate.Visible = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(91, 46);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 20);
            this.tbName.TabIndex = 8;
            // 
            // tbBadHabits
            // 
            this.tbBadHabits.Location = new System.Drawing.Point(91, 124);
            this.tbBadHabits.Name = "tbBadHabits";
            this.tbBadHabits.Size = new System.Drawing.Size(150, 20);
            this.tbBadHabits.TabIndex = 9;
            this.tbBadHabits.Visible = false;
            // 
            // nudDayBirthday
            // 
            this.nudDayBirthday.Location = new System.Drawing.Point(112, 72);
            this.nudDayBirthday.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDayBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDayBirthday.Name = "nudDayBirthday";
            this.nudDayBirthday.Size = new System.Drawing.Size(34, 20);
            this.nudDayBirthday.TabIndex = 10;
            this.nudDayBirthday.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMonthBirthday
            // 
            this.nudMonthBirthday.Location = new System.Drawing.Point(152, 72);
            this.nudMonthBirthday.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonthBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonthBirthday.Name = "nudMonthBirthday";
            this.nudMonthBirthday.Size = new System.Drawing.Size(34, 20);
            this.nudMonthBirthday.TabIndex = 11;
            this.nudMonthBirthday.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudYearBirthday
            // 
            this.nudYearBirthday.Location = new System.Drawing.Point(192, 72);
            this.nudYearBirthday.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudYearBirthday.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.nudYearBirthday.Name = "nudYearBirthday";
            this.nudYearBirthday.Size = new System.Drawing.Size(49, 20);
            this.nudYearBirthday.TabIndex = 12;
            this.nudYearBirthday.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // nudWalkYear
            // 
            this.nudWalkYear.Location = new System.Drawing.Point(192, 124);
            this.nudWalkYear.Maximum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.nudWalkYear.Minimum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.nudWalkYear.Name = "nudWalkYear";
            this.nudWalkYear.Size = new System.Drawing.Size(49, 20);
            this.nudWalkYear.TabIndex = 14;
            this.nudWalkYear.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.nudWalkYear.Visible = false;
            // 
            // nudWalkDay
            // 
            this.nudWalkDay.Location = new System.Drawing.Point(112, 124);
            this.nudWalkDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudWalkDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWalkDay.Name = "nudWalkDay";
            this.nudWalkDay.Size = new System.Drawing.Size(34, 20);
            this.nudWalkDay.TabIndex = 15;
            this.nudWalkDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWalkDay.Visible = false;
            // 
            // nudWalkMonth
            // 
            this.nudWalkMonth.Location = new System.Drawing.Point(152, 124);
            this.nudWalkMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudWalkMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWalkMonth.Name = "nudWalkMonth";
            this.nudWalkMonth.Size = new System.Drawing.Size(34, 20);
            this.nudWalkMonth.TabIndex = 16;
            this.nudWalkMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWalkMonth.Visible = false;
            // 
            // nudFindAnimal
            // 
            this.nudFindAnimal.Location = new System.Drawing.Point(6, 19);
            this.nudFindAnimal.Name = "nudFindAnimal";
            this.nudFindAnimal.Size = new System.Drawing.Size(55, 20);
            this.nudFindAnimal.TabIndex = 17;
            // 
            // rbIsReserved
            // 
            this.rbIsReserved.AutoSize = true;
            this.rbIsReserved.Location = new System.Drawing.Point(91, 150);
            this.rbIsReserved.Name = "rbIsReserved";
            this.rbIsReserved.Size = new System.Drawing.Size(83, 17);
            this.rbIsReserved.TabIndex = 18;
            this.rbIsReserved.Text = "Is Reserved";
            this.rbIsReserved.UseVisualStyleBackColor = true;
            // 
            // lbNotReserved
            // 
            this.lbNotReserved.FormattingEnabled = true;
            this.lbNotReserved.Location = new System.Drawing.Point(9, 34);
            this.lbNotReserved.Name = "lbNotReserved";
            this.lbNotReserved.Size = new System.Drawing.Size(144, 147);
            this.lbNotReserved.TabIndex = 19;
            // 
            // lbIsReserved
            // 
            this.lbIsReserved.FormattingEnabled = true;
            this.lbIsReserved.Location = new System.Drawing.Point(159, 34);
            this.lbIsReserved.Name = "lbIsReserved";
            this.lbIsReserved.Size = new System.Drawing.Size(144, 147);
            this.lbIsReserved.TabIndex = 20;
            // 
            // gbCreation
            // 
            this.gbCreation.Controls.Add(this.nudChipNumber);
            this.gbCreation.Controls.Add(this.animalTypeComboBox);
            this.gbCreation.Controls.Add(this.createAnimalButton);
            this.gbCreation.Controls.Add(this.label1);
            this.gbCreation.Controls.Add(this.rbIsReserved);
            this.gbCreation.Controls.Add(this.label2);
            this.gbCreation.Controls.Add(this.label3);
            this.gbCreation.Controls.Add(this.nudWalkMonth);
            this.gbCreation.Controls.Add(this.lblBadHabits);
            this.gbCreation.Controls.Add(this.nudWalkDay);
            this.gbCreation.Controls.Add(this.lblWalkDate);
            this.gbCreation.Controls.Add(this.nudWalkYear);
            this.gbCreation.Controls.Add(this.tbName);
            this.gbCreation.Controls.Add(this.tbBadHabits);
            this.gbCreation.Controls.Add(this.nudYearBirthday);
            this.gbCreation.Controls.Add(this.nudDayBirthday);
            this.gbCreation.Controls.Add(this.nudMonthBirthday);
            this.gbCreation.Location = new System.Drawing.Point(9, 8);
            this.gbCreation.Name = "gbCreation";
            this.gbCreation.Size = new System.Drawing.Size(251, 172);
            this.gbCreation.TabIndex = 21;
            this.gbCreation.TabStop = false;
            this.gbCreation.Text = "Add Animals";
            // 
            // nudChipNumber
            // 
            this.nudChipNumber.ImeMode = System.Windows.Forms.ImeMode.On;
            this.nudChipNumber.Location = new System.Drawing.Point(91, 98);
            this.nudChipNumber.Name = "nudChipNumber";
            this.nudChipNumber.Size = new System.Drawing.Size(150, 20);
            this.nudChipNumber.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReserve);
            this.groupBox1.Controls.Add(this.btnDeleteAnimal);
            this.groupBox1.Controls.Add(this.nudFindAnimal);
            this.groupBox1.Controls.Add(this.showInfoButton);
            this.groupBox1.Location = new System.Drawing.Point(9, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 49);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get animal info";
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(189, 18);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(56, 23);
            this.btnReserve.TabIndex = 24;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAnimal
            // 
            this.btnDeleteAnimal.Location = new System.Drawing.Point(136, 18);
            this.btnDeleteAnimal.Name = "btnDeleteAnimal";
            this.btnDeleteAnimal.Size = new System.Drawing.Size(47, 23);
            this.btnDeleteAnimal.TabIndex = 18;
            this.btnDeleteAnimal.Text = "Delete";
            this.btnDeleteAnimal.UseVisualStyleBackColor = true;
            this.btnDeleteAnimal.Click += new System.EventHandler(this.btnDeleteAnimal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbNotReserved);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnSort);
            this.groupBox2.Controls.Add(this.btnDeleteSelectedAnimal);
            this.groupBox2.Controls.Add(this.lbIsReserved);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(266, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 223);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Animals in shelter";
            // 
            // btnDeleteSelectedAnimal
            // 
            this.btnDeleteSelectedAnimal.Location = new System.Drawing.Point(48, 192);
            this.btnDeleteSelectedAnimal.Name = "btnDeleteSelectedAnimal";
            this.btnDeleteSelectedAnimal.Size = new System.Drawing.Size(89, 23);
            this.btnDeleteSelectedAnimal.TabIndex = 26;
            this.btnDeleteSelectedAnimal.Text = "Delete selected";
            this.btnDeleteSelectedAnimal.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedAnimal.Click += new System.EventHandler(this.btnDeleteSelectedAnimal_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(6, 192);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(36, 23);
            this.btnSort.TabIndex = 25;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSortReserved_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Reserved animals:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Non reserved animals:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(143, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(41, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(190, 192);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(40, 23);
            this.btnLoad.TabIndex = 25;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(236, 192);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(67, 23);
            this.btnExport.TabIndex = 27;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 243);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCreation);
            this.MaximizeBox = false;
            this.Name = "AdministrationForm";
            this.Text = "Animalshelter";
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYearBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWalkYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWalkDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWalkMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFindAnimal)).EndInit();
            this.gbCreation.ResumeLayout(false);
            this.gbCreation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBadHabits;
        private System.Windows.Forms.Label lblWalkDate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBadHabits;
        private System.Windows.Forms.NumericUpDown nudDayBirthday;
        private System.Windows.Forms.NumericUpDown nudMonthBirthday;
        private System.Windows.Forms.NumericUpDown nudYearBirthday;
        private System.Windows.Forms.NumericUpDown nudWalkYear;
        private System.Windows.Forms.NumericUpDown nudWalkDay;
        private System.Windows.Forms.NumericUpDown nudWalkMonth;
        private System.Windows.Forms.NumericUpDown nudFindAnimal;
        private System.Windows.Forms.CheckBox rbIsReserved;
        private System.Windows.Forms.ListBox lbNotReserved;
        private System.Windows.Forms.ListBox lbIsReserved;
        private System.Windows.Forms.GroupBox gbCreation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteSelectedAnimal;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnDeleteAnimal;
        private System.Windows.Forms.NumericUpDown nudChipNumber;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExport;
    }
}

