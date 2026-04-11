using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject painelQuebrar;
    public Image imagemPedraGrande;
    public Slider barraVida;

    private ItemQuebravel itemAtual;
    private int vidaAtual;

    void Awake() => instance = this;

    public void AbrirPainelQuebrar(ItemQuebravel item)
    {
        itemAtual = item;
        vidaAtual = item.vidaMaxima;

        imagemPedraGrande.sprite = item.iconeGrande;
        barraVida.maxValue = item.vidaMaxima;
        barraVida.value = vidaAtual;

        painelQuebrar.SetActive(true);
    }

    public void DarClique()
    {
        vidaAtual--;
        barraVida.value = vidaAtual;

        if (vidaAtual <= 0)
        {
            QuebrarItem();
        }
    }

    void QuebrarItem()
    {
        painelQuebrar.SetActive(false);
        Destroy(itemAtual.gameObject); 

        
        FindObjectOfType<SpawnerManager>().GerarUmNovoItem();
    }
}