using UnityEngine;
using System.Collections;

//Gives a class to each specific type of ship found in Ships.cs
public class StandardShip
{
    public Ships type;
        public string className { set; get; }
        public string shipName { set; get; }
        public int maxDisplacement;
        public int speed { set; get; }
        public int ConningT { set; get; }
        public int mainGuns { set; get; }
        public int antiAir { set; get; }
        public int secondaryGuns { set; get; }
        public int maxFuel { set; get; }
        public int curFuel { set; get; }
        public int fuelDay { set; get; }

        //turret types for the ships
        TurretType mTur { set; get; }
        TurretType aTur { set; get; }
        TurretType sTur { set; get; }



        public StandardShip(Ships t) {
            type = t;
            maxDisplacement = (int) t;

            speed = 0;
            ConningT = 0;
            mainGuns = 0;
            secondaryGuns = 0;
            antiAir = 0;
        }

  }//end of StandardShip

    
