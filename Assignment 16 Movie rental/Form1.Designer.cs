
namespace Assignment_16_Movie_rental
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
            this.label1 = new System.Windows.Forms.Label();
            this.moviepicker = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.movienamelabel = new System.Windows.Forms.Label();
            this.lenghtlabel = new System.Windows.Forms.Label();
            this.availablelabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.borrowbutton = new System.Windows.Forms.Button();
            this.returnbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "BlockBuster";
            // 
            // moviepicker
            // 
            this.moviepicker.FormattingEnabled = true;
            this.moviepicker.Location = new System.Drawing.Point(34, 81);
            this.moviepicker.Name = "moviepicker";
            this.moviepicker.Size = new System.Drawing.Size(365, 21);
            this.moviepicker.TabIndex = 1;
            this.moviepicker.SelectedIndexChanged += new System.EventHandler(this.moviepicker_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.movienamelabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lenghtlabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.availablelabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(476, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.08696F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.91304F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 174);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Movie";
            // 
            // movienamelabel
            // 
            this.movienamelabel.AutoSize = true;
            this.movienamelabel.Location = new System.Drawing.Point(146, 0);
            this.movienamelabel.Name = "movienamelabel";
            this.movienamelabel.Size = new System.Drawing.Size(35, 13);
            this.movienamelabel.TabIndex = 1;
            this.movienamelabel.Text = "label3";
            // 
            // lenghtlabel
            // 
            this.lenghtlabel.AutoSize = true;
            this.lenghtlabel.Location = new System.Drawing.Point(146, 53);
            this.lenghtlabel.Name = "lenghtlabel";
            this.lenghtlabel.Size = new System.Drawing.Size(35, 13);
            this.lenghtlabel.TabIndex = 3;
            this.lenghtlabel.Text = "label5";
            // 
            // availablelabel
            // 
            this.availablelabel.AutoSize = true;
            this.availablelabel.Location = new System.Drawing.Point(146, 115);
            this.availablelabel.Name = "availablelabel";
            this.availablelabel.Size = new System.Drawing.Size(35, 13);
            this.availablelabel.TabIndex = 5;
            this.availablelabel.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Available";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Length";
            // 
            // borrowbutton
            // 
            this.borrowbutton.Location = new System.Drawing.Point(476, 208);
            this.borrowbutton.Name = "borrowbutton";
            this.borrowbutton.Size = new System.Drawing.Size(140, 56);
            this.borrowbutton.TabIndex = 3;
            this.borrowbutton.Text = "BORROW";
            this.borrowbutton.UseVisualStyleBackColor = true;
            this.borrowbutton.Click += new System.EventHandler(this.borrowbutton_Click);
            // 
            // returnbutton
            // 
            this.returnbutton.Location = new System.Drawing.Point(622, 208);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(140, 56);
            this.returnbutton.TabIndex = 4;
            this.returnbutton.Text = "RETURN";
            this.returnbutton.UseVisualStyleBackColor = true;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.borrowbutton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.moviepicker);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox moviepicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label movienamelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lenghtlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label availablelabel;
        private System.Windows.Forms.Button borrowbutton;
        private System.Windows.Forms.Button returnbutton;
    }
}

