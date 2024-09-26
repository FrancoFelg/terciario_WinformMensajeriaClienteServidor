namespace App1MensajeriaCliente
{
    partial class ClienteChatForm
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
            entradaTextBox = new System.Windows.Forms.TextBox();
            mostrarTextBox = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // entradaTextBox
            // 
            entradaTextBox.Location = new System.Drawing.Point(16, 19);
            entradaTextBox.Name = "entradaTextBox";
            entradaTextBox.Size = new System.Drawing.Size(772, 23);
            entradaTextBox.TabIndex = 0;
            entradaTextBox.KeyDown += entradaTextBox_KeyDown;
            // 
            // mostrarTextBox
            // 
            mostrarTextBox.Location = new System.Drawing.Point(16, 48);
            mostrarTextBox.Multiline = true;
            mostrarTextBox.Name = "mostrarTextBox";
            mostrarTextBox.Size = new System.Drawing.Size(772, 339);
            mostrarTextBox.TabIndex = 1;
            // 
            // ClienteChatForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(mostrarTextBox);
            Controls.Add(entradaTextBox);
            Name = "ClienteChatForm";
            Text = "Cliente";
            Load += ClienteChatForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox entradaTextBox;
        private System.Windows.Forms.TextBox mostrarTextBox;
    }
}
