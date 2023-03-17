namespace WinformsAdoNet
{
    partial class AddWindow
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCourseName = new TextBox();
            txtCoursePlace = new TextBox();
            txtCoursePrice = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 195);
            button1.Name = "button1";
            button1.Size = new Size(154, 53);
            button1.TabIndex = 0;
            button1.Text = "Zapisz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 25);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Nazwa kursu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 70);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Miejsce kursu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 128);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 3;
            label3.Text = "Cena kursu";
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(174, 22);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(100, 23);
            txtCourseName.TabIndex = 4;
            // 
            // txtCoursePlace
            // 
            txtCoursePlace.Location = new Point(174, 70);
            txtCoursePlace.Name = "txtCoursePlace";
            txtCoursePlace.Size = new Size(100, 23);
            txtCoursePlace.TabIndex = 5;
            // 
            // txtCoursePrice
            // 
            txtCoursePrice.Location = new Point(174, 125);
            txtCoursePrice.Name = "txtCoursePrice";
            txtCoursePrice.Size = new Size(100, 23);
            txtCoursePrice.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(208, 195);
            button2.Name = "button2";
            button2.Size = new Size(154, 53);
            button2.TabIndex = 7;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 281);
            Controls.Add(button2);
            Controls.Add(txtCoursePrice);
            Controls.Add(txtCoursePlace);
            Controls.Add(txtCourseName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AddWindow";
            Text = "AddWindow";
            Load += AddWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCourseName;
        private TextBox txtCoursePlace;
        private TextBox txtCoursePrice;
        private Button button2;
    }
}