using System;
using Microsoft.EntityFrameworkCore;
using Hotels.API.Dto;


namespace Hotels.API.Services
{
    public class HotelsServices : IRestaurantsService
    {


        private AppDbContext _context = context;
        private object hotelDb;
        private static AppDbContext context;

        public List<Models.Hotel> GetAllHotels()
            {
                var allHotels = _context.Hotels.ToList();
                return allHotels;
            }

            public Models.Hotel AddRestaurant(PostHotelsDto hotel)
            {
                var newHotel = new Models.Hotel()
                {
                    Name = hotel.Name,
                    Price = hotel.Price
                };

                _context.Hotels.Add(newHotel);
                _context.SaveChanges();

                return newHotel;
            }

            public void DeleteHotel(int id)
            {
                var hoteltDb = _context.Hotels
                    .FirstOrDefault(n => n.Id == id);

               
                _context.SaveChanges();
            }



            public Models.Hotel GetHotelById(int id)
            {
            var newHotel = _context.Hotels
                    .FirstOrDefault(n => n.Id == id);

                return newHotel;
            }

            public Models.Hotel UpdateHotel(PutHotelDto hotelData, int id)
            {
                var hotelDb = _context.Hotels
                    .FirstOrDefault(n => n.Id == id);

               

                _context.SaveChanges();

                return hotelDb;
            }
        }
    }

