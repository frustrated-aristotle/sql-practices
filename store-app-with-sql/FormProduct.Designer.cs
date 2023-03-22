namespace store_app_with_sql
{
    partial class FormProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_purchaseCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_saleCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_stock = new System.Windows.Forms.NumericUpDown();
            this.button_list = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stock)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(521, 426);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox_id.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.textBox_id.Location = new System.Drawing.Point(705, 13);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(272, 32);
            this.textBox_id.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.label1.Location = new System.Drawing.Point(654, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox_name.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.textBox_name.Location = new System.Drawing.Point(705, 51);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(272, 32);
            this.textBox_name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.label2.Location = new System.Drawing.Point(632, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(621, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock:";
            // 
            // textBox_purchaseCost
            // 
            this.textBox_purchaseCost.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox_purchaseCost.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.textBox_purchaseCost.Location = new System.Drawing.Point(705, 127);
            this.textBox_purchaseCost.Name = "textBox_purchaseCost";
            this.textBox_purchaseCost.Size = new System.Drawing.Size(272, 32);
            this.textBox_purchaseCost.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(533, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Purchase Cost:";
            // 
            // textBox_saleCost
            // 
            this.textBox_saleCost.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox_saleCost.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.textBox_saleCost.Location = new System.Drawing.Point(705, 165);
            this.textBox_saleCost.Name = "textBox_saleCost";
            this.textBox_saleCost.Size = new System.Drawing.Size(272, 32);
            this.textBox_saleCost.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(577, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sale Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(588, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Category:";
            // 
            // numericUpDown_stock
            // 
            this.numericUpDown_stock.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.numericUpDown_stock.Location = new System.Drawing.Point(705, 90);
            this.numericUpDown_stock.Name = "numericUpDown_stock";
            this.numericUpDown_stock.Size = new System.Drawing.Size(272, 32);
            this.numericUpDown_stock.TabIndex = 15;
            // 
            // button_list
            // 
            this.button_list.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_list.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.button_list.Location = new System.Drawing.Point(705, 253);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(272, 35);
            this.button_list.TabIndex = 16;
            this.button_list.Text = "LIST";
            this.button_list.UseVisualStyleBackColor = false;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_update.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.button_update.Location = new System.Drawing.Point(705, 377);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(272, 35);
            this.button_update.TabIndex = 19;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_delete.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.button_delete.Location = new System.Drawing.Point(705, 336);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(272, 35);
            this.button_delete.TabIndex = 18;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // comboBox_category
            // 
            this.comboBox_category.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox_category.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBox_category.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(705, 203);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(272, 33);
            this.comboBox_category.TabIndex = 20;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_save.Font = new System.Drawing.Font("Roboto Mono", 14F);
            this.button_save.Location = new System.Drawing.Point(705, 294);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(272, 35);
            this.button_save.TabIndex = 21;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_list);
            this.Controls.Add(this.numericUpDown_stock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_saleCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_purchaseCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_purchaseCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_saleCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_stock;
        private System.Windows.Forms.Button button_list;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Button button_save;
    }
}