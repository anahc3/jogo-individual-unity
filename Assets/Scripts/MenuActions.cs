using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuActions : MonoBehaviour
{
    public GameObject painelMenu;
    public GameObject painelInstrucoes;

    public void IniciarJogo()
    {
        GameController.Init(); // inicializa o GameController
        SceneManager.LoadScene(1); 
    }

    public void Menu() {
        SceneManager.LoadScene(0); 
    }

    public void AbrirInstrucoes()
    {
        painelMenu.SetActive(false);
        painelInstrucoes.SetActive(true);
    }

    public void VoltarAoMenu()
    {
        painelInstrucoes.SetActive(false);
        painelMenu.SetActive(true);
    }
}
