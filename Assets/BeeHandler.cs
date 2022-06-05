using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeHandler : MonoBehaviour
{
    public GameObject bee;

    public void EnableBee() {
        bee.SetActive(true);
    }

    public void DisableBee() {
        bee.SetActive(false);
    }
}
