namespace MtankersleyDemo2UC
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(61, 94);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.Size = new System.Drawing.Size(248, 39);
            this.tb1.TabIndex = 0;
            this.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(56, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 25);
            this.lbl1.TabIndex = 1;
            // 
            // tb2
            // 
            this.tb2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.Location = new System.Drawing.Point(61, 139);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.ReadOnly = true;
            this.tb2.Size = new System.Drawing.Size(248, 39);
            this.tb2.TabIndex = 2;
            this.tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(110, 15);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(199, 76);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "label1";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tb1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(364, 204);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tb1;
        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.TextBox tb2;
        public System.Windows.Forms.Label lb1;
    }
}
