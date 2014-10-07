using System;
using System.IO;

namespace AccountApplication
{
	class Bank
	{
		private Account[] Accounts;

		public Account[] GetAccounts()
		{
			return Accounts;
		}

		public void InitializeBank()
		{
			//inicializar el array
			Accounts = new Account[100];
			
			try
	        {
	        	int counter = 0;
	        	//leer los datos desde el archivo
				//en este caso se toma el archivo completo y se guarda en un array
				string[] lines = File.ReadAllLines("bank.txt");

				//se recorre el array para obtener los datos
				foreach(string line in lines){
					string[] temp_account = line.Split(' ');
					Account t_account = new Account();

					t_account.AccountNumber = Convert.ToInt32(temp_account[0]);
					t_account.AccountPass = Convert.ToInt32(temp_account[1]);
					t_account.AccountBalance = Convert.ToInt32(temp_account[2]);
					t_account.AccountType = temp_account[3];

					Accounts[counter] = t_account;

					counter++;
				}
	        }
	        catch (Exception e)
	        {
	            Console.WriteLine("The file could not be read:");
	            Console.WriteLine(e.Message);
	        }
		}
	}
}