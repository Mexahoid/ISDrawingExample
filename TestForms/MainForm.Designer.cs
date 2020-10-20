namespace TestForms
{
    partial class MainForm
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
            this.CtrlPnlMain = new System.Windows.Forms.Panel();
            this.CtrlBtnMove = new System.Windows.Forms.Button();
            this.CtrlNudDist = new System.Windows.Forms.NumericUpDown();
            this.CtrlLblDist = new System.Windows.Forms.Label();
            this.CtrlGrbY = new System.Windows.Forms.GroupBox();
            this.CtrlRBYUp = new System.Windows.Forms.RadioButton();
            this.CtrlRBYDown = new System.Windows.Forms.RadioButton();
            this.CtrlRBYNone = new System.Windows.Forms.RadioButton();
            this.CtrlGrbX = new System.Windows.Forms.GroupBox();
            this.CtrlRBXNone = new System.Windows.Forms.RadioButton();
            this.CtrlRBXLeft = new System.Windows.Forms.RadioButton();
            this.CtrlRBXRight = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlNudDist)).BeginInit();
            this.CtrlGrbY.SuspendLayout();
            this.CtrlGrbX.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtrlPnlMain
            // 
            this.CtrlPnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CtrlPnlMain.Location = new System.Drawing.Point(12, 12);
            this.CtrlPnlMain.Name = "CtrlPnlMain";
            this.CtrlPnlMain.Size = new System.Drawing.Size(401, 366);
            this.CtrlPnlMain.TabIndex = 0;
            this.CtrlPnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CtrlPnlMain_MouseDown);
            // 
            // CtrlBtnMove
            // 
            this.CtrlBtnMove.Location = new System.Drawing.Point(419, 70);
            this.CtrlBtnMove.Name = "CtrlBtnMove";
            this.CtrlBtnMove.Size = new System.Drawing.Size(75, 23);
            this.CtrlBtnMove.TabIndex = 1;
            this.CtrlBtnMove.Text = "Двигаться";
            this.CtrlBtnMove.UseVisualStyleBackColor = true;
            this.CtrlBtnMove.Click += new System.EventHandler(this.CtrlBtnMove_Click);
            // 
            // CtrlNudDist
            // 
            this.CtrlNudDist.Location = new System.Drawing.Point(419, 29);
            this.CtrlNudDist.Name = "CtrlNudDist";
            this.CtrlNudDist.Size = new System.Drawing.Size(75, 20);
            this.CtrlNudDist.TabIndex = 2;
            // 
            // CtrlLblDist
            // 
            this.CtrlLblDist.AutoSize = true;
            this.CtrlLblDist.Location = new System.Drawing.Point(420, 13);
            this.CtrlLblDist.Name = "CtrlLblDist";
            this.CtrlLblDist.Size = new System.Drawing.Size(63, 13);
            this.CtrlLblDist.TabIndex = 3;
            this.CtrlLblDist.Text = "Дистанция";
            // 
            // CtrlGrbY
            // 
            this.CtrlGrbY.Controls.Add(this.CtrlRBYNone);
            this.CtrlGrbY.Controls.Add(this.CtrlRBYDown);
            this.CtrlGrbY.Controls.Add(this.CtrlRBYUp);
            this.CtrlGrbY.Location = new System.Drawing.Point(522, 13);
            this.CtrlGrbY.Name = "CtrlGrbY";
            this.CtrlGrbY.Size = new System.Drawing.Size(89, 89);
            this.CtrlGrbY.TabIndex = 4;
            this.CtrlGrbY.TabStop = false;
            this.CtrlGrbY.Text = "По Y";
            // 
            // CtrlRBYUp
            // 
            this.CtrlRBYUp.AutoSize = true;
            this.CtrlRBYUp.Checked = true;
            this.CtrlRBYUp.Location = new System.Drawing.Point(7, 20);
            this.CtrlRBYUp.Name = "CtrlRBYUp";
            this.CtrlRBYUp.Size = new System.Drawing.Size(55, 17);
            this.CtrlRBYUp.TabIndex = 0;
            this.CtrlRBYUp.TabStop = true;
            this.CtrlRBYUp.Text = "Вверх";
            this.CtrlRBYUp.UseVisualStyleBackColor = true;
            // 
            // CtrlRBYDown
            // 
            this.CtrlRBYDown.AutoSize = true;
            this.CtrlRBYDown.Location = new System.Drawing.Point(7, 43);
            this.CtrlRBYDown.Name = "CtrlRBYDown";
            this.CtrlRBYDown.Size = new System.Drawing.Size(50, 17);
            this.CtrlRBYDown.TabIndex = 0;
            this.CtrlRBYDown.Text = "Вниз";
            this.CtrlRBYDown.UseVisualStyleBackColor = true;
            // 
            // CtrlRBYNone
            // 
            this.CtrlRBYNone.AutoSize = true;
            this.CtrlRBYNone.Location = new System.Drawing.Point(7, 66);
            this.CtrlRBYNone.Name = "CtrlRBYNone";
            this.CtrlRBYNone.Size = new System.Drawing.Size(73, 17);
            this.CtrlRBYNone.TabIndex = 0;
            this.CtrlRBYNone.Text = "На месте";
            this.CtrlRBYNone.UseVisualStyleBackColor = true;
            // 
            // CtrlGrbX
            // 
            this.CtrlGrbX.Controls.Add(this.CtrlRBXNone);
            this.CtrlGrbX.Controls.Add(this.CtrlRBXLeft);
            this.CtrlGrbX.Controls.Add(this.CtrlRBXRight);
            this.CtrlGrbX.Location = new System.Drawing.Point(522, 121);
            this.CtrlGrbX.Name = "CtrlGrbX";
            this.CtrlGrbX.Size = new System.Drawing.Size(89, 89);
            this.CtrlGrbX.TabIndex = 4;
            this.CtrlGrbX.TabStop = false;
            this.CtrlGrbX.Text = "По Х";
            // 
            // CtrlRBXNone
            // 
            this.CtrlRBXNone.AutoSize = true;
            this.CtrlRBXNone.Location = new System.Drawing.Point(7, 66);
            this.CtrlRBXNone.Name = "CtrlRBXNone";
            this.CtrlRBXNone.Size = new System.Drawing.Size(73, 17);
            this.CtrlRBXNone.TabIndex = 0;
            this.CtrlRBXNone.Text = "На месте";
            this.CtrlRBXNone.UseVisualStyleBackColor = true;
            // 
            // CtrlRBXLeft
            // 
            this.CtrlRBXLeft.AutoSize = true;
            this.CtrlRBXLeft.Location = new System.Drawing.Point(7, 43);
            this.CtrlRBXLeft.Name = "CtrlRBXLeft";
            this.CtrlRBXLeft.Size = new System.Drawing.Size(56, 17);
            this.CtrlRBXLeft.TabIndex = 0;
            this.CtrlRBXLeft.Text = "Влево";
            this.CtrlRBXLeft.UseVisualStyleBackColor = true;
            // 
            // CtrlRBXRight
            // 
            this.CtrlRBXRight.AutoSize = true;
            this.CtrlRBXRight.Checked = true;
            this.CtrlRBXRight.Location = new System.Drawing.Point(7, 20);
            this.CtrlRBXRight.Name = "CtrlRBXRight";
            this.CtrlRBXRight.Size = new System.Drawing.Size(62, 17);
            this.CtrlRBXRight.TabIndex = 0;
            this.CtrlRBXRight.TabStop = true;
            this.CtrlRBXRight.Text = "Вправо";
            this.CtrlRBXRight.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 389);
            this.Controls.Add(this.CtrlGrbX);
            this.Controls.Add(this.CtrlGrbY);
            this.Controls.Add(this.CtrlLblDist);
            this.Controls.Add(this.CtrlNudDist);
            this.Controls.Add(this.CtrlBtnMove);
            this.Controls.Add(this.CtrlPnlMain);
            this.Name = "MainForm";
            this.Text = "Рисование";
            ((System.ComponentModel.ISupportInitialize)(this.CtrlNudDist)).EndInit();
            this.CtrlGrbY.ResumeLayout(false);
            this.CtrlGrbY.PerformLayout();
            this.CtrlGrbX.ResumeLayout(false);
            this.CtrlGrbX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CtrlPnlMain;
        private System.Windows.Forms.Button CtrlBtnMove;
        private System.Windows.Forms.NumericUpDown CtrlNudDist;
        private System.Windows.Forms.Label CtrlLblDist;
        private System.Windows.Forms.GroupBox CtrlGrbY;
        private System.Windows.Forms.RadioButton CtrlRBYNone;
        private System.Windows.Forms.RadioButton CtrlRBYDown;
        private System.Windows.Forms.RadioButton CtrlRBYUp;
        private System.Windows.Forms.GroupBox CtrlGrbX;
        private System.Windows.Forms.RadioButton CtrlRBXNone;
        private System.Windows.Forms.RadioButton CtrlRBXLeft;
        private System.Windows.Forms.RadioButton CtrlRBXRight;
    }
}

