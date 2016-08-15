namespace CalculatorUI
{
    partial class AddPluginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPluginForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._pluginWebBrowser = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this._pluginNameTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._operatorTypeComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._cancelBtn = new System.Windows.Forms.Button();
            this._vsLinkBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this._createPluginBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.36782F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.96552F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 358);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(730, 45);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "*Please use unique Plugin Names. Copy the Code on the Right into visual studio";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 418F));
            this.tableLayoutPanel2.Controls.Add(this._pluginWebBrowser, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 54);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.86207F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(730, 240);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // _pluginWebBrowser
            // 
            this._pluginWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pluginWebBrowser.Location = new System.Drawing.Point(315, 3);
            this._pluginWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this._pluginWebBrowser.Name = "_pluginWebBrowser";
            this._pluginWebBrowser.ScrollBarsEnabled = false;
            this._pluginWebBrowser.Size = new System.Drawing.Size(412, 234);
            this._pluginWebBrowser.TabIndex = 9;
            this._pluginWebBrowser.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this._pluginNameTbox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this._operatorTypeComboBox, 0, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.41072F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.41072F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.17857F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.19643F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.80357F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(306, 234);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Plugin Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _pluginNameTbox
            // 
            this._pluginNameTbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pluginNameTbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pluginNameTbox.Location = new System.Drawing.Point(4, 44);
            this._pluginNameTbox.Name = "_pluginNameTbox";
            this._pluginNameTbox.Size = new System.Drawing.Size(298, 27);
            this._pluginNameTbox.TabIndex = 0;
            this._pluginNameTbox.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operator Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _operatorTypeComboBox
            // 
            this._operatorTypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._operatorTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._operatorTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._operatorTypeComboBox.FormattingEnabled = true;
            this._operatorTypeComboBox.Items.AddRange(new object[] {
            "Unary Operator",
            "Binary Operator\t\t"});
            this._operatorTypeComboBox.Location = new System.Drawing.Point(4, 119);
            this._operatorTypeComboBox.Name = "_operatorTypeComboBox";
            this._operatorTypeComboBox.Size = new System.Drawing.Size(298, 26);
            this._operatorTypeComboBox.TabIndex = 3;
            this._operatorTypeComboBox.Tag = "IPlugin";
            this._operatorTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.onComboSelected);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this._cancelBtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this._vsLinkBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this._createPluginBtn, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 300);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(730, 55);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // _cancelBtn
            // 
            this._cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._cancelBtn.Location = new System.Drawing.Point(621, 8);
            this._cancelBtn.Name = "_cancelBtn";
            this._cancelBtn.Size = new System.Drawing.Size(106, 38);
            this._cancelBtn.TabIndex = 2;
            this._cancelBtn.Text = "Cancel";
            this._cancelBtn.UseVisualStyleBackColor = true;
            this._cancelBtn.Click += new System.EventHandler(this.onCancel);
            // 
            // _vsLinkBtn
            // 
            this._vsLinkBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._vsLinkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._vsLinkBtn.Enabled = false;
            this._vsLinkBtn.ForeColor = System.Drawing.Color.Purple;
            this._vsLinkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._vsLinkBtn.ImageIndex = 0;
            this._vsLinkBtn.ImageList = this.imageList1;
            this._vsLinkBtn.Location = new System.Drawing.Point(55, 8);
            this._vsLinkBtn.Name = "_vsLinkBtn";
            this._vsLinkBtn.Size = new System.Drawing.Size(185, 38);
            this._vsLinkBtn.TabIndex = 2;
            this._vsLinkBtn.Text = "Open in Visual Studio";
            this._vsLinkBtn.UseVisualStyleBackColor = true;
            this._vsLinkBtn.Click += new System.EventHandler(this.onOpenVisualStudio);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "visualstudio.png");
            // 
            // _createPluginBtn
            // 
            this._createPluginBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._createPluginBtn.Location = new System.Drawing.Point(360, 8);
            this._createPluginBtn.Name = "_createPluginBtn";
            this._createPluginBtn.Size = new System.Drawing.Size(123, 38);
            this._createPluginBtn.TabIndex = 1;
            this._createPluginBtn.Text = "Create Plugin";
            this._createPluginBtn.UseVisualStyleBackColor = true;
            this._createPluginBtn.Click += new System.EventHandler(this.onCreatePlugin);
            // 
            // AddPluginForm
            // 
            this.AcceptButton = this._createPluginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 358);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddPluginForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Plugin";
            this.Load += new System.EventHandler(this.onLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.WebBrowser _pluginWebBrowser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button _cancelBtn;
        private System.Windows.Forms.Button _createPluginBtn;
        private System.Windows.Forms.Button _vsLinkBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _pluginNameTbox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _operatorTypeComboBox;
    }
}