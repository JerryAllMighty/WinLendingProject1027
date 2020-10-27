using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;
using System.Data;

namespace WinLendingProject
{
    public struct Book
    {
        public int ID;
        public string Name;
        public string Author;

        public Book(int bookID, string bookName, string bookAuthor)
        {
            ID = bookID;
            Name = bookName;
            Author = bookAuthor;
        }
    }

    class BookDB : IDisposable
    {
        MySqlConnection conn;
        public BookDB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["gudi"].ConnectionString;

            conn = new MySqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Book book)
        {
            try
            {
                string sql = $@"insert into book (bookid, bookname, author) 
                                        values({book.ID}, '{book.Name}', '{book.Author}') ";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }

        }

        public bool Update(Book book)
        {
            try
            {
                string sql = $@"update book
                                    set bookname = '{book.Name}', 
                                    author = '{book.Author}'
                                    where bookid = '{book.ID}' ";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }

        }

        public bool Delete(int bookid)
        {

            try
            {
                string sql = $@"delete from book
                                    where bookid = {bookid}; ";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }

        }

        public DataTable GetAllData()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"select bookid, bookname, author, deleted from book
                            where deleted = 0";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);


                da.Fill(dt);
                return dt;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;

            }


        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
