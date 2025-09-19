using System.Windows;
using ai_math_models.IntervalsMethod.ViewModels;

namespace ai_math_models.IntervalsMethod.Views;

public partial class IntervalsView : Window
{
    public IntervalsView()
    {
        InitializeComponent();
        DataContext = new IntervalsViewModel();
    }
}