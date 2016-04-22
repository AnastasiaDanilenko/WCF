namespace GettingStartedClient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_entertheroom = new System.Windows.Forms.Button();
            this.button_addroom = new System.Windows.Forms.Button();
            this.button_sendtouser = new System.Windows.Forms.Button();
            this.button_addnewuser = new System.Windows.Forms.Button();
            this.comboBox_rooms = new System.Windows.Forms.ComboBox();
            this.comboBox_users = new System.Windows.Forms.ComboBox();
            this.textBox_roomname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.richTextBox_text = new System.Windows.Forms.RichTextBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_quitroom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_entertheroom
            // 
            this.button_entertheroom.Location = new System.Drawing.Point(38, 230);
            this.button_entertheroom.Name = "button_entertheroom";
            this.button_entertheroom.Size = new System.Drawing.Size(248, 46);
            this.button_entertheroom.TabIndex = 6;
            this.button_entertheroom.Text = "Присоединиться к комнате";
            this.button_entertheroom.UseVisualStyleBackColor = true;
            this.button_entertheroom.Click += new System.EventHandler(this.button_entertheroom_Click);
            // 
            // button_addroom
            // 
            this.button_addroom.Location = new System.Drawing.Point(36, 366);
            this.button_addroom.Name = "button_addroom";
            this.button_addroom.Size = new System.Drawing.Size(248, 47);
            this.button_addroom.TabIndex = 7;
            this.button_addroom.Text = "Создать новую комнату";
            this.button_addroom.UseVisualStyleBackColor = true;
            this.button_addroom.Click += new System.EventHandler(this.button_addroom_Click);
            // 
            // button_sendtouser
            // 
            this.button_sendtouser.Location = new System.Drawing.Point(36, 516);
            this.button_sendtouser.Name = "button_sendtouser";
            this.button_sendtouser.Size = new System.Drawing.Size(248, 48);
            this.button_sendtouser.TabIndex = 8;
            this.button_sendtouser.Text = "Послать сообщение выбранному пользователю";
            this.button_sendtouser.UseVisualStyleBackColor = true;
            this.button_sendtouser.Click += new System.EventHandler(this.button_sendtouser_Click);
            // 
            // button_addnewuser
            // 
            this.button_addnewuser.Location = new System.Drawing.Point(23, 73);
            this.button_addnewuser.Name = "button_addnewuser";
            this.button_addnewuser.Size = new System.Drawing.Size(198, 33);
            this.button_addnewuser.TabIndex = 9;
            this.button_addnewuser.Text = "Присоединиться к чату";
            this.button_addnewuser.UseVisualStyleBackColor = true;
            this.button_addnewuser.Click += new System.EventHandler(this.button_addnewuser_Click);
            // 
            // comboBox_rooms
            // 
            this.comboBox_rooms.FormattingEnabled = true;
            this.comboBox_rooms.Location = new System.Drawing.Point(36, 188);
            this.comboBox_rooms.Name = "comboBox_rooms";
            this.comboBox_rooms.Size = new System.Drawing.Size(248, 24);
            this.comboBox_rooms.TabIndex = 10;
            this.comboBox_rooms.DropDown += new System.EventHandler(this.comboBox_rooms_DropDown);
            // 
            // comboBox_users
            // 
            this.comboBox_users.FormattingEnabled = true;
            this.comboBox_users.Location = new System.Drawing.Point(38, 469);
            this.comboBox_users.Name = "comboBox_users";
            this.comboBox_users.Size = new System.Drawing.Size(246, 24);
            this.comboBox_users.TabIndex = 11;
            this.comboBox_users.DropDown += new System.EventHandler(this.comboBox_users_DropDown);
            // 
            // textBox_roomname
            // 
            this.textBox_roomname.Location = new System.Drawing.Point(36, 328);
            this.textBox_roomname.Name = "textBox_roomname";
            this.textBox_roomname.Size = new System.Drawing.Size(248, 22);
            this.textBox_roomname.TabIndex = 12;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(23, 36);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(198, 22);
            this.textBox_name.TabIndex = 13;
            // 
            // richTextBox_text
            // 
            this.richTextBox_text.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_text.Location = new System.Drawing.Point(331, 19);
            this.richTextBox_text.Name = "richTextBox_text";
            this.richTextBox_text.Size = new System.Drawing.Size(827, 375);
            this.richTextBox_text.TabIndex = 14;
            this.richTextBox_text.Text = "";
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(331, 471);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(827, 22);
            this.textBox_message.TabIndex = 15;
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(685, 520);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(153, 44);
            this.button_send.TabIndex = 16;
            this.button_send.Text = "Послать сообщение комнате";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1016, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "Отключиться от чата";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_quitroom
            // 
            this.button_quitroom.Location = new System.Drawing.Point(331, 520);
            this.button_quitroom.Name = "button_quitroom";
            this.button_quitroom.Size = new System.Drawing.Size(163, 44);
            this.button_quitroom.TabIndex = 18;
            this.button_quitroom.Text = "Покинуть текущую комнату";
            this.button_quitroom.UseVisualStyleBackColor = true;
            this.button_quitroom.Click += new System.EventHandler(this.button_quitroom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Введите своё сообщение здесь: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Список активных комнат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Название комнаты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Список активных пользователей";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button_addnewuser);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Location = new System.Drawing.Point(38, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 119);
            this.panel1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Введите ваш логин";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_quitroom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.richTextBox_text);
            this.Controls.Add(this.textBox_roomname);
            this.Controls.Add(this.comboBox_users);
            this.Controls.Add(this.comboBox_rooms);
            this.Controls.Add(this.button_sendtouser);
            this.Controls.Add(this.button_addroom);
            this.Controls.Add(this.button_entertheroom);
            this.Name = "Form1";
            this.Text = "Чат";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button_entertheroom;
        public System.Windows.Forms.ComboBox comboBox_rooms;
        public System.Windows.Forms.ComboBox comboBox_users;
        public System.Windows.Forms.TextBox textBox_roomname;
        public System.Windows.Forms.TextBox textBox_name;
        public System.Windows.Forms.Button button_addnewuser;
        public System.Windows.Forms.Button button_sendtouser;
        public System.Windows.Forms.Button button_addroom;
        public System.Windows.Forms.RichTextBox richTextBox_text;
        public System.Windows.Forms.TextBox textBox_message;
        public System.Windows.Forms.Button button_send;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_quitroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}

