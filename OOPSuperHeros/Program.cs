using System;

namespace OOPSuperHeros
{
    class Program
    {
        class Player
        {
            string name;
            int hp;
            public Player(string _name)
            {
                name = _name;
                Random rnd = new Random();
                hp = rnd.Next(100, 151);
            }
            public void SayHello()
            {
                Console.WriteLine($"{name} says hello!");
            }
            public void ShowHP()
            {
                Console.WriteLine($"{name}'s HP: {hp}");
            }
            public int MakeDamage()
            {
                Random rnd = new Random();
                return rnd.Next(10, 51);
            }
            public void Takedamage(int damage)
            {
                if (hp <= 0)
                {
                    hp = 0;
                }else
                {
                    hp = hp - damage;
                }
            }
            public int HP
            {
                get{ return hp; }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Name character one:");
            string characterone = Console.ReadLine();
            Console.WriteLine("Name character two:");
            string charactertwo = Console.ReadLine();


            Player Playerone = new Player(characterone);
            Player playertwo = new Player(charactertwo);
            Playerone.SayHello();
            Playerone.ShowHP();
            playertwo.SayHello();
            playertwo.ShowHP();

            for(int i = 0; i < 3; i++)
            {
                Playerone.Takedamage(playertwo.MakeDamage());
                playertwo.Takedamage(Playerone.MakeDamage());
                Playerone.ShowHP();
                playertwo.ShowHP();
            }
            if (Playerone.HP > playertwo.HP)
            {
                Console.WriteLine($"{characterone} won !");
            }
            else if (Playerone.HP < playertwo.HP)
            {
                Console.WriteLine($"{charactertwo} won !");
            }
            else
            {
                Console.WriteLine("it's a tie!");
            }

        }
    }
}
