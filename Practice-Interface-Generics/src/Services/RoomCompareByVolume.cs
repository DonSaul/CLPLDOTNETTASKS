public class RoomComparerByVolume<T> : IComparer<Room<T>> where T : IShape
{
    public int Compare(Room<T> x, Room<T> y)
    {
        return x.Volume().CompareTo(y.Volume());
    }
}
