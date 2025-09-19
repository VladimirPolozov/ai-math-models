
using System.ComponentModel;
using System.Windows.Input;
using org.mariuszgromada.math.mxparser;
using ai_math_models.IntervalsMethod.Models;
using ai_math_models.IntervalsMethod.Views;
using ai_math_models.IntervalsMethod.Models;

namespace ai_math_models.IntervalsMethod.ViewModels;

public class IntervalsViewModel : INotifyPropertyChanged
{
    // поля пользовательского ввода
    private string _functionExpressionString;
    private Function _functionExpression;
    private double _parameterA;
    private double _parameterB;
    private double _epsilon;
    private int _singsAfterCommaCount;

    public string FunctionExpressionString
    {
        get => _functionExpressionString;
        set
        {
            _functionExpressionString = value.ToLower();
            OnPropertyChanged(nameof(FunctionExpressionString));
        }
    }
        
    public Function FunctionExpression
    {
        get => _functionExpression;
        set
        {
            _functionExpression = value;
            OnPropertyChanged(nameof(FunctionExpression));
        }
    }

    public double ParameterA
    {
        get => _parameterA;
        set
        {
            _parameterA = value;
            OnPropertyChanged(nameof(ParameterA));
        }
    }

    public double ParameterB
    {
        get => _parameterB;
        set
        {
            _parameterB = value;
            OnPropertyChanged(nameof(ParameterB));
        }
    }

    public double Epsilon
    {
        get => _epsilon;
        set
        {
            _epsilon = value;
            OnPropertyChanged(nameof(Epsilon));
        }
    }

    public int SingsAfterCommaCount
    {
        get => _singsAfterCommaCount;
        set
        {
            _singsAfterCommaCount = value;
            OnPropertyChanged(nameof(SingsAfterCommaCount));
        }
    }
    
    private void ClearData()
    {
        throw new NotImplementedException();
    }
    
    private void SetDefaultData()
    {
        FunctionExpressionString = "x";
        ParameterA = -50;
        ParameterB = 50;
        Epsilon = 0.01;
        SingsAfterCommaCount = 2;
    }

    private void Calculate()
    {
        try
        {
            FunctionExpression = IntervalsModel.ConvertStringToFunc(FunctionExpressionString);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }
    
    public ICommand CalculateCommand { get; }
    public ICommand ClearCommand { get; }
    
    public IntervalsViewModel()
    {
        SetDefaultData();
        ClearCommand = new RelayCommand(_ => SetDefaultData());
        CalculateCommand = new RelayCommand(_ => Calculate());
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}