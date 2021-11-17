using AutoMapper;
using CatalogOfGoods.Data;
using CatalogOfGoods.Dtos;
using CatalogOfGoods.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogOfGoods.Controllers
{
    //api/catalogofgoods
    [Route("api/catalogofgoods")]
    [ApiController]
    public class CatalogOfGoodsController : ControllerBase
    {
        private readonly ICatalogOfGoodsRepository _repository;
        private readonly IMapper _mapper;

        public CatalogOfGoodsController(ICatalogOfGoodsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/catalogofgoods
        [HttpGet]
        public ActionResult<IEnumerable<GoodReadDto>> GetCatalogOfGoods()
        {
            var catalogOfGoods = _repository.GetCatalogOfGoods();

            if (catalogOfGoods != null)
            {
                return Ok(_mapper.Map<IEnumerable<GoodReadDto>>(catalogOfGoods));
            }

            return NotFound();
        }

        //GET api/catalogofgoods/{id}
        [HttpGet("{id}")]
        public ActionResult <GoodReadDto> GetGoodById(int id)
        {
            var good = _repository.GetGoodById(id);
            if (good != null)
            {
                return Ok(_mapper.Map<GoodReadDto>(good));
            }

            return NotFound();       
        }

        //POST api/catalogofgoods
        [HttpPost]
        public ActionResult <GoodReadDto> CreateGood(GoodCreateDto goodCreateDto)
        {
            var goodModel = _mapper.Map<Good>(goodCreateDto);
            _repository.CreateNewGood(goodModel);
            _repository.SaveChanges();

            var goodReadDto = _mapper.Map<GoodReadDto>(goodModel);

            return Ok(goodReadDto);
        }

        //PUT api/catalogofgoods/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateGood(int id, GoodUpdateDto goodUpdateDto)
        {
            var goodModelFromRepository = _repository.GetGoodById(id);
            if (goodModelFromRepository == null)
            {
                return NotFound();
            }

            _mapper.Map(goodUpdateDto, goodModelFromRepository);

            _repository.UpdateGood(goodModelFromRepository);
            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/catalogofgoods/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteGood(int id)
        {
            var goodModelFromRepository = _repository.GetGoodById(id);
            if (goodModelFromRepository == null)
            {
                return NotFound();
            }

            _repository.DeleteGood(goodModelFromRepository);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
