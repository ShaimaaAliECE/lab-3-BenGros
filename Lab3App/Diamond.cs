﻿using System;
namespace Lab3App
{
	public class Diamond : Treasure
	{
		public Diamond(string description, int score) : base(description,score)
		{

		}

        public override void Display()
        {
            Console.WriteLine(this.GetType().Name + this.Description + " is displayed");
        }
    }
}

