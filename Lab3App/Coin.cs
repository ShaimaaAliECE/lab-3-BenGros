using System;
using System.Collections.Generic;

namespace Lab3App
{
	public class Coin : Treasure
	{
		private int value;
		public Coin(string description, int score, int value) : base(description,score)
		{
			this.value = value;
		}

		public void UpdateTotalValue()
		{
			Board.TotalValue = Board.TotalValue + value;
			Console.WriteLine("Total Value is updated to: " + Board.TotalValue);
		}

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
			UpdateTotalValue();
        }

        public override void Display()
		{
			Console.WriteLine(this.GetType().Name + " " + this.Description + " is displayed");

		}
	}
}

