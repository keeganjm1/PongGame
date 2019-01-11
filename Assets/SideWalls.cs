using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D hitinfo)
    {
         if (hitinfo.name == "Ball")
        {
            string wallName = transform.name;
            GameManager.Score(wallName);
            hitinfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
                
        }
    }

}
