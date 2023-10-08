using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public GameObject particleSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CollectPowerup(other.gameObject);
        }
    }

    private void CollectPowerup(GameObject player)
    {
        gameObject.SetActive(false);
        GameManager.Instance.IncrementScore();
        Instantiate(particleSystem, transform.position, transform.rotation);

        CharacterMovement characterMovement = player.GetComponent<CharacterMovement>();
        if (characterMovement != null)
        {
            characterMovement.EnableDoubleJump();
        }

        Invoke("ResetPowerup", 30.0f);
    }

    private void ResetPowerup()
    {
        gameObject.SetActive(true);
    }
}
