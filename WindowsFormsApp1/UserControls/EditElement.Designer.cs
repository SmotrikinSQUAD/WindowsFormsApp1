namespace WindowsFormsApp1.UserControls
{
    partial class EditElement
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.word_name = new System.Windows.Forms.Label();
            this.Edit_but = new System.Windows.Forms.Button();
            this.Delete_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // word_name
            // 
            this.word_name.AutoSize = true;
            this.word_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.word_name.Location = new System.Drawing.Point(17, 11);
            this.word_name.Name = "word_name";
            this.word_name.Size = new System.Drawing.Size(79, 29);
            this.word_name.TabIndex = 0;
            this.word_name.Text = "label1";
            // 
            // Edit_but
            // 
            this.Edit_but.Location = new System.Drawing.Point(220, 11);
            this.Edit_but.Name = "Edit_but";
            this.Edit_but.Size = new System.Drawing.Size(83, 31);
            this.Edit_but.TabIndex = 1;
            this.Edit_but.Text = "Изменить";
            this.Edit_but.UseVisualStyleBackColor = true;
            this.Edit_but.Click += new System.EventHandler(this.Edit_but_Click);
            // 
            // Delete_but
            // 
            this.Delete_but.Location = new System.Drawing.Point(309, 11);
            this.Delete_but.Name = "Delete_but";
            this.Delete_but.Size = new System.Drawing.Size(83, 31);
            this.Delete_but.TabIndex = 2;
            this.Delete_but.Text = "Удалить";
            this.Delete_but.UseVisualStyleBackColor = true;
            this.Delete_but.Click += new System.EventHandler(this.Delete_but_Click);
            // 
            // EditElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Delete_but);
            this.Controls.Add(this.Edit_but);
            this.Controls.Add(this.word_name);
            this.Name = "EditElement";
            this.Size = new System.Drawing.Size(405, 52);
            this.Load += new System.EventHandler(this.EditElement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label word_name;
        private System.Windows.Forms.Button Edit_but;
        private System.Windows.Forms.Button Delete_but;
    }
}
