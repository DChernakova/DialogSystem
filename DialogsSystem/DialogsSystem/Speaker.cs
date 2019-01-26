using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DialogsSystem
{

    public static class Speaker
    {        
       //получить рандомно реплику из списка
        
        /// <summary>
        /// Получить фразу с ответами по идентификатору
        /// </summary>
        /// <param name="spId">Идентификатор диалога</param>
        /// <param name="doc">Файл с фразами</param>
        /// <returns></returns>
        public static Speak GetSpeak(string spId, XmlDocument doc)
        {
            Speak res = new Speak();
            XmlElement curSpeak = doc.DocumentElement;
            string xpath = "//Speak[@id=" + spId + "]";
            XmlNode speakNode=  curSpeak.SelectSingleNode(xpath);

            
            res.npcText = speakNode.Attributes["npcText"].Value;
            if (speakNode.SelectNodes("answer").Count!=0)
            {
                
                XmlNodeList answersXml = speakNode.SelectNodes("answer");
               
                res.answers = new List<Answer>();
                for (int i=0;i<answersXml.Count;i++)
                {
                    Answer a = new Answer();
                    a.textUser = answersXml.Item(i).Attributes["text"].Value;
                    a.idNextSpeak= int.Parse(answersXml.Item(i).Attributes["speakId"].Value==""?"0": answersXml.Item(i).Attributes["speakId"].Value);
                    a.isExit = bool.Parse(answersXml.Item(i).Attributes["exit"].Value);
                    res.answers.Add(a);
                }

            }
            
            return res;
        }

        /// <summary>
        /// Получить файл диалогов 
        /// </summary>
        /// <param name="path">Название файла</param>
        /// <returns></returns>
        public static XmlDocument GetXmlSpeaks(string path)
        {
            string filePath= @"C:\\Users\\Диана\\Desktop\\justProject\\DialogsSystem\\DialogsSystem\" +path;
            XmlDocument res = new XmlDocument();
            res.Load(filePath);
            return res;
        }
    }
}
