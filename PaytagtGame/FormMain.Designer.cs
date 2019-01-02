namespace PaytagtGame
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btYewropa = new System.Windows.Forms.Button();
            this.btAziýa = new System.Windows.Forms.Button();
            this.btAfrika = new System.Windows.Forms.Button();
            this.btAmerika = new System.Windows.Forms.Button();
            this.btOkeaniya = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btYewropa
            // 
            this.btYewropa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btYewropa.Location = new System.Drawing.Point(229, 22);
            this.btYewropa.Name = "btYewropa";
            this.btYewropa.Size = new System.Drawing.Size(348, 69);
            this.btYewropa.TabIndex = 0;
            this.btYewropa.Text = "Ýewropa";
            this.btYewropa.UseVisualStyleBackColor = true;
            this.btYewropa.Click += new System.EventHandler(this.btYewropa_Click);
            // 
            // btAziýa
            // 
            this.btAziýa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAziýa.Location = new System.Drawing.Point(229, 112);
            this.btAziýa.Name = "btAziýa";
            this.btAziýa.Size = new System.Drawing.Size(348, 67);
            this.btAziýa.TabIndex = 0;
            this.btAziýa.Text = "Aziýa";
            this.btAziýa.UseVisualStyleBackColor = true;
            this.btAziýa.Click += new System.EventHandler(this.btAziýa_Click);
            // 
            // btAfrika
            // 
            this.btAfrika.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAfrika.Location = new System.Drawing.Point(229, 402);
            this.btAfrika.Name = "btAfrika";
            this.btAfrika.Size = new System.Drawing.Size(348, 67);
            this.btAfrika.TabIndex = 0;
            this.btAfrika.Text = "Afrika";
            this.btAfrika.UseVisualStyleBackColor = true;
            this.btAfrika.Click += new System.EventHandler(this.btAfrika_Click);
            // 
            // btAmerika
            // 
            this.btAmerika.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAmerika.Location = new System.Drawing.Point(229, 205);
            this.btAmerika.Name = "btAmerika";
            this.btAmerika.Size = new System.Drawing.Size(348, 71);
            this.btAmerika.TabIndex = 0;
            this.btAmerika.Text = "Amerika";
            this.btAmerika.UseVisualStyleBackColor = true;
            // 
            // btOkeaniya
            // 
            this.btOkeaniya.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOkeaniya.Location = new System.Drawing.Point(229, 309);
            this.btOkeaniya.Name = "btOkeaniya";
            this.btOkeaniya.Size = new System.Drawing.Size(348, 67);
            this.btOkeaniya.TabIndex = 0;
            this.btOkeaniya.Text = "Okeaniýa";
            this.btOkeaniya.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(781, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAfrika);
            this.Controls.Add(this.btAziýa);
            this.Controls.Add(this.btOkeaniya);
            this.Controls.Add(this.btAmerika);
            this.Controls.Add(this.btYewropa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paýtagtlar";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Click += new System.EventHandler(this.FormMain_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btYewropa;
        private System.Windows.Forms.Button btAziýa;
        private System.Windows.Forms.Button btAfrika;
        private System.Windows.Forms.Button btAmerika;
        private System.Windows.Forms.Button btOkeaniya;
        private System.Windows.Forms.Button button1;
    }
}

