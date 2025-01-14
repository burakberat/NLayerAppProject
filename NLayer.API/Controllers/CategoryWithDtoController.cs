﻿using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Dtos.CategoryDtos;
using NLayer.Core.Entities;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryWithDtoController : CustomBaseController
    {
        private readonly IServiceWithDto<Category, CategoryDto> _categoryServiceWithDto;

        public CategoryWithDtoController(IServiceWithDto<Category, CategoryDto> serviceWithDto)
        {
            _categoryServiceWithDto = serviceWithDto;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return CreateActionResult(await _categoryServiceWithDto.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryDto categoryDto)
        {
            return CreateActionResult(await _categoryServiceWithDto.AddAsync(categoryDto));
        }
    }
}
