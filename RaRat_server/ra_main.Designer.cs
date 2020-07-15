namespace RaRat_server
{
    partial class ra_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ra_main));
            this.richTextBox_results = new System.Windows.Forms.RichTextBox();
            this.textBox_command = new System.Windows.Forms.TextBox();
            this.button_run = new System.Windows.Forms.Button();
            this.button_list_processes = new System.Windows.Forms.Button();
            this.comboBox_client_list = new System.Windows.Forms.ComboBox();
            this.label_choose_client = new System.Windows.Forms.Label();
            this.button_create = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_client_info = new System.Windows.Forms.Button();
            this.button_file_transfer = new System.Windows.Forms.Button();
            this.button_screenshot = new System.Windows.Forms.Button();
            this.button_encrypt_file = new System.Windows.Forms.Button();
            this.button_keylogging = new System.Windows.Forms.Button();
            this.button_webcam = new System.Windows.Forms.Button();
            this.button_show_message = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_results
            // 
            this.richTextBox_results.DetectUrls = false;
            this.richTextBox_results.Location = new System.Drawing.Point(342, 12);
            this.richTextBox_results.Name = "richTextBox_results";
            this.richTextBox_results.ReadOnly = true;
            this.richTextBox_results.Size = new System.Drawing.Size(399, 318);
            this.richTextBox_results.TabIndex = 0;
            this.richTextBox_results.Text = "";
            // 
            // textBox_command
            // 
            this.textBox_command.Location = new System.Drawing.Point(342, 346);
            this.textBox_command.Name = "textBox_command";
            this.textBox_command.Size = new System.Drawing.Size(318, 20);
            this.textBox_command.TabIndex = 1;
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(666, 346);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(75, 22);
            this.button_run.TabIndex = 2;
            this.button_run.Text = "run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click_1);
            // 
            // button_list_processes
            // 
            this.button_list_processes.Location = new System.Drawing.Point(15, 59);
            this.button_list_processes.Name = "button_list_processes";
            this.button_list_processes.Size = new System.Drawing.Size(150, 31);
            this.button_list_processes.TabIndex = 3;
            this.button_list_processes.Text = "List Processes";
            this.button_list_processes.UseVisualStyleBackColor = true;
            this.button_list_processes.Click += new System.EventHandler(this.button_list_processes_Click_1);
            // 
            // comboBox_client_list
            // 
            this.comboBox_client_list.FormattingEnabled = true;
            this.comboBox_client_list.Location = new System.Drawing.Point(12, 29);
            this.comboBox_client_list.Name = "comboBox_client_list";
            this.comboBox_client_list.Size = new System.Drawing.Size(306, 21);
            this.comboBox_client_list.TabIndex = 13;
            this.comboBox_client_list.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_choose_client
            // 
            this.label_choose_client.AutoSize = true;
            this.label_choose_client.Location = new System.Drawing.Point(12, 9);
            this.label_choose_client.Name = "label_choose_client";
            this.label_choose_client.Size = new System.Drawing.Size(71, 13);
            this.label_choose_client.TabIndex = 14;
            this.label_choose_client.Text = "Choose client";
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(152, 346);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 16;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button13_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(233, 346);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 17;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click_1);
            // 
            // button_client_info
            // 
            this.button_client_info.Location = new System.Drawing.Point(170, 59);
            this.button_client_info.Name = "button_client_info";
            this.button_client_info.Size = new System.Drawing.Size(150, 31);
            this.button_client_info.TabIndex = 18;
            this.button_client_info.Text = "Client info";
            this.button_client_info.UseVisualStyleBackColor = true;
            this.button_client_info.Click += new System.EventHandler(this.button_client_info_Click_1);
            // 
            // button_file_transfer
            // 
            this.button_file_transfer.Location = new System.Drawing.Point(170, 96);
            this.button_file_transfer.Name = "button_file_transfer";
            this.button_file_transfer.Size = new System.Drawing.Size(150, 31);
            this.button_file_transfer.TabIndex = 20;
            this.button_file_transfer.Text = "File Transfer";
            this.button_file_transfer.UseVisualStyleBackColor = true;
            this.button_file_transfer.Click += new System.EventHandler(this.button_file_transfer_Click_1);
            // 
            // button_screenshot
            // 
            this.button_screenshot.Location = new System.Drawing.Point(15, 96);
            this.button_screenshot.Name = "button_screenshot";
            this.button_screenshot.Size = new System.Drawing.Size(150, 31);
            this.button_screenshot.TabIndex = 19;
            this.button_screenshot.Text = "Screenshot";
            this.button_screenshot.UseVisualStyleBackColor = true;
            this.button_screenshot.Click += new System.EventHandler(this.button_screenshot_Click_1);
            // 
            // button_encrypt_file
            // 
            this.button_encrypt_file.Location = new System.Drawing.Point(170, 133);
            this.button_encrypt_file.Name = "button_encrypt_file";
            this.button_encrypt_file.Size = new System.Drawing.Size(150, 31);
            this.button_encrypt_file.TabIndex = 22;
            this.button_encrypt_file.Text = "Encrypt File";
            this.button_encrypt_file.UseVisualStyleBackColor = true;
            this.button_encrypt_file.Click += new System.EventHandler(this.button_encrypt_file_Click);
            // 
            // button_keylogging
            // 
            this.button_keylogging.Location = new System.Drawing.Point(15, 133);
            this.button_keylogging.Name = "button_keylogging";
            this.button_keylogging.Size = new System.Drawing.Size(150, 31);
            this.button_keylogging.TabIndex = 21;
            this.button_keylogging.Text = "Keylogging";
            this.button_keylogging.UseVisualStyleBackColor = true;
            this.button_keylogging.Click += new System.EventHandler(this.button_keylogging_Click);
            // 
            // button_webcam
            // 
            this.button_webcam.Location = new System.Drawing.Point(170, 170);
            this.button_webcam.Name = "button_webcam";
            this.button_webcam.Size = new System.Drawing.Size(150, 31);
            this.button_webcam.TabIndex = 24;
            this.button_webcam.Text = "Webcam";
            this.button_webcam.UseVisualStyleBackColor = true;
            this.button_webcam.Click += new System.EventHandler(this.button_webcam_Click_1);
            // 
            // button_show_message
            // 
            this.button_show_message.Location = new System.Drawing.Point(15, 170);
            this.button_show_message.Name = "button_show_message";
            this.button_show_message.Size = new System.Drawing.Size(150, 31);
            this.button_show_message.TabIndex = 23;
            this.button_show_message.Text = "Show Message";
            this.button_show_message.UseVisualStyleBackColor = true;
            this.button_show_message.Click += new System.EventHandler(this.button_show_message_Click_1);
            // 
            // ra_main
            // 
            this.ClientSize = new System.Drawing.Size(757, 386);
            this.Controls.Add(this.button_webcam);
            this.Controls.Add(this.button_show_message);
            this.Controls.Add(this.button_encrypt_file);
            this.Controls.Add(this.button_keylogging);
            this.Controls.Add(this.button_file_transfer);
            this.Controls.Add(this.button_screenshot);
            this.Controls.Add(this.button_client_info);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.label_choose_client);
            this.Controls.Add(this.comboBox_client_list);
            this.Controls.Add(this.button_list_processes);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.textBox_command);
            this.Controls.Add(this.richTextBox_results);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ra_main";
            this.Text = "RaRat ( Version 0.1 )";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_results;
        private System.Windows.Forms.TextBox textBox_command;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.Button button_list_processes;
        private System.Windows.Forms.ComboBox comboBox_client_list;
        private System.Windows.Forms.Label label_choose_client;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_client_info;
        private System.Windows.Forms.Button button_file_transfer;
        private System.Windows.Forms.Button button_screenshot;
        private System.Windows.Forms.Button button_encrypt_file;
        private System.Windows.Forms.Button button_keylogging;
        private System.Windows.Forms.Button button_webcam;
        private System.Windows.Forms.Button button_show_message;
    }
}

