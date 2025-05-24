namespace Analizator_FASTA
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(154, 179);
            button1.Name = "button1";
            button1.Size = new Size(448, 34);
            button1.TabIndex = 2;
            button1.Text = "Wyświetlanie listy sekwencji z nazwami i długościami.";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(154, 244);
            button2.Name = "button2";
            button2.Size = new Size(448, 34);
            button2.TabIndex = 3;
            button2.Text = "Szczegółowe dane o wybranej sekwencji";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(154, 314);
            button3.Name = "button3";
            button3.Size = new Size(448, 34);
            button3.TabIndex = 4;
            button3.Text = "Generowanie wykresu długości sekwencji";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(154, 12);
            button4.Name = "button4";
            button4.Size = new Size(448, 81);
            button4.TabIndex = 5;
            button4.Text = "Wczytywanie jednego lub wielu plików w formacie FASTA";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Location = new Point(154, 118);
            button5.Name = "button5";
            button5.Size = new Size(448, 34);
            button5.TabIndex = 6;
            button5.Text = "Walidacja poprawności formatu FASTA";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(154, 369);
            button6.Name = "button6";
            button6.Size = new Size(181, 69);
            button6.TabIndex = 7;
            button6.Text = "Eksport wyników analizy do plika CSV";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(440, 369);
            button7.Name = "button7";
            button7.Size = new Size(162, 69);
            button7.TabIndex = 8;
            button7.Text = "Eksport wyników analizy do plika  JSON";
            button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
