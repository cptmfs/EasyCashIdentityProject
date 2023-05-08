using EasyCashIdentityProject.DTO.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.Business.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(i => i.Name).NotEmpty().WithMessage("İsim alanı boş olamaz");
            RuleFor(i => i.Surname).NotEmpty().WithMessage("Soyad alanı boş olamaz");
            RuleFor(i => i.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş olamaz");
            RuleFor(i => i.EMail).NotEmpty().WithMessage("Mail alanı boş olamaz");
            RuleFor(i => i.Password).NotEmpty().WithMessage("Şifre alanı boş olamaz");
            RuleFor(i => i.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş olamaz");
            RuleFor(i=>i.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter girişi yapınız");
            RuleFor(i => i.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(i => i.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalarınız eşleşmiyor"); // Equal sağ ve sol taraftaki eşitlik durumunu kontrol ediyor..
            RuleFor(i=>i.EMail).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz");
        }
    }
}
