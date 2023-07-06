using FluentValidation;
using Smu.Assignment.Models.Consts;
using Smu.Assignment.Models.Requests;

namespace Smu.Assignment.Validators
{
    public class SquareDrawingRequestValidator : AbstractValidator<SquareDrawingRequest>
    {
        public SquareDrawingRequestValidator()
        {
            RuleFor(x => x.Shape).NotEmpty().WithMessage("Must provide Shape")
                .Must(BeAValidShape).WithMessage("Invalid Shape.");

            RuleFor(x => x.Size)
                .GreaterThanOrEqualTo(ValidationConsts.MinimumShapeSize).WithMessage($"Size cannot be less than {ValidationConsts.MinimumShapeSize}.")
                .LessThanOrEqualTo(ValidationConsts.MaximumShapeSize).WithMessage("Exceeded maximum Size.");
        }

        private bool BeAValidShape(string shape)
        {
            return shape.Equals("square", StringComparison.OrdinalIgnoreCase);
        }
    }
}