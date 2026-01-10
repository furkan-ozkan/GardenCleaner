using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 100f;

    // Start fonksiyonu oyunun en basinda yalnizca 1 defa calisir.
    void Start()
    {
        
    }

    // Update fonksiyonu her framede 1 defa calisir.
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        if (Keyboard.current.sKey.isPressed)
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if (Keyboard.current.dKey.isPressed)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Keyboard.current.aKey.isPressed)
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
    }
}
