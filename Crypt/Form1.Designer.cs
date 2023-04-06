
namespace Crypt
{
    partial class Crypto
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
            this.messageText = new System.Windows.Forms.TextBox();
            this.SignBtn = new System.Windows.Forms.Button();
            this.prKeyText = new System.Windows.Forms.TextBox();
            this.primeNumText = new System.Windows.Forms.TextBox();
            this.primeRootText = new System.Windows.Forms.TextBox();
            this.secNumText = new System.Windows.Forms.TextBox();
            this.aSignText = new System.Windows.Forms.TextBox();
            this.bSignText = new System.Windows.Forms.TextBox();
            this.yKeyText = new System.Windows.Forms.TextBox();
            this.CheckSignBtn = new System.Windows.Forms.Button();
            this.checkResultText = new System.Windows.Forms.TextBox();
            this.PubKeyLabel = new System.Windows.Forms.Label();
            this.PrKeyLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.pKeyLabel = new System.Windows.Forms.Label();
            this.gKeyLabel = new System.Windows.Forms.Label();
            this.yKeyLabel = new System.Windows.Forms.Label();
            this.xKeyLabel = new System.Windows.Forms.Label();
            this.kKeyLabel = new System.Windows.Forms.Label();
            this.mKeyLabel = new System.Windows.Forms.Label();
            this.aKeyLabel = new System.Windows.Forms.Label();
            this.bKeyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nNumText_RSA = new System.Windows.Forms.TextBox();
            this.eNumText_RSA = new System.Windows.Forms.TextBox();
            this.checkResultText_RSA = new System.Windows.Forms.TextBox();
            this.SignRSA_btn = new System.Windows.Forms.Button();
            this.PubKeyLabel_RSA = new System.Windows.Forms.Label();
            this.signLabel_RSA = new System.Windows.Forms.Label();
            this.msgNumLabel_RSA = new System.Windows.Forms.Label();
            this.msgNumText_RSA = new System.Windows.Forms.TextBox();
            this.signText_RSA = new System.Windows.Forms.TextBox();
            this.resLabel_RSA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(138, 47);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(100, 20);
            this.messageText.TabIndex = 0;
            this.messageText.Text = "m";
            // 
            // SignBtn
            // 
            this.SignBtn.Location = new System.Drawing.Point(16, 194);
            this.SignBtn.Name = "SignBtn";
            this.SignBtn.Size = new System.Drawing.Size(79, 27);
            this.SignBtn.TabIndex = 1;
            this.SignBtn.Text = "SignMsg";
            this.SignBtn.UseVisualStyleBackColor = true;
            this.SignBtn.Click += new System.EventHandler(this.SignBtn_Click);
            // 
            // prKeyText
            // 
            this.prKeyText.Location = new System.Drawing.Point(13, 142);
            this.prKeyText.Name = "prKeyText";
            this.prKeyText.Size = new System.Drawing.Size(100, 20);
            this.prKeyText.TabIndex = 2;
            this.prKeyText.Text = "x";
            // 
            // primeNumText
            // 
            this.primeNumText.Location = new System.Drawing.Point(13, 47);
            this.primeNumText.Name = "primeNumText";
            this.primeNumText.Size = new System.Drawing.Size(100, 20);
            this.primeNumText.TabIndex = 3;
            this.primeNumText.Text = "p";
            // 
            // primeRootText
            // 
            this.primeRootText.Location = new System.Drawing.Point(13, 73);
            this.primeRootText.Name = "primeRootText";
            this.primeRootText.Size = new System.Drawing.Size(100, 20);
            this.primeRootText.TabIndex = 4;
            this.primeRootText.Text = "g";
            // 
            // secNumText
            // 
            this.secNumText.Location = new System.Drawing.Point(13, 168);
            this.secNumText.Name = "secNumText";
            this.secNumText.Size = new System.Drawing.Size(100, 20);
            this.secNumText.TabIndex = 5;
            this.secNumText.Text = "k";
            // 
            // aSignText
            // 
            this.aSignText.Location = new System.Drawing.Point(138, 89);
            this.aSignText.Name = "aSignText";
            this.aSignText.Size = new System.Drawing.Size(100, 20);
            this.aSignText.TabIndex = 6;
            this.aSignText.Text = "a";
            // 
            // bSignText
            // 
            this.bSignText.Location = new System.Drawing.Point(138, 115);
            this.bSignText.Name = "bSignText";
            this.bSignText.Size = new System.Drawing.Size(100, 20);
            this.bSignText.TabIndex = 7;
            this.bSignText.Text = "b";
            // 
            // yKeyText
            // 
            this.yKeyText.Location = new System.Drawing.Point(13, 99);
            this.yKeyText.Name = "yKeyText";
            this.yKeyText.Size = new System.Drawing.Size(100, 20);
            this.yKeyText.TabIndex = 8;
            this.yKeyText.Text = "y";
            // 
            // CheckSignBtn
            // 
            this.CheckSignBtn.Location = new System.Drawing.Point(138, 142);
            this.CheckSignBtn.Name = "CheckSignBtn";
            this.CheckSignBtn.Size = new System.Drawing.Size(100, 27);
            this.CheckSignBtn.TabIndex = 9;
            this.CheckSignBtn.Text = "CheckSign";
            this.CheckSignBtn.UseVisualStyleBackColor = true;
            this.CheckSignBtn.Click += new System.EventHandler(this.CheckSignBtn_Click);
            // 
            // checkResultText
            // 
            this.checkResultText.Location = new System.Drawing.Point(138, 191);
            this.checkResultText.Name = "checkResultText";
            this.checkResultText.Size = new System.Drawing.Size(100, 20);
            this.checkResultText.TabIndex = 10;
            this.checkResultText.Text = "Result";
            // 
            // PubKeyLabel
            // 
            this.PubKeyLabel.AutoSize = true;
            this.PubKeyLabel.Location = new System.Drawing.Point(13, 31);
            this.PubKeyLabel.Name = "PubKeyLabel";
            this.PubKeyLabel.Size = new System.Drawing.Size(57, 13);
            this.PubKeyLabel.TabIndex = 14;
            this.PubKeyLabel.Text = "Public Key";
            // 
            // PrKeyLabel
            // 
            this.PrKeyLabel.AutoSize = true;
            this.PrKeyLabel.Location = new System.Drawing.Point(13, 126);
            this.PrKeyLabel.Name = "PrKeyLabel";
            this.PrKeyLabel.Size = new System.Drawing.Size(61, 13);
            this.PrKeyLabel.TabIndex = 15;
            this.PrKeyLabel.Text = "Private Key";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(149, 31);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(50, 13);
            this.messageLabel.TabIndex = 16;
            this.messageLabel.Text = "Message";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(151, 73);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(28, 13);
            this.outputLabel.TabIndex = 17;
            this.outputLabel.Text = "Sign";
            // 
            // pKeyLabel
            // 
            this.pKeyLabel.AutoSize = true;
            this.pKeyLabel.Location = new System.Drawing.Point(119, 50);
            this.pKeyLabel.Name = "pKeyLabel";
            this.pKeyLabel.Size = new System.Drawing.Size(13, 13);
            this.pKeyLabel.TabIndex = 18;
            this.pKeyLabel.Text = "p";
            // 
            // gKeyLabel
            // 
            this.gKeyLabel.AutoSize = true;
            this.gKeyLabel.Location = new System.Drawing.Point(119, 76);
            this.gKeyLabel.Name = "gKeyLabel";
            this.gKeyLabel.Size = new System.Drawing.Size(13, 13);
            this.gKeyLabel.TabIndex = 19;
            this.gKeyLabel.Text = "g";
            // 
            // yKeyLabel
            // 
            this.yKeyLabel.AutoSize = true;
            this.yKeyLabel.Location = new System.Drawing.Point(119, 102);
            this.yKeyLabel.Name = "yKeyLabel";
            this.yKeyLabel.Size = new System.Drawing.Size(12, 13);
            this.yKeyLabel.TabIndex = 20;
            this.yKeyLabel.Text = "y";
            // 
            // xKeyLabel
            // 
            this.xKeyLabel.AutoSize = true;
            this.xKeyLabel.Location = new System.Drawing.Point(119, 145);
            this.xKeyLabel.Name = "xKeyLabel";
            this.xKeyLabel.Size = new System.Drawing.Size(12, 13);
            this.xKeyLabel.TabIndex = 21;
            this.xKeyLabel.Text = "x";
            // 
            // kKeyLabel
            // 
            this.kKeyLabel.AutoSize = true;
            this.kKeyLabel.Location = new System.Drawing.Point(119, 171);
            this.kKeyLabel.Name = "kKeyLabel";
            this.kKeyLabel.Size = new System.Drawing.Size(13, 13);
            this.kKeyLabel.TabIndex = 22;
            this.kKeyLabel.Text = "k";
            // 
            // mKeyLabel
            // 
            this.mKeyLabel.AutoSize = true;
            this.mKeyLabel.Location = new System.Drawing.Point(244, 50);
            this.mKeyLabel.Name = "mKeyLabel";
            this.mKeyLabel.Size = new System.Drawing.Size(15, 13);
            this.mKeyLabel.TabIndex = 23;
            this.mKeyLabel.Text = "m";
            // 
            // aKeyLabel
            // 
            this.aKeyLabel.AutoSize = true;
            this.aKeyLabel.Location = new System.Drawing.Point(244, 92);
            this.aKeyLabel.Name = "aKeyLabel";
            this.aKeyLabel.Size = new System.Drawing.Size(13, 13);
            this.aKeyLabel.TabIndex = 24;
            this.aKeyLabel.Text = "a";
            // 
            // bKeyLabel
            // 
            this.bKeyLabel.AutoSize = true;
            this.bKeyLabel.Location = new System.Drawing.Point(244, 118);
            this.bKeyLabel.Name = "bKeyLabel";
            this.bKeyLabel.Size = new System.Drawing.Size(13, 13);
            this.bKeyLabel.TabIndex = 25;
            this.bKeyLabel.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Check result";
            // 
            // nNumText_RSA
            // 
            this.nNumText_RSA.Location = new System.Drawing.Point(275, 47);
            this.nNumText_RSA.Name = "nNumText_RSA";
            this.nNumText_RSA.Size = new System.Drawing.Size(100, 20);
            this.nNumText_RSA.TabIndex = 29;
            this.nNumText_RSA.Text = "n";
            this.nNumText_RSA.TextChanged += new System.EventHandler(this.nNumText_TextChanged);
            // 
            // eNumText_RSA
            // 
            this.eNumText_RSA.Location = new System.Drawing.Point(275, 70);
            this.eNumText_RSA.Name = "eNumText_RSA";
            this.eNumText_RSA.Size = new System.Drawing.Size(100, 20);
            this.eNumText_RSA.TabIndex = 30;
            this.eNumText_RSA.Text = "e";
            // 
            // checkResultText_RSA
            // 
            this.checkResultText_RSA.Location = new System.Drawing.Point(276, 230);
            this.checkResultText_RSA.Name = "checkResultText_RSA";
            this.checkResultText_RSA.Size = new System.Drawing.Size(100, 20);
            this.checkResultText_RSA.TabIndex = 31;
            this.checkResultText_RSA.Text = "Result";
            // 
            // SignRSA_btn
            // 
            this.SignRSA_btn.Location = new System.Drawing.Point(275, 185);
            this.SignRSA_btn.Name = "SignRSA_btn";
            this.SignRSA_btn.Size = new System.Drawing.Size(100, 26);
            this.SignRSA_btn.TabIndex = 32;
            this.SignRSA_btn.Text = "Sign";
            this.SignRSA_btn.UseVisualStyleBackColor = true;
            this.SignRSA_btn.Click += new System.EventHandler(this.SignRSA_btn_Click);
            // 
            // PubKeyLabel_RSA
            // 
            this.PubKeyLabel_RSA.AutoSize = true;
            this.PubKeyLabel_RSA.Location = new System.Drawing.Point(272, 31);
            this.PubKeyLabel_RSA.Name = "PubKeyLabel_RSA";
            this.PubKeyLabel_RSA.Size = new System.Drawing.Size(57, 13);
            this.PubKeyLabel_RSA.TabIndex = 34;
            this.PubKeyLabel_RSA.Text = "Public Key";
            // 
            // signLabel_RSA
            // 
            this.signLabel_RSA.AutoSize = true;
            this.signLabel_RSA.Location = new System.Drawing.Point(272, 96);
            this.signLabel_RSA.Name = "signLabel_RSA";
            this.signLabel_RSA.Size = new System.Drawing.Size(28, 13);
            this.signLabel_RSA.TabIndex = 35;
            this.signLabel_RSA.Text = "Sign";
            // 
            // msgNumLabel_RSA
            // 
            this.msgNumLabel_RSA.AutoSize = true;
            this.msgNumLabel_RSA.Location = new System.Drawing.Point(272, 142);
            this.msgNumLabel_RSA.Name = "msgNumLabel_RSA";
            this.msgNumLabel_RSA.Size = new System.Drawing.Size(50, 13);
            this.msgNumLabel_RSA.TabIndex = 36;
            this.msgNumLabel_RSA.Text = "Message";
            // 
            // msgNumText_RSA
            // 
            this.msgNumText_RSA.Location = new System.Drawing.Point(275, 158);
            this.msgNumText_RSA.Name = "msgNumText_RSA";
            this.msgNumText_RSA.Size = new System.Drawing.Size(100, 20);
            this.msgNumText_RSA.TabIndex = 37;
            this.msgNumText_RSA.Text = "m";
            // 
            // signText_RSA
            // 
            this.signText_RSA.Location = new System.Drawing.Point(275, 115);
            this.signText_RSA.Name = "signText_RSA";
            this.signText_RSA.Size = new System.Drawing.Size(100, 20);
            this.signText_RSA.TabIndex = 38;
            this.signText_RSA.Text = "sign";
            // 
            // resLabel_RSA
            // 
            this.resLabel_RSA.AutoSize = true;
            this.resLabel_RSA.Location = new System.Drawing.Point(272, 214);
            this.resLabel_RSA.Name = "resLabel_RSA";
            this.resLabel_RSA.Size = new System.Drawing.Size(66, 13);
            this.resLabel_RSA.TabIndex = 39;
            this.resLabel_RSA.Text = "Check result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "El-Gamal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "RSA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "e";
            // 
            // Crypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(400, 255);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resLabel_RSA);
            this.Controls.Add(this.signText_RSA);
            this.Controls.Add(this.msgNumText_RSA);
            this.Controls.Add(this.msgNumLabel_RSA);
            this.Controls.Add(this.signLabel_RSA);
            this.Controls.Add(this.PubKeyLabel_RSA);
            this.Controls.Add(this.SignRSA_btn);
            this.Controls.Add(this.checkResultText_RSA);
            this.Controls.Add(this.eNumText_RSA);
            this.Controls.Add(this.nNumText_RSA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bKeyLabel);
            this.Controls.Add(this.aKeyLabel);
            this.Controls.Add(this.mKeyLabel);
            this.Controls.Add(this.kKeyLabel);
            this.Controls.Add(this.xKeyLabel);
            this.Controls.Add(this.yKeyLabel);
            this.Controls.Add(this.gKeyLabel);
            this.Controls.Add(this.pKeyLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.PrKeyLabel);
            this.Controls.Add(this.PubKeyLabel);
            this.Controls.Add(this.checkResultText);
            this.Controls.Add(this.CheckSignBtn);
            this.Controls.Add(this.yKeyText);
            this.Controls.Add(this.bSignText);
            this.Controls.Add(this.aSignText);
            this.Controls.Add(this.secNumText);
            this.Controls.Add(this.primeRootText);
            this.Controls.Add(this.primeNumText);
            this.Controls.Add(this.prKeyText);
            this.Controls.Add(this.SignBtn);
            this.Controls.Add(this.messageText);
            this.Name = "Crypto";
            this.Text = "Crypto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.Button SignBtn;
        private System.Windows.Forms.TextBox prKeyText;
        private System.Windows.Forms.TextBox primeNumText;
        private System.Windows.Forms.TextBox primeRootText;
        private System.Windows.Forms.TextBox secNumText;
        private System.Windows.Forms.TextBox aSignText;
        private System.Windows.Forms.TextBox bSignText;
        private System.Windows.Forms.TextBox yKeyText;
        private System.Windows.Forms.Button CheckSignBtn;
        private System.Windows.Forms.TextBox checkResultText;
        private System.Windows.Forms.Label PubKeyLabel;
        private System.Windows.Forms.Label PrKeyLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label pKeyLabel;
        private System.Windows.Forms.Label gKeyLabel;
        private System.Windows.Forms.Label yKeyLabel;
        private System.Windows.Forms.Label xKeyLabel;
        private System.Windows.Forms.Label kKeyLabel;
        private System.Windows.Forms.Label mKeyLabel;
        private System.Windows.Forms.Label aKeyLabel;
        private System.Windows.Forms.Label bKeyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nNumText_RSA;
        private System.Windows.Forms.TextBox eNumText_RSA;
        private System.Windows.Forms.TextBox checkResultText_RSA;
        private System.Windows.Forms.Button SignRSA_btn;
        private System.Windows.Forms.Label PubKeyLabel_RSA;
        private System.Windows.Forms.Label signLabel_RSA;
        private System.Windows.Forms.Label msgNumLabel_RSA;
        private System.Windows.Forms.TextBox msgNumText_RSA;
        private System.Windows.Forms.TextBox signText_RSA;
        private System.Windows.Forms.Label resLabel_RSA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

