using System;

namespace CS264JanExamCommandDesign
{

        public abstract class Shape
        {
            public int ID {get; set;}
            public int Y {get; set;}
            public int X {get; set;}
            public override string ToString()
            {
                return "Shape!";
            }
        }
    public class Circle:Shape
      {

      public int CR {get; set; } //radius
      public string CF {get; set;}//fill 
      public Circle(int cid,int x, int y, int r, string cf) {ID=cid; X =x; Y=y; CR=r; CF=cf;}
        public override string ToString()
            {
                // convert the Object to a string
                string dispSVG = String.Format(@"<circle id = ""{0}"" cx=""{1}"" cy=""{2}"" r=""{3}"" fill=""{4}"" />", ID,X, Y, CR,CF);

                //return svgOpen + "".PadLeft(3, ' ') + dispSVG + svgClose;
                return dispSVG;
            }
      }

      public class Rectangle:Shape
      {


        public int RH {get; set; } //height
        public int RW {get; set; } //width
        public string RF {get; set;} //fill
        public int RXC {get; set;} //curve
        public int RYC {get; set;} //curve
        public Rectangle(int rid, int rx, int ry, int rh, int rw,string rf, int rxc, int ryc) {ID = rid;X= rx; Y =ry; RH=rh; RW=rw;RF=rf;RXC=rxc; RYC=ryc;}
           public override string ToString()
            {
                // convert the Object to a string
                string dispSVG = String.Format(@"<rect id = ""{0}"" x=""{1}"" y=""{2}"" width=""{3}"" height =""{4}"" rx=""{6}"" ry=""{7}"" fill =""{5}""/>", ID,X, Y, RW,RH,RF,RXC,RYC);

                //return dispSVG
                return dispSVG;
            }
      }
      public class PathShape:Shape
      {
        public string PSS{get; set;}//path string


        public PathShape(int psid,string pss){ID=psid; PSS =pss;}
                 public override string ToString()
            {
                // convert the Object to a string
                string dispSVG = String.Format(@"<path id = ""{0}"" d= ""M{1}"" />", ID,PSS);

                //return svgOpen + "".PadLeft(3, ' ') + dispSVG + svgClose;
                return dispSVG;
            }
      }
}
