using _06_Oobj.src.Entities;

namespace dotnet__poo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Knight arus = new Knight("Arus",23,"Knight", "Humano", "Metal");
            arus.LevelPower=15;
            arus.LevelDefense=20;
            arus.ContainsSword=true;
            arus.DualBlades=false;
            arus.NameSword="Espada do Amanhece";

            Console.WriteLine(arus.FullSheet());
            Console.WriteLine("========================");
            Console.WriteLine(arus.Attack());
            Console.WriteLine("========================");
            Console.WriteLine(arus.Attack(7));
            Console.WriteLine("========================");
            

            Wizard wizard = new Wizard("Jenica",23,"White wizard", "Elfa", "Fogo");
            wizard.LevelPowerMagic=30;
            wizard.LevelDefense=10;
            wizard.MagicStaff=false;
            wizard.MagicWand=false;
            wizard.NameMagicWand="Avara QueRrabar";

            Console.WriteLine(wizard.FullSheet());
            Console.WriteLine("========================");
            Console.WriteLine(wizard.Attack());
            Console.WriteLine("========================");
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine("========================");
            Console.WriteLine();
            

            Necromante necron = new Necromante("Solom Black",80,"Necromante", "Devil", "Chamas Negras",true);
            necron.DifficultyLevel = (arus.LevelPower + wizard.LevelPowerMagic );
            /*necron.DifficultyLevel = (8 );*/
            Console.WriteLine(necron.FullSheet());


           
            
        }
    }
}