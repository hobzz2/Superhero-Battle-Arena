namespace Arena
{
	public class ArcherHero : BaseHero
	{
		public ArcherHero(string name ,int health,string power,int damage): base (name , health ,power,damage ){}
		public override void Attack()
		{
			Console.WriteLine($"{Name} smirks at the camera and launches a perfectly aimed {SpecialPower} from across the room!");
            Console.WriteLine($"{Name} dealt {Damage} ranged damage!");			
		}
	}
}