using UnityEngine;
using System.Collections;

public class ShipType
{
    public class standaradShipP
    {
        int speed { set; get; }
        int ConningT { set; get; }
        int mainGuns { set; get; }
        int antiAir { set; get; }
        int secondaryGuns { set; get; }


    }



    public class BB
    {
        Ships type = Ships.Battleship;
        int maxTonnage = 45000;
        int speed { set; get; }
        int ConningT { set; get; }
        int bowGuns { set; get; }


    }
}