namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                try
                {
                    
                    BankAccount account = new BankAccount(
                        accountNumber: 1001,
                        fullName: "Mohamed Hassan",
                        nationalID: "29801012345678",
                        phoneNumber: "01123456789",
                        address: "Shebin El Kom",
                        balance: 2500.50
                    );

                  
                    account.ShowAccountDetails();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error"+ex.Message);
                }
            }
        }

    }
