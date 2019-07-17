using MvvmCross.ViewModels;
using NotFoundException.ViewModels;

namespace NotFoundException
{
    public class App: MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<TipViewModel>();
        }
    }
}
