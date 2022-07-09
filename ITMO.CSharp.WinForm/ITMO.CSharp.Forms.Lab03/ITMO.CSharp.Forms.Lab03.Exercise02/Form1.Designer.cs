
namespace WinTimer2
{
    partial class Form1
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
            this.userControlTimer21 = new WinTimer2.UserControlTimer2();
            this.SuspendLayout();
            // 
            // userControlTimer21
            // 
            this.userControlTimer21.Location = new System.Drawing.Point(117, 62);
            this.userControlTimer21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlTimer21.Name = "userControlTimer21";
            this.userControlTimer21.Size = new System.Drawing.Size(112, 120);
            this.userControlTimer21.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 228);
            this.Controls.Add(this.userControlTimer21);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "WinTimer2";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTimer2 userControlTimer21;
    }
}

