
using Hotels.API.Dto;
namespace Hotels.API.Services
{
    public interface IHotelsServices
    {
        List<Models.Hotel> GetAllHotels();
        Models.Hotel GetHotelById(int id);
        Models.Hotel AddHotel(PostHotelDto hotel);
        Models.Hotel UpdateHotel(PutHotelDto hotelData, int id);
        void DeleteHotel(int id);
    }
}
