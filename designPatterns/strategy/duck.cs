using System;
namespace designPatterns.strategyMode
{
  /*
  行为接口
  */
  #region 
  public interface IFlyBehavior
  {
    public void Fly();
  }
  public interface IQuackBehavior
  {
    public void Quack();
  }
  #endregion

  #region
  /*
  对象的抽象类实现
  */ 
  public abstract class Duck
  {
    protected IFlyBehavior FlyBehavior;
    protected IQuackBehavior QuackBehavior;

    protected Duck()
    {}
    public abstract void Display();
    public void PerformFly()
    {
      FlyBehavior.Fly();
    }
    public void PerformQuack()
    {
      QuackBehavior.Quack();
    }
    public void SetFlyBehavior(IFlyBehavior fb)
    {
      FlyBehavior = fb;
    }
    public void SetQuackBehavior(IQuackBehavior qb)
    {
      QuackBehavior = qb;
    }
  }
  #endregion

  #region
  /*
  行为实现类
  */
   public class FlyWithWings : IFlyBehavior
   {
     public void Fly()
     {
       Console.WriteLine("I'm flying");
     }    
   }

   public class FlyNoWay : IFlyBehavior
   {
     public void Fly()
     {
       Console.WriteLine("I'm can't flying");
     }
   }

   public class NoWayQuack : IQuackBehavior
   {
    public void Quack()
    {
      Console.WriteLine("no way Quack");
    }
   }

   public class MuteQuack : IQuackBehavior
   {
     public void Quack()
     {
       Console.WriteLine("<< Silence >>");
     }
   }
   #endregion


  #region 
  /*
  对象具体实现类
  */
  public class MallardDuck : Duck
  {
    public MallardDuck()
    {
      QuackBehavior = new NoWayQuack();
      FlyBehavior = new FlyWithWings();
    }
    public override void Display()
    {
      Console.WriteLine("I'm a real Mallard duck");
    }
  }
  #endregion

  #region 
  /*
  测试类 
  */
  public class MiniDuckSimulator
  {
    public MiniDuckSimulator()
    {
      Duck mallard = new MallardDuck();

      mallard.PerformFly();
      mallard.SetFlyBehavior(new FlyNoWay());
      mallard.PerformFly();

      mallard.PerformQuack();
      mallard.SetQuackBehavior(new MuteQuack());
      mallard.PerformQuack();

    }
  }
  #endregion
}