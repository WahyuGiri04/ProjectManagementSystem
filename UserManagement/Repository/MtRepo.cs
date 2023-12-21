using System.Globalization;
using System.Transactions;
using CsvHelper;

namespace UserManagement;

public class MtRepo
{
    public readonly DatabaseContext databaseContext;

    public MtRepo(DatabaseContext databaseContext){
        this.databaseContext = databaseContext;
    }

    public List<Mt100Load> LoadDataMT100<T>(Stream file)
    {
        var reader = new StreamReader(file);
        List<Mt100Load> ListDataTemp = [];
        using (TransactionScope Trx = new(TransactionScopeAsyncFlowOption.Enabled))
        {

            string line2 = "";
            List<string> lines = new List<string>();
            while ((line2 = reader.ReadLine()) != null)
            {
                lines.Add(reader.ReadLine());
            }

            string Delimiter = "|";
            try
            {
                int number = 1;

                foreach (string line in lines)
                {
                    if (number == 1)
                    {
                        number++;
                    }
                    else
                    {
                        string[] words = line.Split(Delimiter);
                        // Use a tab to indent each line of the file.
                        Mt100Load Data = new Mt100Load();
                        Data.ClientId = words[0];
                        Data.Code = words[0];
                        Data.Refnumber = words[1];
                        Data.Valuedate = words[2];
                        Data.Ccy = words[3];
                        Data.Amount = words[4];
                        Data.Orderingpartyname = words[5];
                        Data.Orderingpartyaccount = words[6];
                        Data.BeneBankCode = words[7];
                        Data.BeneBankName = words[8];
                        Data.BeneBankAdd1 = words[9];
                        Data.BeneBankAdd2 = words[10];
                        Data.BeneAccountNo = words[11];
                        Data.BeneName = words[12];
                        Data.Remark1 = words[13];
                        Data.Remark2 = words[14];
                        Data.Charge = words[15];
                        Data.Emailbene = words[16];
                        Data.Statusbnidirect = words[17];
                        Data.Statusbnidirectdesc = words[18];
                        Data.Filerefno = words[19];
                        Data.Trxrefno = words[20];
                        Data.Hostjurnal = words[21];
                        ListDataTemp.Add(Data);
                        databaseContext.Add(Data);
                        number++;
                    }
                }
            }
            catch (Exception){
                throw;
            }
        }
        databaseContext.SaveChanges();
        return ListDataTemp;

    }
}
