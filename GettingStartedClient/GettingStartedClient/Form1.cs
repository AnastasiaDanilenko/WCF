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
        ClienChatCallbackHandler callback = new ClienChatCallbackHandler();
        public string current_room = "";
        public string message1 = "";
        public List<string> users = new List<string>();
        public List<string> rooms = new List<string>();
        public List<string> messages = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            listener.StartClient(callback);
        }
        public void showmessage(string message)
        {
            richTextBox_text.AppendText("\n" + message);
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            string message = "\n" + textBox_message.Text;
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
        private void Renew(List<string> new_users, List<string> new_rooms) 
        {
            users = new_users.ToList();
            rooms = new_rooms.ToList();           
        }


        private void button_addnewuser_Click(object sender, EventArgs e)
        {
            listener.NewUserArrived(textBox_name.Text);
            textBox_message.Text = textBox_name.Text + ": ";
            showmessage("\nВы подключились к чату. Ваш логин: " + textBox_name.Text);
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
            foreach (string s in users)
                if (!comboBox_users.Items.Contains(s))
                {
                    comboBox_users.Items.Add(s);
                }
        }

        private void GotMessMeth(string message)
        {
            if (richTextBox_text.InvokeRequired)
            {
                richTextBox_text.BeginInvoke(new NewMS(GotMessMeth), message);
            }
            else
                richTextBox_text.AppendText("\n" + message);
        }

        private void GotPrivateMeth(string message)
        {
            if (richTextBox_text.InvokeRequired)
            {
                richTextBox_text.BeginInvoke(new NewMS(GotPrivateMeth), message);
            }
            else
                richTextBox_text.AppendText("\nПринято приватное сообщение от пользователя " + message);
        }

        public void Add_room(string room)
        {
            rooms.Add(room);
            if (richTextBox_text.InvokeRequired)
            {
                richTextBox_text.BeginInvoke(new NewMS(Add_room), room);
            }
            else
            {
                string message = "\nОткрылась новая комната: " + room;
                richTextBox_text.AppendText("\n" + message);
            }
        }

        private void New_user(string clients)
        {
            users.Add(clients);
            if (richTextBox_text.InvokeRequired)
            {
                richTextBox_text.BeginInvoke(new NewMS(New_user), clients);
            }
            else
            {
                string message = "\nК чату присоединился новый пользователь: " + clients;
                richTextBox_text.AppendText("\n" + message);
            }
        }

        private void Room_deleted(string name)
        {
            if (comboBox_rooms.InvokeRequired)
            {
                comboBox_rooms.BeginInvoke(new NewMS(Room_deleted), name);
            }
            else
                comboBox_rooms.Items.Remove(name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //callback.GotMess -= GotMessMeth;

            callback.GotMess += GotMessMeth;
            callback.GotPrivate += GotPrivateMeth;
            callback.GotUpd += Renew;
            callback.GotRoomOpened += Add_room;
            callback.GotUserArrived += new GotUserArrivedDelegate(New_user);
            callback.GotUserDelete += new GotUserDeleteDelegate(Room_deleted);
            callback.GotRDelete += new GotRDeleteDelegate(Room_deleted);

            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            listener.GotMessageEvent += new GotMessageDelegate(listener.send);
            listener.GotPrivateMessageEvent += new GotPrivateMessageDelegate(listener.Send_Private);
            listener.GotUserToAddEvent += new GotUserToAddDelegate(listener.AddNewUser);
            listener.GotRoomAddEvent += new GotRoomAddDelegate(listener.AddNewRoom);
            listener.GotRoomEnterEvent += new GotRoomEnterDelegate(listener.EnterRoom);
            listener.GotUserToDeleteEvent += new GotUserToDeleteDelegate(listener.Delete);
            listener.GotRoomDeleteEvent += new GotRoomDeleteDelegate(listener.Quit_Room);
            richTextBox_text.AppendText("Чтобы начать общение в чате, заполните форму регистрации." +
                "\n\nПодключитесь к существующей комнате или создайте новую." +
                "\n\nДля приватного общения выберите имя активного пользователя из списка и нажмите на кнопку Послать сообщение выбранному пользователю");
        }

        private void comboBox_rooms_DropDown(object sender, EventArgs e)
        {
            foreach (string s in rooms)
                if (!comboBox_rooms.Items.Contains(s))
                {
                    comboBox_rooms.Items.Add(s);
                }
        }

        

        private void button_quitroom_Click(object sender, EventArgs e)
        {
            listener.Quit_Room(current_room, textBox_name.Text);
            showmessage("\nВы покинули комнату " + current_room + ". Вы больше не будете получать сообщения от этой комнаты.");
        }
    }
}
