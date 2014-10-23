namespace lab7
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.djghjcsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ответыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.теоритическиеВопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.практическиеВопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.djghjcsToolStripMenuItem,
            this.ответыToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(284, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // djghjcsToolStripMenuItem
      // 
      this.djghjcsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.теоритическиеВопросыToolStripMenuItem,
            this.практическиеВопросыToolStripMenuItem});
      this.djghjcsToolStripMenuItem.Name = "djghjcsToolStripMenuItem";
      this.djghjcsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
      this.djghjcsToolStripMenuItem.Text = "Вопросы";
      // 
      // ответыToolStripMenuItem
      // 
      this.ответыToolStripMenuItem.Name = "ответыToolStripMenuItem";
      this.ответыToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
      this.ответыToolStripMenuItem.Text = "Ответы";
      // 
      // теоритическиеВопросыToolStripMenuItem
      // 
      this.теоритическиеВопросыToolStripMenuItem.Name = "теоритическиеВопросыToolStripMenuItem";
      this.теоритическиеВопросыToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.теоритическиеВопросыToolStripMenuItem.Text = "Теоритические вопросы";
      this.теоритическиеВопросыToolStripMenuItem.Click += new System.EventHandler(this.теоритическиеВопросыToolStripMenuItem_Click);
      // 
      // практическиеВопросыToolStripMenuItem
      // 
      this.практическиеВопросыToolStripMenuItem.Name = "практическиеВопросыToolStripMenuItem";
      this.практическиеВопросыToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.практическиеВопросыToolStripMenuItem.Text = "Практические вопросы";
      this.практическиеВопросыToolStripMenuItem.Click += new System.EventHandler(this.практическиеВопросыToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.menuStrip1);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Зачет по теоретической механике";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem djghjcsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem теоритическиеВопросыToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem практическиеВопросыToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ответыToolStripMenuItem;
  }
}

