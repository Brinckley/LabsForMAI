//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab_14.Classes
//{
//    public abstract class CommandActivity
//    {
//        public abstract void Do();
//        public abstract void ReDo();
//    }

//    public class Ellipse {

//    }

//    public class ListPoints 
//    {
//        int runner;
//        List<Ellipse> list;
//        bool seen;

//        public ListPoints() {
//            Runner = 0;           
//            List = new List<CommandActivity>();
//        }

//        public int Runner { get => runner; set => runner = value; }
//        public List<CommandActivity> List { get => list; set => list = value; }
//    }

//    public class EllipseCommand : CommandActivity
//    {
//        ListPoints circles;

//        public override void Do(Graphics gr)
//        {
//            if (circles.Runner < circles.List.Count) {
//                circles.Runner++;
//                (circles.List[circles.Runner])

//            }
//        }

//        public override void ReDo()
//        {

//        }
//    }
//}
