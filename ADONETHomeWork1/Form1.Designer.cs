namespace ADONETHomeWork1
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
            this.cBox_Authors = new System.Windows.Forms.ComboBox();
            this.cBox_Categories = new System.Windows.Forms.ComboBox();
            this.cBox_Books = new System.Windows.Forms.ComboBox();
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_Search = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lBox_SearchedBooks = new System.Windows.Forms.ListBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBox_Name = new System.Windows.Forms.TextBox();
            this.tBox_Pages = new System.Windows.Forms.TextBox();
            this.tBox_YearPress = new System.Windows.Forms.TextBox();
            this.tBox_Comment = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBox_Authors
            // 
            this.cBox_Authors.FormattingEnabled = true;
            this.cBox_Authors.Location = new System.Drawing.Point(12, 12);
            this.cBox_Authors.Name = "cBox_Authors";
            this.cBox_Authors.Size = new System.Drawing.Size(256, 23);
            this.cBox_Authors.TabIndex = 0;
            this.cBox_Authors.Text = "Authors";
            this.cBox_Authors.SelectedIndexChanged += new System.EventHandler(this.cBox_Authors_SelectedIndexChanged);
            // 
            // cBox_Categories
            // 
            this.cBox_Categories.Enabled = false;
            this.cBox_Categories.FormattingEnabled = true;
            this.cBox_Categories.Location = new System.Drawing.Point(274, 12);
            this.cBox_Categories.Name = "cBox_Categories";
            this.cBox_Categories.Size = new System.Drawing.Size(256, 23);
            this.cBox_Categories.TabIndex = 2;
            this.cBox_Categories.Text = "Categories";
            this.cBox_Categories.SelectedIndexChanged += new System.EventHandler(this.cBox_Categories_SelectedIndexChanged);
            // 
            // cBox_Books
            // 
            this.cBox_Books.Enabled = false;
            this.cBox_Books.FormattingEnabled = true;
            this.cBox_Books.Location = new System.Drawing.Point(536, 12);
            this.cBox_Books.Name = "cBox_Books";
            this.cBox_Books.Size = new System.Drawing.Size(256, 23);
            this.cBox_Books.TabIndex = 4;
            this.cBox_Books.Text = "Books";
            this.cBox_Books.SelectedIndexChanged += new System.EventHandler(this.cBox_Books_SelectedIndexChanged);
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Location = new System.Drawing.Point(12, 88);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(0, 15);
            this.lbl_Msg.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(86, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search Section";
            // 
            // tBox_Search
            // 
            this.tBox_Search.Location = new System.Drawing.Point(102, 211);
            this.tBox_Search.Name = "tBox_Search";
            this.tBox_Search.Size = new System.Drawing.Size(185, 23);
            this.tBox_Search.TabIndex = 8;
            this.tBox_Search.Text = "Axtar";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(812, 12);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lBox_SearchedBooks
            // 
            this.lBox_SearchedBooks.FormattingEnabled = true;
            this.lBox_SearchedBooks.ItemHeight = 15;
            this.lBox_SearchedBooks.Location = new System.Drawing.Point(28, 240);
            this.lBox_SearchedBooks.Name = "lBox_SearchedBooks";
            this.lBox_SearchedBooks.Size = new System.Drawing.Size(477, 274);
            this.lBox_SearchedBooks.TabIndex = 11;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(293, 211);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(79, 23);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "Axtar";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(684, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 50);
            this.label2.TabIndex = 13;
            this.label2.Text = "Update Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(702, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pages";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(702, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "YearPress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Comment";
            // 
            // tBox_Name
            // 
            this.tBox_Name.Location = new System.Drawing.Point(702, 259);
            this.tBox_Name.Name = "tBox_Name";
            this.tBox_Name.Size = new System.Drawing.Size(185, 23);
            this.tBox_Name.TabIndex = 18;
            // 
            // tBox_Pages
            // 
            this.tBox_Pages.Location = new System.Drawing.Point(702, 313);
            this.tBox_Pages.Name = "tBox_Pages";
            this.tBox_Pages.Size = new System.Drawing.Size(185, 23);
            this.tBox_Pages.TabIndex = 19;
            // 
            // tBox_YearPress
            // 
            this.tBox_YearPress.Location = new System.Drawing.Point(702, 363);
            this.tBox_YearPress.Name = "tBox_YearPress";
            this.tBox_YearPress.Size = new System.Drawing.Size(185, 23);
            this.tBox_YearPress.TabIndex = 20;
            // 
            // tBox_Comment
            // 
            this.tBox_Comment.Location = new System.Drawing.Point(702, 413);
            this.tBox_Comment.Name = "tBox_Comment";
            this.tBox_Comment.Size = new System.Drawing.Size(185, 23);
            this.tBox_Comment.TabIndex = 21;
            // 
            // btn_Update
            // 
            this.btn_Update.Enabled = false;
            this.btn_Update.Location = new System.Drawing.Point(745, 454);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(93, 48);
            this.btn_Update.TabIndex = 22;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 582);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.tBox_Comment);
            this.Controls.Add(this.tBox_YearPress);
            this.Controls.Add(this.tBox_Pages);
            this.Controls.Add(this.tBox_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lBox_SearchedBooks);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.tBox_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Msg);
            this.Controls.Add(this.cBox_Books);
            this.Controls.Add(this.cBox_Categories);
            this.Controls.Add(this.cBox_Authors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cBox_Authors;
        private ComboBox cBox_Categories;
        private ComboBox cBox_Books;
        private Label lbl_Msg;
        private Label label1;
        private TextBox tBox_Search;
        private Button btn_Delete;
        private ListBox lBox_SearchedBooks;
        private Button btn_Search;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tBox_Name;
        private TextBox tBox_Pages;
        private TextBox tBox_YearPress;
        private TextBox tBox_Comment;
        private Button btn_Update;
    }
}