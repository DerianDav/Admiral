using UnityEngine;
using System.Collections;
using System;

public class MainController : MonoBehaviour {
    // Use this for initialization
    ArrayList fleet = new ArrayList();
    bool turrScreen = false;
 

    void Start () {
	
	}//end of Start
	
	// Update is called once per frame
	void Update () {
        





        }
	}//end of Update
   
}//end of Main Controller

class newTurret{
    TurretDesign turret;

    public newTurret(TurretType type) {
        turret = new TurretDesign();

    }
}

