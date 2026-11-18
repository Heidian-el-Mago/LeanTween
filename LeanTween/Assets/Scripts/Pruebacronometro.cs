using UnityEngine;
using UnityEngine.UIElements;

public class Pruebacronometro : MonoBehaviour
{
    [SerializeField] LeanTweenType efecto;
    [SerializeField] LeanTweenType efectoPersonaje1;
    public GameObject cube;
    public GameObject camera;
    public GameObject personaje1;
    Vector3 positionCube = new Vector3 (-10.02f, 0, 0);
    void Start()
    {
        transform.position = new Vector3(0f, 20f, 0f);
    }
   public void MoveX()
    {
        LeanTween.moveY(personaje1, 0f, 1f).setEase(efectoPersonaje1);
        LeanTween.moveX(cube, 5f, 1f).setEase(efecto).setOnComplete(MoveAntiX);
    }

    void MoveAntiX()
    {
        LeanTween.move(cube, positionCube, 1f).setEase(efecto).setOnComplete(MoveX);
    }

}
