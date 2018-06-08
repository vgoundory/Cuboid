using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creation : MonoBehaviour
{

    public GameObject Tile, StrongSwitch, Switch, TeleSwitch, StrongBridge;
    public string spawnBridge;



    public void CreateTile()
    {
        for (int i = 0; i < 1; i++)
        {
            Instantiate(Tile);
            Debug.Log("Tiles");
        }
    }
    public void CreateStrongSwitch()
    {
        if (Input.GetButton("spawnStrongSwitch"))

        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(StrongSwitch);
                Debug.Log("StrongSwitch");

            }
        }
    }
    public void CreateNormalSwitch()
    {
        if (Input.GetButton("spawnNormalSwitch"))
        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(Switch);
                Debug.Log("NormalSwitch");

            }
        }
    }
    public void CreateTeleSwitch()
    {
        if (Input.GetButton("spawnTeleSwitch"))
        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(TeleSwitch);
                Debug.Log("TeleSwitch");

            }
        }
    }
    public void CreateBridge()
    { if(Input.GetButton("spawnBridge"))
        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(StrongBridge);
                Debug.Log("StongBridge");

            }
        }
    }
}

  
