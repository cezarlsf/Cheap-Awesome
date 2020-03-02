using System;
using System.Collections.Generic;
using System.Text;

namespace CheapAwesome.Domain
{
	/// <summary>
	/// Class used for various validation that are needed in the domain
	/// </summary>
	public static class Validators
	{
		//validate various data, here we will validate the code
		public static void ValidateCode(string code)
		{
			//here we either check if the code is correct or we just use some other auth. method
			//i will just check if the code is not null or empty for simplicity 

			if (string.IsNullOrEmpty(code))
			{
				throw new ArgumentNullException("some custom message");
			}
		}
	}
}
