using UnityEngine;
using System.Collections;

//basic template for a turret
public class TurretDesign {
    public TurretType type { set; get; }
    //Displacement = base * calliber + (AmmoCap * (x*calliber))
    public int displacement { set; get; }

    public int calliber { set; get; }
    public int AmmoCap { set; get; }
    public string name = "";

    public TurretDesign() {
        calliber = 0;
        AmmoCap = 0;
    }

}
