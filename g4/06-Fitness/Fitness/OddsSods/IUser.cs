using System;
using System.Collections.Generic;
using System.Text;

namespace OddsSods
{
	public interface IUser
	{
		string GetUserName();

		void SetUserName(string value);

		void SetPassword(string value);

		string GetPassword();
	}
}
