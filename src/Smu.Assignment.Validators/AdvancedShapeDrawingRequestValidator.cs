using FluentValidation;
using Smu.Assignment.Models.Requests;

namespace Smu.Assignment.Validators
{
    public class AdvancedShapeDrawingRequestValidator : AbstractValidator<AdvancedShapeDrawingRequest>
    {

        public AdvancedShapeDrawingRequestValidator()
        {
            RuleFor(x => x).SetValidator(new ShapeDrawingRequestValidator());
        }
    }
}