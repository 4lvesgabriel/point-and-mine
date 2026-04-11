using UnityEngine;

public class ItemQuebravel : MonoBehaviour
{
    public string nomeItem;
    public int vidaMaxima = 10;
    public Sprite iconeGrande; 

    
    private void OnMouseDown()
    {
        UIManager.instance.AbrirPainelQuebrar(this);
    }
}