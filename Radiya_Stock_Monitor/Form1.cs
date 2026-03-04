using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Radiya_Stock_Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckStock_Click_1(object sender, EventArgs e)
        {
            string connString = "Host=*;Username=odoo;Password=*;Database=odoo_practice";

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT t.name AS 품목, SUM(q.quantity) AS 재고수량 
                           FROM public.stock_quant q 
                           JOIN public.product_product p ON q.product_id = p.id 
                           JOIN public.product_template t ON p.product_tmpl_id = t.id 
                           GROUP BY t.name 
                           HAVING SUM(q.quantity) < 5";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvStockList.DataSource = dt; // 디자인 name 일치 확인함

                    if (dt.Rows.Count > 0)
                        MessageBox.Show($"재고 부족 품목이 {dt.Rows.Count}건 발견되었습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("모든 재고가 안정적입니다.", "확인");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("접속 오류: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvStockList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}