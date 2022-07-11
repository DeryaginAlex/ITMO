
namespace ControlWorkApp2
{
    partial class StartForm
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
            this.ButtonFinishForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonFinishForm
            // 
            this.ButtonFinishForm.Location = new System.Drawing.Point(128, 91);
            this.ButtonFinishForm.Name = "ButtonFinishForm";
            this.ButtonFinishForm.Size = new System.Drawing.Size(518, 254);
            this.ButtonFinishForm.TabIndex = 0;
            this.ButtonFinishForm.Text = "Next form";
            this.ButtonFinishForm.UseVisualStyleBackColor = true;
            this.ButtonFinishForm.Click += new System.EventHandler(this.ButtonFinishForm_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonFinishForm);
            this.Name = "StartForm";
            this.Text = "Start";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonFinishForm;
    }
}

