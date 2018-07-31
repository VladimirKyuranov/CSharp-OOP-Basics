using System;

public class Mission : IMission
{
    public Mission(string codeName, string state)
    {
        this.CodeName = codeName;
        StateParse(state);
    }

    public string CodeName { get; private set; }

    public MissionStateEnum State { get; private set; }

    private void StateParse(string state)
    {
        bool validState = Enum.TryParse(typeof(MissionStateEnum), state, out object outState);

        if (validState == false)
        {
            throw new ArgumentException("Invalid state!");
        }

        this.State = (MissionStateEnum)outState;
    }

    public void Complete()
    {
        this.State = MissionStateEnum.Finished;
    }

    public override string ToString()
    {
        return $"Code Name: {this.CodeName} State: {this.State}";
    }
}