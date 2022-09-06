using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.Business.Abstract
{
   public interface IHotelService
    {
        public List<Hotel> GetAllHotels();
        public Hotel UpdateHotel(Hotel hotel);
        public Hotel GetHotelById(int id);
        public Hotel CreateHotel(Hotel hotel);
        void DeleteHotel(int id);
    }
}
