using System;
using System.Text;
using System.IO;
using System.Collections;
using System.Collections.Generic;
//for this exam i have decided to implement a combination of factory and command design methods. Factory is the design by which i will create my emotes
//command will the the design by which i implement undo and redo functionality. Reason i chose factory was because of how it it tidies up the code
//each class has a functionality. Leads to less clusters which makes the code easier to read, although it is over 1000 lines so not that easy looking back on it
//command design my preferred pattern over memento purely due to it making sense to me easier.
namespace CS264JanExamCommandDesign
{
    //FROM HERE DOWN IS IMPLEMENTATION OF THE FACTORY DESIGN 
    //My factory method is implemented by going into client and then calling all of the respective
    //factories as they are needed. Command design is implemented as before in assignment 3 with same methods and classes
    //only a little bit of rejigging was needed.
    class Program
    {
       // The Creator class declares the factory method that is supposed to return
    // an object of a Product class. The Creator's subclasses usually provide
    // the implementation of this method.
    public abstract class FeatureCreator
    {
        // Note that the Creator may also provide some default implementation of
        // the factory method.
        public abstract Shape FactoryMethod();

        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public Shape getShape()
        {
            // Call the factory method to create a Product object.
            Shape product = FactoryMethod();

            return product;
        }
    }
    

