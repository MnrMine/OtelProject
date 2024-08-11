using MediatR;
using OtelRezervasyon.MediatorPattern.Results;

namespace OtelRezervasyon.MediatorPattern.Queries
{
    public class SearchRoomQuery : IRequest<List<SearchRoomQueryResult>>
    {
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public SearchRoomQuery( DateTime entryDate, DateTime releaseDate)
        {

            EntryDate = entryDate;
            ReleaseDate = releaseDate;
        }
    }
}
