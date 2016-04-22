using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Windows.Forms;
using GettingStartedClient.ServerChat;

namespace GettingStartedClient
{
    
    public partial class Form1 : Form
    {
        public delegate void NewMS(string mes);
        Listener listener = new Listener();
        public string current_room = "";
        public string message = "";
        public List<string> users = new List<string>();
        public List<string> rooms = new List<string>();
        public List<string> messages = new List<string>();
        public static RichTextBox text { get; private set; }
        
        public Form1()
        {
            InitializeComponent();
            text = this.richTextBox_text;
            listener.StartClient(this);
        }
        public void showmessage(string message)
        {
            richTextBox_text.AppendText("\n" + message);
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            string message = textBox_message.Text;
            listener.NewMessage(current_room, message);
        }
        private void button_sendtouser_Click(object sender, EventArgs e)
        {
            listener.NewPrivateMessage(textBox_message.Text, comboBox_users.SelectedItem.ToString());
            string mes = textBox_message.Text;
            mes = mes.Remove(0, textBox_name.Text.Length);
            richTextBox_text.AppendText("\n Сообщение для пользователя" + comboBox_users.SelectedItem.ToString() + mes);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            listener.DeleteUser(textBox_name.Text);
        }

        private void button_addroom_Click(object sender, EventArgs e)
        {
            listener.NewRoom(textBox_roomname.Text);
        }
        private void RenewRooms()
        {
            comboBox_rooms.Items.Clear();
            foreach (string s in rooms)
                if (!comboBox_rooms.Items.Contains(s))
                {
                    comboBox_rooms.Items.Add(s);
                }
        }

        private void RenewClients()
        {
            comboBox_users.Items.Clear();
            foreach (string s in users)
                if (!comboBox_users.Items.Contains(s))
                {
                    comboBox_users.Items.Add(s);
                }
        }

        private void button_addnewuser_Click(object sender, EventArgs e)
        {
            listener.NewUserArrived(textBox_name.Text);
            textBox_message.Text = textBox_name.Text + ": ";
            showmessage("Вы подключились к чату. Ваш логин: " + textBox_name.Text);
            textBox_name.Enabled = false;
            button_addnewuser.Enabled = false;
        }

        private void button_entertheroom_Click(object sender, EventArgs e)
        {
            current_room = comboBox_rooms.SelectedItem.ToString();
            listener.RoomEnter(current_room, textBox_name.Text);
            showmessage("Вы вошли в комнату: " + current_room);
            button_send.Enabled = true;
        }

        private void comboBox_users_DropDown(object sender, EventArgs e)
        {

            RenewClients();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            listener.GotMessageEvent += new GotMessageDelegate(listener.send);
            listener.GotPrivateMessageEvent += new GotPrivateMessageDelegate(listener.Send_Private);
            listener.GotUserToAddEvent += new GotUserToAddDelegate(listener.AddNewUser);
            listener.GotRoomAddEvent += new GotRoomAddDelegate(listener.AddNewRoom);
            listener.GotRoomEnterEvent += new GotRoomEnterDelegate(listener.EnterRoom);
            listener.GotUserToDeleteEvent += new GotUserToDeleteDelegate(listener.DeleteUser);
            listener.GotRoomDeleteEvent += new GotRoomDeleteDelegate(listener.Quit_Room);
            richTextBox_text.AppendText("Чтобы начать общение в чате, заполните форму регистрации." +
                "\nПодключитесь к существующей комнате или создайте новую." +
                "\nДля приватного общения выберите имя активного пользователя из списка и нажмите на кнопку Послать сообщение выбранному пользователю");
        }

        private void comboBox_rooms_DropDown(object sender, EventArgs e)
        {
            RenewRooms();
        }

        

        private void button_quitroom_Click(object sender, EventArgs e)
        {
            listener.Quit_Room(current_room, textBox_name.Text);
            showmessage("Вы покинули комнату " + current_room + ". Вы больше не будете получать сообщения от этой комнаты.");
        }
    }
}
