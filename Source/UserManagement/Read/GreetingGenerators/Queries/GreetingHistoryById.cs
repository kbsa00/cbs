using System;
using System.Linq;
using Dolittle.Queries;

namespace Read.GreetingGenerators.Queries
{
    public class GreetingHistoryById : IQueryFor<GreetingHistory>
    {
        private readonly IGreetingHistories _repository;

        public Guid DataCollectorId { get; set; }

        public GreetingHistoryById(IGreetingHistories repository, Guid dataCollectorId)
        {
            _repository = repository;
            DataCollectorId = dataCollectorId;
        }


        public IQueryable<GreetingHistory> Query => _repository.Query.Where(g => g.DataCollectorId == DataCollectorId);

    }
}