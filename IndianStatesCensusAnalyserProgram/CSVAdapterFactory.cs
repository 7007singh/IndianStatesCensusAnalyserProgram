﻿using IndiaCensusDataDemo;
using IndianCensus.DTO;
using IndianStateCensusAnalyser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianCensus
{
    public class CSVAdapterFactory
    {
        //public Dictionary<string, CensusDTO> LoadCsvData(CensusAnalyser.Country country, string csvFilePath, string dataHeaders)
        //{
        //    switch (country)
        //    {
        //        case (CensusAnalyser.Country.INDIA):
        //            return new IndianCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);
        //            //case (CensusAnalyser.Country.US):
        //            //    return new USCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);
        //    }
        //    return default;
        //}
        public Dictionary<string, CensusDataDAO> LoadCsvData(CensusAnalyser.Country country, string csvFilePath, string dataHeaders)
        {
            switch (country)
            {
                case (CensusAnalyser.Country.INDIA):
                    return new CensusAnalyser().LoadCensusData(country, csvFilePath, dataHeaders);
                    //case (CensusAnalyser.Country.US):
                    //    return new USCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);
            }
            return default;
        }
    }
}
