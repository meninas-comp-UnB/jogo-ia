using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Nome da cena para voltar
    public string cenaAlvo;

    // Coordenadas para a posição na cena
    public float xCoord; //-5.81
    public float yCoord; //1.04
    public float zCoord; //0

    // Tag do jogador
    public string tagDoJogador;

    // Função para voltar para uma cena em uma coordenada específica
    public void VoltarParaCenaAlvo()
    {
        // Carrega a cena alvo
        SceneManager.LoadScene(cenaAlvo);

        // Após a cena ser carregada, configure a posição do jogador
        GameObject jogador = GameObject.FindGameObjectWithTag(tagDoJogador);

        if (jogador != null)
        {
            // Define a posição do jogador para as coordenadas especificadas
            jogador.transform.position = new Vector3(xCoord, yCoord, zCoord);
        }
        else
        {
            Debug.LogError("O jogador não foi encontrado na cena com a tag especificada.");
        }
    }
}
