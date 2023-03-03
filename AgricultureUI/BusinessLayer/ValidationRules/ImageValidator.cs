using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    // ımage gibi sistem isimlerinin verilmesi çok doğpru değil 
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görsel Başlığını boş geçemezsiniz");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapın");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapın");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel açıklamansını Başlığını boş geçemezsiniz");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter veri girişi yapın");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Lütfen en az 10 karakter veri girişi yapın");

            RuleFor(x => x.ImageURL).NotEmpty().WithMessage("Görsel yolunu boş geçemezsiniz");

            
        }
    }
}
