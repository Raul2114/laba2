namespace ClassVsStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            // Класс
            ClassClass classObject = new ClassClass();
            classObject.a = 1;
            ClassClass classObject2 = classObject;
            classObject2.a = 2;
            Console.WriteLine($"classObject: {classObject.a}, classObject2: {classObject2.a}");

            // Структура
            StructStruct structObject = new StructStruct();
            structObject.SomeValue = 1;
            StructStruct structObject2 = structObject;
            structObject2.SomeValue = 2;
            Console.WriteLine($"structObject: {structObject.SomeValue}, structObject2: {structObject2.SomeValue}");

            Console.ReadKey();
        }
    }

    // Класс
    class ClassClass
    {
        public int a;
    }

    // Структура
    struct StructStruct
    {
        public int SomeValue;
    }
}