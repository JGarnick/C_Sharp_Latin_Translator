using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latin_Translator
{
    public partial class latinTranslatorForm : Form
    {
        public latinTranslatorForm()
        {
            InitializeComponent();
        }

        private void translateSinisterButton_Click(object sender, EventArgs e)
        {
            translateSinisterLabel.Text = "left";
            translateDexterLabel.Text = "";
            translateMediumLabel.Text = "";
        }

        private void translateDexterButton_Click(object sender, EventArgs e)
        {
            translateSinisterLabel.Text = "";
            translateDexterLabel.Text = "right";
            translateMediumLabel.Text = "";
        }

        private void translateMediumButton_Click(object sender, EventArgs e)
        {
            translateSinisterLabel.Text = "";
            translateDexterLabel.Text = "";
            translateMediumLabel.Text = "center";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