    // Concrete Creators override the factory method in order to change the
    // resulting product's type.
    class LeftBrow : FeatureCreator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override Shape FactoryMethod()
        {
            int rid = 1;
            int rx = 77;
            int ry = 66;
            int rh = 6;
            int rw = 36;
            int rxc = 4;
            int ryc =4;
            string rf = "black";
            Rectangle r1 = new Rectangle(rid,rx,ry,rh,rw,rf,rxc,ryc);
            return r1;
        }
    }
     class LeftBrow2 : FeatureCreator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override Shape FactoryMethod()
        {
            int rid = 1;
            int rx = 77;
            int ry = 56;
            int rh = 10;
            int rw = 36;
            int rxc = 4;
            int ryc =4;
            string rf = "blue";
            Rectangle r1 = new Rectangle(rid,rx,ry,rh,rw,rf,rxc,ryc);
            return r1;
        }
    }
     class RightBrow : FeatureCreator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override Shape FactoryMethod()
        {
            int rid = 2;
            int rx = 140;
            int ry = 66;
            int rh = 6;
            int rw = 36;
            int rxc = 4;
            int ryc =4;
            string rf = "black";
            Rectangle r1 = new Rectangle(rid,rx,ry,rh,rw,rf,rxc,ryc);
            return r1;
        }
    }
    class RightBrow2 : FeatureCreator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override Shape FactoryMethod()
        {
            int rid = 2;
            int rx = 140;
            int ry = 56;
            int rh = 10;
            int rw = 36;
            int rxc = 4;
            int ryc =4;
            string rf = "blue";
            Rectangle r1 = new Rectangle(rid,rx,ry,rh,rw,rf,rxc,ryc);
            return r1;
        }
    }
     class FaceBase : FeatureCreator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override Shape FactoryMethod()
        {
             int cid = 0;
            int cx = 128;
            int cy = 128;
            int cr = 120;
            string cf = "yellow";
            Circle c1 = new Circle(cid,cx,cy,cr,cf);
            return c1;
        }
    }
    class Mouth : FeatureCreator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override Shape FactoryMethod()
        {
            int pathid=3;
            int startpoint1 = 100;
            int startpoint2 = 160;
            char Q = 'Q';
            string fullpath = " " + startpoint1 + " " + startpoint2 + " " + Q +" " + 128 + " " + 190 + "  " + 156 + " " + 160;
            PathShape ps = new PathShape(pathid,fullpath);
            return ps;
        }
    } 
     class Mouth2 : FeatureCreator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override Shape FactoryMethod()
        {
            int pathid=3;
            int startpoint1 = 100;
            int startpoint2 = 210;
            char Q = 'Q';
            string fullpath = " " + startpoint1 + " " + startpoint2 + " " + Q +" " + 128 + " " + 190 + "  " + 156 + " " + 210;
            PathShape ps = new PathShape(pathid,fullpath);
            return ps;
        }
    }
     class LeftEye : FeatureCreator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override Shape FactoryMethod()
        {
            int cid = 4;
            int cx = 100;
            int cy = 104;
            int cr = 12;
            string cf = "black";
            Circle c1 = new Circle(cid,cx,cy,cr,cf);
            return c1;
        }
    } 
     class LeftEye2 : FeatureCreator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override Shape FactoryMethod()
        {
            int cid = 4;
            int cx = 106;
            int cy = 114;
            int cr = 20;
            string cf = "red";
            Circle c1 = new Circle(cid,cx,cy,cr,cf);
            return c1;
        }
    } 

    class RightEye : FeatureCreator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override Shape FactoryMethod()
        {
            int cid = 5;
            int cx = 150;
            int cy = 104;
            int cr = 12;
            string cf = "black";
            Circle c1 = new Circle(cid,cx,cy,cr,cf);
            return c1;
        }
    } 
    class RightEye2 : FeatureCreator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override Shape FactoryMethod()
        {
            int cid = 5;
            int cx = 156;
            int cy = 114;
            int cr = 20;
            string cf = "red";
            Circle c1 = new Circle(cid,cx,cy,cr,cf);
            return c1;
        }
    } 

    // The Product interface declares the operations that all concrete products
    // must implement.
    public interface IFeature
    {
       public string Operation();
    }

    // Concrete Products provide various implementations of the Product
    // interface.
    class ILeftBrow : IFeature
    {
        public string Operation()
        {
            return "LeftBrow";
        }
    }
    class IRightBrow : IFeature
    {
        public string Operation()
        {
            return "RightBrow";
        }
    }
    class IFaceBase : IFeature
    {
        public string Operation()
        {
            return "FaceBase";
        }
    }
    class IMouth : IFeature
    {
        public string Operation()
        {
            return "Mouth";
        }
    }
    class ILeftEye : IFeature
    {
        public string Operation()
        {
            return "LeftEye";
        }
    }
    class IRightEye : IFeature
    {
        public string Operation()
        {
            return "RightEye";
        }
    }
   ///****end of product factories****//
   //***Start of command design pattern***////
        public class Canvas //this is my reciever class, recieves commands and carries out actions
        {
            private Stack<Shape> canvas = new Stack<Shape>();

            public void Add(Shape s)
            {
                canvas.Push(s);
                Console.WriteLine("Added Feature to canvas: {0}" + Environment.NewLine, s);
            }
            public Shape Remove()
            {
                Shape s = canvas.Pop();
               Console.WriteLine("Removed Feature from canvas: {0}" + Environment.NewLine, s);
                return s;
            }
            public void Clear()
            {
                while(canvas.Count!=0)
                {
                    canvas.Pop();
                }
            }
            public void Remove1(int id)
            {
                Console.Write(id +"this is id");
                Stack<Shape> save = new Stack<Shape>();
                foreach(var item in canvas)
                {
                    if(item.ID!=id)
                    {
                        Console.Write(item.ID +"this is item id");
                        save.Push(item);
                    }
                }
                canvas.Clear();
                canvas = save;
            }

            public void MoveUp(int id)
            {
                foreach(var item in canvas)
                {
                    if(item.ID==id)
                    {
                        if(item.ID == 1)
                        {
                            item.Y = item.Y-10;
                        }
                        else if(item.ID == 2)
                        {
                            item.Y = item.Y-10;
                        }
                        else if(item.ID == 3)
                        {
                            
                        }
                        else if(item.ID == 4)
                        {
                            item.Y = item.Y-10;
                            item.X = item.Y-10;
                        }
                        else if(item.ID == 5)
                        {
                            item.Y = item.Y-10;
                            item.X = item.Y-10;
                        }
                    }
                }
            }
             public void MoveDown(int id)
            {
                foreach(var item in canvas)
                {
                    if(item.ID==id)
                    {
                        if(item.ID == 1)
                        {
                            item.Y = item.Y+10;
                        }
                        else if(item.ID == 2)
                        {
                            item.Y = item.Y+10;
                        }
                        else if(item.ID == 3)
                        {
                            
                        }
                        else if(item.ID == 4)
                        {
                            item.Y = item.Y+10;
                            item.X = item.Y+10;
                        }
                        else if(item.ID == 5)
                        {
                            item.Y = item.Y+10;
                            item.X = item.Y+10;
                        }
                    }
                }
            }
               public void MoveRight(int id)
            {
                foreach(var item in canvas)
                {
                   if(item.ID==id)
                    {
                        if(item.ID == 1)
                        {
                            item.X = item.X+10;
                        }
                        else if(item.ID == 2)
                        {
                            item.X = item.X+10;
                        }
                        else if(item.ID == 3)
                        {
                            
                        }
                        else if(item.ID == 4)
                        {
                            item.Y = item.Y+10;
                            item.X = item.Y+10;
                        }
                        else if(item.ID == 5)
                        {
                            item.Y = item.Y+10;
                            item.X = item.Y+10;
                        }
                    }
                }
            }
               public void MoveLeft(int id)
            {
                foreach(var item in canvas)
                {
                    if(item.ID==id)
                    {
                        if(item.ID == 1)
                        {
                            item.X = item.X-10;
                        }
                        else if(item.ID == 2)
                        {
                            item.X = item.X-10;
                        }
                        else if(item.ID == 3)
                        {
                            
                        }
                        else if(item.ID == 4)
                        {
                            item.Y = item.Y-10;
                            item.X = item.Y-10;
                        }
                        else if(item.ID == 5)
                        {
                            item.Y = item.Y-10;
                            item.X = item.Y-10;
                        }
                    }
                }
            }

            public void Reset(int id)
            {
                 foreach(var item in canvas)
                {
                    if(item.ID==id)
                    {
                        if (item.ID==1)
                        {
                            item.X =87;
                             item.Y =66;
                        }
                        else if (item.ID==2)
                        {
                            item.X =140;
                            item.Y =66;
                        }
                         else if (item.ID==4)
                        {
                            item.X = 150;
                             item.Y =104;
                        }
                         else if (item.ID==5)
                        {
                            item.X =100;
                            item.Y =104;
                        }
                    }
                }
            }
            public void Save()
            {
                 using StreamWriter sw2 = new StreamWriter(@"C:\Users\natha\OneDrive\Documents\CS264JanExamCommandDesign\CS264JanExam.svg");
                string start = @"<svg height=""1200"" width=""1200"" xmlns= http://www.w3.org/2000/svg>";
                string facebase = @"<circle id = ""0"" cx=""128"" cy=""128"" r=""120"" fill=""yellow"" />";
                string end = "</svg>";
                sw2.WriteLine(start);
                sw2.WriteLine(facebase);
                foreach(var item in canvas)
                {
                    sw2.WriteLine(item);
                }
                sw2.WriteLine(end);
            }

            public void Display()
            {
                foreach(var item in canvas)
                {
                    Console.WriteLine(item);
                }
            }

            public Canvas()
            {
                Console.WriteLine("\nCreated a new Canvas!"); Console.WriteLine();
            }

            public override string ToString()
            {
                String str = "Canvas (" + canvas.Count + " elements): " + Environment.NewLine + Environment.NewLine;
                foreach (Shape s in canvas)
                {
                    str += "   > " + s + Environment.NewLine;
                }
                return str;
            }

        }

        public class User
        {  
            private Stack<Command> undo;
            private Stack<Command> redo;

            public int UndoCount { get => undo.Count; }
            public int RedoCount { get => undo.Count; }
            public User()
            {
                Reset();
                Console.WriteLine("Created a new User!"); Console.WriteLine();
            }
            public void Reset()
            {
                undo = new Stack<Command>();
                redo = new Stack<Command>();
            }

            public void Action(Command command)
            {
                // first update the undo - redo stacks
                undo.Push(command);  // save the command to the undo command
                redo.Clear();        // once a new command is issued, the redo stack clears

                Type t = command.GetType();
                if (t.Equals(typeof(AddFeatureCommand)))
                {
                    //Console.WriteLine("Command Received: Add new Shape!" + Environment.NewLine);
                    command.Do();
                }
                if (t.Equals(typeof(DeleteFeatureCommand)))
                {
                    //Console.WriteLine("Command Received: Delete last Shape!" + Environment.NewLine);
                    command.Do();
                }
            }
             public void Undo()
            {
                Console.WriteLine("Undoing operation!");
                if (undo.Count > 0)
                {
                    Command c = undo.Pop(); c.Undo(); redo.Push(c);
                }
            }

            // Redo
            public void Redo()
            {
                Console.WriteLine("Redoing operation!");
                if (redo.Count > 0)
                {
                    Command c = redo.Pop(); c.Do(); undo.Push(c);
                }
            }

            public void RedoAll(Canvas backup, Canvas canvas)
            {
                Console.WriteLine("Redoing all operations"); 
                canvas = backup;
            }
        }

        public abstract class Command
        {
            public abstract void Do();     // what happens when we execute (do)
            public abstract void Undo();   // what happens when we unexecute (undo)
        }

         public class AddFeatureCommand : Command
        {
            Shape shape;
            Canvas canvas;
            public AddFeatureCommand(Shape s, Canvas c)
            {
                shape = s;
                canvas = c;
            }

            // Adds a shape to the canvas as "Do" action
            public override void Do()
            {
                canvas.Add(shape);
            }
            // Removes a shape from the canvas as "Undo" action
            public override void Undo()
            {
                shape = canvas.Remove();
            }

        }

        // Delete Shape Command - it is a ConcreteCommand Class (extends Command)
        // This deletes a Shape from the Canvas as the "Do" action
        public class DeleteFeatureCommand : Command
        {

            Shape shape;
            Canvas canvas;
             public DeleteFeatureCommand(Canvas c)
            {
                canvas = c;
            }
            // Removes a shape from the canvas as "Do" action
            public override void Do()
            {
                shape = canvas.Remove();
            }

            // Restores a shape to the canvas a an "Undo" action
            public override void Undo()
            {
                canvas.Add(shape);
            }
        }
    //****end of command design pattern**///
        static void Main(string[] args)
        {
            User user = new User();

            Client(user);
        }
        public static Shape ClientCode(FeatureCreator Sha)
        {
            return Sha.getShape();
        }
        //client acts as main class and method due to using factory method
        static void Client(User user)
        {
            Console.WriteLine("Enter Start to begin");
           String command = Console.ReadLine();
            while(command != "Start")
            {
                Console.WriteLine("invalid input please enter Start to begin");
                command = Console.ReadLine();
            }
            Canvas canvas = new Canvas();
            if(command == "Start")
            {
                FaceBase fcbase = new FaceBase();
               // Console.WriteLine("A Face Base has been created");
                //user.Action(new AddFeatureCommand(ClientCode(new FaceBase()),canvas));
                string filepath = @"C:\Users\natha\OneDrive\Documents\CS264JanExamCommandDesign\";
                StreamWriter sw = new StreamWriter(Path.Combine(filepath, "CS264JanExam.svg"));
                sw.AutoFlush = true;
                sw.Close();

                Console.WriteLine("Enter Help to see a list of commands or Add a Feature");

                while(command != "Quit")
                {
                    command = Console.ReadLine();
                    if(command == "Help" )
                    {
                        HelpMessage();
                    }

                    else if((command == "Add <Left-Brow>" || command == "Add <Right-Brow>" || command == "Add <Mouth>" || command == "Add <Left-Eye>" || command == "Add <Right-Eye>"))
                    {
                        AddFeature(command,user,canvas);
                    }
                    else if(command =="Undo")
                    {
                        //command design
                        user.Undo();
                    }
                    else if(command =="Redo")
                    {
                        //command design
                       user.Redo();
                    }
                    else if(command =="Clear")
                    {
                        Canvas backup = canvas;
                        Clear(canvas);
                        Console.Write("Are you sure? enter R now to restore or data will be lost");
                        if(command =="RedoAll")
                        {
                            user.RedoAll(backup,canvas);
                        }
                    }
                    else if(command =="Save")
                    {
                        Save(canvas,user);
                        Console.Write("Saved");
                    }
                    else if(command =="Display")
                    {
                        Display(canvas);
                    }
                    else if((command == "Remove <Left-Brow>" || command == "Remove <Right-Brow>" || command == "Remove <Mouth>" || command == "Remove <Left-Eye>" || command == "Remove <Right-Eye>"))
                    {
                        Remove(canvas,command);
                    }
                    else if ((command == "Style <Left-Brow>" || command == "Style <Right-Brow>" || command == "Style <Mouth>" || command == "Style <Left-Eye>" || command == "Style <Right-Eye>"))
                    {
                        Style(canvas,command,user);
                    }
                    else if((command == "MoveUp <Left-Brow>" || command == "MoveUp <Right-Brow>" || command == "MoveUp <Mouth>" || command == "MoveUp <Left-Eye>" || command == "MoveUp <Right-Eye>"))
                    {
                        MoveUp(canvas,command,user);
                    }
                    else if((command == "MoveDown <Left-Brow>" || command == "MoveDown  <Right-Brow>" || command == "MoveDown  <Mouth>" || command == "MoveDown  <Left-Eye>" || command == "MoveDown  <Right-Eye>"))
                    {
                        MoveDown(canvas,command,user);
                    }
                    else if((command == "MoveLeft <Left-Brow>" || command == "MoveDown  <Right-Brow>" || command == "MoveDown  <Mouth>" || command == "MoveDown  <Left-Eye>" || command == "MoveDown  <Right-Eye>"))
                    {
                        MoveLeft(canvas,command,user);
                    }
                    else if((command == "MoveRight <Left-Brow>" || command == "MoveDown  <Right-Brow>" || command == "MoveDown  <Mouth>" || command == "MoveDown  <Left-Eye>" || command == "MoveDown  <Right-Eye>"))
                    {
                        MoveRight(canvas,command,user);
                    }
                    else if((command == "Reset <Left-Brow>" || command == "Reset <Right-Brow>" || command == "Reset  <Mouth>" || command == "Reset  <Left-Eye>" || command == "Reset  <Right-Eye>"))
                    {
                        Reset(canvas,command,user);
                    }

                    else if(command =="Quit")
                    {
                        Console.WriteLine("Remember to save your program by entering Save before leaving else if you already saved enter anything else");
                       string finalc = Console.ReadLine();
                       if(finalc == "Save")
                       {
                           Save(canvas,user);
                       }
                    }
                    else
                    {
                        if(command != "Quit")
                        {
                        Console.WriteLine("Invalid input please enter H for list of commands or enter valid command");
                        }
                    }
                }
            }
        }
