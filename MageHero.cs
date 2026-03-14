namespace Arena
{
	public class MageHero : BaseHero
	{
		public MageHero(string name ,int health,string power,int damage): base (name , health ,power,damage ){}
		public override void Attack()
		{
			Console.WriteLine($"{Name} casts a {SpecialPower} spell, shouting: 'FALSE! Identity theft is not a joke!'");
            Console.WriteLine($"{Name} dealt {Damage} magic damage!");
		}
	}
}