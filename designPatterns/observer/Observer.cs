using System;
using System.Collections.Generic;

namespace designPatterns.Observer {

  public abstract class Observer {
    protected Subject subject;
    public abstract void update();
  }

  public class Subject {
    private List<Observer> observers = new List<Observer>();

    private int state;

    public int getState() {
      return state;
    }
    public void setState(int state) {
      this.state = state;

    }
    public void attach(Observer observer) {
      observers.Add(observer);
      notifyAllObservers();
    }

    public void notifyAllObservers() {
      foreach (Observer observer in observers) {
        observer.update();
      }
    }
  }

  public class BinaryObserver : Observer 
  {
    public BinaryObserver(Subject subject)
    {
      this.subject = subject;
      this.subject.attach(this);
    }

    public override void update()
    {
      Console.WriteLine("Binary String: binary");
    }
  }

  public class OctalObserver : Observer 
  {
    public OctalObserver(Subject subject)
    {
      this.subject = subject;
      this.subject.attach(this);
    }

    public override void update()
    {
      Console.WriteLine("Octal String: Octal");
    }
  }

  public class HexaObserver : Observer
  {
    public HexaObserver(Subject subject)
    {
      this.subject = subject;
      this.subject.attach(this);
    }

    public override void update()
    {
      Console.WriteLine("Hexa string: Hexa");
    }
  }

  public class ObserverPatternDemo
  {
    public ObserverPatternDemo()
    {
      Subject subject = new Subject();

      new HexaObserver(subject);
      new OctalObserver(subject);
      new BinaryObserver(subject);
    }
  }
}