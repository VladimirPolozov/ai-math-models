using System.Windows;
using ai_math_models.IntervalMethod.ViewModels;

namespace ai_math_models.IntervalMethod.Views;

public partial class IntervalsView : Window
{
    public IntervalsView()
    {
        InitializeComponent();
        DataContext = new IntervalsViewModel();
    }
}