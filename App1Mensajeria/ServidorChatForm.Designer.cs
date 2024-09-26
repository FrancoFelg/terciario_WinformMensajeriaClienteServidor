using System;

namespace App1Mensajeria
{
    partial class ServidorChatForm
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
            entradaTextbox = new System.Windows.Forms.TextBox();
            mostrarTextBox = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // entradaTextbox
            // 
            entradaTextbox.Location = new System.Drawing.Point(12, 12);
            entradaTextbox.Name = "entradaTextbox";
            entradaTextbox.Size = new System.Drawing.Size(776, 23);
            entradaTextbox.TabIndex = 0;
            entradaTextbox.KeyDown += entradaTextbox_KeyDown;

            // 
            // mostrarTextBox
            // 
            mostrarTextBox.Location = new System.Drawing.Point(12, 50);
            mostrarTextBox.Multiline = true;
            mostrarTextBox.Name = "mostrarTextBox";
            mostrarTextBox.Size = new System.Drawing.Size(776, 342);
            mostrarTextBox.TabIndex = 1;
            // 
            // ServidorChatForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(mostrarTextBox);
            Controls.Add(entradaTextbox);
            Name = "ServidorChatForm";
            Text = "Servidor";
            Load += ServidorChatForm_load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.TextBox entradaTextbox;
        private System.Windows.Forms.TextBox mostrarTextBox;
    }
}
