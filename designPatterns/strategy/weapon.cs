using System;
namespace designPatterns.strategyMode
{
  #region
  public interface IWeapon
  {
    public void Action();
    public int Hurt();
  }
  #endregion

  #region
  public class Knife : IWeapon
  {
    public void Action()
    {
      Console.WriteLine("Knife chop");
    }
    public int Hurt()
    {
      int hurt = 50;
      return hurt;
    }
  }

  public class Spear : IWeapon
  {
    public void Action()
    {
      Console.WriteLine("Spear shoot");
    }
    public int Hurt()
    {
      int hurt = 150;
      return hurt;
    }
  }

  public class Sword : IWeapon
  {
    public void Action()
    {
      Console.WriteLine("Sword stab");
    }
    public int Hurt()
    {
      int hurt = 80;
      return hurt;
    }
  }
  #endregion

  public abstract class Role
  {
    protected IWeapon Weapon;

    public void perFromWeapon()
    {
      Weapon.Action();
    }

    public abstract void Hurt();

    public void setWeapon(IWeapon weapon)
    {
      Weapon = weapon;
    }
  }

  public class wylRole : Role
  {
    public wylRole()
    {
      Weapon = new Knife();
    }
    public override void Hurt()
    {
      Console.WriteLine("Hurt:");
      Console.WriteLine(Weapon.Hurt());
    }
  }

  public class RoleWeapon
  {
    public RoleWeapon()
    {
      Role wylRole = new wylRole();
      wylRole.perFromWeapon();
      wylRole.Hurt();

      wylRole.setWeapon(new Spear());
      wylRole.perFromWeapon();
      wylRole.Hurt();
    }
  }
}