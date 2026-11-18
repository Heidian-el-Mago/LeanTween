using UnityEngine;

public class Pruebacronometro : MonoBehaviour
{
    float cronometro = 0f;
    float escala = 0.02f;
    void Update()
    {

        LeanTween.moveX(this.gameObject, 10f, 3f);

    }
}
