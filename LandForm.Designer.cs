namespace BasicCRUDMohammad
{
    partial class LandForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btndeletestud = new System.Windows.Forms.Button();
            this.btnupdatestud = new System.Windows.Forms.Button();
            this.btnaddsavestud = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namebox = new System.Windows.Forms.TextBox();
            this.agebox = new System.Windows.Forms.TextBox();
            this.coursebox = new System.Windows.Forms.TextBox();
            this.deptbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.edpbox = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(695, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = " Student to Record";
            // 
            // btndeletestud
            // 
            this.btndeletestud.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletestud.Location = new System.Drawing.Point(288, 423);
            this.btndeletestud.Name = "btndeletestud";
            this.btndeletestud.Size = new System.Drawing.Size(126, 43);
            this.btndeletestud.TabIndex = 8;
            this.btndeletestud.Text = "Delete";
            this.btndeletestud.UseVisualStyleBackColor = true;
            this.btndeletestud.Click += new System.EventHandler(this.btndeletestud_Click);
            // 
            // btnupdatestud
            // 
            this.btnupdatestud.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatestud.Location = new System.Drawing.Point(156, 423);
            this.btnupdatestud.Name = "btnupdatestud";
            this.btnupdatestud.Size = new System.Drawing.Size(126, 43);
            this.btnupdatestud.TabIndex = 7;
            this.btnupdatestud.Text = "Update";
            this.btnupdatestud.UseVisualStyleBackColor = true;
            this.btnupdatestud.Click += new System.EventHandler(this.btnupdatestud_Click);
            // 
            // btnaddsavestud
            // 
            this.btnaddsavestud.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddsavestud.Location = new System.Drawing.Point(24, 423);
            this.btnaddsavestud.Name = "btnaddsavestud";
            this.btnaddsavestud.Size = new System.Drawing.Size(126, 43);
            this.btnaddsavestud.TabIndex = 6;
            this.btnaddsavestud.Text = "Add Student";
            this.btnaddsavestud.UseVisualStyleBackColor = true;
            this.btnaddsavestud.Click += new System.EventHandler(this.btnaddsavestud_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(446, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 458);
            this.panel3.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(672, 458);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(142, 159);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(287, 39);
            this.namebox.TabIndex = 1;
            // 
            // agebox
            // 
            this.agebox.Location = new System.Drawing.Point(142, 214);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(287, 39);
            this.agebox.TabIndex = 2;
            // 
            // coursebox
            // 
            this.coursebox.Location = new System.Drawing.Point(142, 284);
            this.coursebox.Name = "coursebox";
            this.coursebox.Size = new System.Drawing.Size(287, 39);
            this.coursebox.TabIndex = 4;
            // 
            // deptbox
            // 
            this.deptbox.Location = new System.Drawing.Point(142, 348);
            this.deptbox.Name = "deptbox";
            this.deptbox.Size = new System.Drawing.Size(287, 39);
            this.deptbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "EDP #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 31);
            this.label4.TabIndex = 28;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 31);
            this.label5.TabIndex = 29;
            this.label5.Text = "Course";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 31);
            this.label6.TabIndex = 30;
            this.label6.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 31);
            this.label8.TabIndex = 33;
            this.label8.Text = "Department";
            // 
            // edpbox
            // 
            this.edpbox.Location = new System.Drawing.Point(142, 101);
            this.edpbox.Name = "edpbox";
            this.edpbox.Size = new System.Drawing.Size(287, 39);
            this.edpbox.TabIndex = 0;
            // 
            // LandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 567);
            this.Controls.Add(this.edpbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deptbox);
            this.Controls.Add(this.coursebox);
            this.Controls.Add(this.agebox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndeletestud);
            this.Controls.Add(this.btnupdatestud);
            this.Controls.Add(this.btnaddsavestud);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic CRUD";
            this.Load += new System.EventHandler(this.LandForm_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndeletestud;
        private System.Windows.Forms.Button btnupdatestud;
        private System.Windows.Forms.Button btnaddsavestud;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox agebox;
        private System.Windows.Forms.TextBox coursebox;
        private System.Windows.Forms.TextBox deptbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edpbox;
    }
}