using MicroCourse.Services.Catalog.Dtos;
using MicroCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroCourse.Services.Catalog.Services
{
    public interface ICourseService
    {
        Task<Response<List<CourseDto>>> GetAllAsync();

        Task<Response<CourseDto>> GetByIdAsync(string id);

        Task<Response<List<CourseDto>>> GetAllByUserIdAsync(string userId);

        Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);

        Task<Response<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto);

        Task<Response<NoContent>> DeleteAsync(string id);
    }
}