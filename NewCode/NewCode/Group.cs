using System;

namespace NewCode
{
    public class Group : IGroup
    {
        private Student[] _students;

        public Student[] Students
        {
            get => _students;
            set
            {
                _students = value;
            }
        }

        private string _groupNo;

        public Group()
        {
            Students = new Student[0];
        }

        public int StudentLimit { get; set; }

        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                    _groupNo = value;
            }
        }

        public static bool CheckGroupNo(string groupNo)
        {
            if (!string.IsNullOrWhiteSpace(groupNo) && groupNo.Length == 4)
            {
                if (char.IsLetter(groupNo[0]))
                {
                    for (int i = 1; i < groupNo.Length; i++)
                    {
                        if (!char.IsDigit(groupNo[i]))
                            return false;
                    }

                    return true;
                }
            }

            return false;
        }

        public int CalcGroupAvg()
        {
            int sum = 0;
            for (int i = 0; i < _students.Length; i++)
            {
                sum += _students[i].Point;
            }

            if (_students.Length != 0)
                return sum / _students.Length;
            return 0;
        }

        public void AddStudent(Student student)
        {
            if (_students.Length < StudentLimit && StudentExist(student))
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
        }

        public Student[] GetStudentsByPoint(int min, int max)
        {
            Student[] stds = new Student[0];
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Point >= min && _students[i].Point <= max)
                {
                    Array.Resize(ref stds, stds.Length + 1);
                    _students[_students.Length - 1] = _students[i];
                }
            }

            return stds;
        }

        public Student GetStudentByNo(int no)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].No.Equals(no))
                {
                    return _students[i];
                }
            }

            return null;
        }

        public bool StudentExist(Student student)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (student == _students[i])
                {
                    return false;
                }
            }
            return true;
        }

        public void ShowInfo(Student[] stds)
        {
            for (int i = 0; i < stds.Length; i++)
            {
                Console.WriteLine($"FullName: {stds[i].FullName} - Point: {stds[i].Point} - No: {stds[i].No}");
            }
        }
    }
}