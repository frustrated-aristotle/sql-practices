namespace store_app_with_sql
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_categoryName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dBStoreDataSet = new store_app_with_sql.DBStoreDataSet();
            this.tablecategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_categoryTableAdapter = new store_app_with_sql.DBStoreDataSetTableAdapters.table_categoryTableAdapter();
            this.button_list = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablecategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_categoryName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name:";
            // 
            // textBox_categoryName
            // 
            this.textBox_categoryName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox_categoryName.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.textBox_categoryName.Location = new System.Drawing.Point(167, 33);
            this.textBox_categoryName.Name = "textBox_categoryName";
            this.textBox_categoryName.Size = new System.Drawing.Size(216, 32);
            this.textBox_categoryName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Mono", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(389, 327);
            this.dataGridView1.TabIndex = 1;
            // 
            // dBStoreDataSet
            // 
            this.dBStoreDataSet.DataSetName = "DBStoreDataSet";
            this.dBStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablecategoryBindingSource
            // 
            this.tablecategoryBindingSource.DataMember = "table_category";
            this.tablecategoryBindingSource.DataSource = this.dBStoreDataSet;
            // 
            // table_categoryTableAdapter
            // 
            this.table_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // button_list
            // 
            this.button_list.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.button_list.Location = new System.Drawing.Point(425, 111);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(120, 43);
            this.button_list.TabIndex = 2;
            this.button_list.Text = "LIST";
            this.button_list.UseVisualStyleBackColor = true;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.button_save.Location = new System.Drawing.Point(425, 171);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(120, 43);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.button_update.Location = new System.Drawing.Point(425, 296);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(120, 43);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.button_delete.Location = new System.Drawing.Point(425, 232);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(120, 43);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.button_search.Location = new System.Drawing.Point(425, 363);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(120, 43);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "SEARCH";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox_id.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.textBox_id.Location = new System.Drawing.Point(471, 41);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(74, 32);
            this.textBox_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.label2.Location = new System.Drawing.Point(420, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_list);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablecategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_categoryName;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBStoreDataSet dBStoreDataSet;
        private System.Windows.Forms.BindingSource tablecategoryBindingSource;
        private DBStoreDataSetTableAdapters.table_categoryTableAdapter table_categoryTableAdapter;
        private System.Windows.Forms.Button button_list;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label2;
    }
}

