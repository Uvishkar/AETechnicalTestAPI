using AETechnicalTestAPI;
using NUnit.Framework;

namespace CsvLoader_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            //CsvLoader.SaveToDatabase();
           CsvLoader.CSVDataloader();
            //CsvLoader.InsertDataIntoSQLServerUsingSQLBulkCopy(csvData);
            //Assert.Pass();
        }
    }
}