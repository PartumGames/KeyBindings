using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseKeys : MonoBehaviour {

    public KeyBindingManager keyBindings;


    void Update(){
        if (Input.GetKeyDown(keyBindings.jumpKey))
        {
            print("the jump key is: " + keyBindings.jumpKey.ToString());
        }

        if (Input.GetKeyDown(keyBindings.pauseKey))
        {
            print("the pause key is: " + keyBindings.pauseKey.ToString());
        }

        if (Input.GetKeyDown(keyBindings.inventoryKey))
        {
            print("the inventory key is: " + keyBindings.inventoryKey.ToString());
        }
    }


//end o class
}
