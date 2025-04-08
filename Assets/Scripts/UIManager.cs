using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject painelVitoria;
    public GameObject painelDerrota;

    void Start()
    {
        GameController.Init(); 
    }

    void FixedUpdate()
    {
        if (GameController.PlayerWon)
        {
            painelVitoria.SetActive(true);
        }

        if (GameController.PlayerDefeated)
        {
            painelDerrota.SetActive(true);
        }
    }
}
