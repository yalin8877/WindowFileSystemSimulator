namespace FileSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PathNow = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.file1 = new System.Windows.Forms.Button();
            this.file6 = new System.Windows.Forms.Button();
            this.file5 = new System.Windows.Forms.Button();
            this.file4 = new System.Windows.Forms.Button();
            this.file3 = new System.Windows.Forms.Button();
            this.file2 = new System.Windows.Forms.Button();
            this.file8 = new System.Windows.Forms.Button();
            this.file9 = new System.Windows.Forms.Button();
            this.file10 = new System.Windows.Forms.Button();
            this.file11 = new System.Windows.Forms.Button();
            this.file12 = new System.Windows.Forms.Button();
            this.file7 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "当前路径";
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.richTextBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(6, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(529, 354);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建文件ToolStripMenuItem,
            this.新建文件夹ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // 新建文件ToolStripMenuItem
            // 
            this.新建文件ToolStripMenuItem.Name = "新建文件ToolStripMenuItem";
            this.新建文件ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.新建文件ToolStripMenuItem.Text = "新建文件";
            this.新建文件ToolStripMenuItem.Click += new System.EventHandler(this.新建文件ToolStripMenuItem_Click);
            // 
            // 新建文件夹ToolStripMenuItem
            // 
            this.新建文件夹ToolStripMenuItem.Name = "新建文件夹ToolStripMenuItem";
            this.新建文件夹ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.新建文件夹ToolStripMenuItem.Text = "新建文件夹";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.重命名ToolStripMenuItem,
            this.属性ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(113, 92);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.重命名ToolStripMenuItem.Text = "重命名";
            // 
            // 属性ToolStripMenuItem
            // 
            this.属性ToolStripMenuItem.Name = "属性ToolStripMenuItem";
            this.属性ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.属性ToolStripMenuItem.Text = "属性";
            // 
            // PathNow
            // 
            this.PathNow.Location = new System.Drawing.Point(77, 52);
            this.PathNow.Name = "PathNow";
            this.PathNow.ReadOnly = true;
            this.PathNow.Size = new System.Drawing.Size(458, 21);
            this.PathNow.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "新建文件系统";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "打开文件系统";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 35);
            this.button3.TabIndex = 15;
            this.button3.Text = "保存文件系统";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(149, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 35);
            this.button4.TabIndex = 16;
            this.button4.Text = "格式化";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 116);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件系统操作";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Location = new System.Drawing.Point(7, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 389);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件目录结构";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.treeView1.Location = new System.Drawing.Point(8, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(234, 354);
            this.treeView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button29);
            this.groupBox3.Controls.Add(this.button30);
            this.groupBox3.Controls.Add(this.button31);
            this.groupBox3.Controls.Add(this.button32);
            this.groupBox3.Controls.Add(this.button33);
            this.groupBox3.Controls.Add(this.button34);
            this.groupBox3.Controls.Add(this.button17);
            this.groupBox3.Controls.Add(this.button18);
            this.groupBox3.Controls.Add(this.button19);
            this.groupBox3.Controls.Add(this.button20);
            this.groupBox3.Controls.Add(this.button21);
            this.groupBox3.Controls.Add(this.button22);
            this.groupBox3.Controls.Add(this.button23);
            this.groupBox3.Controls.Add(this.button24);
            this.groupBox3.Controls.Add(this.button25);
            this.groupBox3.Controls.Add(this.button26);
            this.groupBox3.Controls.Add(this.button27);
            this.groupBox3.Controls.Add(this.button28);
            this.groupBox3.Controls.Add(this.file8);
            this.groupBox3.Controls.Add(this.file9);
            this.groupBox3.Controls.Add(this.file10);
            this.groupBox3.Controls.Add(this.file11);
            this.groupBox3.Controls.Add(this.file12);
            this.groupBox3.Controls.Add(this.file7);
            this.groupBox3.Controls.Add(this.file2);
            this.groupBox3.Controls.Add(this.file3);
            this.groupBox3.Controls.Add(this.file4);
            this.groupBox3.Controls.Add(this.file5);
            this.groupBox3.Controls.Add(this.file6);
            this.groupBox3.Controls.Add(this.file1);
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(263, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 389);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "可视化文件系统（可在面板和文件上单击右键选择操作）";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PathNow);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(263, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(541, 116);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "当前路径";
            // 
            // file1
            // 
            this.file1.BackColor = System.Drawing.Color.Transparent;
            this.file1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.file1.ContextMenuStrip = this.contextMenuStrip2;
            this.file1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file1.Image = ((System.Drawing.Image)(resources.GetObject("file1.Image")));
            this.file1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.file1.Location = new System.Drawing.Point(30, 40);
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(75, 62);
            this.file1.TabIndex = 10;
            this.file1.UseVisualStyleBackColor = false;
            this.file1.Visible = false;
            // 
            // file6
            // 
            this.file6.BackColor = System.Drawing.Color.Transparent;
            this.file6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.file6.ContextMenuStrip = this.contextMenuStrip2;
            this.file6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file6.Image = ((System.Drawing.Image)(resources.GetObject("file6.Image")));
            this.file6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.file6.Location = new System.Drawing.Point(435, 40);
            this.file6.Name = "file6";
            this.file6.Size = new System.Drawing.Size(75, 62);
            this.file6.TabIndex = 13;
            this.file6.UseVisualStyleBackColor = false;
            this.file6.Visible = false;
            // 
            // file5
            // 
            this.file5.BackColor = System.Drawing.Color.Transparent;
            this.file5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.file5.ContextMenuStrip = this.contextMenuStrip2;
            this.file5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file5.Image = ((System.Drawing.Image)(resources.GetObject("file5.Image")));
            this.file5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.file5.Location = new System.Drawing.Point(354, 40);
            this.file5.Name = "file5";
            this.file5.Size = new System.Drawing.Size(75, 62);
            this.file5.TabIndex = 14;
            this.file5.UseVisualStyleBackColor = false;
            this.file5.Visible = false;
            // 
            // file4
            // 
            this.file4.BackColor = System.Drawing.Color.Transparent;
            this.file4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.file4.ContextMenuStrip = this.contextMenuStrip2;
            this.file4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file4.Image = ((System.Drawing.Image)(resources.GetObject("file4.Image")));
            this.file4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.file4.Location = new System.Drawing.Point(273, 40);
            this.file4.Name = "file4";
            this.file4.Size = new System.Drawing.Size(75, 62);
            this.file4.TabIndex = 15;
            this.file4.UseVisualStyleBackColor = false;
            this.file4.Visible = false;
            // 
            // file3
            // 
            this.file3.BackColor = System.Drawing.Color.Transparent;
            this.file3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.file3.ContextMenuStrip = this.contextMenuStrip2;
            this.file3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file3.Image = ((System.Drawing.Image)(resources.GetObject("file3.Image")));
            this.file3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.file3.Location = new System.Drawing.Point(192, 40);
            this.file3.Name = "file3";
            this.file3.Size = new System.Drawing.Size(75, 62);
            this.file3.TabIndex = 16;
            this.file3.UseVisualStyleBackColor = false;
            this.file3.Visible = false;
            // 
            // file2
            // 
            this.file2.BackColor = System.Drawing.Color.Transparent;
            this.file2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.file2.ContextMenuStrip = this.contextMenuStrip2;
            this.file2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file2.Image = ((System.Drawing.Image)(resources.GetObject("file2.Image")));
            this.file2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.file2.Location = new System.Drawing.Point(111, 40);
            this.file2.Name = "file2";
            this.file2.Size = new System.Drawing.Size(75, 62);
            this.file2.TabIndex = 17;
            this.file2.UseVisualStyleBackColor = false;
            this.file2.Visible = false;
            // 
            // file8
            // 
            this.file8.BackColor = System.Drawing.Color.Transparent;
            this.file8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.file8.ContextMenuStrip = this.contextMenuStrip2;
            this.file8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file8.Image = ((System.Drawing.Image)(resources.GetObject("file8.Image")));
            this.file8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.file8.Location = new System.Drawing.Point(111, 110);
            this.file8.Name = "file8";
            this.file8.Size = new System.Drawing.Size(75, 62);
            this.file8.TabIndex = 23;
            this.file8.UseVisualStyleBackColor = false;
            this.file8.Visible = false;
            // 
            // file9
            // 
            this.file9.BackColor = System.Drawing.Color.Transparent;
            this.file9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.file9.ContextMenuStrip = this.contextMenuStrip2;
            this.file9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file9.Image = ((System.Drawing.Image)(resources.GetObject("file9.Image")));
            this.file9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.file9.Location = new System.Drawing.Point(192, 110);
            this.file9.Name = "file9";
            this.file9.Size = new System.Drawing.Size(75, 62);
            this.file9.TabIndex = 22;
            this.file9.UseVisualStyleBackColor = false;
            this.file9.Visible = false;
            // 
            // file10
            // 
            this.file10.BackColor = System.Drawing.Color.Transparent;
            this.file10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.file10.ContextMenuStrip = this.contextMenuStrip2;
            this.file10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file10.Image = ((System.Drawing.Image)(resources.GetObject("file10.Image")));
            this.file10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.file10.Location = new System.Drawing.Point(273, 110);
            this.file10.Name = "file10";
            this.file10.Size = new System.Drawing.Size(75, 62);
            this.file10.TabIndex = 21;
            this.file10.UseVisualStyleBackColor = false;
            this.file10.Visible = false;
            // 
            // file11
            // 
            this.file11.BackColor = System.Drawing.Color.Transparent;
            this.file11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.file11.ContextMenuStrip = this.contextMenuStrip2;
            this.file11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file11.Image = ((System.Drawing.Image)(resources.GetObject("file11.Image")));
            this.file11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.file11.Location = new System.Drawing.Point(354, 110);
            this.file11.Name = "file11";
            this.file11.Size = new System.Drawing.Size(75, 62);
            this.file11.TabIndex = 20;
            this.file11.UseVisualStyleBackColor = false;
            this.file11.Visible = false;
            // 
            // file12
            // 
            this.file12.BackColor = System.Drawing.Color.Transparent;
            this.file12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.file12.ContextMenuStrip = this.contextMenuStrip2;
            this.file12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file12.Image = ((System.Drawing.Image)(resources.GetObject("file12.Image")));
            this.file12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.file12.Location = new System.Drawing.Point(435, 110);
            this.file12.Name = "file12";
            this.file12.Size = new System.Drawing.Size(75, 62);
            this.file12.TabIndex = 19;
            this.file12.UseVisualStyleBackColor = false;
            this.file12.Visible = false;
            // 
            // file7
            // 
            this.file7.BackColor = System.Drawing.Color.Transparent;
            this.file7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.file7.ContextMenuStrip = this.contextMenuStrip2;
            this.file7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file7.Image = ((System.Drawing.Image)(resources.GetObject("file7.Image")));
            this.file7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.file7.Location = new System.Drawing.Point(30, 110);
            this.file7.Name = "file7";
            this.file7.Size = new System.Drawing.Size(75, 62);
            this.file7.TabIndex = 18;
            this.file7.UseVisualStyleBackColor = false;
            this.file7.Visible = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button17.ContextMenuStrip = this.contextMenuStrip2;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button17.Location = new System.Drawing.Point(111, 248);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 62);
            this.button17.TabIndex = 35;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Visible = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button18.ContextMenuStrip = this.contextMenuStrip2;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button18.Location = new System.Drawing.Point(192, 248);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 62);
            this.button18.TabIndex = 34;
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Visible = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button19.ContextMenuStrip = this.contextMenuStrip2;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Image = ((System.Drawing.Image)(resources.GetObject("button19.Image")));
            this.button19.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button19.Location = new System.Drawing.Point(273, 248);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 62);
            this.button19.TabIndex = 33;
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Visible = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button20.ContextMenuStrip = this.contextMenuStrip2;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Image = ((System.Drawing.Image)(resources.GetObject("button20.Image")));
            this.button20.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button20.Location = new System.Drawing.Point(354, 248);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 62);
            this.button20.TabIndex = 32;
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Visible = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Transparent;
            this.button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button21.ContextMenuStrip = this.contextMenuStrip2;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.Image = ((System.Drawing.Image)(resources.GetObject("button21.Image")));
            this.button21.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button21.Location = new System.Drawing.Point(435, 248);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 62);
            this.button21.TabIndex = 31;
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Visible = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Transparent;
            this.button22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button22.ContextMenuStrip = this.contextMenuStrip2;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Image = ((System.Drawing.Image)(resources.GetObject("button22.Image")));
            this.button22.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button22.Location = new System.Drawing.Point(30, 248);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 62);
            this.button22.TabIndex = 30;
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Visible = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Transparent;
            this.button23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button23.ContextMenuStrip = this.contextMenuStrip2;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Image = ((System.Drawing.Image)(resources.GetObject("button23.Image")));
            this.button23.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button23.Location = new System.Drawing.Point(111, 178);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 62);
            this.button23.TabIndex = 29;
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Visible = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.Transparent;
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button24.ContextMenuStrip = this.contextMenuStrip2;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button24.Image = ((System.Drawing.Image)(resources.GetObject("button24.Image")));
            this.button24.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button24.Location = new System.Drawing.Point(192, 178);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 62);
            this.button24.TabIndex = 28;
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Visible = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.Transparent;
            this.button25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button25.ContextMenuStrip = this.contextMenuStrip2;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button25.Image = ((System.Drawing.Image)(resources.GetObject("button25.Image")));
            this.button25.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button25.Location = new System.Drawing.Point(273, 178);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 62);
            this.button25.TabIndex = 27;
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Visible = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Transparent;
            this.button26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button26.ContextMenuStrip = this.contextMenuStrip2;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button26.Image = ((System.Drawing.Image)(resources.GetObject("button26.Image")));
            this.button26.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button26.Location = new System.Drawing.Point(354, 178);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 62);
            this.button26.TabIndex = 26;
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Visible = false;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.Transparent;
            this.button27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button27.ContextMenuStrip = this.contextMenuStrip2;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button27.Image = ((System.Drawing.Image)(resources.GetObject("button27.Image")));
            this.button27.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button27.Location = new System.Drawing.Point(435, 178);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 62);
            this.button27.TabIndex = 25;
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Visible = false;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.Transparent;
            this.button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button28.ContextMenuStrip = this.contextMenuStrip2;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button28.Image = ((System.Drawing.Image)(resources.GetObject("button28.Image")));
            this.button28.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button28.Location = new System.Drawing.Point(30, 178);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(75, 62);
            this.button28.TabIndex = 24;
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Visible = false;
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Transparent;
            this.button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button29.ContextMenuStrip = this.contextMenuStrip2;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button29.Image = ((System.Drawing.Image)(resources.GetObject("button29.Image")));
            this.button29.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button29.Location = new System.Drawing.Point(111, 316);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(75, 62);
            this.button29.TabIndex = 41;
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Visible = false;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.Transparent;
            this.button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button30.ContextMenuStrip = this.contextMenuStrip2;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button30.Image = ((System.Drawing.Image)(resources.GetObject("button30.Image")));
            this.button30.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button30.Location = new System.Drawing.Point(192, 316);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(75, 62);
            this.button30.TabIndex = 40;
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Visible = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.Transparent;
            this.button31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button31.ContextMenuStrip = this.contextMenuStrip2;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button31.Image = ((System.Drawing.Image)(resources.GetObject("button31.Image")));
            this.button31.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button31.Location = new System.Drawing.Point(273, 316);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(75, 62);
            this.button31.TabIndex = 39;
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Visible = false;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.Transparent;
            this.button32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button32.ContextMenuStrip = this.contextMenuStrip2;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button32.Image = ((System.Drawing.Image)(resources.GetObject("button32.Image")));
            this.button32.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button32.Location = new System.Drawing.Point(354, 316);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(75, 62);
            this.button32.TabIndex = 38;
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Visible = false;
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.Transparent;
            this.button33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button33.ContextMenuStrip = this.contextMenuStrip2;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button33.Image = ((System.Drawing.Image)(resources.GetObject("button33.Image")));
            this.button33.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button33.Location = new System.Drawing.Point(435, 316);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(75, 62);
            this.button33.TabIndex = 37;
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Visible = false;
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.Transparent;
            this.button34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button34.ContextMenuStrip = this.contextMenuStrip2;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button34.Image = ((System.Drawing.Image)(resources.GetObject("button34.Image")));
            this.button34.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button34.Location = new System.Drawing.Point(30, 316);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(75, 62);
            this.button34.TabIndex = 36;
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 521);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件系统模拟";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建文件夹ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 属性ToolStripMenuItem;
        private System.Windows.Forms.TextBox PathNow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button file1;
        private System.Windows.Forms.Button file2;
        private System.Windows.Forms.Button file3;
        private System.Windows.Forms.Button file4;
        private System.Windows.Forms.Button file5;
        private System.Windows.Forms.Button file6;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button file8;
        private System.Windows.Forms.Button file9;
        private System.Windows.Forms.Button file10;
        private System.Windows.Forms.Button file11;
        private System.Windows.Forms.Button file12;
        private System.Windows.Forms.Button file7;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;

    }
}

