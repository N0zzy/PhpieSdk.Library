﻿using System;

namespace PhpieSdk.Library.Service;

public class TypeVariables
{
    public string Element { get; set; }
    public Type Type { get; set; }
    public Type CurrentType { get; set; }
    public string Modifier { get; set; }
    public int Number { get; set; }
    public bool _isReadonly { get; set; } = false;
}