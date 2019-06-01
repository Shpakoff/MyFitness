using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFitness.BL.Model
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    [Serializable]
    public class User
    {
        #region Свойства
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// Дата рождение.
        /// </summary>
        public DateTime BirthData { get; }
        /// <summary>
        /// Рост.
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }
        #endregion
        /// <summary>
        /// Добавление нового пользователя
        /// </summary>
        /// <param name="name">Имя. </param>
        /// <param name="gender">Пол. </param>
        /// <param name="birthData">Дата рождения. </param>
        /// <param name="height">Рост. </param>
        /// <param name="weight">Вес. </param>
        public User(string name, 
                    Gender gender, 
                    DateTime birthData, 
                    double height, 
                    double weight)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Имя пользователя не может быть пустым или null", nameof(name));
            }

            if (gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null", nameof(gender));
            }

            if (birthData < DateTime.Parse("01.09.1910") || birthData > DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения", nameof(birthData));
            }
            if (height < 0)
            {
                throw new ArgumentException("Рост не может быть меньше или равен нулю", nameof(height));
            }
            if (weight < 0)
            {
                throw new ArgumentException("Вес не может быть меньше или равен нулю", nameof(weight));
            }
            #endregion
            Name = name;
            Gender = gender;
            BirthData = birthData;
            Height = height;
            Weight = weight;
        }


        public override string ToString()
        {
            return Name;
        }
    }
   
}
