﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureMetadata
{
    public string name { get; set;  }
    public string bundle { get; set; }
}

public static class FurnitureConstants {

    public static bool FETCH_MODELS = false;

    // hard coding this list for now
    public static Dictionary<string, FurnitureMetadata> FURNITURE_MAP = new Dictionary<string, FurnitureMetadata>
    {
        // place holder models
        { "BasicTable",  new FurnitureMetadata { name="IKEA-Lack_Black_Table-3D", bundle="table" } }
    };

}
