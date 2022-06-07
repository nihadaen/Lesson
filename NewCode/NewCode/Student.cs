using System;

namespace NewCode
{
    public class Student
    {
        private int _no;
        private string _fullName;
        private int _point;

        public static int Index;

        public Student()
        {
            Index++;
            _no = Index;
        }

        public int No
        {
            get => _no;
            set
            {
                _no = value;
            }
        }
        public string FullName
        {
            get => _fullName;
            set
            {
                if (CheckName(value))
                {
                    _fullName = value;
                }
            }
        }
        public int Point
        {
            get => _point;
            set
            {
                if (value >= 0 && value <= value)
                {
                    _point = value;
                }
            }
        }
        public bool CheckName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsUpper(name[0]) && name.Length >= 3)
                {
                    if (name[i].Equals(' '))
                    {
                        if (Char.IsUpper(name[i+1]))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        
    }
}