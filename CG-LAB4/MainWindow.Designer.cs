﻿namespace CG_LAB4
{
    partial class MainWindow
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
            this.groupBox_gb1 = new System.Windows.Forms.GroupBox();
            this.dodec_rb = new System.Windows.Forms.RadioButton();
            this.icosaedr_rb = new System.Windows.Forms.RadioButton();
            this.oct_rb = new System.Windows.Forms.RadioButton();
            this.gecs_rb = new System.Windows.Forms.RadioButton();
            this.tetr_rb = new System.Windows.Forms.RadioButton();
            this.groupBox_gb2 = new System.Windows.Forms.GroupBox();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBox_gb1.SuspendLayout();
            this.groupBox_gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_gb1
            // 
            this.groupBox_gb1.Controls.Add(this.dodec_rb);
            this.groupBox_gb1.Controls.Add(this.icosaedr_rb);
            this.groupBox_gb1.Controls.Add(this.oct_rb);
            this.groupBox_gb1.Controls.Add(this.gecs_rb);
            this.groupBox_gb1.Controls.Add(this.tetr_rb);
            this.groupBox_gb1.Location = new System.Drawing.Point(13, 13);
            this.groupBox_gb1.Name = "groupBox_gb1";
            this.groupBox_gb1.Size = new System.Drawing.Size(411, 40);
            this.groupBox_gb1.TabIndex = 0;
            this.groupBox_gb1.TabStop = false;
            this.groupBox_gb1.Text = "Тела";
            // 
            // dodec_rb
            // 
            this.dodec_rb.AutoSize = true;
            this.dodec_rb.Location = new System.Drawing.Point(322, 17);
            this.dodec_rb.Name = "dodec_rb";
            this.dodec_rb.Size = new System.Drawing.Size(82, 17);
            this.dodec_rb.TabIndex = 4;
            this.dodec_rb.TabStop = true;
            this.dodec_rb.Tag = "4";
            this.dodec_rb.Text = "Додекаэдр";
            this.dodec_rb.UseVisualStyleBackColor = true;
            this.dodec_rb.CheckedChanged += new System.EventHandler(this.dodec_rb_CheckedChanged);
            // 
            // icosaedr_rb
            // 
            this.icosaedr_rb.AutoSize = true;
            this.icosaedr_rb.Location = new System.Drawing.Point(240, 17);
            this.icosaedr_rb.Name = "icosaedr_rb";
            this.icosaedr_rb.Size = new System.Drawing.Size(75, 17);
            this.icosaedr_rb.TabIndex = 3;
            this.icosaedr_rb.TabStop = true;
            this.icosaedr_rb.Tag = "3";
            this.icosaedr_rb.Text = "Икосаэдр";
            this.icosaedr_rb.UseVisualStyleBackColor = true;
            // 
            // oct_rb
            // 
            this.oct_rb.AutoSize = true;
            this.oct_rb.Location = new System.Drawing.Point(165, 17);
            this.oct_rb.Name = "oct_rb";
            this.oct_rb.Size = new System.Drawing.Size(68, 17);
            this.oct_rb.TabIndex = 2;
            this.oct_rb.TabStop = true;
            this.oct_rb.Tag = "2";
            this.oct_rb.Text = "Октаэдр";
            this.oct_rb.UseVisualStyleBackColor = true;
            // 
            // gecs_rb
            // 
            this.gecs_rb.AutoSize = true;
            this.gecs_rb.Location = new System.Drawing.Point(85, 17);
            this.gecs_rb.Name = "gecs_rb";
            this.gecs_rb.Size = new System.Drawing.Size(73, 17);
            this.gecs_rb.TabIndex = 1;
            this.gecs_rb.TabStop = true;
            this.gecs_rb.Tag = "1";
            this.gecs_rb.Text = "Гексаэдр";
            this.gecs_rb.UseVisualStyleBackColor = true;
            // 
            // tetr_rb
            // 
            this.tetr_rb.AutoSize = true;
            this.tetr_rb.Location = new System.Drawing.Point(6, 17);
            this.tetr_rb.Name = "tetr_rb";
            this.tetr_rb.Size = new System.Drawing.Size(73, 17);
            this.tetr_rb.TabIndex = 0;
            this.tetr_rb.TabStop = true;
            this.tetr_rb.Text = "Тетраэдр";
            this.tetr_rb.UseVisualStyleBackColor = true;
            this.tetr_rb.CheckedChanged += new System.EventHandler(this.tetr_rb_CheckedChanged);
            // 
            // groupBox_gb2
            // 
            this.groupBox_gb2.Controls.Add(this.hScrollBar3);
            this.groupBox_gb2.Controls.Add(this.hScrollBar2);
            this.groupBox_gb2.Controls.Add(this.hScrollBar1);
            this.groupBox_gb2.Location = new System.Drawing.Point(430, 13);
            this.groupBox_gb2.Name = "groupBox_gb2";
            this.groupBox_gb2.Size = new System.Drawing.Size(712, 40);
            this.groupBox_gb2.TabIndex = 1;
            this.groupBox_gb2.TabStop = false;
            this.groupBox_gb2.Text = "Свет";
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Location = new System.Drawing.Point(469, 16);
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(231, 17);
            this.hScrollBar3.TabIndex = 2;
            this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(238, 16);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(231, 17);
            this.hScrollBar2.TabIndex = 1;
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(7, 17);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(231, 17);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 640);
            this.Controls.Add(this.groupBox_gb2);
            this.Controls.Add(this.groupBox_gb1);
            this.Name = "MainWindow";
            this.Text = "Task4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox_gb1.ResumeLayout(false);
            this.groupBox_gb1.PerformLayout();
            this.groupBox_gb2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_gb1;
        private System.Windows.Forms.RadioButton gecs_rb;
        private System.Windows.Forms.RadioButton tetr_rb;
        private System.Windows.Forms.RadioButton dodec_rb;
        private System.Windows.Forms.RadioButton icosaedr_rb;
        private System.Windows.Forms.RadioButton oct_rb;
        private System.Windows.Forms.GroupBox groupBox_gb2;
        private System.Windows.Forms.HScrollBar hScrollBar3;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}
