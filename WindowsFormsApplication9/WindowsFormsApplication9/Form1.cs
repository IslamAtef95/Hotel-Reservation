using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        // declarations of useful variables
        List<Reserve> reserve;
        FileStream haha;
        int Regular;
        int suite;
        int Full;
        int Half;
        
        bool max_image;
        int count;
        
        public Form1()
        {
            // initialization of prices and reservations list
            
            max_image = false;
            Regular = 1200;
            suite = 3000;
            Full = 2;
            Half = 1;
            reserve = new List<Reserve>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\islam\Documents\Visual Studio 2015\Projects\WindowsFormsApplication9\WindowsFormsApplication9\bin\Release\30cal5.wav");
            simpleSound.Play();
            
            this.Width = 556;
            this.Height = 432;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // control of file database at start
            if (File.Exists(@"D:\database.txt") == false)
            {
                haha = new FileStream(@"D:\database.txt", FileMode.Create);
                count = 0;
            }
            else
            {
                haha = new FileStream(@"D:\database.txt", FileMode.Open);
            }
            
            // reading old reservations from the file
            StreamReader k = new StreamReader(haha);
            while (k.EndOfStream == false)
            {
                Reserve temp = new Reserve();
                count = int.Parse(k.ReadLine());
                temp.name = k.ReadLine();
                temp.room.roomno = int.Parse(k.ReadLine());
                temp.Checkin = DateTime.Parse(k.ReadLine());
                temp.Checkout = DateTime.Parse(k.ReadLine());
                temp.num = int.Parse(k.ReadLine());
                temp.room.reserved = true;
                reserve.Add(temp);
            }
            k.Close();
            haha.Close();
            // background music
            SoundPlayer simpleSound = new SoundPlayer(@"D:\Soft-background-music.wav");
            simpleSound.Play();
            menu();
        }

        // Replay button
        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"D:\Soft-background-music.wav");
            simpleSound.Play();
        }

        // Reservation button
        private void button3_Click(object sender, EventArgs e)
        {
            resize_min();
            // control visibility of group boxes and items
            Reserve.Visible = true;
            can.Visible = false;
            all.Visible = false;
            pictureBox1.Visible = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // register the reservation
            Reserve temp = new Reserve();
            resize_min();
            temp.room.roomno = int.Parse(textBox2.Text);
            temp.name = name.Text;
            temp.Checkin = indate.Value;
            temp.Checkout = outdate.Value;
            temp.room.reserved = true;
            temp.num = 110 + count;
            if (check (temp) == false)
            {
                
                if (temp.room.roomno > 600)
                {
                    MessageBox.Show("Out of range");
                }
                else if (temp.room.roomno >= 501 && temp.room.roomno <= 600 && regular.Checked == true)
                {
                    MessageBox.Show(temp.room.roomno + " is a Suite room");
                }
                else if (temp.room.roomno >= 0 && temp.room.roomno <= 500 && Suite.Checked == true)
                {
                    MessageBox.Show(temp.room.roomno + " is a Regular room");
                }
                else
                {
                    reserve.Add(temp);
                    MessageBox.Show("Reservation is done Price: " + price(temp) + " Reservation number: " + temp.num);
                    count++;
                    menu();
                    name.Clear();
                    textBox2.Clear();
                }
            }
            Suite.Checked = false;
            regular.Checked = false;
            full.Checked = false;
            half.Checked = false;
        }

        // Exit button
        private void button5_Click_1(object sender, EventArgs e)
        {
            // write all reservations in the file when the button is pressed
            FileStream hehe;
            hehe = new FileStream(@"D:\database.txt", FileMode.Create);
            StreamWriter k = new StreamWriter(hehe);
            
            foreach (Reserve h in reserve)
            {
                if (h.room.reserved == true)
                {
                    k.WriteLine(count);
                    k.WriteLine(h.name);
                    k.WriteLine(h.room.roomno);
                    k.WriteLine(h.Checkin);
                    k.WriteLine(h.Checkout);
                    k.WriteLine(h.num);
                }
            }
            MessageBox.Show("******************SAYONARA*****************");
            k.Close();
            hehe.Close();
            this.Close();
        }

        // displays the main menu
        public void menu()
        {
            button3.Visible = true;
            cancel.Visible = true;
            button7.Visible = true;
            empty.Visible = true;
            checkB.Visible = true;
            Reserve.Visible = false;
            can.Visible = false;
        }

        // Check the availability of the room
        public bool check(Reserve x)
        {
            int count = 0;
            
                foreach (Reserve k in reserve)
                {
                    if (k.room.roomno == x.room.roomno)
                    {
                        if (k.room.reserved)
                        {
                            if (x.Checkin <= k.Checkout && x.Checkin >= k.Checkin)
                            {
                                count = 1;
                                MessageBox.Show("This room is reserved from " + k.Checkin + " To " + k.Checkout);
                            }
                            else if (x.Checkout <= k.Checkout && x.Checkout >= k.Checkin)
                            {
                                count = 1;
                                MessageBox.Show("This room is reserved from " + k.Checkin + " To " + k.Checkout);
                            }

                        }
                    }
                }
                
            
            if (count == 1 )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // calculate the price
        public int price(Reserve temp)
        {
            int no_of_days = temp.Checkout.DayOfYear - temp.Checkin.DayOfYear;
            
            if (Suite.Checked)
            {
                if (full.Checked)
                {
                    return no_of_days * suite * Full;
                }
                else
                {
                    return no_of_days * suite * Half;
                }
            }
            else
            {
                if (full.Checked)
                {
                    return no_of_days * Regular * Full;
                }
                else
                {
                    return no_of_days * Regular * Half;
                }
            }
        }

        // Cancel Reservation button
        private void cancel_Click(object sender, EventArgs e)
        {
            resize_min();
            Reserve.Visible = false;
            can.Visible = true;
            c.Visible = true;
            c1.Visible = false;
            all.Visible = false;
            pictureBox1.Visible = false;
        }

        // Confirmation of reservation cancel
        private void button6_Click(object sender, EventArgs e)
        {
            // process of canceling reservation
            int y = 0;
            int x = int.Parse(name1.Text);
            foreach(Reserve k in reserve)
            {
                if (k.num == x)
                {
                   if (k.room.reserved == true)
                    {
                        k.room.reserved = false;
                        y++;
                        MessageBox.Show("Reservation is canceled");
                        menu();
                    }
                }
            }
            if (y == 0)
            {
                MessageBox.Show("Their is no reservation with this number");
            }
        }

        // display all reservations
        private void button7_Click(object sender, EventArgs e)
        {
            resize_max();
            Reserve.Visible = false;
            can.Visible = false;
            all.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            foreach (Reserve k in reserve)
            {
                if (k.room.reserved == true)
                {
                    all.Text += "Name: " + k.name + " Room: " + k.room.roomno + " From : " + k.Checkin + " To: " + k.Checkout + "\r\n";
                }
            }
        }

        private void Suite_CheckedChanged(object sender, EventArgs e)
        {
            // display image of suite
            resize_max();
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            can.Visible = false;
            all.Visible = false;
        }

        private void regular_CheckedChanged(object sender, EventArgs e)
        {
            // display image of regular room
            resize_max();
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            can.Visible = false;
            all.Visible = false;
        }

        public void resize_max()
        {
            if (max_image == false)
            {
                this.Width += 400;
                max_image = true;
            }
        }

        public void resize_min()
        {
            if (max_image)
            {
                this.Width -= 400;
                max_image = false;
                all.Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resize_min();
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\islam\Documents\Visual Studio 2015\Projects\WindowsFormsApplication9\WindowsFormsApplication9\bin\Release\30cal5.wav");
            simpleSound.Play();
            reserve = new List<Reserve>();
            MessageBox.Show("The hotel is now empty");
        }

        private void checkB_Click(object sender, EventArgs e)
        {
            resize_min();
            Reserve.Visible = false;
            can.Visible = true;
            c1.Visible = true;
            c.Visible = false;
            all.Visible = false;
            pictureBox1.Visible = false;
        }

        private void c1_Click(object sender, EventArgs e)
        {
            int y = 0;
            int x = int.Parse(name1.Text);
            foreach (Reserve k in reserve)
            {
                if (k.num == x)
                {
                    if (k.room.reserved == true)
                    {
                        MessageBox.Show("Name:" + k.name + "\r\n" + "Room: " + k.room.roomno + "\r\n" + "From: " + k.Checkin + "\r\n" + "To: " + k.Checkout);
                        menu();
                        y = 1;
                    }
                }
            }
            if (y == 0)
            {
                MessageBox.Show("Their is no reservation with this number");
            }
        }
    }
}
