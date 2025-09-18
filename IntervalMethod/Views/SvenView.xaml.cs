using System.Windows;
using ai_math_models.IntervalMethod.ViewModels;

namespace ai_math_models.IntervalMethod.Views;

public partial class SvenView : Window
{
    public SvenView()
    {
        InitializeComponent();
        DataContext = new SvenViewModel();
    }
}