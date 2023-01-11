using System.Data;
using System.Data.SqlClient;

namespace ADONETHomeWork1
{
    public partial class Form1 : Form
    {
        DBCommands application = new();
        

        public Form1()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            application.GetAuthors(cBox_Authors, lbl_Msg);
        }

        private void cBox_Authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBox_Books.Enabled = false;
            cBox_Books.Text = "";
            cBox_Books.Items.Clear();

            cBox_Categories.Text = "";
            cBox_Categories.Items.Clear();

            btn_Delete.Enabled = false;
            cBox_Categories.Enabled= true;
            application.GetCategories(cBox_Categories, lbl_Msg);
        }

        private void cBox_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cBox_Books.Enabled = true;
            cBox_Books.Text = "";
            cBox_Books.Items.Clear();
            btn_Delete.Enabled = false;
            application.GetBooks(cBox_Books, cBox_Authors.SelectedIndex, cBox_Categories.SelectedIndex, lbl_Msg);
        }

        private void cBox_Books_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Delete.Enabled = true;
            application.GetBookInfo(tBox_Name, tBox_Pages, tBox_YearPress, tBox_Comment, cBox_Books.SelectedIndex, lbl_Msg);
            btn_Update.Enabled = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            application.DeleteBook(cBox_Books, cBox_Books.SelectedIndex, lbl_Msg);
            cBox_Books.Enabled = false;
            cBox_Books.Text = "";
            cBox_Books.Items.Clear();

            cBox_Categories.Enabled = false;
            cBox_Categories.Text = "";
            cBox_Categories.Items.Clear();  

            cBox_Authors.Text = "Authors";
            cBox_Authors.Text = "Authors";
            tBox_Name.Text = "";
            tBox_Pages.Text = "";
            tBox_YearPress.Text = "";
            tBox_Comment.Text = "";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tBox_Search.Text.Length > 0)
            {
                lBox_SearchedBooks.Items.Clear();
                application.Search(lBox_SearchedBooks, tBox_Search.Text, lbl_Msg);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            application.UpdateBook(tBox_Name.Text, tBox_Pages.Text, tBox_YearPress.Text, tBox_Comment.Text, cBox_Books.SelectedIndex, lbl_Msg);
            cBox_Books.Enabled = false;
            cBox_Books.Text = "";
            cBox_Books.Items.Clear();

            cBox_Categories.Enabled = false;
            cBox_Categories.Text = "";
            cBox_Categories.Items.Clear();

            cBox_Authors.Text = "Authors";
            tBox_Name.Text = "";
            tBox_Pages.Text = "";
            tBox_YearPress.Text = "";
            tBox_Comment.Text = "";
        }
    }
}