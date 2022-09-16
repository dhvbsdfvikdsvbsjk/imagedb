
namespace waitingforyou
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерАбонентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.электроннаяПочтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресПропискиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресПроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияИНомерПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПодразделенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кемВыданDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыдачиПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.причинаРасторженияДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.лицевойСчетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.услугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРасторженияДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серийныйНомерОборудованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bayebatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vremenDataSet = new waitingforyou.vremenDataSet();
            this.bayebatTableAdapter = new waitingforyou.vremenDataSetTableAdapters.BayebatTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sotoDataSet = new waitingforyou.sotoDataSet();
            this.fasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fasTableAdapter = new waitingforyou.sotoDataSetTableAdapters.fasTableAdapter();
            this.sotoDataSet1 = new waitingforyou.sotoDataSet1();
            this.fasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fasTableAdapter1 = new waitingforyou.sotoDataSet1TableAdapters.fasTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayebatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vremenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерАбонентаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.электроннаяПочтаDataGridViewTextBoxColumn,
            this.адресПропискиDataGridViewTextBoxColumn,
            this.адресПроживанияDataGridViewTextBoxColumn,
            this.серияИНомерПаспортаDataGridViewTextBoxColumn,
            this.кодПодразделенияDataGridViewTextBoxColumn,
            this.кемВыданDataGridViewTextBoxColumn,
            this.датаВыдачиПаспортаDataGridViewTextBoxColumn,
            this.номерДоговораDataGridViewTextBoxColumn,
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn,
            this.типДоговораDataGridViewTextBoxColumn,
            this.причинаРасторженияДоговораDataGridViewTextBoxColumn,
            this.лицевойСчетDataGridViewTextBoxColumn,
            this.услугиDataGridViewTextBoxColumn,
            this.датаРасторженияДоговораDataGridViewTextBoxColumn,
            this.серийныйНомерОборудованияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bayebatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(82, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(409, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // номерАбонентаDataGridViewTextBoxColumn
            // 
            this.номерАбонентаDataGridViewTextBoxColumn.DataPropertyName = "Номер абонента";
            this.номерАбонентаDataGridViewTextBoxColumn.HeaderText = "Номер абонента";
            this.номерАбонентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерАбонентаDataGridViewTextBoxColumn.Name = "номерАбонентаDataGridViewTextBoxColumn";
            this.номерАбонентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.Width = 125;
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            this.полDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            this.датаРожденияDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            this.номерТелефонаDataGridViewTextBoxColumn.Width = 125;
            // 
            // электроннаяПочтаDataGridViewTextBoxColumn
            // 
            this.электроннаяПочтаDataGridViewTextBoxColumn.DataPropertyName = "Электронная почта";
            this.электроннаяПочтаDataGridViewTextBoxColumn.HeaderText = "Электронная почта";
            this.электроннаяПочтаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.электроннаяПочтаDataGridViewTextBoxColumn.Name = "электроннаяПочтаDataGridViewTextBoxColumn";
            this.электроннаяПочтаDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресПропискиDataGridViewTextBoxColumn
            // 
            this.адресПропискиDataGridViewTextBoxColumn.DataPropertyName = "Адрес прописки";
            this.адресПропискиDataGridViewTextBoxColumn.HeaderText = "Адрес прописки";
            this.адресПропискиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресПропискиDataGridViewTextBoxColumn.Name = "адресПропискиDataGridViewTextBoxColumn";
            this.адресПропискиDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресПроживанияDataGridViewTextBoxColumn
            // 
            this.адресПроживанияDataGridViewTextBoxColumn.DataPropertyName = "Адрес проживания";
            this.адресПроживанияDataGridViewTextBoxColumn.HeaderText = "Адрес проживания";
            this.адресПроживанияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресПроживанияDataGridViewTextBoxColumn.Name = "адресПроживанияDataGridViewTextBoxColumn";
            this.адресПроживанияDataGridViewTextBoxColumn.Width = 125;
            // 
            // серияИНомерПаспортаDataGridViewTextBoxColumn
            // 
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Серия и номер паспорта";
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.HeaderText = "Серия и номер паспорта";
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.Name = "серияИНомерПаспортаDataGridViewTextBoxColumn";
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодПодразделенияDataGridViewTextBoxColumn
            // 
            this.кодПодразделенияDataGridViewTextBoxColumn.DataPropertyName = "Код подразделения";
            this.кодПодразделенияDataGridViewTextBoxColumn.HeaderText = "Код подразделения";
            this.кодПодразделенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПодразделенияDataGridViewTextBoxColumn.Name = "кодПодразделенияDataGridViewTextBoxColumn";
            this.кодПодразделенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // кемВыданDataGridViewTextBoxColumn
            // 
            this.кемВыданDataGridViewTextBoxColumn.DataPropertyName = "Кем выдан";
            this.кемВыданDataGridViewTextBoxColumn.HeaderText = "Кем выдан";
            this.кемВыданDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кемВыданDataGridViewTextBoxColumn.Name = "кемВыданDataGridViewTextBoxColumn";
            this.кемВыданDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаВыдачиПаспортаDataGridViewTextBoxColumn
            // 
            this.датаВыдачиПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Дата выдачи паспорта";
            this.датаВыдачиПаспортаDataGridViewTextBoxColumn.HeaderText = "Дата выдачи паспорта";
            this.датаВыдачиПаспортаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаВыдачиПаспортаDataGridViewTextBoxColumn.Name = "датаВыдачиПаспортаDataGridViewTextBoxColumn";
            this.датаВыдачиПаспортаDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерДоговораDataGridViewTextBoxColumn
            // 
            this.номерДоговораDataGridViewTextBoxColumn.DataPropertyName = "Номер договора";
            this.номерДоговораDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.номерДоговораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерДоговораDataGridViewTextBoxColumn.Name = "номерДоговораDataGridViewTextBoxColumn";
            this.номерДоговораDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаЗаключенияДоговораDataGridViewTextBoxColumn
            // 
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.DataPropertyName = "Дата заключения договора";
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.HeaderText = "Дата заключения договора";
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.Name = "датаЗаключенияДоговораDataGridViewTextBoxColumn";
            this.датаЗаключенияДоговораDataGridViewTextBoxColumn.Width = 125;
            // 
            // типДоговораDataGridViewTextBoxColumn
            // 
            this.типДоговораDataGridViewTextBoxColumn.DataPropertyName = "Тип договора";
            this.типДоговораDataGridViewTextBoxColumn.HeaderText = "Тип договора";
            this.типДоговораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типДоговораDataGridViewTextBoxColumn.Name = "типДоговораDataGridViewTextBoxColumn";
            this.типДоговораDataGridViewTextBoxColumn.Width = 125;
            // 
            // причинаРасторженияДоговораDataGridViewTextBoxColumn
            // 
            this.причинаРасторженияДоговораDataGridViewTextBoxColumn.DataPropertyName = "Причина расторжения договора";
            this.причинаРасторженияДоговораDataGridViewTextBoxColumn.HeaderText = "Причина расторжения договора";
            this.причинаРасторженияДоговораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.причинаРасторженияДоговораDataGridViewTextBoxColumn.Name = "причинаРасторженияДоговораDataGridViewTextBoxColumn";
            this.причинаРасторженияДоговораDataGridViewTextBoxColumn.Width = 125;
            // 
            // лицевойСчетDataGridViewTextBoxColumn
            // 
            this.лицевойСчетDataGridViewTextBoxColumn.DataPropertyName = "Лицевой счет";
            this.лицевойСчетDataGridViewTextBoxColumn.HeaderText = "Лицевой счет";
            this.лицевойСчетDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.лицевойСчетDataGridViewTextBoxColumn.Name = "лицевойСчетDataGridViewTextBoxColumn";
            this.лицевойСчетDataGridViewTextBoxColumn.Width = 125;
            // 
            // услугиDataGridViewTextBoxColumn
            // 
            this.услугиDataGridViewTextBoxColumn.DataPropertyName = "Услуги";
            this.услугиDataGridViewTextBoxColumn.HeaderText = "Услуги";
            this.услугиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.услугиDataGridViewTextBoxColumn.Name = "услугиDataGridViewTextBoxColumn";
            this.услугиDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаРасторженияДоговораDataGridViewTextBoxColumn
            // 
            this.датаРасторженияДоговораDataGridViewTextBoxColumn.DataPropertyName = "Дата расторжения договора";
            this.датаРасторженияДоговораDataGridViewTextBoxColumn.HeaderText = "Дата расторжения договора";
            this.датаРасторженияДоговораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРасторженияДоговораDataGridViewTextBoxColumn.Name = "датаРасторженияДоговораDataGridViewTextBoxColumn";
            this.датаРасторженияДоговораDataGridViewTextBoxColumn.Width = 125;
            // 
            // серийныйНомерОборудованияDataGridViewTextBoxColumn
            // 
            this.серийныйНомерОборудованияDataGridViewTextBoxColumn.DataPropertyName = "Серийный номер оборудования ";
            this.серийныйНомерОборудованияDataGridViewTextBoxColumn.HeaderText = "Серийный номер оборудования ";
            this.серийныйНомерОборудованияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.серийныйНомерОборудованияDataGridViewTextBoxColumn.Name = "серийныйНомерОборудованияDataGridViewTextBoxColumn";
            this.серийныйНомерОборудованияDataGridViewTextBoxColumn.Width = 125;
            // 
            // bayebatBindingSource
            // 
            this.bayebatBindingSource.DataMember = "Bayebat";
            this.bayebatBindingSource.DataSource = this.vremenDataSet;
            // 
            // vremenDataSet
            // 
            this.vremenDataSet.DataSetName = "vremenDataSet";
            this.vremenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bayebatTableAdapter
            // 
            this.bayebatTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.fasBindingSource;
            this.comboBox1.DisplayMember = "люди";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(710, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "люди";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.fasBindingSource1;
            this.comboBox2.DisplayMember = "работа";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(710, 173);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 24);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "работа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "dopolnenie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "picture";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(679, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // sotoDataSet
            // 
            this.sotoDataSet.DataSetName = "sotoDataSet";
            this.sotoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fasBindingSource
            // 
            this.fasBindingSource.DataMember = "fas";
            this.fasBindingSource.DataSource = this.sotoDataSet;
            // 
            // fasTableAdapter
            // 
            this.fasTableAdapter.ClearBeforeFill = true;
            // 
            // sotoDataSet1
            // 
            this.sotoDataSet1.DataSetName = "sotoDataSet1";
            this.sotoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fasBindingSource1
            // 
            this.fasBindingSource1.DataMember = "fas";
            this.fasBindingSource1.DataSource = this.sotoDataSet1;
            // 
            // fasTableAdapter1
            // 
            this.fasTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(902, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1010, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "на бд";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1060, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1060, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1109, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 485);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayebatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vremenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private vremenDataSet vremenDataSet;
        private System.Windows.Forms.BindingSource bayebatBindingSource;
        private vremenDataSetTableAdapters.BayebatTableAdapter bayebatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерАбонентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn электроннаяПочтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресПропискиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресПроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияИНомерПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПодразделенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кемВыданDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыдачиПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаключенияДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn причинаРасторженияДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn лицевойСчетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn услугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРасторженияДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серийныйНомерОборудованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private sotoDataSet sotoDataSet;
        private System.Windows.Forms.BindingSource fasBindingSource;
        private sotoDataSetTableAdapters.fasTableAdapter fasTableAdapter;
        private sotoDataSet1 sotoDataSet1;
        private System.Windows.Forms.BindingSource fasBindingSource1;
        private sotoDataSet1TableAdapters.fasTableAdapter fasTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
    }
}

