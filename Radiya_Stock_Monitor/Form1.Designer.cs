namespace Radiya_Stock_Monitor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCheckStock = new System.Windows.Forms.Button();
            this.dgvStockList = new System.Windows.Forms.DataGridView();
            this.npgsqlConnection1 = new Npgsql.NpgsqlConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckStock
            // 
            this.btnCheckStock.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCheckStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckStock.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckStock.ForeColor = System.Drawing.Color.White;
            this.btnCheckStock.Location = new System.Drawing.Point(862, 650);
            this.btnCheckStock.Name = "btnCheckStock";
            this.btnCheckStock.Size = new System.Drawing.Size(93, 60);
            this.btnCheckStock.TabIndex = 0;
            this.btnCheckStock.Text = "확인";
            this.btnCheckStock.UseVisualStyleBackColor = false;
            this.btnCheckStock.Click += new System.EventHandler(this.btnCheckStock_Click_1);
            // 
            // dgvStockList
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStockList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockList.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockList.EnableHeadersVisualStyles = false;
            this.dgvStockList.Location = new System.Drawing.Point(172, 192);
            this.dgvStockList.Name = "dgvStockList";
            this.dgvStockList.RowHeadersWidth = 82;
            this.dgvStockList.RowTemplate.Height = 37;
            this.dgvStockList.Size = new System.Drawing.Size(900, 400);
            this.dgvStockList.TabIndex = 1;
            this.dgvStockList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockList_CellContentClick);
            // 
            // npgsqlConnection1
            // 
            this.npgsqlConnection1.ProvideClientCertificatesCallback = null;
            this.npgsqlConnection1.ProvidePasswordCallback = null;
            this.npgsqlConnection1.UserCertificateValidationCallback = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "재고 부족 알림 체크";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(442, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "현재 재고 부족 품목을 확인하세요.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(295, 668);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(533, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "⚠️ 주의: 재고 부족 품목을 빠르게 보충하세요!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1238, 815);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStockList);
            this.Controls.Add(this.btnCheckStock);
            this.Name = "Form1";
            this.Text = "radiya 재고 모니터링";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheckStock;
        private System.Windows.Forms.DataGridView dgvStockList;
        private Npgsql.NpgsqlConnection npgsqlConnection1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

