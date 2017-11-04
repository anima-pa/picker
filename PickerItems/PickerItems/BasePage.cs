using Xamarin.Forms;

namespace PickerItems
{
    public class BasePage : ContentPage
    {
        public void Show()
        {
            DependencyService.Get<IProgressInterface>().Show();
        }

        public void Hide()
        {
            DependencyService.Get<IProgressInterface>().Hide();
        }

        public BasePage()
        {
        }
    }
}
