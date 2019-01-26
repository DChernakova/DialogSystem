namespace DialogsSystem
{
    public class Answer
    {
        /// <summary>
        /// Текст ответа
        /// </summary>
        public string textUser { get; set; }
        /// <summary>
        /// Идентификатор следующей реплики
        /// </summary>
        public int idNextSpeak { get; set; }
        /// <summary>
        /// Признак завершения диалога
        /// </summary>
        public bool isExit { get; set; }

    }
}