namespace HolyWaterWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class HashService : IHashService
    {
        public int HashPassword(string pw)
        {
            unchecked
            {
                int hash1 = 5381;
                int hash2 = hash1;

                for (int i = 0; i < pw.Length && pw[i] != '\0'; i += 2)
                {
                    hash1 = ((hash1 << 5) + hash1) ^ pw[i];
                    if (i == pw.Length - 1 || pw[i + 1] == '\0')
                        break;
                    hash2 = ((hash2 << 5) + hash2) ^ pw[i + 1];
                }

                return hash1 + (hash2 * 1566083941);
            }
        }
    }
}
