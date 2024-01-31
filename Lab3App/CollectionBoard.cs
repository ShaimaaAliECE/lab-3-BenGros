using System;
namespace Lab3App
{
	public class CollectionBoard
	{
		private int totalScore;
		private int totalValue;
		public CollectionBoard()
		{
			totalScore = 0;
			totalValue = 0;
		}
		public int TotalScore
		{
			get
			{
				return this.totalScore;
			}
			set
			{
				this.totalScore = value;
			}
		}
		public int TotalValue
		{
			get
			{
				return this.totalValue;
			}
			set
			{
				this.totalValue = value;
			}
		}
	}
}

