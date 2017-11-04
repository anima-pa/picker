using BigTed;
using PickerItems.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(ProgressLoader))]

namespace PickerItems.iOS
{
    public class ProgressLoader : IProgressInterface
    {
        public ProgressLoader()
        {
        }

        public void Hide()
        {
            BTProgressHUD.Dismiss();
        }

        public void Show(string title )
        {
            BTProgressHUD.Show(title, maskType: ProgressHUD.MaskType.Black);
        }
    }
}
