namespace NewCode
{
    public interface IGroup
    {
        public Student[] Students { get; }

        public void AddStudent(Student student);

        public int CalcGroupAvg();
    }
}