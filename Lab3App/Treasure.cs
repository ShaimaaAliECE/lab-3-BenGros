using System;
using System.Collections.Generic;

namespace Lab3App
{
	public abstract class Treasure : Collectable
	{
		private int score;
		public Treasure(string description, int score) : base(description)
		{
			this.score = score;
		}

		public void UpdateTotalScore()
		{
			Board.TotalScore = Board.TotalScore + score;
			Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
		}

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
			UpdateTotalScore();
        }


    }
}

