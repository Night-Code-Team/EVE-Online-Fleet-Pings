namespace EVE_Online_Fleet_Pings
{
    partial class LogoSelection
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogoSelection));
            this.Cancel = new System.Windows.Forms.Button();
            this.AddNewLogo = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.LogosList = new System.Windows.Forms.ListView();
            this.Logos = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(16, 388);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(201, 34);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddNewLogo
            // 
            this.AddNewLogo.Location = new System.Drawing.Point(300, 388);
            this.AddNewLogo.Name = "AddNewLogo";
            this.AddNewLogo.Size = new System.Drawing.Size(201, 34);
            this.AddNewLogo.TabIndex = 1;
            this.AddNewLogo.Text = "Add New Logo";
            this.AddNewLogo.UseVisualStyleBackColor = true;
            this.AddNewLogo.Click += new System.EventHandler(this.AddNewLogo_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(587, 388);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(201, 34);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // LogosList
            // 
            this.LogosList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LogosList.Location = new System.Drawing.Point(16, 12);
            this.LogosList.Name = "LogosList";
            this.LogosList.Size = new System.Drawing.Size(772, 370);
            this.LogosList.TabIndex = 2;
            this.LogosList.UseCompatibleStateImageBehavior = false;
            // 
            // Logos
            // 
            this.Logos.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Logos.ImageSize = new System.Drawing.Size(16, 16);
            this.Logos.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LogoSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.LogosList);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.AddNewLogo);
            this.Controls.Add(this.Cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogoSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Logo Selection";
            this.ResumeLayout(false);

        }

        #endregion
        private Button Cancel;
        private Button AddNewLogo;
        private Button Submit;
        private ListView LogosList;
        private ImageList Logos;
    }
}