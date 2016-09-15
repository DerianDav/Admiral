using UnityEngine;
using System.Collections;

public class TurretList
{
    private ArrayList turrets = new ArrayList();
    public int amount = 0;
    private int cur = 0;

    public void addTurret(TurretDesign t)
    {
        turrets.Add(t);
        amount++;
    }//end of addTurret

    public TurretDesign getTurretAt(int num) {
        return (TurretDesign) turrets[num];
    }//end of getTurretAt

    //returns prev turret in list
    public TurretDesign prevTur() {
        if (cur == 0)
        {
            return (TurretDesign)turrets[0];
        }
        else {
            cur--;
            return (TurretDesign)turrets[cur];
        }

    }//end of prevtur

    //returns next turret in list
    public TurretDesign nextTur() {
        if (cur == 0)
        {
            cur++;
            return (TurretDesign)turrets[0];
        }
        else
        {
            if (cur < amount)
            {
                cur++;
            }
            return (TurretDesign)turrets[cur];
        }
    }//end of nextTur

}