using IndianCensus.DTO;
using IndianCensus;
using IndianStateCensusAnalyser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using IndiaCensusDataDemo;
using IndianStatesCensusAnalyserProgram.DAO;

namespace IndianCensusAnalyserTestProject
{
    [TestClass]
    public class IndianCensusAnalyserTestClass
    {
        Dictionary<string, StateCodeDataDAO> dict = new Dictionary<string, StateCodeDataDAO>();
        //Dictionary<string, CensusDTO> dict = new Dictionary<string, CensusDTO>();
        CSVAdapterFactory factory = new CSVAdapterFactory();
        //string indianPopulation = @"C:\Users\Shweta\source\repos\IndianStatesCensusAnalyserProgram\IndianStatesCensusAnalyserProgram\CSVFile\IndianStateCensusData.csv";
        //public const string incorrectFile = @"C:\Users\Shweta\source\repos\IndianStatesCensusAnalyserProgram\IndianStatesCensusAnalyserProgram\CSVFile\IndianCensus.txt";
        //public const string incorrectFileType = @"C:\Users\Shweta\source\repos\IndianStatesCensusAnalyserProgram\IndianStatesCensusAnalyserProgram\CSVFile\CensusData.txt";
        //public const string incorrectDelimiter = @"C:\Users\Shweta\source\repos\IndianStatesCensusAnalyserProgram\IndianStatesCensusAnalyserProgram\CSVFile\DelimiterIndiaStateCensusData.csv";
        //public const string incorrectHeader = @"C:\Users\Shweta\source\repos\IndianStatesCensusAnalyserProgram\IndianStatesCensusAnalyserProgram\CSVFile\WrongIndiaStateCensusData.csv";

        //[TestMethod]
        //public void Given_CSVFile_Should_Return_NoOfRecord()
        //{
        //    dict = factory.LoadCsvData(CensusAnalyser.Country.INDIA, indianPopulation, "State,Population,AreaInSqKm,DensityPerSqKm");
        //    Assert.AreEqual(29, dict.Count);
        //}

        //[TestMethod]
        //[DataRow(incorrectHeader, "Incorrect header in Data")]
        //[DataRow(incorrectDelimiter, "File Containers Wrong Delimiter")]
        //[DataRow(incorrectFileType, "Invalid file type")]
        //[DataRow(incorrectFile, "File Not Found")]
        //public void Given_State_CensusCSVFile_If_Incorrect_Returns_FileNotFound_Exception(string file, string expected)
        //{
        //    var result = Assert.ThrowsException<CensusAnalyserException>(() => factory.LoadCsvData(CensusAnalyser.Country.INDIA, file, "State,Population,AreaInSqKm,DensityPerSqKm"));
        //    Assert.AreEqual(expected, result.Message);
        //}

        string indianStateCode = @"C:\Users\Shweta\source\repos\IndianStatesCensusAnalyserProgram\IndianStatesCensusAnalyserProgram\CSVFile\IndianStateCode.csv";
        public const string incorrectFile = @"C:\Users\Shweta\source\repos\IndianStatesCensusAnalyserProgram\IndianStatesCensusAnalyserProgram\CSVFile\IndianState.txt";
        public const string incorrectFileType = @"C:\Users\Shweta\source\repos\IndianStatesCensusAnalyserProgram\IndianStatesCensusAnalyserProgram\CSVFile\CensusData.txt";

        [TestMethod]
        public void Given_CSVFile_Should_Return_NoOfRecord()
        {
            dict = factory.LoadCsvData(CensusAnalyser.Country.INDIA, indianStateCode, "SrNo,State Name,TIN,StateCode");
            Assert.AreEqual(37, dict.Count);
        }
        [TestMethod]
        [DataRow(incorrectFileType, "Invalid file type")]
        //[DataRow(incorrectFile, "File Not Found")]
        public void Given_State_CensusCSVFile_If_Incorrect_Returns_FileNotFound_Exception(string file, string expected)
        {
            var result = Assert.ThrowsException<CensusAnalyserException>(() => factory.LoadCsvData(CensusAnalyser.Country.INDIA, file, "SrNo,State Name,TIN,StateCode"));
            Assert.AreEqual(expected, result.Message);
        }
    }
}
