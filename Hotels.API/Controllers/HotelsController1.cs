using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Hotels.API.Dto;
using Hotels.API.Services;


namespace Hotels.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController1 : ControllerBase
    {
        [HttpGet("All")]
        public IActionResult GetHotels()
        {
            //List of hotels
            var allHotelss = new List<Hotels.API.Models.Hotel>()
            {
                new Hotels.API.Models.Hotel()
                {
                    Id = 1,
                    Name = "First Hotel",
                    
                },
                new Hotels.API.Models.Hotel()
                {
                    Id = 2,
                    Name = "Second Hotel",
                   
                },
            };

            return Ok(allHotelss);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetHotelById(int id)
        {
            var newHotel = new Models.Hotel()
            {
                Id = 1,
                Name = "First Hotel",
               
            };

            return Ok(newHotel);
        }


        [HttpPost]
        public IActionResult AddNewHotel([FromBody] PostHotelsDto payload)
        {
            return Ok(payload);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateHotel([FromBody] PutHotelsDto payload, int id)
        {
            return Ok(payload);
        }


        [HttpDelete("DeleteById/{id}")]
        public IActionResult DeleteHotel(int id)
        {
            return Ok();
        }

    }
}
   
