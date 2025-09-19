using org.mariuszgromada.math.mxparser;

namespace ai_math_models.IntervalsMethod.Models;

public static class IntervalsModel
{
    public static Function ConvertStringToFunc(string functionExpression)
    {
        return new Function("f(x) = " + functionExpression);
    }
}