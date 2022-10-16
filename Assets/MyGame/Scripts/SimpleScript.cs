using UnityEngine;

public class SimpleScript : MonoBehaviour
{

    [SerializeField] private Sprite[] idle;                    //Instanzvariable

    private void Start()
    {
        Debug.Log("Anzahlt Elemente:" + idle.Length);
    }
}
