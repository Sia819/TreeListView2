using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestProject_WPF
{
    /// <summary>
    /// TreeListView2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TreeListView2 : UserControl
    {
        public myScheduleItem sc { get; set; }
        public TreeListView2()
        {
            InitializeComponent();

            // Sample data
            this.DataContext = this;
            sc =
            new myScheduleItem
            {
                SubItems = new myScheduleItem[]
                {
                    new myScheduleItem
                    {
                        Task = "Coding",
                        Duration = 4,
                        Notes = "It pays the bills",
                        SubItems = new myScheduleItem[]
                        {
                            new myScheduleItem { Task = "Write", Duration = 2, Notes = "C# or go home" },
                            new myScheduleItem { Task = "Compile", Duration = 1, Notes = "WTB: SSD" },
                            new myScheduleItem { Task = "Test", Duration = 1, Notes = "Works on my machine" },
                        },
                    },
                    new myScheduleItem
                    {
                        Task = "Meetings",
                        Duration = 2,
                        Notes = "A necessary evil",
                        SubItems = new myScheduleItem[]
                        {
                            new myScheduleItem { Task = "Boring", Duration = 1, Notes = "Zzzzzz" },
                            new myScheduleItem { Task = "Gossipy", Duration = 0.75, Notes = "Oh no he didn't!" },
                            new myScheduleItem { Task = "Useful", Duration = 0.25, Notes = "Right away, boss" },
                        },
                    },
                    new myScheduleItem
                    {
                        Task = "Communicate",
                        Duration = 1,
                        Notes = "No man is an island",
                        SubItems = new myScheduleItem[]
                        {
                            new myScheduleItem { Task = "Email", Duration = 0.5, Notes = "So much junk mail" },
                            new myScheduleItem { Task = "Blogs", Duration = 0.25, Notes = "blogs.msdn.com/delay" },
                            new myScheduleItem { Task = "Twitter", Duration = 0.25, Notes = "RT: Nothing to report" },
                        },
                    },
                    new myScheduleItem
                    {
                        Task = "Hello",
                        Duration = 1,
                        Notes = "Hello Saying",
                    },
                    new myScheduleItem
                    {
                        Task = "Eating",
                        Duration = 1.5,
                        Notes = "Fuel for the body",
                        SubItems = new myScheduleItem[]
                        {
                            new myScheduleItem { Task = "Lunch", Duration = 1, Notes = "Bag lunch from home" },
                            new myScheduleItem
                            {
                                Task = "Snack",
                                Duration = 0.5,
                                Notes = "Still hungry",
                                SubItems = new myScheduleItem[]
                                {
                                    new myScheduleItem { Task = "Fruit", Duration = 0.25, Notes = "Good for you" },
                                    new myScheduleItem { Task = "Candy", Duration = 0.25, Notes = "Yummy!" },
                                },
                            },
                        },
                    },
                },
            };

        }
    }

    public class myScheduleItem
    {
        public string Task { get; set; }
        public double Duration { get; set; }
        public string Notes { get; set; }
        public myScheduleItem[] SubItems { get; set; }
        public myScheduleItem()
        {
            SubItems = new myScheduleItem[0];
        }
    }
}
