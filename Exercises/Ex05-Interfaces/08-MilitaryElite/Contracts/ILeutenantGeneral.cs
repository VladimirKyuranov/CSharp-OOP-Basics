﻿using System.Collections.Generic;

public interface ILeutenantGeneral : IPrivate
{
    IReadOnlyCollection<ISoldier> Privates { get; }
    void AddSoldier(ISoldier soldier);
}