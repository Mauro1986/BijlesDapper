
namespace BijlesDapper
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
            this.lblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.CmbGenre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.TxtTime = new System.Windows.Forms.TextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.brnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.VideoGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VideoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(38, 87);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 17);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(116, 84);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 22);
            this.TxtId.TabIndex = 1;
            this.TxtId.Text = "txtId";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(116, 139);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.Text = "txtTitle";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(38, 139);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // CmbGenre
            // 
            this.CmbGenre.FormattingEnabled = true;
            this.CmbGenre.Items.AddRange(new object[] {
            "Action ",
            "Thriller",
            "Comedy",
            "Family",
            "Romance"});
            this.CmbGenre.Location = new System.Drawing.Point(116, 198);
            this.CmbGenre.Name = "CmbGenre";
            this.CmbGenre.Size = new System.Drawing.Size(121, 24);
            this.CmbGenre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Genre:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(38, 263);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 17);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time";
            // 
            // TxtTime
            // 
            this.TxtTime.Location = new System.Drawing.Point(116, 258);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Size = new System.Drawing.Size(100, 22);
            this.TxtTime.TabIndex = 7;
            this.TxtTime.Text = "txtTime";
            // 
            // TxtYear
            // 
            this.TxtYear.Location = new System.Drawing.Point(116, 310);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(100, 22);
            this.TxtYear.TabIndex = 9;
            this.TxtYear.Text = "txtYear";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(38, 315);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 17);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(41, 376);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // brnUpdate
            // 
            this.brnUpdate.Location = new System.Drawing.Point(162, 376);
            this.brnUpdate.Name = "brnUpdate";
            this.brnUpdate.Size = new System.Drawing.Size(75, 23);
            this.brnUpdate.TabIndex = 11;
            this.brnUpdate.Text = "Update";
            this.brnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(41, 426);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(162, 426);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // VideoGrid
            // 
            this.VideoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VideoGrid.Location = new System.Drawing.Point(311, 66);
            this.VideoGrid.Name = "VideoGrid";
            this.VideoGrid.RowHeadersWidth = 51;
            this.VideoGrid.RowTemplate.Height = 24;
            this.VideoGrid.Size = new System.Drawing.Size(573, 383);
            this.VideoGrid.TabIndex = 14;
            this.VideoGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VideoGrid_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Movie Database Demo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 476);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VideoGrid);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.brnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.TxtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbGenre);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VideoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox CmbGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox TxtTime;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button brnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView VideoGrid;
        private System.Windows.Forms.Label label2;
    }
}

