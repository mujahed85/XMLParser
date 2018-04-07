using System.Windows.Forms;

namespace XMLParsers.Presentation
{
    partial class frmTask1
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
            this.lblXMLPath = new System.Windows.Forms.Label();
            this.txtXMLPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnParseSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblXMLPath
            // 
            this.lblXMLPath.AutoSize = true;
            this.lblXMLPath.Location = new System.Drawing.Point(16, 19);
            this.lblXMLPath.Name = "lblXMLPath";
            this.lblXMLPath.Size = new System.Drawing.Size(54, 13);
            this.lblXMLPath.TabIndex = 0;
            this.lblXMLPath.Text = "XML Path";
            // 
            // txtXMLPath
            // 
            this.txtXMLPath.Location = new System.Drawing.Point(76, 19);
            this.txtXMLPath.Name = "txtXMLPath";
            this.txtXMLPath.Size = new System.Drawing.Size(536, 20);
            this.txtXMLPath.TabIndex = 2;
            this.txtXMLPath.Text = "D:\\Mujahed\\XMLParsers\\XMLParser\\XMLParser\\bin\\Debug\\TenancyContract.xml";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtXMLPath);
            this.groupBox1.Controls.Add(this.lblXMLPath);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task 1.1";
            // 
            // btnParseSave
            // 
            this.btnParseSave.Location = new System.Drawing.Point(116, 19);
            this.btnParseSave.Name = "btnParseSave";
            this.btnParseSave.Size = new System.Drawing.Size(166, 23);
            this.btnParseSave.TabIndex = 1;
            this.btnParseSave.Text = "Parse and Save";
            this.btnParseSave.UseVisualStyleBackColor = true;
            this.btnParseSave.Click += new System.EventHandler(this.btnParseSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnParseSave);
            this.groupBox2.Location = new System.Drawing.Point(22, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task 1.2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 267);
            this.dataGridView1.TabIndex = 5;
            // 
            // frmTask1
            // 
            this.ClientSize = new System.Drawing.Size(900, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTask1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private Label lblXMLPath;

        #endregion
        private TextBox txtXMLPath;
        private GroupBox groupBox1;
        private Button btnParseSave;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
    }
}

