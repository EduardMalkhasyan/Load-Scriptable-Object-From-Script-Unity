using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Robot : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI robotName;
    [SerializeField] private Image robotImage;

    [SerializeField] private RobotConfig robotConfigLink;

    private SOLoader<RobotConfig> robotConfig;

    private void Start()
    {
        robotConfigLink = RobotConfig.Value;
        Setup(RobotConfig.Value.RobotName, RobotConfig.Value.RobotColor);
    }

    private void Setup(string name, Color imageColor)
    {
        robotName.text = name;
        robotImage.color = imageColor;
    }
}
