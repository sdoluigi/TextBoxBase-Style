using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TextBoxBase_Style
{
    internal partial class MainWindowVM : ObservableValidator
    {
        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required] 
        [MaxLength(10)]
        private string? testTextRequired;

        [ObservableProperty]
        [NotifyDataErrorInfo]
        [MaxLength(10)]
        private string? testText;

        [ObservableProperty]
        [NotifyDataErrorInfo]
        [MaxLength(10)]
        private string? testTextSimplest;
    }
}
