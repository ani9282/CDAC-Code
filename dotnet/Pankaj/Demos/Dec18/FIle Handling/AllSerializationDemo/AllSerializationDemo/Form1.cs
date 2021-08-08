using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;//For XML Serialization
using System.Runtime.Serialization.Formatters.Binary;//For Binary Serialization
using System.Runtime.Serialization.Formatters.Soap;//For SOAP Serialization


namespace AllSerializationDemo
{
    public partial class Form1 : Form
    {
        Student s1;
        public Form1()
        {
            InitializeComponent();
        }
        public void AllClear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1 = new Student();
            s1.RollNo = Convert.ToInt32(textBox1.Text);
            s1.Name = textBox2.Text;
            s1.Marks = Convert.ToInt32(textBox3.Text);
           
            AllClear();
            //Binary Serialization
            FileStream fs = new FileStream("Student.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter b1 = new BinaryFormatter();
            b1.Serialize(fs, s1);
            MessageBox.Show("Record Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Student.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter b1 = new BinaryFormatter();
           Student myStud=(Student) b1.Deserialize(fs);
           textBox1.Text = myStud.RollNo.ToString();
           textBox2.Text = myStud.Name;
           textBox3.Text = myStud.Marks.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //XML Serialization
            FileStream fs = new FileStream("Student.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            s1 = new Student();
            s1.RollNo = Convert.ToInt32(textBox1.Text);
            s1.Name = textBox2.Text;
            s1.Marks = Convert.ToInt32(textBox3.Text);
            xs.Serialize(fs, s1);
            AllClear();
            MessageBox.Show("Record Added");

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //XML Deserialization
            FileStream fs = new FileStream("Student.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            Student ms =(Student) xs.Deserialize(fs);
            textBox1.Text = ms.RollNo.ToString();
            textBox2.Text = ms.Name;
            textBox3.Text = ms.Marks.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //SOAP Serialization
            s1 = new Student();
            s1.RollNo = Convert.ToInt32(textBox1.Text);
            s1.Name = textBox2.Text;
            s1.Marks = Convert.ToInt32(textBox3.Text);

            AllClear();
            //Binary Serialization
            FileStream fs = new FileStream("MyStudent.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter b1 = new SoapFormatter();
            b1.Serialize(fs, s1);
            MessageBox.Show("Record Added");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("MyStudent.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter b1 = new SoapFormatter();
            Student myStud = (Student)b1.Deserialize(fs);
            textBox1.Text = myStud.RollNo.ToString();
            textBox2.Text = myStud.Name;
            textBox3.Text = myStud.Marks.ToString();
        }
    }
}
