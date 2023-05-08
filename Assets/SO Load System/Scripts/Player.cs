using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Text playerName;
    [SerializeField] private Image playerImage;

    private void Start()
    {
        Setup(PlayerConfig.Value.PlayerName, PlayerConfig.Value.PlayerColor);
    }

    private void Setup(string name, Color imageColor)
    {
        playerName.text = name;
        playerImage.color = imageColor;
    }
}
