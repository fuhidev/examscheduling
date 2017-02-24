namespace ExamSchedule.Algorithm
{
    public interface IAssignColor
    {
        void Assign();

        int MaxDay { get; set; }
        int TimeSlot { get; set; }
        int TimeBreak { get; set; }
        int MaxCourseOnDay { get; set; }
    }
}