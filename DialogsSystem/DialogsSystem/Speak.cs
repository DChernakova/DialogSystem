using System.Collections.Generic;

namespace DialogsSystem
{
    public class Speak
    {
        /// <summary>
        /// Список ответов пользователя
        /// </summary>
        public List<Answer> answers { get; set; }
        /// <summary>
        /// Текст персонажа
        /// </summary>
        public string npcText { get; set; }

    }
}