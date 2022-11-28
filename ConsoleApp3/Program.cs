// See https://aka.ms/new-console-template for more information
class student
{
    public string name;
    public int weight;

    public student(string modelName, int modelweight)
    {
        name = modelName;
        weight = modelweight;

    }
    static void Manin(string[] args)
    {
        student student1 = new student("top", 79);
        student student2 = new student("palm", 60);
        student student3 = new student("ter", 61);
        student student4 = new student("pee", 62);
        student student5 = new student("ta", 60);
        int[] weightList = { student1.weight, student2.weight, student3.weight, student4.weight, student5.weight };
        int max = weightList.Max();
        int min = weightList.Min();
        Console.WriteLine("แสดงค่าเฉลี่ยน้ำหนักของนักศึกษาทั้งหมด" + (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 5);
        Console.WriteLine("แสดงชื่อและน้ำหนักของคนที่มีน้ำหนักมากที่สุด" + max);
        Console.WriteLine("แสดงชื่อและน้ำหนักของคนที่มีน้ำหนักน้อยที่สุด" + min);
        Console.WriteLine("นาย ธนาพร ชนิดกุล 653450092-2:");


    }
}