//methods that are called from client
       static void HelpMessage()
        {
             Console.WriteLine("Commands:");
            Console.WriteLine("Help               Help(Displays this message)");
            Console.WriteLine("Add <Left-Brow>    Add <Feature> to the canvas");
            Console.WriteLine("Remove <Feature>     Removes Feature");
            Console.WriteLine("Style <Feature>     Removes Feature");
            Console.WriteLine("Undo               Undo last operation");
            Console.WriteLine("Redo               Redo last operation");
            Console.WriteLine("Clear               Clear canvas");
            Console.WriteLine("Quit               Quit application");
            Console.WriteLine("Display               Display application");
            Console.WriteLine("Save               Save application");
            Console.WriteLine("Move <Feature> (up) / (down)");
            Console.WriteLine("Reset <Feature>     Reset position to origin");
        }
        static void Clear(Canvas canvas)
        {
          canvas.Clear();
            
        }
//method that call save canvas 
        static void Save(Canvas canvas,User user)
        {
            canvas.Save();
        }
        //method that calls display canvas 
        static void Display(Canvas canvas)
        {
            canvas.Display();
        }
        //add featuress to stack method
        static void AddFeature(String command, User user,Canvas canvas)
        {
            if(command.Contains("<Left-Brow>"))
            {
            LeftBrow lftbrow = new LeftBrow();
            Console.WriteLine("A Left-Brow has been created");
            user.Action(new AddFeatureCommand(ClientCode(new LeftBrow()),canvas));
            }   
            else if(command.Contains("<Right-Brow>"))
            {
            RightBrow rghtbrow = new RightBrow();
            Console.WriteLine("A Right-Brow has been created");
            user.Action(new AddFeatureCommand(ClientCode(new RightBrow()),canvas));
            }    
            else if(command.Contains("<Mouth>"))
            {
            Mouth mth = new Mouth();
            Console.WriteLine("A Mouth has been created");
            user.Action(new AddFeatureCommand(ClientCode(new Mouth()),canvas));
            }   
            else if(command.Contains("<Left-Eye>"))
            {
            LeftEye le = new LeftEye();
            Console.WriteLine("A Left-Eye has been created");
            user.Action(new AddFeatureCommand(ClientCode(new LeftEye()),canvas));
            }   
            else if(command.Contains("<Right-Eye>"))
            {
            RightEye re = new RightEye();
            Console.WriteLine("A Right-Eye has been created");
            user.Action(new AddFeatureCommand(ClientCode(new RightEye()),canvas));
            }          
        }
        //remove feature handled using id
        static void Remove(Canvas canvas,String command)
        {
            int id =0;
            if(command.Contains("Left-Brow"))
            {
                id=1;
            }
             else if(command.Contains("Right-Brow"))
            {
                id=2;
            }
             else if(command.Contains("Mouth"))
            {
                id=3;
            }
             else if(command.Contains("Left-Eye"))
            {
                id=4;
            }
             else if(command.Contains("Right-Eye"))
            {
                id=5;
            }
            canvas.Remove1(id);
        } 
