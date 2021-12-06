
namespace TcpServerr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)

        {

            if (disposing)

            {

                if (components != null)

                {

                    components.Dispose();

                }

            }

            base.Dispose(disposing);

        }



        #region Windows Form Designer generated code

        /// <summary>

        /// Required method for Designer support - do not modify

        /// the contents of this method with the code editor.

        /// </summary>

        private void InitializeComponent()

        {

            this.Exibe = new System.Windows.Forms.TextBox();

            this.Envia = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            this.Exibe.Location = new System.Drawing.Point(8, 40);

            this.Exibe.Multiline = true;

            this.Exibe.Name = "Exibe";

            this.Exibe.Size = new System.Drawing.Size(299, 238);

            this.Exibe.TabIndex = 1;

            this.Envia.Location = new System.Drawing.Point(8, 8);

            this.Envia.Name = "Envia";

            this.Envia.Size = new System.Drawing.Size(272, 20);

            this.Envia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Envia_KeyDown);

            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);

            this.ClientSize = new System.Drawing.Size(299, 278);

            this.Controls.Add(this.Exibe);

            this.Controls.Add(this.Envia);

            this.Name = "Server";

            this.Text = "Servidor";

            this.Closing += new System.ComponentModel.CancelEventHandler(this.Server_Closing);

            this.Load += new System.EventHandler(this.Server_Load);

            this.ResumeLayout(false);

            this.PerformLayout();


        }

        #endregion
    }
}

