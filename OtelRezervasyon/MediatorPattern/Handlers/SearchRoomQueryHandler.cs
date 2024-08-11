using MediatR;
using Microsoft.EntityFrameworkCore;
using OtelRezervasyon.DataAccessLayer.Context;
using OtelRezervasyon.MediatorPattern.Queries;
using OtelRezervasyon.MediatorPattern.Results;

namespace OtelRezervasyon.MediatorPattern.Handlers
{
    public class SearchRoomQueryHandler : IRequestHandler<SearchRoomQuery, List<SearchRoomQueryResult>>
    {
        private readonly HotelContext _hotelContext;

        public SearchRoomQueryHandler(HotelContext hotelContext)
        {
            _hotelContext = hotelContext;
        }

        public async Task<List<SearchRoomQueryResult>> Handle(SearchRoomQuery request, CancellationToken cancellationToken)
        {
            var values = await _hotelContext.SearchRooms.Include(x => x.Room).Where(x => x.EntryDate == request.EntryDate || x.ReleaseDate == request.ReleaseDate).ToListAsync();
            return values.Select(x => new SearchRoomQueryResult
            {
                RoomsId = x.RoomsId,
               CoverImageUrl = x.Room.CoverImageUrl,
                RoomName = x.Room.RoomName,
                 Description= x.Room.Description,
                Bed = x.Room.Bed,
                Square = x.Room.Square,
                Capacity = x.Room.Capacity,
                Available=x.Room.Available,
                EntryDate = x.EntryDate,
                ReleaseDate = x.ReleaseDate,
            }).ToList();
        }
    }
}