//handle all of the styles in method below
        static void Style(Canvas canvas, String command, User user)
        {
             int id =0;
            if(command.Contains("Left-Brow"))
            {
                id=1;
            }
             else if(command.Contains("Right-Brow"))
            {
                id=2;
            }
             else if(command.Contains("Mouth"))
            {
                id=3;
            }
             else if(command.Contains("Left-Eye"))
            {
                id=4;
            }
             else if(command.Contains("Right-Eye"))
            {
                id=5;
            }
            canvas.Remove1(id);
            if(id==1)
            {
            LeftBrow2 lftbrow = new LeftBrow2();
            Console.WriteLine("A Left-Brow has been styled 2");
            user.Action(new AddFeatureCommand(ClientCode(new LeftBrow2()),canvas));
            }
           else if(id==2)
            {
            RightBrow2 rghtbrow = new RightBrow2();
            Console.WriteLine("A Right-Brow has been styled 2");
            user.Action(new AddFeatureCommand(ClientCode(new RightBrow2()),canvas));
            }
            else if(id==3)
            {
            Mouth2 mth = new Mouth2();
            Console.WriteLine("A Mouth has been styled 2");
            user.Action(new AddFeatureCommand(ClientCode(new Mouth2()),canvas));
            }
            else if(id==4)
            {
            LeftEye2 le = new LeftEye2();
            Console.WriteLine("A Left-Eye has been styled 2");
            user.Action(new AddFeatureCommand(ClientCode(new LeftEye2()),canvas));
            }
            else if(id==5)
            {
            RightEye2 re = new RightEye2();
            Console.WriteLine("A Right-Eye has been styled 2");
            user.Action(new AddFeatureCommand(ClientCode(new RightEye2()),canvas));
            }
        }
