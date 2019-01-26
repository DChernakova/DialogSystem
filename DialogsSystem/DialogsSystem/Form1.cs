using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DialogsSystem
{
    public partial class Form1 : Form
    {
        XmlDocument curFile = new XmlDocument();

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Список персонажей
            Fisher fs = new Fisher { firstName="Рыбак", Id=1, pathSpeaksFile="SpeaksFisher.xml"};
            
            comboCharacters.Items.Add(fs);
            comboCharacters.DisplayMember = "firstName";
            comboCharacters.ValueMember = "Id";
            
        }

        private void comboCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            Character curChar = (Character)comboCharacters.SelectedItem;
            curFile = Speaker.GetXmlSpeaks(curChar.pathSpeaksFile);
            Speak newSpeak= Speaker.GetSpeak(0, curFile); //получаем первую фразу, которую говорит персонаж
            npcText.Text = newSpeak.npcText;
            listAnswers.DataSource=newSpeak.answers;
            listAnswers.DisplayMember = "textUser";
            listAnswers.ValueMember = "idNextSpeak";
        }
        
        //Выбираем ответ
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Answer nextAnswer = (Answer)listAnswers.SelectedItem;
            if (nextAnswer.isExit != true)
            {
                Speak newSpeak = Speaker.GetSpeak(nextAnswer.idNextSpeak, curFile);
                npcText.Text = newSpeak.npcText;
                listAnswers.DataSource = newSpeak.answers;
            }
            else MessageBox.Show("Диалог окончен");
        }
    }
}
