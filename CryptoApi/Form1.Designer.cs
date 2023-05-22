namespace CryptoApi
{
    partial class Form1
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
            comboBox1=new ComboBox();
            textBox1=new TextBox();
            textBox2=new TextBox();
            textBox3=new TextBox();
            comboBox2=new ComboBox();
            textBox4=new TextBox();
            textBox5=new TextBox();
            comboBox3=new ComboBox();
            textBox6=new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled=true;
            comboBox1.Location=new Point(12, 81);
            comboBox1.Name="comboBox1";
            comboBox1.Size=new Size(302, 49);
            comboBox1.TabIndex=0;
            comboBox1.SelectedIndexChanged+=comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(40, 28);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(250, 47);
            textBox1.TabIndex=1;
            textBox1.Text="BINANCE";
            // 
            // textBox2
            // 
            textBox2.Location=new Point(40, 149);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(250, 47);
            textBox2.TabIndex=2;
            // 
            // textBox3
            // 
            textBox3.Location=new Point(448, 28);
            textBox3.Name="textBox3";
            textBox3.Size=new Size(250, 47);
            textBox3.TabIndex=3;
            textBox3.Text="ByBit";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled=true;
            comboBox2.Location=new Point(412, 81);
            comboBox2.Name="comboBox2";
            comboBox2.Size=new Size(302, 49);
            comboBox2.TabIndex=4;
            comboBox2.SelectedIndexChanged+=comboBox2_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location=new Point(431, 149);
            textBox4.Name="textBox4";
            textBox4.Size=new Size(250, 47);
            textBox4.TabIndex=5;
            // 
            // textBox5
            // 
            textBox5.Location=new Point(803, 28);
            textBox5.Name="textBox5";
            textBox5.Size=new Size(250, 47);
            textBox5.TabIndex=6;
            textBox5.Text="KuCoin";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled=true;
            comboBox3.Location=new Point(779, 81);
            comboBox3.Name="comboBox3";
            comboBox3.Size=new Size(302, 49);
            comboBox3.TabIndex=7;
            comboBox3.SelectedIndexChanged+=comboBox3_SelectedIndexChanged;
            // 
            // textBox6
            // 
            textBox6.Location=new Point(803, 149);
            textBox6.Name="textBox6";
            textBox6.Size=new Size(250, 47);
            textBox6.TabIndex=8;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(17F, 41F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1525, 450);
            Controls.Add(textBox6);
            Controls.Add(comboBox3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(comboBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox3;
        private TextBox textBox6;
    }
}