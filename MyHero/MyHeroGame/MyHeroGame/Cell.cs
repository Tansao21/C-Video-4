using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHeroGame
{
	public enum Cell
	{
		Empty = '*', //пустота
		Wall = '#', //стена
		Portal = 'O', // портал
		Bound = 'X' // граница
	}
}
