
namespace task_4_geom
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
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.trackBarTurn = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTurn)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(1184, 75);
            this.trackBarSize.Maximum = 12;
            this.trackBarSize.Minimum = 3;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(233, 45);
            this.trackBarSize.TabIndex = 3;
            this.trackBarSize.TickFrequency = 2;
            this.trackBarSize.Value = 8;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // trackBarTurn
            // 
            this.trackBarTurn.Location = new System.Drawing.Point(135, 84);
            this.trackBarTurn.Maximum = 3;
            this.trackBarTurn.Minimum = 1;
            this.trackBarTurn.Name = "trackBarTurn";
            this.trackBarTurn.Size = new System.Drawing.Size(175, 45);
            this.trackBarTurn.TabIndex = 4;
            this.trackBarTurn.Value = 1;
            this.trackBarTurn.Scroll += new System.EventHandler(this.trackBarTurn_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(176, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поворот";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1257, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Размер";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarTurn);
            this.Controls.Add(this.trackBarSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTurn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.TrackBar trackBarTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

