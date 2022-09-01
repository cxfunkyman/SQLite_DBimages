using Devart.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite_DBimages
{
    public partial class DBimages : Form
    {
        private static string connString = @"Data Source=.\test_pic.db";
       
        public DBimages()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();

            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";

            if (OD.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAddLoad.Load(OD.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Validator.IsEmpty(textBoxName.Text))
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                conn.Open();

                SQLiteCommand cmd = conn.CreateCommand();

                var image = new ImageConverter().ConvertTo(pictureBoxAddLoad.Image, typeof(Byte[]));

                cmd.Parameters.AddWithValue("@image", image);
                cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                cmd.CommandText = "INSERT INTO pic_test (pic, name) VALUES (@image, @name)";

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Image was added");
                    pictureBoxAddLoad.Image = null;
                    textBoxName.Clear();
                }
                else
                {
                    MessageBox.Show("Image was not added");
                }
                conn.Close();
            }
            else
                MessageBox.Show("Please type a picture name");

        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            if(Validator.IsEmpty(textBoxSearch.Text))
            {
                SQLiteConnection conn = new SQLiteConnection(connString);
                conn.Open();

                SQLiteCommand cmd = conn.CreateCommand();

                var image = new ImageConverter().ConvertTo(pictureBoxAddLoad.Image, typeof(Byte[]));

                if (radioBtnID.Checked)
                {
                    if(Validator.IsADigit(textBoxSearch.Text))
                    {
                        cmd.Parameters.AddWithValue("@id", textBoxSearch.Text);
                        cmd.CommandText = "SELECT * FROM pic_test WHERE Id = @id";                        
                    }
                    else
                        return;
                }

                else if (radioBtnName.Checked)
                {
                    string name = textBoxSearch.Text;
                    cmd.CommandText = "SELECT * FROM pic_test WHERE name LIKE '" + name + "%' COLLATE NOCASE";
                }


                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MemoryStream ms = new MemoryStream(reader.GetSQLiteBlob(1).Value);
                    pictureBoxFetch.Image = Image.FromStream(ms);
                }
                else
                {
                    pictureBoxFetch.Image = null;
                    MessageBox.Show("Image was not found");
                }
                conn.Close();
            }
            else
                MessageBox.Show("Search field is empty!!");
        }
    }
}
