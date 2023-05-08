using UnityEngine;
using UnityEngine.UI;

public class OtherRobot : MonoBehaviour
{
    [SerializeField] private Text robotName;
    [SerializeField] private Image robotImage;
    [SerializeField] private RobotConfig robotConfigLink;

    private void Start()
    {
        robotConfigLink = RobotConfig.SpecificValue("SOsLoadSystem/RobotConfigOther");
        Setup(robotConfigLink.RobotName, robotConfigLink.RobotColor);
    }

    private void Setup(string name, Color imageColor)
    {
        robotName.text = name;
        robotImage.color = imageColor;
    }
}