//all movement of features handled in methods below
        static void MoveUp(Canvas canvas, String command, User user)
        {
            int id=0;
             if(command.Contains("Left-Brow"))
            {
                id=1;
            }
             else if(command.Contains("Right-Brow"))
            {
                id=2;
            }
             else if(command.Contains("Mouth"))
            {
                id=3;
            }
             else if(command.Contains("Left-Eye"))
            {
                id=4;
            }
             else if(command.Contains("Right-Eye"))
            {
                id=5;
            }
            canvas.MoveUp(id);
        }
        static void MoveDown(Canvas canvas, String command, User user)
        {
            int id=0;
             if(command.Contains("Left-Brow"))
            {
                id=1;
            }
             else if(command.Contains("Right-Brow"))
            {
                id=2;
            }
             else if(command.Contains("Mouth"))
            {
                id=3;
            }
             else if(command.Contains("Left-Eye"))
            {
                id=4;
            }
             else if(command.Contains("Right-Eye"))
            {
                id=5;
            }
            canvas.MoveDown(id);
        }
        static void MoveRight(Canvas canvas, String command, User user)
        {
            int id=0;
             if(command.Contains("Left-Brow"))
            {
                id=1;
            }
             else if(command.Contains("Right-Brow"))
            {
                id=2;
            }
             else if(command.Contains("Mouth"))
            {
                id=3;
            }
             else if(command.Contains("Left-Eye"))
            {
                id=4;
            }
             else if(command.Contains("Right-Eye"))
            {
                id=5;
            }
            canvas.MoveRight(id);
        }
        static void MoveLeft(Canvas canvas, String command, User user)
        {
            int id=0;
             if(command.Contains("Left-Brow"))
            {
                id=1;
            }
             else if(command.Contains("Right-Brow"))
            {
                id=2;
            }
             else if(command.Contains("Mouth"))
            {
                id=3;
            }
             else if(command.Contains("Left-Eye"))
            {
                id=4;
            }
             else if(command.Contains("Right-Eye"))
            {
                id=5;
            }
            canvas.MoveLeft(id);
        }
        static void Reset(Canvas canvas, String command, User user)
        {
             int id=0;
             if(command.Contains("Left-Brow"))
            {
                id=1;
            }
             else if(command.Contains("Right-Brow"))
            {
                id=2;
            }
             else if(command.Contains("Mouth"))
            {
                id=3;
            }
             else if(command.Contains("Left-Eye"))
            {
                id=4;
            }
             else if(command.Contains("Right-Eye"))
            {
                id=5;
            }
            canvas.Reset(id);
        }
    }
}