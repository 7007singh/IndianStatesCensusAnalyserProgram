using IndianCensus.DTO;
using IndianCensus;
using IndianStateCensusAnalyser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace IndianCensusAnalyserTestProject
{
    [TestClass]
    public class IndianCensusAnalyserTestClass
    {
        Dictionary<string, CensusDTO> dict = new Dictionary<string, CensusDTO>();
        CSVAdapterFactory factory = new CSVAdapterFactory();
        string indianPopulation = @"C:\Users\Shweta\source\repos\IndianStatesCensusAnalyserProgram\IndianStatesCensusAnalyserProgram\CSVFile\IndianStateCensusData.csv";

        [TestMethod]
        public void Given_CSVFile_Should_Return_NoOfRecord()
        {
            dict = factory.LoadCsvData(CensusAnalyser.Country.INDIA, indianPopulation, "State,Population,AreaInSqKm,DensityPerSqKm");
            Assert.AreEqual(29, dict.Count);
        }
    }
}
