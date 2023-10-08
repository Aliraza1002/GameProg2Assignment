using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject particleSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            GameManager.Instance.IncrementScore();
            gameObject.SetActive(false);
            GameObject particleSystemBurst = Instantiate(particleSystem, transform.position, transform.rotation);
            Destroy(particleSystemBurst, 3);
        }
    }
}
