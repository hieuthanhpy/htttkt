using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTTKT
{
    public partial class TheKho : Form
    {
        public TheKho()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                // eclare and init value some variables
                string connectionString, ngaybdau = startDate.Value.ToString("yyyy-MM-dd"), ngaykthuc = endDate.Value.ToString("yyyy-MM-dd"), makho = txt_maKho.Text;
                SqlConnection conn;

                // Connect to SQL Server
                connectionString = @"Data Source=ADMIN; Initial Catalog=HTTTKT; User ID=sa; Password=123456";
                conn = new SqlConnection(connectionString);
                //conn.Open();

                string sql;

                if (ngaybdau == "" || ngaykthuc == "")
                {
                    MessageBox.Show("Vui lòng chọn ngày bắt đầu và ngày kết thúc");
                } else
                {
                    if (makho == "")
                    {
                        sql = "select * from GOC_PHIEU INNER JOIN SAN_PHAM ON GOC_PHIEU.PSO = SAN_PHAM.PSO WHERE GOC_PHIEU.NLAP >=" + "'" + ngaybdau.ToString()+ "'"  +
                            " AND GOC_PHIEU.NLAP <= " + "'" + ngaykthuc.ToString() + "'";
                    }
                    else
                    {
                        sql = "select * from GOC_PHIEU INNER JOIN SAN_PHAM ON GOC_PHIEU.PSO = SAN_PHAM.PSO WHERE GOC_PHIEU.NLAP >=" + "'" + ngaybdau.ToString() + "'" +
                            " AND GOC_PHIEU.NLAP <= " + "'" + ngaykthuc.ToString() + "' AND GOC_PHIEU.MSCH = " + "'" + makho + "'";
                    }

                    //cmd = new SqlCommand(sql, conn);
                    //dataReader = cmd.ExecuteReader();
                    SqlDataAdapter data = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    conn.Open();
                    data.Fill(ds, "ds");
                    conn.Close();
                    dataGridView1.DataSource = ds;
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataMember = "ds";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        xcelApp.Cells[i + 2, j + 1] = "";
                    } else
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            xcelApp.Columns.AutoFit();
            xcelApp.Visible = true;
        }
    }
}
