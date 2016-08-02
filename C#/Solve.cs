using System;
using System.Collections.Generic;
using expr;

namespace solve
{
	abstract class parser_t<T>
	{
		public abstract T to_T (string a);
	}
	class solver_t<T>
	{
		expression<T> opers;
		parser_t<T> parser;
		public solver_t (parser_t<T> parse, expression<T> opers2)
		{
			parser = parse;
			opers = opers2;
		}
		private class Pair<T1, U>
		{
			public Pair() 
			{
			}

			public Pair(T1 first, U second)
			{
				this.First = first;
				this.Second = second;
			}

			public T1 First { get; set; }
			public U Second { get; set; }
		};
		private Pair < string, List <int> > clean (string expr)
		{
			return new Pair < string, List < int > > ();
		}
		public T solve (string expr)
		{
			int min_priority = opers.number_priority;
			int pos = -1;
			foreach (var item in expr) 
			{
				if (opers.operators.IndexOf (item) == -1)
					throw new SystemException ("Undefined operator, digit or bracket!");
				Operation <T> op;
				if (opers.oper.TryGetValue (item, out op)) 
				{
					if (min_priority > op.priority)
				}
			}
			Operation<T> value;
			opers.oper.TryGetValue('+', out value);
			var a = parser.to_T (expr);
			var b = a;
			a = b;
			Console.WriteLine (value.f (a, b));
			return default(T);
		}
	}
}
