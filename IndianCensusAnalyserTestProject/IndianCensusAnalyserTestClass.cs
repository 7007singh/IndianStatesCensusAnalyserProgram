using IndianCensus.DTO;
using IndianCensus;
using IndianStateCensusAnalyser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using IndiaCensusDataDemo;

namespace IndianCensusAnalyserTestProject
{
    [TestClass]
    public class IndianCensusAnalyserTestClass
    {
        Dictionary<string, CensusDTO> dict = new Dictionary<string, CensusDTO>();
        CSVAdapterFactory factory = new CSVAdapterFactory();
        string indianPopulation = @"C:\Users\Shweta\source\repos\IndianStatesCensusAnalyserProgram\IndianStatesCensusAnalyserProgram\CSVFile\IndianStateCensusData.csv";
        string incorrectFile = @"C:\Users\Shweta\source\repos\IndianStatesCensusAnalyserProgram\IndianStatesCensusAnalyserProgram\CSVFile\IndianCensus.txt";
        
        [TestMethod]
        public void Given_CSVFile_Should_Return_NoOfRecord()
        {
            dict = factory.LoadCsvData(CensusAnalyser.Country.INDIA, indianPopulation, "State,Population,AreaInSqKm,DensityPerSqKm");
            Assert.AreEqual(29, dict.Count);
        }
        [TestMethod]
        public void Given_State_CensusCSVFile_If_Incorrect_Returns_FileNotFound_Exception()
        {
            var result = Assert.ThrowsException<CensusAnalyserException>(() => factory.LoadCsvData(CensusAnalyser.Country.INDIA, incorrectFile, "State,Population,AreaInSqKm,DensityPerSqKm"));
            Assert.AreEqual("File Not Found", result.Message);
        }
    }
}
