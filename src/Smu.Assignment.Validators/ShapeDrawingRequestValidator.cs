using FluentValidation;
using Smu.Assignment.Models.Consts;
using Smu.Assignment.Models.Requests;

namespace Smu.Assignment.Validators
{
    public class ShapeDrawingRequestValidator : AbstractValidator<ShapeDrawingRequest>
    {
        public ShapeDrawingRequestValidator()
        {
            RuleFor(x => x.Shape).NotEmpty().WithMessage("Must provide Shape.")
                                 .Must(BeAValidShape).WithMessage("Invalid Shape.");

            RuleFor(x => x.Size)
                .GreaterThanOrEqualTo(ValidationConsts.MinimumShapeSize).WithMessage($"Size cannot be less than {ValidationConsts.MinimumShapeSize}.")
                .LessThanOrEqualTo(ValidationConsts.MaximumShapeSize).WithMessage("Exceeded maximum Size.");
        }

        private bool BeAValidShape(string shape)
        {
            var validShapes = new List<string> { "square", "triangle" };
            return validShapes.Contains(shape.ToLower());
        }
    }
}