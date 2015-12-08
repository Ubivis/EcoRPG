// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Eco.Gameplay.Buildings;
using Eco.Gameplay.Interactable;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using Eco.Shared.Voxel;

[DataContract]
[Category("Hidden")]
public class FactionRegionBlueprint : Blueprint
{
    public override string FriendlyName { get { return "Area of Faction"; } }

    public override string BuildingName
    {
        get { return "Faction Area"; }
    }

    public override string Description { get { return "Defines the buildable for a specific faction. " + base.Description; } }

    public override int Area
    {
        get { return 9; }
    }

    public override int Height
    {
        get { return 3; }
    }

    public override List<MaterialRequirement> RequiredConstructionType
    {
        get
        {
    //        return new List<MaterialRequirement>() { new MaterialRequirement<ConstructedLogBlock>(10) };
        }
    }

    public override void OnCreated(Player player, Vector3i position)
    {
        WorldObject.Add(new FactionThroneObject(), player, position);
    }
}
