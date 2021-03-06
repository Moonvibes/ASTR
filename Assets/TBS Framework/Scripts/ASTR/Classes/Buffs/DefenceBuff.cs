using System;

public class DefenceBuff : Buff
{
    private float _factor;
    public string Tooltip {
        get { return "This hero has increased defence and will take less damage."; }
        set {}
    }

    public string Name {
        get { return "DefenceBuff"; }
        set {}
    }


    public DefenceBuff(int duration, float factor)
    {
        Duration = duration;
        _factor = factor;
    }

    public int Duration { get; set; }

    public bool isDot
    {
        get
        {
            return false;
        }

        set
        {
            throw new NotImplementedException();
        }
    }

    public void Apply(Unit unit)
    {
        unit.DefenceFactor += _factor;
    }

    public void Undo(Unit unit)
    {
        unit.DefenceFactor -= _factor;
    }

    public Buff Clone()
    {
        return new DefenceBuff(Duration, _factor);
    }

    public void Trigger(Unit unit)
    {
    }
}
