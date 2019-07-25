using System;
using System.Collections.Generic;
using System.Text;

namespace ClassmateClass
{
    public class Classmate
    {
        #region Fields
        //fields
        private string name;
        private string favoriteFood;
        private string homeTown;
        private int age;
        //private DateTime birthday;
        #endregion

        #region Properties
        //Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string FavoriteFood
        {
            get
            {
                return favoriteFood;
            }
            set
            {
                favoriteFood = value;
            }
        }
        public string HomeTown
        {
            get
            {
                return homeTown;
            }
            set
            {
                homeTown = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        #endregion

        #region Constructors
        public Classmate()
        {
            //name = "John Doe";
        }

        public Classmate(string _name, string _hometown, string _favoriteFood, int _age)
        {
            name = _name;
            homeTown = _hometown;
            favoriteFood = _favoriteFood;
            age = _age;
        }
        #endregion

        public void PrintInfo()
        {
            Console.WriteLine("Classmate name: " + Name);
            Console.WriteLine("Favorite Food: " + FavoriteFood);
            Console.WriteLine("Hometown: " + HomeTown);
            Console.WriteLine("Age: " + Age);
        }

    }
}
