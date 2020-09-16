namespace ClassLibrary
{
    public class Class1 : IClass1
    {
        private readonly IClass2 class2;

        public Class1(IClass2 class2)
        {
            this.class2 = class2;
        }

        public void DoStuff()
        {
            class2.DoStuffAswell();
        }
    }
}
