
namespace GentryCRUDexample
{
    partial class HomePage
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
            this.ToPeople = new System.Windows.Forms.Button();
            this.ToItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcom to the Adventure works store.";
            // 
            // ToPeople
            // 
            this.ToPeople.Location = new System.Drawing.Point(13, 13);
            this.ToPeople.Name = "ToPeople";
            this.ToPeople.Size = new System.Drawing.Size(75, 23);
            this.ToPeople.TabIndex = 1;
            this.ToPeople.Text = "People";
            this.ToPeople.UseVisualStyleBackColor = true;
            this.ToPeople.Click += new System.EventHandler(this.ToPeople_Click);
            // 
            // ToItems
            // 
            this.ToItems.Location = new System.Drawing.Point(95, 12);
            this.ToItems.Name = "ToItems";
            this.ToItems.Size = new System.Drawing.Size(75, 23);
            this.ToItems.TabIndex = 2;
            this.ToItems.Text = "Items";
            this.ToItems.UseVisualStyleBackColor = true;
            this.ToItems.Click += new System.EventHandler(this.ToItems_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToItems);
            this.Controls.Add(this.ToPeople);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ToPeople;
        private System.Windows.Forms.Button ToItems;
    }
}

