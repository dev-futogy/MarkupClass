using System;
using System.Drawing;

namespace MarkupClass
{
	public enum PersonalProtectiveType
	{
		All = 0,
		Helmet,
		Vest,
		Nothing,
		NoClass,
	}

	public class GetNameClass
	{

		public PersonalProtectiveType PersonalProtectiveType { get; }

		public GetNameClass(PersonalProtectiveType personalProtectiveType)
		{
			PersonalProtectiveType = personalProtectiveType;
		}

		public GetNameClass(int IdcarType)
		{
			PersonalProtectiveType = (PersonalProtectiveType)IdcarType;
		}

		public override string ToString()
		{
			switch(PersonalProtectiveType)
			{

				case PersonalProtectiveType.All:
					return "All";
				case PersonalProtectiveType.Helmet:
					return "Helmet";
				case PersonalProtectiveType.Vest:
					return "Vest";
				case PersonalProtectiveType.Nothing:
					return "Nothing";
			}
			return base.ToString();
		}
		public Color ToColor()
		{
			switch(PersonalProtectiveType)
			{

				case PersonalProtectiveType.All:
					return Color.Green;
				case PersonalProtectiveType.Helmet:
					return Color.Yellow;
				case PersonalProtectiveType.Vest:
					return Color.Orange;
				case PersonalProtectiveType.Nothing:
					return Color.Red;
			}
			return Color.Black;
		}
	}

}
