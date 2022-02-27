using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColllision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo) 
    {
        if(collisionInfo.transform.tag == "Obstacle")
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);
        }
    }

}
