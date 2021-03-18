
namespace EXTUBE.Forms
{
    partial class MainMenuForm
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
            this.URL_Label = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btn_button = new System.Windows.Forms.Button();
            this.TextBoxUrlPath = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // URL_Label
            // 
            this.URL_Label.AutoScrollMinSize = new System.Drawing.Size(32, 22);
            this.URL_Label.AutoSize = false;
            this.URL_Label.BackColor = System.Drawing.SystemColors.Window;
            this.URL_Label.Location = new System.Drawing.Point(23, 66);
            this.URL_Label.Name = "URL_Label";
            this.URL_Label.Size = new System.Drawing.Size(60, 17);
            this.URL_Label.TabIndex = 1;
            this.URL_Label.Text = "URL";
            // 
            // btn_button
            // 
            this.btn_button.Location = new System.Drawing.Point(23, 115);
            this.btn_button.Name = "btn_button";
            this.btn_button.Size = new System.Drawing.Size(75, 23);
            this.btn_button.TabIndex = 2;
            this.btn_button.Text = "ダウンロード";
            this.btn_button.UseVisualStyleBackColor = true;
            this.btn_button.Click += new System.EventHandler(this.btn_button_Click);
            // 
            // TextBoxUrlPath
            // 
            // 
            // 
            // 
            this.TextBoxUrlPath.CustomButton.Image = null;
            this.TextBoxUrlPath.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.TextBoxUrlPath.CustomButton.Name = "";
            this.TextBoxUrlPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxUrlPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxUrlPath.CustomButton.TabIndex = 1;
            this.TextBoxUrlPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxUrlPath.CustomButton.UseSelectable = true;
            this.TextBoxUrlPath.CustomButton.Visible = false;
            this.TextBoxUrlPath.Lines = new string[0];
            this.TextBoxUrlPath.Location = new System.Drawing.Point(23, 83);
            this.TextBoxUrlPath.MaxLength = 32767;
            this.TextBoxUrlPath.Name = "TextBoxUrlPath";
            this.TextBoxUrlPath.PasswordChar = '\0';
            this.TextBoxUrlPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxUrlPath.SelectedText = "";
            this.TextBoxUrlPath.SelectionLength = 0;
            this.TextBoxUrlPath.SelectionStart = 0;
            this.TextBoxUrlPath.ShortcutsEnabled = true;
            this.TextBoxUrlPath.Size = new System.Drawing.Size(333, 23);
            this.TextBoxUrlPath.TabIndex = 3;
            this.TextBoxUrlPath.UseSelectable = true;
            this.TextBoxUrlPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxUrlPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxUrlPath);
            this.Controls.Add(this.btn_button);
            this.Controls.Add(this.URL_Label);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Drawing.Html.HtmlLabel URL_Label;
        private System.Windows.Forms.Button btn_button;
        private MetroFramework.Controls.MetroTextBox TextBoxUrlPath;
    }
}