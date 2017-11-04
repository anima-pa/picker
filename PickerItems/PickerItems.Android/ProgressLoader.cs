using Xamarin.Forms;
using AndroidHUD;
using PickerItems.Droid;

[assembly: Dependency(typeof(ProgressLoader))]
namespace PickerItems.Droid
{
    public class ProgressLoader : IProgressInterface
    {
        public ProgressLoader()
        {
        }

        public void Hide()
        {
            
                AndHUD.Shared.Dismiss();

        }

        public void Show(string title)
        {
           
                AndHUD.Shared.Show(Forms.Context, status: title, maskType: MaskType.Black);
            
        }
    }
}