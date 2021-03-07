using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LearnVoc
{
    public partial class Form1 : Form
    {
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        public Form1()
        {
            InitializeComponent();
        }        
        private void button5_About_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void button4_Exit_Click(object sender, EventArgs e)
        {
            DialogResult exitAsk = MessageBox.Show("確定離開?", "離開?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitAsk == DialogResult.Yes)
            {
                Close();
            }
            else if (exitAsk == DialogResult.No)
            {
                return;
            }
        }

        private void button3_Reset_Click(object sender, EventArgs e)
        {
            label_question.Text = "問題";
            label_kanji.Text = "日文漢字";
            label_chinese.Text = "中文解答";
            radioButtonN1.Checked = false;
            radioButtonN2.Checked = false;
            radioButtonN3.Checked = false;
            radioButtonN4.Checked = false;
            radioButtonN5.Checked = false;
        }
        private void button2_Next_Click(object sender, EventArgs e)
        {
            if(radioButtonN3.Checked)
            {
                sqlite_conn = new SQLiteConnection("Data source=souko.db");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT nihongo,kanji,chinese FROM n3 ORDER BY RANDOM() limit 1";
                SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    String ni = sqlite_datareader["nihongo"].ToString();
                    String ka = sqlite_datareader["kanji"].ToString();
                    String ch = sqlite_datareader["chinese"].ToString();
                    label_kanji.Visible = false;
                    label_chinese.Visible = false;

                    label_question.Text = ni;
                    label_kanji.Text = ka;
                    label_chinese.Text = ch;
                }
                sqlite_conn.Close();
            }
            else if(radioButtonN4.Checked)
            {
                sqlite_conn = new SQLiteConnection("Data source=souko.db");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT nihongo,kanji,chinese FROM n4 ORDER BY RANDOM() limit 1";
                SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    String ni = sqlite_datareader["nihongo"].ToString();
                    String ka = sqlite_datareader["kanji"].ToString();
                    String ch = sqlite_datareader["chinese"].ToString();
                    label_kanji.Visible = false;
                    label_chinese.Visible = false;

                    label_question.Text = ni;
                    label_kanji.Text = ka;
                    label_chinese.Text = ch;
                }
                sqlite_conn.Close();
            }
            else if(radioButtonN5.Checked)
            {
                sqlite_conn = new SQLiteConnection("Data source=souko.db");
                sqlite_conn.Open();
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT nihongo,kanji,chinese FROM n5 ORDER BY RANDOM() limit 1";
                SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    String ni = sqlite_datareader["nihongo"].ToString();
                    String ka = sqlite_datareader["kanji"].ToString();
                    String ch = sqlite_datareader["chinese"].ToString();
                    label_kanji.Visible = false;
                    label_chinese.Visible = false;

                    label_question.Text = ni;
                    label_kanji.Text = ka;
                    label_chinese.Text = ch;
                }
                sqlite_conn.Close();
            }
            else
            {
                MessageBox.Show("施工中...", "空資料庫!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Kanji_Click(object sender, EventArgs e)
        {
            label_kanji.Visible = true;
        }

        private void button1_Chinese_Click(object sender, EventArgs e)
        {
            label_kanji.Visible = true;
            label_chinese.Visible = true;
        }

        private void radioButtonN1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonN1.Checked)
            {
                MessageBox.Show("施工中...", "空資料庫!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButtonN2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonN2.Checked)
            {
                MessageBox.Show("施工中...", "空資料庫!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButtonN3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
