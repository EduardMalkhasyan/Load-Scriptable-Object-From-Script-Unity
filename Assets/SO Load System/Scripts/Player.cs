using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Text playerName;
    [SerializeField] private Image playerImage;
    [SerializeField] private PlayerConfig playerConfigLink;

    private void Start()
    {
        playerConfigLink = PlayerConfig.Value;
        Setup(playerConfigLink.PlayerName, playerConfigLink.PlayerColor);
    }

    private void Setup(string name, Color imageColor)
    {
        playerName.text = name;
        playerImage.color = imageColor;
    }
}
