using IndianCensus;
using IndianCensus.DTO;
using IndianStatesCensusAnalyserProgram.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    public class CensusAnalyser
    {
        public enum Country
        {
            INDIA
        }
        //public Dictionary<string, CensusDTO> datamap;
        //public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        //{
        //    datamap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
        //    return datamap;
        //}
        public Dictionary<string, StateCodeDataDAO> datamap;
        public Dictionary<string, StateCodeDataDAO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            datamap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return datamap;
        }
    }
}
