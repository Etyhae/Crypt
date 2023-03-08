
namespace Crypt
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
            this.SuspendLayout();
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(118, 25);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(100, 20);
            this.messageText.TabIndex = 0;
            this.messageText.Text = "m";
            // 
            // SignBtn
            // 
            this.SignBtn.Location = new System.Drawing.Point(15, 172);
            this.SignBtn.Name = "SignBtn";
            this.SignBtn.Size = new System.Drawing.Size(79, 27);
            this.SignBtn.TabIndex = 1;
            this.SignBtn.Text = "SignMsg";
            this.SignBtn.UseVisualStyleBackColor = true;
            this.SignBtn.Click += new System.EventHandler(this.SignBtn_Click);
            // 
            // prKeyText
            // 
            this.prKeyText.Location = new System.Drawing.Point(12, 120);
            this.prKeyText.Name = "prKeyText";
            this.prKeyText.Size = new System.Drawing.Size(100, 20);
            this.prKeyText.TabIndex = 2;
            this.prKeyText.Text = "x";
            // 
            // primeNumText
            // 
            this.primeNumText.Location = new System.Drawing.Point(12, 25);
            this.primeNumText.Name = "primeNumText";
            this.primeNumText.Size = new System.Drawing.Size(100, 20);
            this.primeNumText.TabIndex = 3;
            this.primeNumText.Text = "p";
            // 
            // primeRootText
            // 
            this.primeRootText.Location = new System.Drawing.Point(12, 51);
            this.primeRootText.Name = "primeRootText";
            this.primeRootText.Size = new System.Drawing.Size(100, 20);
            this.primeRootText.TabIndex = 4;
            this.primeRootText.Text = "g";
            // 
            // secNumText
            // 
            this.secNumText.Location = new System.Drawing.Point(12, 146);
            this.secNumText.Name = "secNumText";
            this.secNumText.Size = new System.Drawing.Size(100, 20);
            this.secNumText.TabIndex = 5;
            this.secNumText.Text = "k";
            // 
            // aSignText
            // 
            this.aSignText.Location = new System.Drawing.Point(118, 77);
            this.aSignText.Name = "aSignText";
            this.aSignText.Size = new System.Drawing.Size(100, 20);
            this.aSignText.TabIndex = 6;
            this.aSignText.Text = "a";
            // 
            // bSignText
            // 
            this.bSignText.Location = new System.Drawing.Point(118, 103);
            this.bSignText.Name = "bSignText";
            this.bSignText.Size = new System.Drawing.Size(100, 20);
            this.bSignText.TabIndex = 7;
            this.bSignText.Text = "b";
            // 
            // yKeyText
            // 
            this.yKeyText.Location = new System.Drawing.Point(12, 77);
            this.yKeyText.Name = "yKeyText";
            this.yKeyText.Size = new System.Drawing.Size(100, 20);
            this.yKeyText.TabIndex = 8;
            this.yKeyText.Text = "y";
            // 
            // CheckSignBtn
            // 
            this.CheckSignBtn.Location = new System.Drawing.Point(121, 129);
            this.CheckSignBtn.Name = "CheckSignBtn";
            this.CheckSignBtn.Size = new System.Drawing.Size(79, 27);
            this.CheckSignBtn.TabIndex = 9;
            this.CheckSignBtn.Text = "CheckSign";
            this.CheckSignBtn.UseVisualStyleBackColor = true;
            this.CheckSignBtn.Click += new System.EventHandler(this.CheckSignBtn_Click);
            // 
            // checkResultText
            // 
            this.checkResultText.Location = new System.Drawing.Point(118, 162);
            this.checkResultText.Name = "checkResultText";
            this.checkResultText.Size = new System.Drawing.Size(100, 20);
            this.checkResultText.TabIndex = 10;
            this.checkResultText.Text = "Result";
            // 
            // PubKeyLabel
            // 
            this.PubKeyLabel.AutoSize = true;
            this.PubKeyLabel.Location = new System.Drawing.Point(12, 9);
            this.PubKeyLabel.Name = "PubKeyLabel";
            this.PubKeyLabel.Size = new System.Drawing.Size(57, 13);
            this.PubKeyLabel.TabIndex = 14;
            this.PubKeyLabel.Text = "Public Key";
            // 
            // PrKeyLabel
            // 
            this.PrKeyLabel.AutoSize = true;
            this.PrKeyLabel.Location = new System.Drawing.Point(12, 104);
            this.PrKeyLabel.Name = "PrKeyLabel";
            this.PrKeyLabel.Size = new System.Drawing.Size(61, 13);
            this.PrKeyLabel.TabIndex = 15;
            this.PrKeyLabel.Text = "Private Key";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(118, 9);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(50, 13);
            this.messageLabel.TabIndex = 16;
            this.messageLabel.Text = "Message";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(148, 61);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(28, 13);
            this.outputLabel.TabIndex = 17;
            this.outputLabel.Text = "Sign";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 209);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

