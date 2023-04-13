namespace MVCBasics.Services
{
    public class EncryptionService : IEncryptionService
    {

        public string Encrypt(string input, string key)
        {
            string encryptedText = "";
            for (int i = 0; i < input.Length; i++)
            {
                encryptedText += (char)(input[i] ^ key[i % key.Length]);
            }
            return encryptedText;
        }
        public string Decrypt(string input, string key)
        {
            return Encrypt(input, key);
        }

        //The controller does not need these methods
        public string Method1()
        {
            return "Method1";
        }
        public string Method2()
        {
            return "Method2";
        }
        public string Method3()
        {
            return "Method3";
        }
    }
}
