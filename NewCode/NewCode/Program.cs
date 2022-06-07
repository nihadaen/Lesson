using System;

namespace NewCode
{
    public class Program
    { 
        static void Main(string[] args)
        {
             Group group = new Group()
            {
                StudentLimit = 3,
            };
            string num;
            do
            {
                Console.WriteLine("1. Tələbə əlavə et \n" +
                                  "2. Tələbələrin ortalamasına bax \n" +
                                  "3. Tələbələri göstər \n" +
                                  "4. Menudan çıx");
                num = Console.ReadLine();
                if (num == "1")
                {
                    try
                    {
                        Console.WriteLine("Tələbə adını qeyd edin: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Tələbə pointini daxil edin: ");
                        string numPr = Console.ReadLine();
                        int pr = Convert.ToInt32(numPr);
                        Student newStd = new Student()
                        {
                            FullName = name,
                            Point = pr,
                        };
                        group.AddStudent(newStd);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Bilinmədik bir xəta baş verdi.");
                    }
                }
                else if (num == "2")
                {
                    try
                    {
                        Console.WriteLine($"Group average: {group.CalcGroupAvg()}");
                    }
                    catch (Exception exp)
                    {
                        Console.WriteLine("Bilinmədik bir xəta baş verdi.");
                    }
                }
                else if (num == "3")
                {
                    Console.WriteLine("Tələbənin pointinə görə yoxsa no-suna görə görmək istəyirsiz | 1 - point, 2 - no" );
                    string op = Console.ReadLine();
                    int z = Convert.ToInt32(op);
                    if (z == 1)
                    {
                        try
                        {
                            Console.WriteLine("Min dəyər daxil edin: ");
                            string minStr = Console.ReadLine();
                            int x = Convert.ToInt32(minStr);
                            Console.WriteLine("Max dəyər daxil edin: ");
                            string maxStr = Console.ReadLine();
                            int y = Convert.ToInt32(maxStr);
                            Student[] newstds = group.GetStudentsByPoint(x, y);
                            group.ShowInfo(newstds);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Bilinmədik bir xəta baş verdi!");
                        }
                    }
                    else if (z == 2)
                    {
                        try
                        {
                            Console.WriteLine("Student no daxil edin: ");
                            String stdNo = Console.ReadLine();
                            int a = Convert.ToInt32(stdNo);
                            Student student = group.GetStudentByNo(a);
                            Console.WriteLine($"FullName: {student.FullName} - Point: {student.Point} - No: {student.No}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Bilinmədik bir xəta baş verdi!");
                        }
                    }
                }
            } while (num != "4");

            Console.WriteLine("Menudan çıxış edildi!");
        }
    }
}