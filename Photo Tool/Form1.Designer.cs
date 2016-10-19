namespace Photo_Tool
{
    partial class Form1
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.pbxphoto = new System.Windows.Forms.PictureBox();
            this.ctxMenuPhoto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageScale = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageStretch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageActual = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchToFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxphoto)).BeginInit();
            this.ctxMenuPhoto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 38);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pbxphoto
            // 
            this.pbxphoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxphoto.ContextMenuStrip = this.ctxMenuPhoto;
            this.pbxphoto.Location = new System.Drawing.Point(12, 77);
            this.pbxphoto.Name = "pbxphoto";
            this.pbxphoto.Size = new System.Drawing.Size(461, 332);
            this.pbxphoto.TabIndex = 1;
            this.pbxphoto.TabStop = false;
            this.pbxphoto.Click += new System.EventHandler(this.pbxphoto_Click);
            // 
            // ctxMenuPhoto
            // 
            this.ctxMenuPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImage});
            this.ctxMenuPhoto.Name = "ctxMenuPhoto";
            this.ctxMenuPhoto.Size = new System.Drawing.Size(108, 26);
            this.ctxMenuPhoto.Text = "menuImage";
            this.ctxMenuPhoto.Opening += new System.ComponentModel.CancelEventHandler(this.ctxMenuPhoto_Opening);
            // 
            // menuImage
            // 
            this.menuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImageScale,
            this.menuImageStretch,
            this.menuImageActual});
            this.menuImage.Name = "menuImage";
            this.menuImage.Size = new System.Drawing.Size(107, 22);
            this.menuImage.Text = "&Image";
            this.menuImage.DropDownOpening += new System.EventHandler(this.menuImage_DropDownOpening);
            this.menuImage.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuImage_DropDownItemClicked);
            // 
            // menuImageScale
            // 
            this.menuImageScale.Checked = true;
            this.menuImageScale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuImageScale.Name = "menuImageScale";
            this.menuImageScale.Size = new System.Drawing.Size(152, 22);
            this.menuImageScale.Tag = "Zoom";
            this.menuImageScale.Text = "&Scale to Fit";
            this.menuImageScale.Click += new System.EventHandler(this.menuImageScale_Click);
            // 
            // menuImageStretch
            // 
            this.menuImageStretch.Name = "menuImageStretch";
            this.menuImageStretch.Size = new System.Drawing.Size(141, 22);
            this.menuImageStretch.Tag = "StretchImage";
            this.menuImageStretch.Text = "&Stretch to Fit";
            // 
            // menuImageActual
            // 
            this.menuImageActual.Name = "menuImageActual";
            this.menuImageActual.Size = new System.Drawing.Size(141, 22);
            this.menuImageActual.Tag = "Normal";
            this.menuImageActual.Text = "&Actual Size";
            // 
            // menuView
            // 
            this.menuView.DropDown = this.ctxMenuPhoto;
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "&View";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.menuView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileLoad,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileLoad
            // 
            this.mnuFileLoad.Name = "mnuFileLoad";
            this.mnuFileLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuFileLoad.Size = new System.Drawing.Size(140, 22);
            this.mnuFileLoad.Text = "Load";
            this.mnuFileLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(140, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // scaleToFitToolStripMenuItem
            // 
            this.scaleToFitToolStripMenuItem.Name = "scaleToFitToolStripMenuItem";
            this.scaleToFitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scaleToFitToolStripMenuItem.Text = "Scale to Fit";
            // 
            // stretchToFitToolStripMenuItem
            // 
            this.stretchToFitToolStripMenuItem.Name = "stretchToFitToolStripMenuItem";
            this.stretchToFitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stretchToFitToolStripMenuItem.Text = "Stretch to Fit";
            // 
            // actualSizeToolStripMenuItem
            // 
            this.actualSizeToolStripMenuItem.Name = "actualSizeToolStripMenuItem";
            this.actualSizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.actualSizeToolStripMenuItem.Text = "Actual Size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 421);
            this.Controls.Add(this.pbxphoto);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxphoto)).EndInit();
            this.ctxMenuPhoto.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pbxphoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ContextMenuStrip ctxMenuPhoto;
        private System.Windows.Forms.ToolStripMenuItem menuImage;
        private System.Windows.Forms.ToolStripMenuItem menuImageScale;
        private System.Windows.Forms.ToolStripMenuItem menuImageStretch;
        private System.Windows.Forms.ToolStripMenuItem menuImageActual;
        private System.Windows.Forms.ToolStripMenuItem scaleToFitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchToFitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuView;
    }
}

