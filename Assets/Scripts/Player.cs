using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerName;
    [SerializeField] private Image playerImage;

    [SerializeField] private PlayerConfig playerConfigLink;

    private SOLoader<PlayerConfig> playerConfig;

    private void Start()
    {
        playerConfigLink = PlayerConfig.Value;
        Setup(PlayerConfig.Value.PlayerName, PlayerConfig.Value.PlayerColor);
    }

    private void Setup(string name, Color imageColor)
    {
        playerName.text = name;
        playerImage.color = imageColor;
    }
}
