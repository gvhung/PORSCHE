namespace Workshop
{
    partial class frmWork
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWork));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCarNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelay = new System.Windows.Forms.Button();
            this.btnAddhour = new System.Windows.Forms.Button();
            this.btnCarStae = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnClearCar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.中断ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.追加工时ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.延时ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返修ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.完工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.洗车ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.洗车与送车时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pn = new System.Windows.Forms.Panel();
            this.picDown = new System.Windows.Forms.PictureBox();
            this.picUp = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 105;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(1298, 258);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "等待";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "工人";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 48);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.txtCarNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDelay);
            this.panel1.Controls.Add(this.btnAddhour);
            this.panel1.Controls.Add(this.btnCarStae);
            this.panel1.Controls.Add(this.btnBooking);
            this.panel1.Controls.Add(this.btnClearCar);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnComplete);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(2, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 55);
            this.panel1.TabIndex = 10;
            // 
            // txtCarNo
            // 
            this.txtCarNo.Location = new System.Drawing.Point(854, 17);
            this.txtCarNo.Name = "txtCarNo";
            this.txtCarNo.Size = new System.Drawing.Size(66, 26);
            this.txtCarNo.TabIndex = 22;
            this.txtCarNo.TextChanged += new System.EventHandler(this.txtCarNo_TextChanged);
            this.txtCarNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarNo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(759, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "查找车牌号:";
            // 
            // btnDelay
            // 
            this.btnDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelay.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelay.ForeColor = System.Drawing.Color.White;
            this.btnDelay.Location = new System.Drawing.Point(187, 7);
            this.btnDelay.Name = "btnDelay";
            this.btnDelay.Size = new System.Drawing.Size(80, 35);
            this.btnDelay.TabIndex = 20;
            this.btnDelay.Text = "延时";
            this.btnDelay.UseVisualStyleBackColor = false;
            this.btnDelay.Click += new System.EventHandler(this.延时到明天ToolStripMenuItem_Click);
            // 
            // btnAddhour
            // 
            this.btnAddhour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddhour.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddhour.ForeColor = System.Drawing.Color.White;
            this.btnAddhour.Location = new System.Drawing.Point(99, 6);
            this.btnAddhour.Name = "btnAddhour";
            this.btnAddhour.Size = new System.Drawing.Size(80, 35);
            this.btnAddhour.TabIndex = 19;
            this.btnAddhour.Text = "追加工时";
            this.btnAddhour.UseVisualStyleBackColor = false;
            this.btnAddhour.Click += new System.EventHandler(this.追加工时ToolStripMenuItem_Click);
            // 
            // btnCarStae
            // 
            this.btnCarStae.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCarStae.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCarStae.ForeColor = System.Drawing.Color.White;
            this.btnCarStae.Location = new System.Drawing.Point(534, 7);
            this.btnCarStae.Name = "btnCarStae";
            this.btnCarStae.Size = new System.Drawing.Size(80, 35);
            this.btnCarStae.TabIndex = 16;
            this.btnCarStae.Text = "车辆状态";
            this.btnCarStae.UseVisualStyleBackColor = false;
            this.btnCarStae.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBooking.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(448, 7);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(80, 35);
            this.btnBooking.TabIndex = 15;
            this.btnBooking.Text = "预约管理";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearCar
            // 
            this.btnClearCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearCar.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearCar.ForeColor = System.Drawing.Color.White;
            this.btnClearCar.Location = new System.Drawing.Point(362, 7);
            this.btnClearCar.Name = "btnClearCar";
            this.btnClearCar.Size = new System.Drawing.Size(80, 35);
            this.btnClearCar.TabIndex = 14;
            this.btnClearCar.Text = "洗车";
            this.btnClearCar.UseVisualStyleBackColor = false;
            this.btnClearCar.Click += new System.EventHandler(this.洗车ToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(620, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 35);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnComplete.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Location = new System.Drawing.Point(274, 6);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(80, 35);
            this.btnComplete.TabIndex = 12;
            this.btnComplete.Text = "完工";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.完工ToolStripMenuItem_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPause.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(10, 6);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(80, 35);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "中断";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.中断ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1073, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "2009年05月21日";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中断ToolStripMenuItem,
            this.追加工时ToolStripMenuItem,
            this.延时ToolStripMenuItem,
            this.返修ToolStripMenuItem,
            this.完工ToolStripMenuItem,
            this.洗车ToolStripMenuItem,
            this.洗车与送车时间ToolStripMenuItem,
            this.分单ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(173, 180);
            // 
            // 中断ToolStripMenuItem
            // 
            this.中断ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("中断ToolStripMenuItem.Image")));
            this.中断ToolStripMenuItem.Name = "中断ToolStripMenuItem";
            this.中断ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.中断ToolStripMenuItem.Text = "中断";
            this.中断ToolStripMenuItem.EnabledChanged += new System.EventHandler(this.中断ToolStripMenuItem_EnabledChanged);
            this.中断ToolStripMenuItem.TextChanged += new System.EventHandler(this.中断ToolStripMenuItem_TextChanged);
            this.中断ToolStripMenuItem.Click += new System.EventHandler(this.中断ToolStripMenuItem_Click);
            // 
            // 追加工时ToolStripMenuItem
            // 
            this.追加工时ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("追加工时ToolStripMenuItem.Image")));
            this.追加工时ToolStripMenuItem.Name = "追加工时ToolStripMenuItem";
            this.追加工时ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.追加工时ToolStripMenuItem.Text = "追加工时";
            this.追加工时ToolStripMenuItem.EnabledChanged += new System.EventHandler(this.追加工时ToolStripMenuItem_EnabledChanged);
            this.追加工时ToolStripMenuItem.Click += new System.EventHandler(this.追加工时ToolStripMenuItem_Click);
            // 
            // 延时ToolStripMenuItem
            // 
            this.延时ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("延时ToolStripMenuItem.Image")));
            this.延时ToolStripMenuItem.Name = "延时ToolStripMenuItem";
            this.延时ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.延时ToolStripMenuItem.Text = "延时";
            this.延时ToolStripMenuItem.EnabledChanged += new System.EventHandler(this.延时ToolStripMenuItem_EnabledChanged);
            this.延时ToolStripMenuItem.Click += new System.EventHandler(this.延时到明天ToolStripMenuItem_Click);
            // 
            // 返修ToolStripMenuItem
            // 
            this.返修ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("返修ToolStripMenuItem.Image")));
            this.返修ToolStripMenuItem.Name = "返修ToolStripMenuItem";
            this.返修ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.返修ToolStripMenuItem.Text = "返修";
            this.返修ToolStripMenuItem.Click += new System.EventHandler(this.返修ToolStripMenuItem_Click);
            // 
            // 完工ToolStripMenuItem
            // 
            this.完工ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("完工ToolStripMenuItem.Image")));
            this.完工ToolStripMenuItem.Name = "完工ToolStripMenuItem";
            this.完工ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.完工ToolStripMenuItem.Text = "完工";
            this.完工ToolStripMenuItem.EnabledChanged += new System.EventHandler(this.完工ToolStripMenuItem_EnabledChanged);
            this.完工ToolStripMenuItem.Click += new System.EventHandler(this.完工ToolStripMenuItem_Click);
            // 
            // 洗车ToolStripMenuItem
            // 
            this.洗车ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("洗车ToolStripMenuItem.Image")));
            this.洗车ToolStripMenuItem.Name = "洗车ToolStripMenuItem";
            this.洗车ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.洗车ToolStripMenuItem.Text = "洗车";
            this.洗车ToolStripMenuItem.EnabledChanged += new System.EventHandler(this.洗车ToolStripMenuItem_EnabledChanged);
            this.洗车ToolStripMenuItem.Click += new System.EventHandler(this.洗车ToolStripMenuItem_Click);
            // 
            // 洗车与送车时间ToolStripMenuItem
            // 
            this.洗车与送车时间ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("洗车与送车时间ToolStripMenuItem.Image")));
            this.洗车与送车时间ToolStripMenuItem.Name = "洗车与送车时间ToolStripMenuItem";
            this.洗车与送车时间ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.洗车与送车时间ToolStripMenuItem.Text = "洗车与送车时间";
            this.洗车与送车时间ToolStripMenuItem.Click += new System.EventHandler(this.洗车与送车时间ToolStripMenuItem_Click);
            // 
            // 分单ToolStripMenuItem
            // 
            this.分单ToolStripMenuItem.Image = global::Workshop.Properties.Resources._15_01_;
            this.分单ToolStripMenuItem.Name = "分单ToolStripMenuItem";
            this.分单ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.分单ToolStripMenuItem.Text = "分单";
            this.分单ToolStripMenuItem.Click += new System.EventHandler(this.分单ToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1298, 78);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Workshop.Properties.Resources._16_01_;
            this.pictureBox2.Location = new System.Drawing.Point(1279, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 16);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pn
            // 
            this.pn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pn.Controls.Add(this.picDown);
            this.pn.Controls.Add(this.picUp);
            this.pn.Location = new System.Drawing.Point(1, 365);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(141, 30);
            this.pn.TabIndex = 12;
            // 
            // picDown
            // 
            this.picDown.Image = global::Workshop.Properties.Resources.down1;
            this.picDown.Location = new System.Drawing.Point(74, 1);
            this.picDown.Name = "picDown";
            this.picDown.Size = new System.Drawing.Size(35, 32);
            this.picDown.TabIndex = 1;
            this.picDown.TabStop = false;
            this.picDown.Click += new System.EventHandler(this.picDown_Click);
            this.picDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDown_MouseDown);
            this.picDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDown_MouseUp);
            // 
            // picUp
            // 
            this.picUp.Image = global::Workshop.Properties.Resources.up1;
            this.picUp.Location = new System.Drawing.Point(23, 0);
            this.picUp.Name = "picUp";
            this.picUp.Size = new System.Drawing.Size(37, 32);
            this.picUp.TabIndex = 0;
            this.picUp.TabStop = false;
            this.picUp.Click += new System.EventHandler(this.picUp_Click);
            this.picUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picUp_MouseDown);
            this.picUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picUp_MouseUp);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.picUp_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 200;
            this.timer3.Tick += new System.EventHandler(this.picDown_Click);
            // 
            // frmWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1298, 398);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWork";
            this.Text = "车间运作";
            this.Load += new System.EventHandler(this.frmWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 中断ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完工ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 洗车ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 延时ToolStripMenuItem;
        private System.Windows.Forms.Button btnClearCar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCarStae;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.PictureBox picDown;
        private System.Windows.Forms.PictureBox picUp;
        private System.Windows.Forms.ToolStripMenuItem 追加工时ToolStripMenuItem;
        private System.Windows.Forms.Button btnDelay;
        private System.Windows.Forms.Button btnAddhour;
        private System.Windows.Forms.TextBox txtCarNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem 返修ToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem 洗车与送车时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分单ToolStripMenuItem;
    }
}