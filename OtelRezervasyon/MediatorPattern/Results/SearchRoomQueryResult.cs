namespace OtelRezervasyon.MediatorPattern.Results
{
    public class SearchRoomQueryResult
    {
        public int RoomsId { get; set; }
        public string CoverImageUrl { get; set; }
        public string RoomName { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public int Bed { get; set; }
        public int Square { get; set; }

        public bool Available { get; set; }

        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
