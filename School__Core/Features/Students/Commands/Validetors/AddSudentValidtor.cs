using FluentValidation;
using School__Core.Features.Students.Commands.Models;

namespace School__Core.Features.Students.Commands.Validetors
{
    public class AddSudentValidtor : AbstractValidator<AddStudentCommand>
    {
        #region Fields
        //private readonly IStudentService _studentService;
        //private readonly IStringLocalizer<SharedResources> _localizer;
        //private readonly IDepartmentService _departmentService;

        #endregion

        #region Constructors
        public AddSudentValidtor(
                                   //IStudentService studentService,
                                   //                           IStringLocalizer<SharedResources> localizer,
                                   //                           IDepartmentService departmentService


                                   )
        {
            //_studentService = studentService;
            //_localizer = localizer;
            ApplyValidationsRules();
            //ApplyCustomValidationsRules();
            //_departmentService = departmentService;
        }
        #endregion

        #region Actions
        public void ApplyValidationsRules()
        {

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name must be not Empty")
                .MaximumLength(100).WithMessage("Name has Max length 100");

            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Address must be not Empty")
                .MaximumLength(100).WithMessage("Address has Max length 100");

            RuleFor(x => x.DpartmentID)
                .NotEmpty().WithMessage("Department ID must be not Empty");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Phone must be not Empty");
        }

        //public void ApplyCustomValidationsRules()
        //{

        //    // RuleFor(x => x.NameAr)
        //    //     .MustAsync(async (Key, CancellationToken) => !await _studentService.IsNameArExist(Key))
        //    //     .WithMessage(_localizer[SharedResourcesKeys.IsExist]);
        //    // RuleFor(x => x.NameEn)
        //    //    .MustAsync(async (Key, CancellationToken) => !await _studentService.IsNameEnExist(Key))
        //    //    .WithMessage(_localizer[SharedResourcesKeys.IsExist]);



        //    // RuleFor(x => x.DepartmementId)
        //    //.MustAsync(async (Key, CancellationToken) => await _departmentService.IsDepartmentIdExist(Key))
        //    //.WithMessage(_localizer[SharedResourcesKeys.IsNotExist]);

        //}

        #endregion

    }
}
