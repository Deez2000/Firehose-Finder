﻿
namespace FirehoseFinder
{
    partial class Hex_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hex_Search));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker_hex_search = new System.ComponentModel.BackgroundWorker();
            this.statusStrip_search = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar_search = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel_search = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel_hs = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_search = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_byte_text = new System.Windows.Forms.GroupBox();
            this.textBox_hexsearch = new System.Windows.Forms.TextBox();
            this.textBox_byte_search = new System.Windows.Forms.TextBox();
            this.radioButton_search_text = new System.Windows.Forms.RadioButton();
            this.radioButton_byte_search = new System.Windows.Forms.RadioButton();
            this.button_start_search = new System.Windows.Forms.Button();
            this.groupBox_hs = new System.Windows.Forms.GroupBox();
            this.radioButton_dir = new System.Windows.Forms.RadioButton();
            this.radioButton_file = new System.Windows.Forms.RadioButton();
            this.groupBox_addbytes = new System.Windows.Forms.GroupBox();
            this.textBox_addlast = new System.Windows.Forms.TextBox();
            this.textBox_addfirst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip_search.SuspendLayout();
            this.tableLayoutPanel_hs.SuspendLayout();
            this.groupBox_byte_text.SuspendLayout();
            this.groupBox_hs.SuspendLayout();
            this.groupBox_addbytes.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // backgroundWorker_hex_search
            // 
            this.backgroundWorker_hex_search.WorkerReportsProgress = true;
            this.backgroundWorker_hex_search.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_hex_search_DoWork);
            this.backgroundWorker_hex_search.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_hex_search_ProgressChanged);
            this.backgroundWorker_hex_search.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_hex_search_RunWorkerCompleted);
            // 
            // statusStrip_search
            // 
            resources.ApplyResources(this.statusStrip_search, "statusStrip_search");
            this.statusStrip_search.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_search.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar_search,
            this.toolStripStatusLabel_search});
            this.statusStrip_search.Name = "statusStrip_search";
            // 
            // toolStripProgressBar_search
            // 
            resources.ApplyResources(this.toolStripProgressBar_search, "toolStripProgressBar_search");
            this.toolStripProgressBar_search.ForeColor = System.Drawing.Color.LimeGreen;
            this.toolStripProgressBar_search.Name = "toolStripProgressBar_search";
            this.toolStripProgressBar_search.Step = 1;
            this.toolStripProgressBar_search.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel_search
            // 
            resources.ApplyResources(this.toolStripStatusLabel_search, "toolStripStatusLabel_search");
            this.toolStripStatusLabel_search.Name = "toolStripStatusLabel_search";
            // 
            // tableLayoutPanel_hs
            // 
            resources.ApplyResources(this.tableLayoutPanel_hs, "tableLayoutPanel_hs");
            this.tableLayoutPanel_hs.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel_hs.Controls.Add(this.listView_search, 0, 1);
            this.tableLayoutPanel_hs.Controls.Add(this.groupBox_byte_text, 1, 0);
            this.tableLayoutPanel_hs.Controls.Add(this.button_start_search, 2, 2);
            this.tableLayoutPanel_hs.Controls.Add(this.groupBox_hs, 2, 1);
            this.tableLayoutPanel_hs.Controls.Add(this.groupBox_addbytes, 2, 0);
            this.tableLayoutPanel_hs.Name = "tableLayoutPanel_hs";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // listView_search
            // 
            resources.ApplyResources(this.listView_search, "listView_search");
            this.listView_search.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.tableLayoutPanel_hs.SetColumnSpan(this.listView_search, 2);
            this.listView_search.FullRowSelect = true;
            this.listView_search.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_search.HideSelection = false;
            this.listView_search.MultiSelect = false;
            this.listView_search.Name = "listView_search";
            this.tableLayoutPanel_hs.SetRowSpan(this.listView_search, 2);
            this.listView_search.UseCompatibleStateImageBehavior = false;
            this.listView_search.View = System.Windows.Forms.View.Details;
            this.listView_search.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_search_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // groupBox_byte_text
            // 
            resources.ApplyResources(this.groupBox_byte_text, "groupBox_byte_text");
            this.groupBox_byte_text.Controls.Add(this.textBox_hexsearch);
            this.groupBox_byte_text.Controls.Add(this.textBox_byte_search);
            this.groupBox_byte_text.Controls.Add(this.radioButton_search_text);
            this.groupBox_byte_text.Controls.Add(this.radioButton_byte_search);
            this.groupBox_byte_text.Name = "groupBox_byte_text";
            this.groupBox_byte_text.TabStop = false;
            // 
            // textBox_hexsearch
            // 
            resources.ApplyResources(this.textBox_hexsearch, "textBox_hexsearch");
            this.textBox_hexsearch.Name = "textBox_hexsearch";
            this.textBox_hexsearch.TextChanged += new System.EventHandler(this.TextBox_hexsearch_TextChanged);
            // 
            // textBox_byte_search
            // 
            resources.ApplyResources(this.textBox_byte_search, "textBox_byte_search");
            this.textBox_byte_search.Name = "textBox_byte_search";
            this.textBox_byte_search.TextChanged += new System.EventHandler(this.TextBox_byte_search_TextChanged);
            // 
            // radioButton_search_text
            // 
            resources.ApplyResources(this.radioButton_search_text, "radioButton_search_text");
            this.radioButton_search_text.Name = "radioButton_search_text";
            this.radioButton_search_text.UseVisualStyleBackColor = true;
            this.radioButton_search_text.CheckedChanged += new System.EventHandler(this.RadioButton_search_text_CheckedChanged);
            // 
            // radioButton_byte_search
            // 
            resources.ApplyResources(this.radioButton_byte_search, "radioButton_byte_search");
            this.radioButton_byte_search.Checked = true;
            this.radioButton_byte_search.Name = "radioButton_byte_search";
            this.radioButton_byte_search.TabStop = true;
            this.radioButton_byte_search.UseVisualStyleBackColor = true;
            this.radioButton_byte_search.CheckedChanged += new System.EventHandler(this.RadioButton_byte_search_CheckedChanged);
            // 
            // button_start_search
            // 
            resources.ApplyResources(this.button_start_search, "button_start_search");
            this.button_start_search.Name = "button_start_search";
            this.button_start_search.UseVisualStyleBackColor = true;
            this.button_start_search.Click += new System.EventHandler(this.Button_start_search_Click);
            // 
            // groupBox_hs
            // 
            resources.ApplyResources(this.groupBox_hs, "groupBox_hs");
            this.groupBox_hs.Controls.Add(this.radioButton_dir);
            this.groupBox_hs.Controls.Add(this.radioButton_file);
            this.groupBox_hs.Name = "groupBox_hs";
            this.groupBox_hs.TabStop = false;
            // 
            // radioButton_dir
            // 
            resources.ApplyResources(this.radioButton_dir, "radioButton_dir");
            this.radioButton_dir.Name = "radioButton_dir";
            this.radioButton_dir.TabStop = true;
            this.radioButton_dir.UseVisualStyleBackColor = true;
            // 
            // radioButton_file
            // 
            resources.ApplyResources(this.radioButton_file, "radioButton_file");
            this.radioButton_file.Checked = true;
            this.radioButton_file.Name = "radioButton_file";
            this.radioButton_file.TabStop = true;
            this.radioButton_file.UseVisualStyleBackColor = true;
            // 
            // groupBox_addbytes
            // 
            resources.ApplyResources(this.groupBox_addbytes, "groupBox_addbytes");
            this.groupBox_addbytes.Controls.Add(this.textBox_addlast);
            this.groupBox_addbytes.Controls.Add(this.textBox_addfirst);
            this.groupBox_addbytes.Controls.Add(this.label3);
            this.groupBox_addbytes.Controls.Add(this.label2);
            this.groupBox_addbytes.Name = "groupBox_addbytes";
            this.groupBox_addbytes.TabStop = false;
            // 
            // textBox_addlast
            // 
            resources.ApplyResources(this.textBox_addlast, "textBox_addlast");
            this.textBox_addlast.Name = "textBox_addlast";
            // 
            // textBox_addfirst
            // 
            resources.ApplyResources(this.textBox_addfirst, "textBox_addfirst");
            this.textBox_addfirst.Name = "textBox_addfirst";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Hex_Search
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel_hs);
            this.Controls.Add(this.statusStrip_search);
            this.Name = "Hex_Search";
            this.statusStrip_search.ResumeLayout(false);
            this.statusStrip_search.PerformLayout();
            this.tableLayoutPanel_hs.ResumeLayout(false);
            this.tableLayoutPanel_hs.PerformLayout();
            this.groupBox_byte_text.ResumeLayout(false);
            this.groupBox_byte_text.PerformLayout();
            this.groupBox_hs.ResumeLayout(false);
            this.groupBox_hs.PerformLayout();
            this.groupBox_addbytes.ResumeLayout(false);
            this.groupBox_addbytes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker_hex_search;
        private System.Windows.Forms.StatusStrip statusStrip_search;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_search;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_hs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_hs;
        private System.Windows.Forms.RadioButton radioButton_dir;
        private System.Windows.Forms.RadioButton radioButton_file;
        private System.Windows.Forms.Button button_start_search;
        private System.Windows.Forms.ListView listView_search;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox_byte_text;
        private System.Windows.Forms.TextBox textBox_hexsearch;
        private System.Windows.Forms.TextBox textBox_byte_search;
        private System.Windows.Forms.RadioButton radioButton_search_text;
        private System.Windows.Forms.RadioButton radioButton_byte_search;
        private System.Windows.Forms.GroupBox groupBox_addbytes;
        private System.Windows.Forms.TextBox textBox_addlast;
        private System.Windows.Forms.TextBox textBox_addfirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}