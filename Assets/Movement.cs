using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start fonksiyonu oyunun en basinda yalnizca 1 defa calisir.
    void Start()
    {
        Debug.Log("Start Fonksiyonu Calisti!");
    }

    // Update fonksiyonu her framede 1 defa calisir.
    void Update()
    {
        Debug.Log("Update Fonksiyonu Calisti!");
        transform.Translate(new Vector3(0.01f , 0 , 0));
    }
}
