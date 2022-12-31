namespace Drawing;

public class Line:Shape
{

public Point StartPoint{get;set;}
public Point EndPoint{get;set;}

public Line()
{
 this.StartPoint=new Point(0,0);
 this.EndPoint=new Point(0,0);
}

public Line(Point p1,Point p2)
{
 this.StartPoint=p1;
 this.EndPoint=p2;
}

public override void Draw()
{
    Console.WriteLine("\nStartPoint is "+this.StartPoint+" EndPoint is "+this.EndPoint);

}

} 