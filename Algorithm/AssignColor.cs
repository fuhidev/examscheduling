using ExamSchedule.Algorithm.Model;
using ExamSchedule.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamSchedule.Algorithm
{
    internal class AssignColor : IAssignColor
    {
        private List<Color> Colors = new List<Color>();
        private int maxScheduleDay = 2;
        private int nearestExam = 1;
        private int noOfColorCouses = 0;
        private int noOfTimeSlot = 8;
        private int maxCourseOnDay = -1;

        private readonly HashSet<int> tmpInt = new HashSet<int>();

        public AssignColor(List<Room> listRoom = null, List<Node> listNode = null)
        {
            ListRoom = listRoom;
            ListNode = listNode;
        }

        public int NumDay
        {
            get { return tmpInt.Count; }
        }

        public List<Room> ListRoom { get; set; }

        public List<Node> ListNode { get; set; }

        public void Assign()
        {
            ListNode.Sort();

            var first = true;

            Console.WriteLine("Run..");
            InitColor();
            foreach (var node in ListNode)
            {
                if (node.ListFamily == null)
                    throw new NullReferenceException("Không đủ dữ liệu để thực hiện " + node.ID);
                Color color;
                if (node.Color == null)
                {
                    if (first)
                    {
                        first = false;
                        color = FirstNodeColor(node);
                        if (color == null) return;
                    }
                    else
                        color = SmallestAvailableColor(node);
                    if (color != null)
                        AssignColorForNode(node, color);
                }
                var AdjOfNode = node.GetNeighBorNodes();
                AdjOfNode.Sort();
                foreach (var n in AdjOfNode)
                {
                    if (n.Color == null)
                    {
                        color = SmallestAvailableColor(n);
                        if (color != null)
                            AssignColorForNode(n, color);
                    }
                }
            }
            IEnumerable<Node> nodes = null;
            while ((nodes = ListNode.Where(w => w.Color == null)) != null && nodes.Count() > 0 && maxScheduleDay < maxDay)
            {
                maxScheduleDay++;
                InitColor(maxScheduleDay);
                nodes.ToList().Sort();
                foreach (var node in nodes)
                {
                    var color = SmallestAvailableColor(node, maxScheduleDay);
                    if (color != null)
                        AssignColorForNode(node, color);
                }
            }
            var qr = from n in ListNode
                     where n.Color == null
                     select n;
            Console.WriteLine(qr.Count());
        }

        private void InitColor(int day = 1)
        {
            //tạo danh sách Concurency Limit
            ////danh sách được tạo từ phần tử Size của Database.Rooms
            if (ListRoom == null || ListRoom.Count == 0) return;

            for (var i = day; i <= maxScheduleDay; i++)
            {
                for (var j = 1; j <= noOfTimeSlot; j++)
                {
                    if (FindColor(i, j) != null)
                        continue;
                    var CLs = new List<Color.ColorRoomCourse>();
                    ListRoom.ForEach(a => CLs.Add(new Color.ColorRoomCourse
                    {
                        Room = a,
                        Course = null
                    }));
                    var color = new Color
                    {
                        Day = i,
                        Exam = j,
                        CLs = CLs
                    };
                    Colors.Add(color);
                }
            }
        }

        private Color FindColor(int day, int exam)
        {
            return Colors.FirstOrDefault(a => a.Day == day && a.Exam == exam);
        }

        private void AssignColorForNode(Node node, Color color)
        {
            node.Color = color;
            noOfColorCouses++;
            color.ListNode.Add(node);
            //tìm danh sách phòng để cập nhật cho node, cái này chắc chắn được tại vì là đã kiểm tra khi tìm Color cho node, thỏa đủ điều kiện rồi thì mới đến được bước này
            color.AddCoursesOnRooms(node.ListFamily);
            tmpInt.Add(color.Day);
        }

        public IEnumerable<Course> GetCourseHaveSchedule()
        {
            if (ListNode == null || ListNode.Count == 0)
                throw new NullReferenceException("ListNode is null. GetCourseHaveSchedule");
            return from n in ListNode
                   where n.Color != null
                   from course in n.ListFamily
                   select course;
        }

        public Color FirstNodeColor(Node node)
        {
            for (var i = 1; i <= maxScheduleDay; i++)
            {
                for (var j = 1; j <= noOfTimeSlot; j++)
                {
                    var color = FindColor(i, j);
                    var check = color.CheckAbilityRooms(node.ListFamily);
                    if (check)
                        return color;
                }
            }
            return null;
        }

        #region SmallestAvailableColor

        private int InternalDistance(Color c1, Color c2)
        {
            return Math.Abs(c1.Exam - c2.Exam);
        }

        private int ExternalDistance(Color c1, Color c2)
        {
            return Math.Abs(c1.Day - c2.Day);
        }

        #region Check3ExamsConstraint

        private bool Check3ExamsConstraint(Node node, int day)
        {
            if (maxCourseOnDay == -1) return true;
            foreach (var std in node.Students)
            {
                var courses = std.LstCourse;
                var counter = 0;
                foreach (var course in courses)
                {
                    var n = ListNode.First(a => a.Equals(course));
                    if (n == null)
                        throw new NullReferenceException();
                    if (n.Color != null && n.Color.Day == day)
                    {
                        counter++;
                        if (counter == maxCourseOnDay)
                            return false;
                    }
                };
            }
            return true;
        }

        #endregion Check3ExamsConstraint

        public Color SmallestAvailableColor(Node node, int day = 1)
        {
            var lA = node.GetNeighBorNodes(); //lấy danh sách các node kế cận với node

            for (var i = day; i <= maxScheduleDay; i++)
            {
                for (var j = 1; j <= noOfTimeSlot; j++)
                {
                    var valid = true;
                    //lấy màu của ngày thứ i ca thứ j
                    var color = FindColor(i, j);
                    //kiểm tra sức chứa của màu có đáp ứng được node
                    var sumSize = node.SumSize;
                    if (color.GetCL(node.ListFamily.First().Type) >= sumSize)
                    {
                        //kiểm tra sức chứa của màu có đáp ứng được Family của Node
                        var check = color.CheckAbilityRooms(node.ListFamily);
                        if (check)
                        {
                            //Kiểm tra Color có trùng với những màu kế cận với node (kế cận thì không được trùng màu)
                            foreach (var n in lA)
                            {
                                //nếu node đã được gán màu
                                if (n.Color != null)
                                {
                                    //kiểm tra có trùng với ngày hoặc trùng với ca thi hay không
                                    if (n.Color.Day != i || n.Color.Exam != j)
                                    {
                                        //nếu có thì kiểm tra 2 ngày thi có trùng sau không
                                        if (ExternalDistance(n.Color, color) == 0)
                                        {
                                            //nếu trùng thì kiểm tra xem 2 ca thi có trùng hoặc liền kề nhau hay không
                                            if (InternalDistance(n.Color, color) <= nearestExam)
                                            {
                                                valid = false;
                                                break;
                                            }
                                        }

                                        //kiểm tra có vi phạm điều kiện ràng buộc với sinh viên
                                        if (!Check3ExamsConstraint(node, color.Day))
                                        {
                                            valid = false;
                                            break;
                                        }
                                    }
                                    //nếu node kế cận chưa được gán màu thì không cần so sánh làm gì
                                    else
                                    {
                                        valid = false;
                                        break;
                                    }
                                }
                            }
                        }
                        else continue;
                    }
                    else continue;
                    //nếu như thỏa hết điều kiện thì trả về
                    if (valid) return color;
                }
            }
            //không thỏa điều kiện thì không tìm được màu nào
            return null;
        }

        #endregion SmallestAvailableColor

        private int maxDay = 7;
        public int MaxDay { get { return maxDay; } set { this.maxDay = value; } }

        public int TimeSlot { get { return noOfTimeSlot; } set { noOfTimeSlot = value; } }

        public int TimeBreak
        {
            get
            {
                return nearestExam;
            }
            set
            {
                this.nearestExam = value;
            }
        }
        public int MaxCourseOnDay
        {
            get
            {
                return maxCourseOnDay;
            }
            set
            {
                this.maxCourseOnDay= value;
            }
        }

    }
}