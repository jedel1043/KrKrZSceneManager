namespace ScnEditorGUI
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huffmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompressImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompressScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tryRecoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tJS2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClipboardSeekSample = new System.Windows.Forms.ToolStripMenuItem();
            this.SeekUpdate = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decompressImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compressScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tryRecoveryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tJS2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.seekClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.openFileToolStripMenuItem, this.saveFileToolStripMenuItem, this.huffmanToolStripMenuItem,
                this.tryRecoveryToolStripMenuItem, this.tJS2ToolStripMenuItem, this.ClipboardSeekSample
            });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 136);
            this.contextMenuStrip1.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // huffmanToolStripMenuItem
            // 
            this.huffmanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.decompressImageToolStripMenuItem, this.compressImageToolStripMenuItem,
                this.decompressScriptToolStripMenuItem
            });
            this.huffmanToolStripMenuItem.Name = "huffmanToolStripMenuItem";
            this.huffmanToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.huffmanToolStripMenuItem.Text = "Compress";
            // 
            // decompressImageToolStripMenuItem
            // 
            this.decompressImageToolStripMenuItem.Name = "decompressImageToolStripMenuItem";
            this.decompressImageToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.decompressImageToolStripMenuItem.Text = "Decompress Image";
            this.decompressImageToolStripMenuItem.Click +=
                new System.EventHandler(this.decompressImageToolStripMenuItem_Click);
            // 
            // compressImageToolStripMenuItem
            // 
            this.compressImageToolStripMenuItem.Name = "compressImageToolStripMenuItem";
            this.compressImageToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.compressImageToolStripMenuItem.Text = "Compress Image";
            this.compressImageToolStripMenuItem.Click +=
                new System.EventHandler(this.compressImageToolStripMenuItem_Click);
            // 
            // decompressScriptToolStripMenuItem
            // 
            this.decompressScriptToolStripMenuItem.Name = "decompressScriptToolStripMenuItem";
            this.decompressScriptToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.decompressScriptToolStripMenuItem.Text = "Decompress Script";
            this.decompressScriptToolStripMenuItem.Click +=
                new System.EventHandler(this.decompressScriptToolStripMenuItem_Click);
            // 
            // tryRecoveryToolStripMenuItem
            // 
            this.tryRecoveryToolStripMenuItem.Name = "tryRecoveryToolStripMenuItem";
            this.tryRecoveryToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tryRecoveryToolStripMenuItem.Text = "Try Recovery";
            this.tryRecoveryToolStripMenuItem.Click += new System.EventHandler(this.tryRecoveryToolStripMenuItem_Click);
            // 
            // tJS2ToolStripMenuItem
            // 
            this.tJS2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.openToolStripMenuItem, this.saveToolStripMenuItem});
            this.tJS2ToolStripMenuItem.Name = "tJS2ToolStripMenuItem";
            this.tJS2ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tJS2ToolStripMenuItem.Text = "TJS2";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // ClipboardSeekSample
            // 
            this.ClipboardSeekSample.Checked = true;
            this.ClipboardSeekSample.CheckOnClick = true;
            this.ClipboardSeekSample.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ClipboardSeekSample.Name = "ClipboardSeekSample";
            this.ClipboardSeekSample.Size = new System.Drawing.Size(153, 22);
            this.ClipboardSeekSample.Text = "Seek Clipboard";
            this.ClipboardSeekSample.Click += new System.EventHandler(this.ClipboardSeekSample_Click);
            // 
            // SeekUpdate
            // 
            this.SeekUpdate.Enabled = true;
            this.SeekUpdate.Interval = 500;
            this.SeekUpdate.Tick += new System.EventHandler(this.SeekUpdate_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.openToolStripMenuItem1, this.saveToolStripMenuItem1, this.compressToolStripMenuItem,
                this.tryRecoveryToolStripMenuItem1, this.tJS2ToolStripMenuItem1, this.seekClipboardToolStripMenuItem
            });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // compressToolStripMenuItem
            // 
            this.compressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.compressImageToolStripMenuItem1, this.decompressImageToolStripMenuItem1,
                this.compressScriptToolStripMenuItem
            });
            this.compressToolStripMenuItem.Name = "compressToolStripMenuItem";
            this.compressToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.compressToolStripMenuItem.Text = "Compress";
            // 
            // compressImageToolStripMenuItem1
            // 
            this.compressImageToolStripMenuItem1.Name = "compressImageToolStripMenuItem1";
            this.compressImageToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.compressImageToolStripMenuItem1.Text = "Compress Image";
            this.compressImageToolStripMenuItem1.Click +=
                new System.EventHandler(this.compressImageToolStripMenuItem_Click);
            // 
            // decompressImageToolStripMenuItem1
            // 
            this.decompressImageToolStripMenuItem1.Name = "decompressImageToolStripMenuItem1";
            this.decompressImageToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.decompressImageToolStripMenuItem1.Text = "Decompress Image";
            this.decompressImageToolStripMenuItem1.Click +=
                new System.EventHandler(this.decompressImageToolStripMenuItem_Click);
            // 
            // compressScriptToolStripMenuItem
            // 
            this.compressScriptToolStripMenuItem.Name = "compressScriptToolStripMenuItem";
            this.compressScriptToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.compressScriptToolStripMenuItem.Text = "Decompress Script";
            this.compressScriptToolStripMenuItem.Click +=
                new System.EventHandler(this.decompressScriptToolStripMenuItem_Click);
            // 
            // tryRecoveryToolStripMenuItem1
            // 
            this.tryRecoveryToolStripMenuItem1.Name = "tryRecoveryToolStripMenuItem1";
            this.tryRecoveryToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.tryRecoveryToolStripMenuItem1.Text = "Try Recovery";
            this.tryRecoveryToolStripMenuItem1.Click +=
                new System.EventHandler(this.tryRecoveryToolStripMenuItem_Click);
            // 
            // tJS2ToolStripMenuItem1
            // 
            this.tJS2ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.openToolStripMenuItem2, this.saveToolStripMenuItem2});
            this.tJS2ToolStripMenuItem1.Name = "tJS2ToolStripMenuItem1";
            this.tJS2ToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.tJS2ToolStripMenuItem1.Text = "TJS2";
            // 
            // openToolStripMenuItem2
            // 
            this.openToolStripMenuItem2.Name = "openToolStripMenuItem2";
            this.openToolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem2.Text = "Open";
            this.openToolStripMenuItem2.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem2
            // 
            this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            this.saveToolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem2.Text = "Save";
            this.saveToolStripMenuItem2.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // seekClipboardToolStripMenuItem
            // 
            this.seekClipboardToolStripMenuItem.Name = "seekClipboardToolStripMenuItem";
            this.seekClipboardToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.seekClipboardToolStripMenuItem.Text = "Seek Clipboard";
            this.seekClipboardToolStripMenuItem.Click += new System.EventHandler(this.SeekUpdate_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(3, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(462, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(462, 393);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 29);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox2);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.splitContainer1.Size = new System.Drawing.Size(733, 447);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.IntegralHeight = false;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(10, 10);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(222, 427);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.59223F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.407767F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 427);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 481);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(759, 520);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Text = "Scn Editor";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huffmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decompressImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tryRecoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tJS2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClipboardSeekSample;
        private System.Windows.Forms.Timer SeekUpdate;
        private System.Windows.Forms.ToolStripMenuItem decompressScriptToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tryRecoveryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seekClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tJS2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compressScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decompressImageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compressImageToolStripMenuItem1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

