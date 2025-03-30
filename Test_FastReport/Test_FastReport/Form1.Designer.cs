namespace Test_FastReport
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
            this.Rectangle = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.move = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rectangle
            // 
            this.Rectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Rectangle.Location = new System.Drawing.Point(13, 363);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(97, 36);
            this.Rectangle.TabIndex = 0;
            this.Rectangle.Text = "Прямоугольник";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Circle
            // 
            this.Circle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Circle.Location = new System.Drawing.Point(116, 363);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(97, 36);
            this.Circle.TabIndex = 1;
            this.Circle.Text = "Круг";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Triangle
            // 
            this.Triangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Triangle.Location = new System.Drawing.Point(219, 363);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(97, 36);
            this.Triangle.TabIndex = 2;
            this.Triangle.Text = "Треугольник";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(875, 363);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(97, 36);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Прекращение действия";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // check
            // 
            this.check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.check.Location = new System.Drawing.Point(322, 363);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(97, 36);
            this.check.TabIndex = 4;
            this.check.Text = "Проверка";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // move
            // 
            this.move.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.move.Location = new System.Drawing.Point(425, 363);
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(97, 36);
            this.move.TabIndex = 5;
            this.move.Text = "Перемещение";
            this.move.UseVisualStyleBackColor = true;
            this.move.Click += new System.EventHandler(this.move_Click);
            // 
            // size
            // 
            this.size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.size.Location = new System.Drawing.Point(528, 363);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(97, 36);
            this.size.TabIndex = 6;
            this.size.Text = "Изменение размеров";
            this.size.UseVisualStyleBackColor = true;
            this.size.Click += new System.EventHandler(this.size_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 411);
            this.Controls.Add(this.size);
            this.Controls.Add(this.move);
            this.Controls.Add(this.check);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Rectangle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button move;
        private System.Windows.Forms.Button size;
    }
}

