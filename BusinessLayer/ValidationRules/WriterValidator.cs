using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı, soyadı boş geçilemez.");
                //.MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın")
                //.MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez.");
            RuleFor(x => x.WriterPassword).MinimumLength(2).WithMessage("Şifre 2 karakterden küçük olamaz");
            RuleFor(x => x.WriterPassword).MaximumLength(20).WithMessage("Şifre 20 karakterden fazla olamaz.");
                //.Matches(@"[0-9]+").WithMessage("En az bir rakam olmalıdır");

            //.Matches(@"[A-Z]+").WithMessage("En az bir büyük harf olmalıdır")
            //.Matches(@"[a-z]+").WithMessage("En az bir küçük harf olmalıdır")

        }
    }
}
