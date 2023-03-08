using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Crypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignBtn_Click(object sender, EventArgs e)
        {
            BigInteger message = BigInteger.Parse(messageText.Text); // m
            BigInteger primeNum = BigInteger.Parse(primeNumText.Text); // p
            BigInteger privateKey = BigInteger.Parse(prKeyText.Text); // x
            BigInteger primeRoot = BigInteger.Parse(primeRootText.Text); // g
            BigInteger secretNum = BigInteger.Parse(secNumText.Text); // k

            //if (BigInteger.ModPow(primeRoot, primeNum - 1, primeNum) == 1 && primeRoot < primeNum) {
            //    MessageBox.Show("g - не является примитивным корнем p",
            //        "Ошибка в данных", MessageBoxButtons.OK);
            //}
            if (BigInteger.GreatestCommonDivisor(primeNum - 1, secretNum) != 1) {
                MessageBox.Show("k не взаимное простое с p",
                   "Ошибка в данных", MessageBoxButtons.OK);
            }
            else
            {
                BigInteger yKey = BigInteger.ModPow(primeRoot, privateKey, primeNum); //  y
                yKeyText.Text = yKey.ToString();

                BigInteger aSign = BigInteger.ModPow(primeRoot, secretNum, primeNum); // a
                aSignText.Text = aSign.ToString();

                BigInteger bSign = 0;

                while (message != BigInteger.Add(BigInteger.Multiply(privateKey, aSign), BigInteger.Multiply(secretNum, bSign)) % (primeNum - 1))
                {
                    bSign += 1;
                }
                bSignText.Text = bSign.ToString();
            }
        }

        private void CheckSignBtn_Click(object sender, EventArgs e)
        {
            BigInteger message = BigInteger.Parse(messageText.Text); // message
            BigInteger primeNum = BigInteger.Parse(primeNumText.Text); // p
            BigInteger primeRoot = BigInteger.Parse(primeRootText.Text); // g
            BigInteger yKey = BigInteger.Parse(yKeyText.Text); // 
            BigInteger aSign = BigInteger.Parse(aSignText.Text);
            BigInteger bSign = BigInteger.Parse(bSignText.Text);

            BigInteger leftPart = BigInteger.Multiply(BigInteger.ModPow(yKey, aSign, primeNum), BigInteger.ModPow(aSign, bSign, primeNum));
            BigInteger rightPart = BigInteger.ModPow(primeRoot, message, primeNum);
            bool checkResult = leftPart.Equals(rightPart);

            checkResultText.Text = checkResult.ToString();

        }
    }
}
