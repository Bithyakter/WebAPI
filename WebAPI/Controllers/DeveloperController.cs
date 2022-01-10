using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeveloperController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region GetPopularDevelopers
        public IActionResult GetPopularDevelopers([FromQuery] int count)    //FromQuery=fixed size 32
        {
            var popularDevelopers = _unitOfWork.Developers.GetPopularDevelopers(count);
            
            return Ok(popularDevelopers);
        }
        #endregion

        #region AddDeveloperAndProject
        [HttpPost]
        public IActionResult AddDeveloperAndProject()
        {
            var developer = new Developer
            {
                Followers = 25,
                Name = "Suparna Sarker"
            };

            var project = new Project
            {
                Name = "IamSuparna"
            };

            _unitOfWork.Developers.Add(developer);
            _unitOfWork.Projects.Add(project);  
            _unitOfWork.Complete();

            return Ok();
        }
        #endregion
    }
}
