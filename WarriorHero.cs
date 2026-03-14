namespace Arena 
{
	public class WarriorHero : BaseHero 
	{
		public WarriorHero(string name ,int health,string power,int damage): base (name , health ,power,damage ){}
		public override void Attack()
		{
			Console.WriteLine($"{Name} pushes the opponent and shouts: 'The worst thing about prison was {SpecialPower}!'");
            Console.WriteLine($"{Name} dealt {Damage} physical damage!");
		}
	}
}