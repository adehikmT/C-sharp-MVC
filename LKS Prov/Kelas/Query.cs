using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LKS_Prov.Kelas
{
    class Query:Koneksi
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;

        public Boolean InUpDel(String query, String info)
        {
            con = GetCon();
            try
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(info,"Success");
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message,"INformasi");
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public void ShowAll(String query,String table, DataGridView dgv)
        {
            con = GetCon();
            try
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds,table);
                dgv.DataSource = ds;
                dgv.DataMember = table;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message,"ERROR");
            }
            finally
            {
                con.Close();
            }
        }

        public void ShowBox(String query,String fild, ComboBox cb)
        {
            con = GetCon();
            try
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cb.Items.Add(dr[fild]);
                    }
                }
                else
                {
                    cb.Items.Add("null");
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message,"Error");
            }
            finally
            {
                con.Close();
            }
        }

        public String GetData(String query,String fild)
        {
            con = GetCon();
            try
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    return dr[fild].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message,"ERROR");
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void ShowRep(String query,String sr,Chart c)
        {
            con = GetCon();
            try
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = -1;
                    while (dr.Read())
                    {
                        int a = int.Parse(dr[2].ToString());
                       // System.Windows.Forms.MessageBox.Show(a.ToString());
                        if (dr[2].ToString()=="") { a = 0; }
                        String f = "12/12/12";
                        if (dr[0].ToString() != "" && dr[1].ToString() != "") { f = dr[0].ToString() + "-" + dr[1].ToString(); }
                        i++;
                        c.Series[sr].Points.AddXY(f, a);
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
