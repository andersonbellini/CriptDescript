namespace CriptDecript
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "AndersonBellini"; // Data to save
            var password = "CriptDecript"; //Key To Use for recover data
            var strEncryptred = Bellini.Encrypt(str, password);
            var strDecrypted = Bellini.Decrypt(strEncryptred, password);
        }

    }
}
