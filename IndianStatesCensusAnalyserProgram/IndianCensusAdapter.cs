using IndianCensus.DTO;
using IndianStateCensusAnalyser;
using IndianStatesCensusAnalyserProgram.DAO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IndiaCensusDataDemo
{
    public class IndianCensusAdapter : CensusAdapter
    {
        string[] censusData;
        Dictionary<string, StateCodeDataDAO> datamap;
        Dictionary<string, CensusDTO> censusState;
        public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, string dataHeaders)
        {
            try
            {
                datamap = new Dictionary<string, StateCodeDataDAO>();
                censusState = new Dictionary<string, CensusDTO>();
                censusData = GetCensusData(csvFilePath, dataHeaders);
                foreach (string data in censusData.Skip(1))
                {
                    if (!data.Contains(","))
                    {
                        throw new CensusAnalyserException("File Containers Wrong Delimiter", CensusAnalyserException.ExceptionType.INCOREECT_DELIMITER);
                    }
                    string[] coloumn = data.Split(',');
                    if (csvFilePath.Contains("IndianStateCode.csv"))
                        datamap.Add(coloumn[1], new StateCodeDataDAO(coloumn[0], coloumn[1], coloumn[2], coloumn[3]));
                    if (csvFilePath.Contains("IndianStateCensusData.csv"))
                        censusState.Add(coloumn[0], new CensusDTO(new CensusDataDAO(coloumn[0], coloumn[1], coloumn[2], coloumn[3])));
                }
                return censusState;
            }
            catch (CensusAnalyserException ex)
            {
                throw ex;
            }
        }

    }
}