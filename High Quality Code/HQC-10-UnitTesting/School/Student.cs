﻿namespace School
{
    using System;
    using System.Linq;

    public class Student
    {
        private string name;
        private int id;

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value != null && value != string.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException("Name cannot be missing!");
                }
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value >= 10000 && value <= 99999)
                {
                    this.id = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Student's Id" + this.Name +
                        "should be between 10000 and 99999!");
                }
            }
        }
    }
}