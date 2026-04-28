using JurnalModul8_103082400034;

class Program
{
    static void Main(string[] args)
    {
        
        BankTransferConfig config = new BankTransferConfig();

        
        string lang = config.Lang;

        if (lang == "id")
        {
            Console.Write("Masukkan jumlah uang yang akan di-transfer: ");
        }
        else 
        {
            Console.Write("Please insert the amount of money to transfer: ");
        }

        
        string inputAmount = Console.ReadLine() ?? "0";
        long amount;

        if (!long.TryParse(inputAmount, out amount))
        {
            amount = 0;
        }

       
        long transferFee;
        if (amount <= config.Threshold)
        {
            transferFee = config.LowFee;
        }
        else
        {
            transferFee = config.HighFee;
        }

        long totalAmount = amount + transferFee;

       
        if (lang == "id")
        {
            Console.WriteLine($"Biaya transfer = {transferFee}");
            Console.WriteLine($"Total biaya = {totalAmount}");
        }
        else
        {
            Console.WriteLine($"Transfer fee = {transferFee}");
            Console.WriteLine($"Total amount = {totalAmount}");
        }

      
        if (lang == "id")
        {
            Console.WriteLine("Pilih metode transfer:");
        }
        else
        {
            Console.WriteLine("Select transfer method:");
        }

        
        for (int i = 0; i < config.Methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.Methods[i]}");
        }

       
        Console.ReadLine();

        
        string confirmationWord = lang == "id" ? config.ConfirmationId : config.ConfirmationEn;

        if (lang == "id")
        {
            Console.Write($"Ketik \"{confirmationWord}\" untuk mengkonfirmasi transaksi: ");
        }
        else
        {
            Console.Write($"Please type \"{confirmationWord}\" to confirm the transaction: ");
        }

        string confirmationInput = Console.ReadLine() ?? string.Empty;

        
        if (confirmationInput == confirmationWord)
        {
            if (lang == "id")
            {
                Console.WriteLine("Proses transfer berhasil");
            }
            else
            {
                Console.WriteLine("The transfer is completed");
            }
        }
        else
        {
            if (lang == "id")
            {
                Console.WriteLine("Transfer dibatalkan");
            }
            else
            {
                Console.WriteLine("Transfer is cancelled");
            }
        }

        
        Console.WriteLine("\nTekan Enter untuk keluar...");
        Console.ReadLine();
    }
}