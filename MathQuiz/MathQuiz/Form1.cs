using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        private string connStr = ConnectionUtil.GetConnectionString();
        private static int cnt = 0;
        public Form1()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(connStr);
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                string sql = " select 'Select A Level' as 'difficultLevel' union select distinct convert(varchar(10), difficultLevel)  from MathQuiz order by 'difficultLevel' desc ";
                cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);

                cbLevel.SelectedIndexChanged -= cbLevel_SelectedIndexChanged;

                cbLevel.DataSource = dt;
                cbLevel.DisplayMember = "difficultLevel";
                cbLevel.ValueMember = "difficultLevel";

                cbLevel.SelectedIndexChanged += cbLevel_SelectedIndexChanged;

                cbLevel.SelectedIndex = 0;

            }
            catch( Exception ex)
            {  
            }
            finally
            {
                conn.Close();
            }
        }

        private void cbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnt = 0;
            Next.Enabled = true;
            lblSummary.Text = string.Empty;

            
            if (cbLevel.SelectedValue.ToString() == "Select A Level")
            {
                txtCorrectAnswer.Text = string.Empty;
                id.Text = string.Empty;

                txtOperand1.Text = string.Empty;
                txtOperator.Text = string.Empty;
                txtOperant2.Text = string.Empty;

                txtAnswer.Text = string.Empty;
            }
            else
            {
                SqlConnection conn = new SqlConnection(connStr);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    string sql =
                        "select [operand1],[operator], [operand2], [answer], [correctAnswer], [id] from MathQuiz where [difficultLevel] = " +
                        ((cbLevel.SelectedValue.ToString() == string.Empty) ? "null" : cbLevel.SelectedValue);
                    cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        txtCorrectAnswer.Text = dt.Rows[cnt].ItemArray.ElementAt(4).ToString();
                        id.Text = dt.Rows[cnt].ItemArray.ElementAt(5).ToString();

                        txtOperand1.Text = dt.Rows[cnt].ItemArray.ElementAt(0).ToString();
                        txtOperator.Text = dt.Rows[cnt].ItemArray.ElementAt(1).ToString();
                        txtOperant2.Text = dt.Rows[cnt].ItemArray.ElementAt(2).ToString();

                        txtAnswer.Text = dt.Rows[cnt].ItemArray.ElementAt(3).ToString();
                        
                        lblSummary.Text = "Problems number 1  of total " + dt.Rows.Count.ToString();
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        private void Next_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                string sql = "update MathQuiz set answer = " + ((txtAnswer.Text == string.Empty)? "null" : txtAnswer.Text) + " where [id] = " + id.Text;
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand();
                string sql1 = "select [operand1],[operator], [operand2], [answer], [correctAnswer], [id] from MathQuiz where [difficultLevel] = " + cbLevel.SelectedValue;
                cmd1 = new SqlCommand(sql1, conn);
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd1;
                da.Fill(dt);

                cnt = cnt + 1;
                Next.Enabled = (dt.Rows.Count == cnt) ?  false : true;

                if (Next.Enabled)
                {
                    txtCorrectAnswer.Text = dt.Rows[cnt].ItemArray.ElementAt(4).ToString();
                    id.Text = dt.Rows[cnt].ItemArray.ElementAt(5).ToString();

                    txtOperand1.Text = dt.Rows[cnt].ItemArray.ElementAt(0).ToString();
                    txtOperator.Text = dt.Rows[cnt].ItemArray.ElementAt(1).ToString();
                    txtOperant2.Text = dt.Rows[cnt].ItemArray.ElementAt(2).ToString();

                    txtAnswer.Text = dt.Rows[cnt].ItemArray.ElementAt(3).ToString();

                    lblSummary.Text = "Problems number  " + (cnt+1).ToString() + " of total " + dt.Rows.Count.ToString();
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand();
                    string sql2 = "select count(*) as cnt from MathQuiz where [difficultLevel] = " + cbLevel.SelectedValue + " and answer = CorrectAnswer";
                    cmd2 = new SqlCommand(sql2, conn);
                    int cntCorrect = Convert.ToInt16(cmd2.ExecuteScalar());

                    lblSummary.Text = "count the number of problems answered correctly:  " + cntCorrect.ToString();
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
