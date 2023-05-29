namespace WF_Sqlite_cw1
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            tbContent = new TextBox();
            textBox2 = new TextBox();
            btnAdd = new Button();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            lLines = new Label();
            lChars = new Label();
            saveFileDialog1 = new SaveFileDialog();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(447, 323);
            dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(479, 20);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // tbContent
            // 
            tbContent.Location = new Point(479, 64);
            tbContent.Multiline = true;
            tbContent.Name = "tbContent";
            tbContent.ScrollBars = ScrollBars.Both;
            tbContent.Size = new Size(200, 251);
            tbContent.TabIndex = 2;
            tbContent.TextChanged += tbContent_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(479, 332);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(483, 372);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(196, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "dodaj notatkę";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(687, 64);
            button2.Name = "button2";
            button2.Size = new Size(101, 55);
            button2.TabIndex = 5;
            button2.Text = "Załaduj notatkę";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "tekstowe|*.txt|wszystki pliki|*.*";
            // 
            // lLines
            // 
            lLines.AutoSize = true;
            lLines.Location = new Point(685, 149);
            lLines.Name = "lLines";
            lLines.Size = new Size(56, 15);
            lLines.TabIndex = 6;
            lLines.Text = "ilość lini: ";
            // 
            // lChars
            // 
            lChars.AutoSize = true;
            lChars.Location = new Point(684, 185);
            lChars.Name = "lChars";
            lChars.Size = new Size(80, 15);
            lChars.TabIndex = 7;
            lChars.Text = "ilość znaków: ";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(687, 223);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 55);
            btnSave.TabIndex = 8;
            btnSave.Text = "Zapisz do pliku";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(lChars);
            Controls.Add(lLines);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(tbContent);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private TextBox tbContent;
        private TextBox textBox2;
        private Button btnAdd;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private Label lLines;
        private Label lChars;
        private SaveFileDialog saveFileDialog1;
        private Button btnSave;
    }
}