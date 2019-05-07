﻿namespace DrugShop.WinUI
{
    partial class DrugChangePriceQuery
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugChangePriceQuery));
            this.panelTop = new System.Windows.Forms.Panel();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.tbCause = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSeach = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panBottom = new System.Windows.Forms.Panel();
            this.lbTip = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ledClock = new EAS.Windows.UI.Controls.LEDClock();
            this.label38 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ChinseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmrcpriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputControlEnter1 = new EAS.Windows.UI.Controls.InputControlEnter(this.components);
            this.controlAutoFocus1 = new EAS.Windows.UI.Controls.ControlAutoFocus(this.components);
            this.panelTop.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmrcpriceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.dtpEnd);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.dtpStart);
            this.panelTop.Controls.Add(this.tbCause);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.tbSeach);
            this.panelTop.Controls.Add(this.btnPrint);
            this.panelTop.Controls.Add(this.btnSeach);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 48);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(933, 72);
            this.panelTop.TabIndex = 1;
            // 
            // dtpEnd
            // 
            this.controlAutoFocus1.SetAllowNext(this.dtpEnd, true);
            this.controlAutoFocus1.SetAllowPrevious(this.dtpEnd, true);
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.inputControlEnter1.SetFocus(this.dtpEnd, true);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(270, 36);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(170, 23);
            this.dtpEnd.TabIndex = 7;
            // 
            // label3
            // 
            this.controlAutoFocus1.SetAllowNext(this.label3, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label3, false);
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label3, false);
            this.label3.Location = new System.Drawing.Point(247, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "->";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStart
            // 
            this.controlAutoFocus1.SetAllowNext(this.dtpStart, true);
            this.controlAutoFocus1.SetAllowPrevious(this.dtpStart, true);
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.inputControlEnter1.SetFocus(this.dtpStart, true);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(74, 36);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(170, 23);
            this.dtpStart.TabIndex = 5;
            // 
            // tbCause
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbCause, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbCause, true);
            this.tbCause.BackColor = System.Drawing.SystemColors.Window;
            this.inputControlEnter1.SetFocus(this.tbCause, true);
            this.tbCause.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbCause.Location = new System.Drawing.Point(250, 7);
            this.tbCause.MaxLength = 32;
            this.tbCause.Name = "tbCause";
            this.tbCause.Size = new System.Drawing.Size(190, 23);
            this.tbCause.TabIndex = 3;
            this.tbCause.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCause_KeyDown);
            // 
            // label4
            // 
            this.controlAutoFocus1.SetAllowNext(this.label4, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label4, false);
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inputControlEnter1.SetFocus(this.label4, false);
            this.label4.Location = new System.Drawing.Point(180, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "调价原因：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSeach
            // 
            this.controlAutoFocus1.SetAllowNext(this.tbSeach, true);
            this.controlAutoFocus1.SetAllowPrevious(this.tbSeach, true);
            this.tbSeach.BackColor = System.Drawing.SystemColors.Window;
            this.inputControlEnter1.SetFocus(this.tbSeach, true);
            this.tbSeach.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbSeach.Location = new System.Drawing.Point(74, 8);
            this.tbSeach.MaxLength = 32;
            this.tbSeach.Name = "tbSeach";
            this.tbSeach.Size = new System.Drawing.Size(103, 23);
            this.tbSeach.TabIndex = 1;
            this.tbSeach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSeach_KeyDown);
            // 
            // btnPrint
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnPrint, true);
            this.controlAutoFocus1.SetAllowPrevious(this.btnPrint, true);
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.inputControlEnter1.SetFocus(this.btnPrint, true);
            this.btnPrint.Location = new System.Drawing.Point(542, 32);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 27);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSeach
            // 
            this.controlAutoFocus1.SetAllowNext(this.btnSeach, true);
            this.controlAutoFocus1.SetAllowPrevious(this.btnSeach, true);
            this.btnSeach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeach.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.inputControlEnter1.SetFocus(this.btnSeach, true);
            this.btnSeach.Location = new System.Drawing.Point(446, 32);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(90, 27);
            this.btnSeach.TabIndex = 8;
            this.btnSeach.Text = "查询(&S)";
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // label2
            // 
            this.controlAutoFocus1.SetAllowNext(this.label2, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label2, false);
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label2, false);
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "调价时间：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.controlAutoFocus1.SetAllowNext(this.label1, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label1, false);
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.inputControlEnter1.SetFocus(this.label1, false);
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "检 　 索：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.White;
            this.panBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBottom.Controls.Add(this.lbTip);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 437);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(933, 38);
            this.panBottom.TabIndex = 3;
            // 
            // lbTip
            // 
            this.controlAutoFocus1.SetAllowNext(this.lbTip, false);
            this.controlAutoFocus1.SetAllowPrevious(this.lbTip, false);
            this.lbTip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTip.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.lbTip, false);
            this.lbTip.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTip.ForeColor = System.Drawing.Color.Blue;
            this.lbTip.Location = new System.Drawing.Point(14, 11);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(212, 14);
            this.lbTip.TabIndex = 0;
            this.lbTip.Text = "共有票据0张，调价差额0.00元";
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "");
            this.imgList.Images.SetKeyName(1, "");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ledClock);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 48);
            this.panel1.TabIndex = 0;
            // 
            // ledClock
            // 
            this.controlAutoFocus1.SetAllowNext(this.ledClock, false);
            this.controlAutoFocus1.SetAllowPrevious(this.ledClock, false);
            this.ledClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ledClock.ClockColor = System.Drawing.Color.Green;
            this.ledClock.DateTime = new System.DateTime(2013, 10, 10, 10, 35, 18, 0);
            this.inputControlEnter1.SetFocus(this.ledClock, false);
            this.ledClock.IsDrawShadow = true;
            this.ledClock.IsTimerEnable = true;
            this.ledClock.LEDClockStyle = EAS.Windows.UI.Controls.LEDClockStyle.DateAndTime;
            this.ledClock.Location = new System.Drawing.Point(734, 9);
            this.ledClock.Name = "ledClock";
            this.ledClock.Size = new System.Drawing.Size(175, 28);
            this.ledClock.TabIndex = 2;
            // 
            // label38
            // 
            this.controlAutoFocus1.SetAllowNext(this.label38, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label38, false);
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.AutoSize = true;
            this.inputControlEnter1.SetFocus(this.label38, false);
            this.label38.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(654, 16);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(82, 14);
            this.label38.TabIndex = 1;
            this.label38.Text = "当前日期：";
            // 
            // label11
            // 
            this.controlAutoFocus1.SetAllowNext(this.label11, false);
            this.controlAutoFocus1.SetAllowPrevious(this.label11, false);
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputControlEnter1.SetFocus(this.label11, false);
            this.label11.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(22, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "药品调价查询";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.controlAutoFocus1.SetAllowNext(this.dataGridView1, false);
            this.controlAutoFocus1.SetAllowPrevious(this.dataGridView1, false);
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChinseNameDataGridViewTextBoxColumn,
            this.specDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn7,
            this.numberDataGridViewTextBoxColumn,
            this.NSalePrice,
            this.Type,
            this.Provider,
            this.EventTime});
            this.dataGridView1.DataSource = this.dmrcpriceBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputControlEnter1.SetFocus(this.dataGridView1, false);
            this.dataGridView1.Location = new System.Drawing.Point(0, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(933, 317);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // ChinseNameDataGridViewTextBoxColumn
            // 
            this.ChinseNameDataGridViewTextBoxColumn.DataPropertyName = "ChinseName";
            this.ChinseNameDataGridViewTextBoxColumn.HeaderText = "药品名称";
            this.ChinseNameDataGridViewTextBoxColumn.Name = "ChinseNameDataGridViewTextBoxColumn";
            this.ChinseNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "Spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "规格";
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SalePrice";
            this.dataGridViewTextBoxColumn7.HeaderText = "售价";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "调价数量";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // NSalePrice
            // 
            this.NSalePrice.DataPropertyName = "NSalePrice";
            this.NSalePrice.HeaderText = "新零价格";
            this.NSalePrice.Name = "NSalePrice";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "药品类型";
            this.Type.Name = "Type";
            // 
            // Provider
            // 
            this.Provider.DataPropertyName = "Provider";
            this.Provider.HeaderText = "供应商";
            this.Provider.Name = "Provider";
            // 
            // EventTime
            // 
            this.EventTime.DataPropertyName = "EventTime";
            this.EventTime.HeaderText = "调价日期";
            this.EventTime.Name = "EventTime";
            this.EventTime.Width = 200;
            // 
            // dmrcpriceBindingSource
            // 
            this.dmrcpriceBindingSource.DataSource = typeof(DrugShop.Entities.CPrice);
            // 
            // inputControlEnter1
            // 
            this.inputControlEnter1.DroppedDown = true;
            this.inputControlEnter1.EnterBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.inputControlEnter1.EnterForeColor = System.Drawing.Color.Red;
            // 
            // controlAutoFocus1
            // 
            this.controlAutoFocus1.NextKeys = null;
            this.controlAutoFocus1.PreviousKeys = null;
            // 
            // DrugChangePriceQuery
            // 
            this.controlAutoFocus1.SetAllowNext(this, false);
            this.controlAutoFocus1.SetAllowPrevious(this, false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panBottom);
            this.inputControlEnter1.SetFocus(this, false);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "DrugChangePriceQuery";
            this.Size = new System.Drawing.Size(933, 475);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmrcpriceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSeach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCause;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.Label lbTip;
        private System.Windows.Forms.Panel panel1;
        private EAS.Windows.UI.Controls.LEDClock ledClock;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource dmrcpriceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChinseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provider;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTime;
        private EAS.Windows.UI.Controls.ControlAutoFocus controlAutoFocus1;
        private EAS.Windows.UI.Controls.InputControlEnter inputControlEnter1;

    }
}
