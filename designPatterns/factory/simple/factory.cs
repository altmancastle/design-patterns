using System;
using System.Collections.Generic;

namespace designPatterns.factory 
{

  public abstract class Shape 
  {
    public abstract void drew();
  }


  public class Rectangle : Shape 
  {
    public override void drew()
    {
      Console.WriteLine("this is rectangle");
    }
  }

  public class Circle : Shape 
  {
    public override void drew()
    {
      Console.WriteLine("this is circle");
    }
  }


  public class ShapeFactory
  {
    public Shape getShape(string shapeType) {
      if(shapeType == null){
         return null;
      }        
      if(shapeType == "CIRCLE" ){
         return new Circle();
      } else if(shapeType == "RECTANGLE"){
         return new Rectangle();
      }
      return null;
    }
  }


  public class SimpleFactory
  {
    public SimpleFactory()
    {
      ShapeFactory shapeFactory = new ShapeFactory();

      Shape circleShape = shapeFactory.getShape("CIRCLE");
      circleShape.drew();
      Shape rectangleShape = shapeFactory.getShape("RECTANGLE");
      rectangleShape.drew();

    }
  }





}