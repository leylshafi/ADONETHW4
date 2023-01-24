namespace ADONETHW4._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categories = new System.Windows.Forms.ComboBox();
            this.authors = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // categories
            // 
            this.categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categories.FormattingEnabled = true;
            this.categories.Location = new System.Drawing.Point(14, 16);
            this.categories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(219, 28);
            this.categories.TabIndex = 0;
            this.categories.SelectedIndexChanged += new System.EventHandler(this.categories_SelectedIndexChanged);
            // 
            // authors
            // 
            this.authors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authors.Enabled = false;
            this.authors.FormattingEnabled = true;
            this.authors.Location = new System.Drawing.Point(261, 16);
            this.authors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.authors.Name = "authors";
            this.authors.Size = new System.Drawing.Size(219, 28);
            this.authors.TabIndex = 1;
            this.authors.SelectedIndexChanged += new System.EventHandler(this.authors_SelectedIndexChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(613, 17);
            this.search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(265, 27);
            this.search.TabIndex = 2;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(14, 104);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(887, 480);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.authors);
            this.Controls.Add(this.categories);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox categories;
        private ComboBox authors;
        private TextBox search;
        private DataGridView dataGridView1;
    }
}