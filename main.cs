using System ;
using System.Threading;

namespace Arena
{
	public class Program
	{
		static void Main(string[] args )
		{
			BaseHero hero1 = new WarriorHero( "Prison Mike" ,200,"The Dementors",50) ;
			BaseHero hero2 = new MageHero("Dwight Schrute",100,"The Beetroot Curse",80);
			BaseHero hero3 = new ArcherHero("Jim Halpert",150,"Snowball",60);
			List<BaseHero> arena = new List<BaseHero> {hero1,hero2,hero3 };
			Console.WriteLine("""
			=======================================
			Welcome to Superhero Battle Arena!   
			=======================================
			""");
			while( true )
			{
				Console.WriteLine("Do you want to continue ?  ");
				string answer = Console.ReadLine();
				if(answer == "Yes" || answer == "yes")
				{
					Console.WriteLine("""
					=======================================
					Available Fighters:
					1. Prison Mike (Warrior)
					2. Dwight Schrute (Mage)
					3. Jim Halpert (Archer)
					=======================================
					""");
					
					Console.Write("Select your Fighter (1-3): ");
					int attackerIndex;
					while (!int.TryParse(Console.ReadLine(), out attackerIndex) || attackerIndex < 1 || attackerIndex > 3)
					{
						Console.Write("Invalid input! Please enter a number between 1 and 3: ");
					}
					attackerIndex--; 
					Console.Write("Select the Opponent to attack (1-3): ");
					int targetIndex;
					while (!int.TryParse(Console.ReadLine(), out targetIndex) || targetIndex < 1 || targetIndex > 3)
					{
						Console.Write("Invalid input! Please enter a number between 1 and 3: ");
					}
					targetIndex--;
					if(attackerIndex == targetIndex )
						{
							Console.WriteLine("Select a different hero");
							continue;
						}

					BaseHero attacker = arena[attackerIndex];
					attacker.introduce();
					Thread.Sleep(2000);
					BaseHero target = arena[targetIndex];
					target.introduce();
					Thread.Sleep(2000);

					Console.WriteLine("\n--- Battle Action ---");
					attacker.Attack(); 
					Thread.Sleep(2000);
					target.Health -= attacker.Damage; 
					Console.WriteLine($"{target.Name} took {attacker.Damage} damage! Remaining HP: {target.Health}");
					Thread.Sleep(2000);

					if (target.Health <= 0)
					{
						Console.WriteLine($"💀 {target.Name} has been defeated!");
						Thread.Sleep(2000);
					}
					else
					{
						Console.WriteLine($"🛡️ {target.Name} is still standing.");
						Thread.Sleep(2000);
					}
				}
				else if(answer == "No" || answer == "no")
				{
					Console.WriteLine("---Bye Bye---");
					return ;
				}
				else
				{
					Console.WriteLine("Please enter a valid answer ");
				}
			}

			
		}
	}


}