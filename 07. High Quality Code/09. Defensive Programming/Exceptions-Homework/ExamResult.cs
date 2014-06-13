using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentNullException("Grade cannot be negative");
        }
        if (minGrade < 0)
        {
            throw new ArgumentNullException("Minimal grade cannot be negative");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("Maximal grade cannot be lower or the same as the minimal grade");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentNullException("Must have comment");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
