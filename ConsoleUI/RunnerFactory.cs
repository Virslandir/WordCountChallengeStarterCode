using System;
using CoreLib;

namespace ConsoleUI
{
    public class RunnerFactory
    {
        private readonly IDataService _dataService;

        public enum RunnerType
        {
            Test,
            User
        }

        public RunnerFactory()
        {
            var regexProvider = new RegexProvider();
            var stringProcessor = new StringProcessor(regexProvider);

            _dataService = new DataService(stringProcessor);
        }
        
        public Runner CreateRunner(RunnerType runnerType)
        {
            IDataProvider dataProvider = null;

            switch (runnerType)
            {
                case RunnerType.Test:
                    dataProvider = new TestDataProvider();
                    break;
                case RunnerType.User:
                    dataProvider = new UserDataProvider();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(runnerType), runnerType, null);
            }
            
            return new Runner(_dataService, dataProvider);
        }
    }
}