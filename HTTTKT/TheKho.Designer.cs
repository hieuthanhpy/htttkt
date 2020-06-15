using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Windows.Forms;

namespace HTTTKT
{
    partial class TheKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_month = new System.Windows.Forms.Label();
            this.lbl_maKho = new System.Windows.Forms.Label();
            this.txt_maKho = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.export = new System.Windows.Forms.Button();
            this.PSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_TIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Red;
            this.lbl_title.Location = new System.Drawing.Point(244, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(296, 24);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "NHẬT KÝ THẺ KHO (SỐ KHO)";
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Location = new System.Drawing.Point(16, 92);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(69, 15);
            this.lbl_month.TabIndex = 4;
            this.lbl_month.Text = "TỪ NGÀY:";
            // 
            // lbl_maKho
            // 
            this.lbl_maKho.AutoSize = true;
            this.lbl_maKho.Location = new System.Drawing.Point(479, 92);
            this.lbl_maKho.Name = "lbl_maKho";
            this.lbl_maKho.Size = new System.Drawing.Size(68, 15);
            this.lbl_maKho.TabIndex = 8;
            this.lbl_maKho.Text = "MÃ KHO: ";
            // 
            // txt_maKho
            // 
            this.txt_maKho.Location = new System.Drawing.Point(553, 89);
            this.txt_maKho.Name = "txt_maKho";
            this.txt_maKho.Size = new System.Drawing.Size(162, 21);
            this.txt_maKho.TabIndex = 9;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_submit.Location = new System.Drawing.Point(781, 89);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "XEM";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "dd/MM/yyyy";
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(91, 90);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(104, 21);
            this.startDate.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "ĐẾN NGÀY: ";
            // 
            // endDate
            // 
            this.endDate.CustomFormat = "dd/MM/yyyy";
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(317, 90);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(112, 21);
            this.endDate.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PSO,
            this.NLAP,
            this.MSCH,
            this.LDO,
            this.MASP,
            this.DVT,
            this.SO_LUONG,
            this.SO_TIEN});
            this.dataGridView1.Location = new System.Drawing.Point(12, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 388);
            this.dataGridView1.TabIndex = 23;
            // 
            // export
            // 
            this.export.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export.Location = new System.Drawing.Point(248, 581);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 24;
            this.export.Text = "Xuất";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // PSO
            // 
            this.PSO.DataPropertyName = "PSO";
            this.PSO.HeaderText = "Số Phiếu";
            this.PSO.Name = "PSO";
            // 
            // NLAP
            // 
            this.NLAP.DataPropertyName = "NLAP";
            this.NLAP.HeaderText = "Ngày Lập";
            this.NLAP.Name = "NLAP";
            // 
            // MSCH
            // 
            this.MSCH.DataPropertyName = "MSCH";
            this.MSCH.HeaderText = "Mã số cửa hàng của Kho";
            this.MSCH.Name = "MSCH";
            // 
            // LDO
            // 
            this.LDO.DataPropertyName = "LDO";
            this.LDO.HeaderText = "Lý Do";
            this.LDO.Name = "LDO";
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã Sản Phẩm";
            this.MASP.Name = "MASP";
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            // 
            // SO_LUONG
            // 
            this.SO_LUONG.DataPropertyName = "SO_LUONG";
            this.SO_LUONG.HeaderText = "Số Lượng";
            this.SO_LUONG.Name = "SO_LUONG";
            // 
            // SO_TIEN
            // 
            this.SO_TIEN.DataPropertyName = "SO_TIEN";
            this.SO_TIEN.HeaderText = "Số Tiền";
            this.SO_TIEN.Name = "SO_TIEN";
            // 
            // TheKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 636);
            this.Controls.Add(this.export);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_maKho);
            this.Controls.Add(this.lbl_maKho);
            this.Controls.Add(this.lbl_month);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TheKho";
            this.Text = "TheKho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_month;
        private System.Windows.Forms.Label lbl_maKho;
        private System.Windows.Forms.TextBox txt_maKho;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.DateTimePicker startDate;
        private Label label1;
        private DateTimePicker endDate;
        private DataGridView dataGridView1;
        private Button export;
        private DataGridViewTextBoxColumn PSO;
        private DataGridViewTextBoxColumn NLAP;
        private DataGridViewTextBoxColumn MSCH;
        private DataGridViewTextBoxColumn LDO;
        private DataGridViewTextBoxColumn MASP;
        private DataGridViewTextBoxColumn DVT;
        private DataGridViewTextBoxColumn SO_LUONG;
        private DataGridViewTextBoxColumn SO_TIEN;
    }
}