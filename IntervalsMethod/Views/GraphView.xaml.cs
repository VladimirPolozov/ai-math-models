using System.Windows;
using ai_math_models.IntervalsMethod.ViewModels;
namespace ai_math_models.IntervalsMethod.Views;

public partial class GraphView : Window
{
    public GraphView()
    {
        InitializeComponent();
        DataContext = new GraphViewModel();
    }
}