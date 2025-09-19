using System.Windows;
using ai_math_models.IntervalsMethod.ViewModels;

namespace ai_math_models.IntervalsMethod.Views;

public partial class SvenView : Window
{
    public SvenView()
    {
        InitializeComponent();
        DataContext = new SvenViewModel();
    }
}