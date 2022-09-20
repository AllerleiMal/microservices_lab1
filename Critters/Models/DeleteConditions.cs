﻿using System.ComponentModel.DataAnnotations;

namespace Critters.Models;

public class DeleteConditions
{
    [DataType(DataType.Date)]
    public DateTime From { get; set; }
    [DataType(DataType.Date)]
    public DateTime To { get; set; }
    public string Position { get; set; }
}