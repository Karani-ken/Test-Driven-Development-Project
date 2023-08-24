using DeskBooker.Core.Dormain;

namespace DeskBooker.Core.DataInterface
{
    public interface IDeskBookingRepository
    {
        void Save(DeskBooking deskBooking);

    }
}
