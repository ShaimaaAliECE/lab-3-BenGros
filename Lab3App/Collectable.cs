using System;
using System.Collections.Generic;
namespace Lab3App
{
    public abstract class Collectable : Displayable
	{
		private string description;

		public String Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}

		public CollectionBoard Board = new CollectionBoard();
		public Collectable(string description)
		{
			this.description = description;
		}
		public abstract void Display();

		public virtual void AddMe(List<Collectable> list)
		{
			list.Add(this);
			Console.WriteLine(Description+" Collected, Congrats!!!!");
		}

	}
}

