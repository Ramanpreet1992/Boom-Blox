using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisions : MonoBehaviour
{
    [SerializeField] ParticleSystem destructionParticles;
    
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy the block if it collides the ground
        if (collision.collider.tag == "Block")
        {
            Instantiate(destructionParticles, collision.transform.position, Quaternion.identity, transform);
            GameManager.instance.UpdateScore(GameManager.instance.score + 50);
            Destroy(collision.collider.gameObject);
        }

        //Destroy the ball if it coolides the ground 
        else if (collision.collider.tag == "Ball")
        {
            Instantiate(destructionParticles, collision.transform.position, Quaternion.identity, transform);
            Destroy(collision.collider.gameObject);
        }
    }
}
