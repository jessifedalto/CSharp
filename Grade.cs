public class Grade
{
    GradeClassification ClassifyGrade(int math, int science)
        => (math, science) switch
        {
            (>90, _) or (_, >90) => GradeClassification.Good,
            (>70, >70) => GradeClassification.Good,
            (<50, _) and (_, <50) => GradeClassification.Bad,
            _ => GradeClassification.Meh
        };

    public enum GradeClassification
    {
        Good,
        Meh,
        Bad
    }

}
