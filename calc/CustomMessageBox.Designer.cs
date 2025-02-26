namespace calc
{
    partial class CustomMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelMessage = new Label();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // labelMessage
            // 
            labelMessage.Dock = DockStyle.Fill;
            labelMessage.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMessage.Location = new Point(0, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(389, 145);
            labelMessage.TabIndex = 0;
            labelMessage.Text = "TEST";
            // 
            // buttonOK
            // 
            buttonOK.Dock = DockStyle.Bottom;
            buttonOK.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.Location = new Point(0, 97);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(389, 48);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "ЛАДНО";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 145);
            Controls.Add(buttonOK);
            Controls.Add(labelMessage);
            Name = "CustomMessageBox";
            Text = "CustomMessageBox";
            ResumeLayout(false);
        }

        #endregion

        private Label labelMessage;
        private Button buttonOK;
    }
}