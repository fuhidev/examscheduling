using System;
using ExamSchedule.BusinessDatabase;
using Database;

namespace ConsoleTest
{
    internal class
        Program
    {
        private static void TestDatabase()
        {
            //var db = new DataProvider();
            ////db.readCourse(@"D:\Google Drive\Documents\Project 1\DATA\DanhSachMon_HK3_CNTT.xlsx");
            ////db.lstCourse.ForEach(a => Console.WriteLine(a.ToString()));
            ////db.readRoom(@"D:\Google Drive\Documents\Project 1\DATA\PhongThi_HK3.xlsx");
            ////db.lstRoom.ForEach(a => Console.WriteLine(a.ToString()));
            //db.readStudent(@"D:\Google Drive\Documents\Project 1\DATA\danhsachsinhvien.xlsx");
            //db.ListStudent.ForEach(a => Console.WriteLine(a.ToString()));
            //Console.WriteLine(db.lstStudent.Count);
        }

        private static void Main(string[] args)
        {

            var db = new DataProvider();
            db.ImportData(@"D:\Documents\Visual Studio 2013\Projects\DoAn2\data\DS_MON.xlsx",
                            @"D:\Documents\Visual Studio 2013\Projects\DoAn2\data\DS_SV.xlsx",
                            @"D:\Documents\Visual Studio 2013\Projects\DoAn2\data\DS_PHONG.xlsx",
                            @"D:\Documents\Visual Studio 2013\Projects\DoAn2\data\DS_DKMH.xlsx");
            //db.Analyze();
            db.CreateScheduling(DateTime.Now, 8,7,1,3);
            var sch = db.GetScheduling();
            foreach(var s in sch)
                Console.WriteLine(s);
            //Console.WriteLine("________________________________________");
            //db.GetCourseNotColor().ForEach(a => Console.WriteLine(a.Course));
            //Console.WriteLine(db.GetCourseNotColor().Count);
            //while (true)
            //{
            //    var id = Console.ReadLine();
            //    var sc = db.GetSchedulingByStudentID(id);
            //    foreach (var s in sc)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

        }
    }
}