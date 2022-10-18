﻿using System.Runtime.Serialization;

namespace Critters.Models;

[DataContract]
public class Critters
{
    [DataMember]
    public List<Roster> Rosters { get; set; }

    [DataMember]
    public List<Temp> Temps { get; set; }

    [DataMember]
    public DeleteConditions Conditions { get; set; }
}