using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject areaDestino;
    public GameObject areaActual;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            areaActual.SetActive(false);
            GameObject player = other.gameObject;
            other.gameObject.SetActive(false);

            GameObject areaNueva = Instantiate(areaDestino);
            areaNueva.transform.position = Vector3.zero;

            //Destruye area actual
            Destroy(areaActual);

            SpawnPoint punto = GameObject.FindAnyObjectByType<SpawnPoint>();
            player.transform.position = punto.transform.position;
            player.SetActive(true);

        }
    }
}
