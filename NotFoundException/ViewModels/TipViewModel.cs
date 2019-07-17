using Acr.UserDialogs;
using MvvmCross.ViewModels;

namespace NotFoundException.ViewModels
{
    public class TipViewModel: MvxViewModel
    {
        public TipViewModel()
        {
            System.Console.WriteLine("Constructed");
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();

            UserDialogs.Instance.ShowLoading();
            
        }
    }
}
