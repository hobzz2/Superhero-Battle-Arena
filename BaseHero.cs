namespace Arena
{
	public abstract class BaseHero 
	{
		public int Health { get; set ;}
		public int Damage { get; set ;}
		public string Name { get; set ;} 
		public string SpecialPower { get; set ;}
		public BaseHero(string name ,int health,string power,int damage)
		{
			Name = name ;
			Health = health;
			SpecialPower = power;
			Damage = damage;
		}



		public abstract void Attack();
		public  void introduce ()
		{
			Console.WriteLine($"I am {Name}, HP: {Health}, Special Power: {SpecialPower}, Damage : {Damage}");	

		}
	}
}