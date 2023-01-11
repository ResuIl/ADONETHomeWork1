using System.Data.SqlClient;
using System.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Reflection.Metadata.BlobBuilder;
using System.Xml.Linq;
using System.Collections.Generic;

namespace ADONETHomeWork1;

class DBCommands
{
    SqlConnection? conn = null;
    List<string> Authors = new List<string>();
    List<string> Categories = new List<string>();
    List<string> Books = new List<string>();

    public DBCommands()
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;";
        conn = new SqlConnection(ConnectionString);
    }

    public void GetAuthors(ComboBox combo, Label errorMsg)
    {
        SqlDataReader? reader = null;
        try
        {
            conn?.Open();
            Authors.Clear();

            using SqlCommand cmd = new SqlCommand("SELECT * FROM Authors", conn);
            reader = cmd.ExecuteReader();
            StringBuilder stringBuilder = new StringBuilder();

            while (reader.Read())
            {
                stringBuilder.Clear();
                for (int i = 0; i < reader.FieldCount; i++)
                    stringBuilder.Append(" " + reader[i].ToString());
                combo.Items.Add(stringBuilder);
                Authors.Add(stringBuilder.ToString());
            }

        }
        catch (Exception ex)
        {
            errorMsg.Text = $"Error Message: {ex.Message}";
        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }
    }

    public void GetCategories(ComboBox combo, Label errorMsg)
    {
        SqlDataReader? reader = null;
        try
        {
            conn?.Open();
            Categories.Clear();
            using SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", conn);
            reader = cmd.ExecuteReader();
            StringBuilder stringBuilder = new StringBuilder();

            while (reader.Read())
            {
                stringBuilder.Clear();
                for (int i = 0; i < reader.FieldCount; i++)
                    stringBuilder.Append(" " + reader[i].ToString());
                combo.Items.Add(stringBuilder);
                Categories.Add(stringBuilder.ToString());
            }

        }
        catch (Exception ex)
        {
            errorMsg.Text = $"Error Message: {ex.Message}";
        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }
    }

    public void GetBooks(ComboBox combo, int Author, int Category, Label errorMsg)
    {
        SqlDataReader? reader = null;
        try
        {
            conn?.Open();
            Books.Clear();
            using SqlCommand cmd = new SqlCommand($"SELECT * FROM Books WHERE Id_Category = '{Categories[Category].Split(' ')[1]}' AND Id_Author = {Authors[Author].Split(' ')[1]}", conn);
            reader = cmd.ExecuteReader();
            StringBuilder stringBuilder = new StringBuilder();

            while (reader.Read())
            {
                stringBuilder.Clear();
                for (int i = 0; i < reader.FieldCount; i++)
                    stringBuilder.Append(" " + reader[i].ToString());
                combo.Items.Add(stringBuilder);
                Books.Add(stringBuilder.ToString());
            }

        }
        catch (Exception ex)
        {
            errorMsg.Text = $"Error Message: {ex.Message}";
        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }
    }


    public void GetBookInfo(TextBox name, TextBox pages, TextBox year, TextBox comment, int Id, Label errorMsg)
    {
        SqlDataReader? reader = null;
        try
        {
            conn?.Open();
            using SqlCommand cmd = new SqlCommand($"SELECT * FROM Books WHERE Id = {Books[Id].Split(' ')[1]}", conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                name.Text = reader[1].ToString();
                pages.Text = reader[2].ToString();
                year.Text = reader[3].ToString();
                comment.Text = reader[8].ToString();
            }

        }
        catch (Exception ex)
        {
            errorMsg.Text = $"Error Message: {ex.Message}";
        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }
    }

    public void DeleteBook(ComboBox combo, int Id, Label errorMsg)
    {
        SqlDataReader? reader = null;
        try
        {
            conn?.Open();
            using SqlCommand cmd = new SqlCommand($"DELETE Books WHERE Id = {Books[Id].Split(' ')[1]}", conn);
            MessageBox.Show($"Affected Rows {cmd.ExecuteNonQuery()}");
        }
        catch (Exception ex)
        {
            errorMsg.Text = $"Error Message: {ex.Message}";
        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }
    }

    public void UpdateBook(string name, string page, string year, string comment, int Id, Label errorMsg)
    {
        SqlDataReader? reader = null;
        try
        {
            conn?.Open();
            using SqlCommand cmd = new SqlCommand($"UPDATE Books SET Name = '{name}', Pages = '{page}', YearPress = '{year}', Comment = '{comment}' WHERE Id = {Books[Id].Split(' ')[1]}", conn);
            MessageBox.Show($"Affected Rows {cmd.ExecuteNonQuery()}");
        }
        catch (Exception ex)
        {
            errorMsg.Text = $"Error Message: {ex.Message}";
        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }
    }

    public void Search(ListBox lbox, string book, Label errorMsg)
    {
        SqlDataReader? reader = null;
        try
        {
            conn?.Open();

            using SqlCommand cmd = new SqlCommand($"SELECT* FROM Books WHERE Name LIKE '%{book}%'", conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lbox.Items.Add(reader[1].ToString());
            }
        }
        catch (Exception ex)
        {
            errorMsg.Text = $"Error Message: {ex.Message}";
        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }
    }
}
