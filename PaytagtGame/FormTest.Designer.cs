namespace PaytagtGame
{
    partial class FormTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTest));
            this.btA = new System.Windows.Forms.Button();
            this.btB = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btD = new System.Windows.Forms.Button();
            this.labelSorag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btA
            // 
            this.btA.BackColor = System.Drawing.Color.Lavender;
            this.btA.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btA.Location = new System.Drawing.Point(12, 212);
            this.btA.Name = "btA";
            this.btA.Size = new System.Drawing.Size(341, 78);
            this.btA.TabIndex = 0;
            this.btA.UseVisualStyleBackColor = false;
            this.btA.Click += new System.EventHandler(this.btA_Click);
            // 
            // btB
            // 
            this.btB.BackColor = System.Drawing.Color.Lavender;
            this.btB.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btB.Location = new System.Drawing.Point(438, 212);
            this.btB.Name = "btB";
            this.btB.Size = new System.Drawing.Size(309, 78);
            this.btB.TabIndex = 0;
            this.btB.UseVisualStyleBackColor = false;
            this.btB.Click += new System.EventHandler(this.btB_Click);
            // 
            // btC
            // 
            this.btC.BackColor = System.Drawing.Color.Lavender;
            this.btC.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btC.Location = new System.Drawing.Point(12, 332);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(341, 78);
            this.btC.TabIndex = 0;
            this.btC.UseVisualStyleBackColor = false;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btD
            // 
            this.btD.BackColor = System.Drawing.Color.Lavender;
            this.btD.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btD.Location = new System.Drawing.Point(438, 332);
            this.btD.Name = "btD";
            this.btD.Size = new System.Drawing.Size(309, 78);
            this.btD.TabIndex = 0;
            this.btD.UseVisualStyleBackColor = false;
            this.btD.Click += new System.EventHandler(this.btD_Click);
            // 
            // labelSorag
            // 
            this.labelSorag.BackColor = System.Drawing.Color.Lavender;
            this.labelSorag.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSorag.Image = ((System.Drawing.Image)(resources.GetObject("labelSorag.Image")));
            this.labelSorag.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelSorag.Location = new System.Drawing.Point(5, 9);
            this.labelSorag.Name = "labelSorag";
            this.labelSorag.Size = new System.Drawing.Size(679, 169);
            this.labelSorag.TabIndex = 1;
            this.labelSorag.Text = "label1";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(786, 435);
            this.Controls.Add(this.labelSorag);
            this.Controls.Add(this.btD);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btB);
            this.Controls.Add(this.btA);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btA;
        private System.Windows.Forms.Button btB;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btD;
        private System.Windows.Forms.Label labelSorag;
    }
}