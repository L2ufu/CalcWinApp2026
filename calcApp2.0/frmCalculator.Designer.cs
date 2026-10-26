namespace calculator_winApp
{
    partial class frmCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDsplay = new Label();
            Btn0 = new Button();
            buttonFloat = new Button();
            BtnDelete = new Button();
            BtnEquals = new Button();
            BtnPlus = new Button();
            Btn3 = new Button();
            Btn2 = new Button();
            Btn1 = new Button();
            BtnMinus = new Button();
            Btn6 = new Button();
            Btn5 = new Button();
            Btn4 = new Button();
            BtnMulty = new Button();
            BtnDivision = new Button();
            Btn9 = new Button();
            BtnPercent = new Button();
            Btn08 = new Button();
            BtnInvovle = new Button();
            BtnClearAll = new Button();
            Btn7 = new Button();
            SuspendLayout();
            // 
            // lblDsplay
            // 
            lblDsplay.BackColor = Color.LightBlue;
            lblDsplay.Font = new Font("Microsoft PhagsPa", 36F);
            lblDsplay.Location = new Point(12, 9);
            lblDsplay.Name = "lblDsplay";
            lblDsplay.Size = new Size(420, 152);
            lblDsplay.TabIndex = 1;
            lblDsplay.Click += allBtnClick;
            // 
            // Btn0
            // 
            Btn0.BackColor = SystemColors.AppWorkspace;
            Btn0.FlatAppearance.BorderColor = Color.DimGray;
            Btn0.FlatStyle = FlatStyle.Flat;
            Btn0.Font = new Font("Microsoft Sans Serif", 21.75F);
            Btn0.ForeColor = SystemColors.ActiveCaptionText;
            Btn0.Location = new Point(12, 525);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(100, 74);
            Btn0.TabIndex = 8;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = false;
            Btn0.Click += allBtnClick;
            // 
            // buttonFloat
            // 
            buttonFloat.BackColor = SystemColors.AppWorkspace;
            buttonFloat.FlatAppearance.BorderColor = Color.DimGray;
            buttonFloat.FlatStyle = FlatStyle.Flat;
            buttonFloat.Font = new Font("Microsoft Sans Serif", 21.75F);
            buttonFloat.ForeColor = SystemColors.ActiveCaptionText;
            buttonFloat.Location = new Point(118, 525);
            buttonFloat.Name = "buttonFloat";
            buttonFloat.Size = new Size(100, 74);
            buttonFloat.TabIndex = 9;
            buttonFloat.Text = ",";
            buttonFloat.UseVisualStyleBackColor = false;
            buttonFloat.Click += allBtnClick;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = SystemColors.AppWorkspace;
            BtnDelete.FlatAppearance.BorderColor = Color.DimGray;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Font = new Font("Microsoft Sans Serif", 18F);
            BtnDelete.ForeColor = SystemColors.ActiveCaptionText;
            BtnDelete.Location = new Point(226, 525);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(100, 74);
            BtnDelete.TabIndex = 10;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += deleteBtnClick;
            // 
            // BtnEquals
            // 
            BtnEquals.BackColor = Color.DarkSalmon;
            BtnEquals.FlatAppearance.BorderColor = Color.DimGray;
            BtnEquals.FlatStyle = FlatStyle.Flat;
            BtnEquals.Font = new Font("Microsoft Sans Serif", 21.75F);
            BtnEquals.ForeColor = SystemColors.ActiveCaptionText;
            BtnEquals.Location = new Point(332, 525);
            BtnEquals.Name = "BtnEquals";
            BtnEquals.Size = new Size(100, 74);
            BtnEquals.TabIndex = 19;
            BtnEquals.Text = "=";
            BtnEquals.UseVisualStyleBackColor = false;
            BtnEquals.Click += equalsBtnClick;
            // 
            // BtnPlus
            // 
            BtnPlus.BackColor = SystemColors.AppWorkspace;
            BtnPlus.FlatAppearance.BorderColor = Color.DimGray;
            BtnPlus.FlatStyle = FlatStyle.Flat;
            BtnPlus.Font = new Font("Microsoft Sans Serif", 21.75F);
            BtnPlus.ForeColor = SystemColors.ActiveCaptionText;
            BtnPlus.Location = new Point(332, 445);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(100, 74);
            BtnPlus.TabIndex = 12;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = false;
            BtnPlus.Click += operatorBtnClick;
            // 
            // Btn3
            // 
            Btn3.BackColor = SystemColors.AppWorkspace;
            Btn3.FlatAppearance.BorderColor = Color.DimGray;
            Btn3.FlatStyle = FlatStyle.Flat;
            Btn3.Font = new Font("Microsoft Sans Serif", 21.75F);
            Btn3.ForeColor = SystemColors.ActiveCaptionText;
            Btn3.Location = new Point(226, 445);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(100, 74);
            Btn3.TabIndex = 13;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += allBtnClick;
            // 
            // Btn2
            // 
            Btn2.BackColor = SystemColors.AppWorkspace;
            Btn2.FlatAppearance.BorderColor = Color.DimGray;
            Btn2.FlatStyle = FlatStyle.Flat;
            Btn2.Font = new Font("Microsoft Sans Serif", 21.75F);
            Btn2.ForeColor = SystemColors.ActiveCaptionText;
            Btn2.Location = new Point(118, 445);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(100, 74);
            Btn2.TabIndex = 14;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += allBtnClick;
            // 
            // Btn1
            // 
            Btn1.BackColor = SystemColors.AppWorkspace;
            Btn1.FlatAppearance.BorderColor = Color.DimGray;
            Btn1.FlatStyle = FlatStyle.Flat;
            Btn1.Font = new Font("Microsoft Sans Serif", 21.75F);
            Btn1.ForeColor = SystemColors.ActiveCaptionText;
            Btn1.Location = new Point(12, 445);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(100, 74);
            Btn1.TabIndex = 15;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += allBtnClick;
            // 
            // BtnMinus
            // 
            BtnMinus.BackColor = SystemColors.AppWorkspace;
            BtnMinus.FlatAppearance.BorderColor = Color.DimGray;
            BtnMinus.FlatStyle = FlatStyle.Flat;
            BtnMinus.Font = new Font("Microsoft Sans Serif", 21.75F);
            BtnMinus.ForeColor = SystemColors.ActiveCaptionText;
            BtnMinus.Location = new Point(332, 365);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(100, 74);
            BtnMinus.TabIndex = 16;
            BtnMinus.Text = "—";
            BtnMinus.UseVisualStyleBackColor = false;
            BtnMinus.Click += operatorBtnClick;
            // 
            // Btn6
            // 
            Btn6.BackColor = SystemColors.AppWorkspace;
            Btn6.FlatAppearance.BorderColor = Color.DimGray;
            Btn6.FlatStyle = FlatStyle.Flat;
            Btn6.Font = new Font("Microsoft Sans Serif", 21.75F);
            Btn6.ForeColor = SystemColors.ActiveCaptionText;
            Btn6.Location = new Point(226, 365);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(100, 74);
            Btn6.TabIndex = 17;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += allBtnClick;
            // 
            // Btn5
            // 
            Btn5.BackColor = SystemColors.AppWorkspace;
            Btn5.FlatAppearance.BorderColor = Color.DimGray;
            Btn5.FlatStyle = FlatStyle.Flat;
            Btn5.Font = new Font("Microsoft Sans Serif", 21.75F);
            Btn5.ForeColor = SystemColors.ActiveCaptionText;
            Btn5.Location = new Point(118, 365);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(100, 74);
            Btn5.TabIndex = 18;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += allBtnClick;
            // 
            // Btn4
            // 
            Btn4.BackColor = SystemColors.AppWorkspace;
            Btn4.FlatAppearance.BorderColor = Color.DimGray;
            Btn4.FlatStyle = FlatStyle.Flat;
            Btn4.Font = new Font("Microsoft Sans Serif", 21.75F);
            Btn4.ForeColor = SystemColors.ActiveCaptionText;
            Btn4.Location = new Point(12, 365);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(100, 74);
            Btn4.TabIndex = 19;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += allBtnClick;
            // 
            // BtnMulty
            // 
            BtnMulty.BackColor = SystemColors.AppWorkspace;
            BtnMulty.FlatAppearance.BorderColor = Color.DimGray;
            BtnMulty.FlatStyle = FlatStyle.Flat;
            BtnMulty.Font = new Font("Microsoft Sans Serif", 21.75F);
            BtnMulty.ForeColor = SystemColors.ActiveCaptionText;
            BtnMulty.Location = new Point(332, 285);
            BtnMulty.Name = "BtnMulty";
            BtnMulty.Size = new Size(100, 74);
            BtnMulty.TabIndex = 20;
            BtnMulty.Text = "×";
            BtnMulty.UseVisualStyleBackColor = false;
            BtnMulty.Click += operatorBtnClick;
            // 
            // BtnDivision
            // 
            BtnDivision.BackColor = SystemColors.AppWorkspace;
            BtnDivision.FlatAppearance.BorderColor = Color.DimGray;
            BtnDivision.FlatStyle = FlatStyle.Flat;
            BtnDivision.Font = new Font("Microsoft Sans Serif", 21.75F);
            BtnDivision.ForeColor = SystemColors.ActiveCaptionText;
            BtnDivision.Location = new Point(332, 205);
            BtnDivision.Name = "BtnDivision";
            BtnDivision.Size = new Size(100, 74);
            BtnDivision.TabIndex = 21;
            BtnDivision.Text = "/";
            BtnDivision.UseVisualStyleBackColor = false;
            BtnDivision.Click += operatorBtnClick;
            // 
            // Btn9
            // 
            Btn9.BackColor = SystemColors.AppWorkspace;
            Btn9.FlatAppearance.BorderColor = Color.DimGray;
            Btn9.FlatStyle = FlatStyle.Flat;
            Btn9.Font = new Font("Microsoft Sans Serif", 21.75F);
            Btn9.ForeColor = SystemColors.ActiveCaptionText;
            Btn9.Location = new Point(226, 285);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(100, 74);
            Btn9.TabIndex = 22;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = false;
            Btn9.Click += allBtnClick;
            // 
            // BtnPercent
            // 
            BtnPercent.BackColor = SystemColors.AppWorkspace;
            BtnPercent.FlatAppearance.BorderColor = Color.DimGray;
            BtnPercent.FlatStyle = FlatStyle.Flat;
            BtnPercent.Font = new Font("Microsoft Sans Serif", 21.75F);
            BtnPercent.ForeColor = SystemColors.ActiveCaptionText;
            BtnPercent.Location = new Point(226, 205);
            BtnPercent.Name = "BtnPercent";
            BtnPercent.Size = new Size(100, 74);
            BtnPercent.TabIndex = 23;
            BtnPercent.Text = "%";
            BtnPercent.UseVisualStyleBackColor = false;
            BtnPercent.Click += operatorBtnClick;
            // 
            // Btn08
            // 
            Btn08.BackColor = SystemColors.AppWorkspace;
            Btn08.FlatAppearance.BorderColor = Color.DimGray;
            Btn08.FlatStyle = FlatStyle.Flat;
            Btn08.Font = new Font("Microsoft Sans Serif", 21.75F);
            Btn08.ForeColor = SystemColors.ActiveCaptionText;
            Btn08.Location = new Point(118, 285);
            Btn08.Name = "Btn08";
            Btn08.Size = new Size(100, 74);
            Btn08.TabIndex = 24;
            Btn08.Text = "8";
            Btn08.UseVisualStyleBackColor = false;
            Btn08.Click += allBtnClick;
            // 
            // BtnInvovle
            // 
            BtnInvovle.BackColor = SystemColors.AppWorkspace;
            BtnInvovle.FlatAppearance.BorderColor = Color.DimGray;
            BtnInvovle.FlatStyle = FlatStyle.Flat;
            BtnInvovle.Font = new Font("Microsoft Sans Serif", 21.75F);
            BtnInvovle.ForeColor = SystemColors.ActiveCaptionText;
            BtnInvovle.Location = new Point(118, 205);
            BtnInvovle.Name = "BtnInvovle";
            BtnInvovle.Size = new Size(100, 74);
            BtnInvovle.TabIndex = 25;
            BtnInvovle.Text = "^";
            BtnInvovle.UseVisualStyleBackColor = false;
            BtnInvovle.Click += operatorBtnClick;
            // 
            // BtnClearAll
            // 
            BtnClearAll.BackColor = Color.DarkSalmon;
            BtnClearAll.FlatAppearance.BorderColor = Color.DimGray;
            BtnClearAll.FlatStyle = FlatStyle.Flat;
            BtnClearAll.Font = new Font("Microsoft Sans Serif", 21.75F);
            BtnClearAll.ForeColor = SystemColors.ActiveCaptionText;
            BtnClearAll.Location = new Point(12, 205);
            BtnClearAll.Name = "BtnClearAll";
            BtnClearAll.Size = new Size(100, 74);
            BtnClearAll.TabIndex = 26;
            BtnClearAll.Text = "AC";
            BtnClearAll.UseVisualStyleBackColor = false;
            BtnClearAll.Click += acBtnClick;
            // 
            // Btn7
            // 
            Btn7.BackColor = SystemColors.AppWorkspace;
            Btn7.FlatAppearance.BorderColor = Color.DimGray;
            Btn7.FlatStyle = FlatStyle.Flat;
            Btn7.Font = new Font("Microsoft Sans Serif", 21.75F);
            Btn7.ForeColor = SystemColors.ActiveCaptionText;
            Btn7.Location = new Point(12, 285);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(100, 74);
            Btn7.TabIndex = 27;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = false;
            Btn7.Click += allBtnClick;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(444, 611);
            Controls.Add(Btn7);
            Controls.Add(BtnClearAll);
            Controls.Add(BtnInvovle);
            Controls.Add(Btn08);
            Controls.Add(BtnPercent);
            Controls.Add(Btn9);
            Controls.Add(BtnDivision);
            Controls.Add(BtnMulty);
            Controls.Add(Btn4);
            Controls.Add(Btn5);
            Controls.Add(Btn6);
            Controls.Add(BtnMinus);
            Controls.Add(Btn1);
            Controls.Add(Btn2);
            Controls.Add(Btn3);
            Controls.Add(BtnPlus);
            Controls.Add(BtnEquals);
            Controls.Add(BtnDelete);
            Controls.Add(buttonFloat);
            Controls.Add(Btn0);
            Controls.Add(lblDsplay);
            Name = "frmCalculator";
            Text = "Form1";
            Click += operatorBtnClick;
            ResumeLayout(false);

        }

        #endregion
        private Label lblDsplay;
        private Button Btn0;
        private Button buttonFloat;
        private Button BtnDelete;
        private Button BtnEquals;
        private Button BtnPlus;
        private Button Btn3;
        private Button Btn2;
        private Button Btn1;
        private Button BtnMinus;
        private Button Btn6;
        private Button Btn5;
        private Button Btn4;
        private Button BtnMulty;
        private Button BtnDivision;
        private Button Btn9;
        private Button BtnPercent;
        private Button Btn08;
        private Button BtnInvovle;
        private Button BtnClearAll;
        private Button Btn7;
    }
}
