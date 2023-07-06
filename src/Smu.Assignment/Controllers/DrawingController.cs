using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Smu.Assignment.Manager;
using Smu.Assignment.Models.Requests;

namespace Smu.Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrawingController : ControllerBase
    {
        private readonly IShapeDrawer _shapeDrawer;

        public DrawingController(IShapeDrawer shapeDrawer)
        {
            _shapeDrawer = shapeDrawer;
        }

        [HttpPost("square")]
        public async Task<IActionResult> DrawSquare([FromBody] SquareDrawingRequest request, [FromServices] IValidator<SquareDrawingRequest> validator)
        {
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.IsValid)
            {
                var result = _shapeDrawer.Draw(request.Shape, request.Size);
                return Ok(result);
            }
            return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
        }


        [HttpPost("shapes")]
        public async Task<IActionResult> DrawShapes([FromBody] ShapeDrawingRequest request, [FromServices] IValidator<ShapeDrawingRequest> validator)
        {
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.IsValid)
            {
                var result = _shapeDrawer.Draw(request.Shape, request.Size);
                return Ok(result);
            }
            return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
        }


        [HttpPost("shapes-advanced")]
        public async Task<IActionResult> AdvancedDrawShapes([FromBody] AdvancedShapeDrawingRequest request, [FromServices] IValidator<AdvancedShapeDrawingRequest> validator)
        {
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.IsValid)
            {
                var result = _shapeDrawer.Draw(request.Shape, request.Size, request.Char);
                return Ok(result);
            }
            return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
        }
    }
}
