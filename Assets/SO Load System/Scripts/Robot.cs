using UnityEngine;
using UnityEngine.UI;

public class Robot : MonoBehaviour
{
    [SerializeField] private Text robotName;
    [SerializeField] private Image robotImage;
    [SerializeField] private RobotConfig robotConfigLink;

    private void Start()
    {
        robotConfigLink = RobotConfig.Value;
        Setup(robotConfigLink.RobotName, robotConfigLink.RobotColor);
    }

    private void Setup(string name, Color imageColor)
    {
        robotName.text = name;
        robotImage.color = imageColor;
    }
}
