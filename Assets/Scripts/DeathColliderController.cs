using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathColliderController : MonoBehaviour
{
    private GameObject player;
    private Rigidbody playerRb;
    private void OnTriggerEnter(Collider other)
    {
        player = other.gameObject;
        if (player.CompareTag("Player"))
        {
            if (player.GetComponent<PlayerController>())
                player.transform.position = player.GetComponent<PlayerController>().origin;
            else
                player.transform.position = new Vector3(0, 0.05f, 0f);
            playerRb = player.GetComponent<Rigidbody>();
            playerRb.velocity = Vector3.zero;
        }
    }
}
